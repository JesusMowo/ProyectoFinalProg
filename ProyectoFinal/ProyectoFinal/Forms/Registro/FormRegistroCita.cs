using ProyectoFinal.Modelos;
using ProyectoFinal.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Forms.Registro
{
    public partial class FormRegistroCita : Form
    {
        public int UserId;
        private int doctorSeleccionadoId;

        public FormRegistroCita(int userId)
        {
            InitializeComponent();
            UserId = userId;
            CargarDoctores();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Aseguramos que no sea un encabezado
            {
                var filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                doctorSeleccionadoId = (int)filaSeleccionada.Cells["Id"].Value;
                DoctorTxt.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();

                MostrarCitasDisponibles(doctorSeleccionadoId);
            }
        }

        private void MostrarCitasDisponibles(int idDoctor)
        {
            // Limpiar la lista de citas disponibles
            FechasDIsponiblesLbox.Items.Clear();

            // Obtener la ruta de las citas y los doctores
            string rutaCitas = Rutas.ObtenerRutaCitas();
            string rutaDoctores = Rutas.ObtenerRutaDoctores();

            // Leer las citas y el doctor seleccionado
            var citas = CRUD.LeerTxt(rutaCitas, Citas.ParseFromTxt);
            var doctores = CRUD.LeerTxt(rutaDoctores, Doctores.ParseFromTxt);
            var doctor = doctores.FirstOrDefault(d => d.Id == idDoctor);

            if (doctor == null)
            {
                MessageBox.Show("No se encontró el doctor seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el rango de horas del horario del doctor
            var horas = doctor.horarioSemanal.Split('-');
            var horaInicio = TimeSpan.Parse(horas[0]);
            var horaFin = TimeSpan.Parse(horas[1]);

            // Generar todas las horas en el rango
            var horasDisponibles = new List<string>();
            for (var hora = horaInicio; hora <= horaFin; hora = hora.Add(TimeSpan.FromHours(1)))
            {
                horasDisponibles.Add(hora.ToString(@"hh\:mm"));
            }

            // Filtrar las horas que ya están ocupadas para el día seleccionado
            var diaSeleccionado = dateTimePicker1.Value.Date; // Obtener solo la fecha sin la hora
            var horasOcupadas = citas
                .Where(c => c.IdDoctor == idDoctor && c.Dias.Date == diaSeleccionado)
                .Select(c => c.horario)
                .ToHashSet();

            var horasFinales = horasDisponibles
                .Where(h => !horasOcupadas.Contains(h))
                .ToList();

            // Mostrar las horas disponibles en el ListBox
            foreach (var hora in horasFinales)
            {
                FechasDIsponiblesLbox.Items.Add(hora);
            }
        }

        private void CargarDoctores()
        {
            string rutaDoctores = Rutas.ObtenerRutaDoctores();
            var doctores = CRUD.LeerTxt(rutaDoctores, Doctores.ParseFromTxt);

            var datosDoctores = doctores.Select(d => new
            {
                Id = d.Id,
                Nombre = d.nombreCompleto,
                Horario = d.horarioSemanal,
                Especialidad = d.especialidad,
                Telefono = d.telefono
            }).ToList();

            dataGridView1.DataSource = datosDoctores;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void GuardarCitaBtn_Click(object sender, EventArgs e)
        {
            if (doctorSeleccionadoId == 0)
            {
                MessageBox.Show("Por favor, seleccione un doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(HorarioTxt.Text))
            {
                MessageBox.Show("Por favor, ingrese un horario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar el formato del horario (hh:00)
            if (!ValidarHorario(HorarioTxt.Text))
            {
                MessageBox.Show("El horario no tiene el formato correcto. Use hh:mm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el IdPaciente a partir del UserId
            string rutaPacientes = Rutas.ObtenerRutaPacientes();
            var pacientes = CRUD.LeerTxt(rutaPacientes, Paciente.ParseFromTxt);
            var paciente = pacientes.FirstOrDefault(p => p.IdUsuario == UserId);

            if (paciente == null)
            {
                MessageBox.Show("No se encontró un paciente asociado al usuario actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idPaciente = paciente.Id;

            string rutaCitas = Rutas.ObtenerRutaCitas();

            var doctores = CRUD.LeerTxt(Rutas.ObtenerRutaDoctores(), Doctores.ParseFromTxt);
            var doctor = doctores.FirstOrDefault(d => d.Id == doctorSeleccionadoId);

            if (doctor == null)
            {
                MessageBox.Show("No se encontró el doctor seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar si se puede agendar la cita
            if (!GestorDeCitas.PuedeAgendarCita(doctor, rutaCitas, HorarioTxt.Text))
            {
                MessageBox.Show("No se puede agendar la cita. Verifique el horario o conflictos con otras citas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardar la cita
            var nuevaCita = new Citas
            {
                Id = CRUD.GenerarNuevoId(rutaCitas),
                IdPaciente = idPaciente,
                IdDoctor = doctorSeleccionadoId,
                horario = HorarioTxt.Text,
                Dias = dateTimePicker1.Value
            };

            var citas = CRUD.LeerTxt(rutaCitas, Citas.ParseFromTxt);
            citas.Add(nuevaCita);
            CRUD.EscribirTxt(rutaCitas, citas);

            MessageBox.Show("Cita guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

        }

        private bool ValidarHorario(string horario)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(horario, @"^\d{2}:00$");
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday || dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Solo se pueden seleccionar días de la semana (lunes a viernes).", "Día no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Restablecer el valor al día anterior válido (por ejemplo, el viernes anterior)
                dateTimePicker1.Value = ObtenerUltimoDiaLaborable(dateTimePicker1.Value);
            }
            else
            {
                // Actualizar las citas disponibles para el día seleccionado
                if (doctorSeleccionadoId != 0)
                {
                    MostrarCitasDisponibles(doctorSeleccionadoId);
                }
            }
        }
        private DateTime ObtenerUltimoDiaLaborable(DateTime fecha)
        {
            // Si es sábado, retrocede un día (viernes)
            if (fecha.DayOfWeek == DayOfWeek.Saturday)
            {
                return fecha.AddDays(-1);
            }
            // Si es domingo, retrocede dos días (viernes)
            else if (fecha.DayOfWeek == DayOfWeek.Sunday)
            {
                return fecha.AddDays(-2);
            }
            return fecha;
        }

        private void FechasDIsponiblesLbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FechasDIsponiblesLbox.SelectedItem != null)
            {
                // Asignar la hora seleccionada al TextBox de horario
                HorarioTxt.Text = FechasDIsponiblesLbox.SelectedItem.ToString();
            }
        }
    }
}
