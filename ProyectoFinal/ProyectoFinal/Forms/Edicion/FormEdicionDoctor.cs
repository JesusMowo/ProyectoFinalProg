using ProyectoFinal.Modelos;
using ProyectoFinal.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Forms.Edicion
{
    public partial class FormEdicionDoctor : Form
    {
        private string rutaDoctores = Rutas.ObtenerRutaDoctores();
        private int doctorSeleccionadoId;

        public FormEdicionDoctor()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            var doctores = CRUD.LeerTxt(rutaDoctores, Doctores.ParseFromTxt);

            var datosDoctores = doctores.Select(d => new
            {
                Id = d.Id,
                NombreCompleto = d.nombreCompleto,
                Especialidad = d.especialidad,
                HorarioSemanal = d.horarioSemanal,
                Telefono = d.telefono
            }).ToList();

            HorariosDGV.DataSource = datosDoctores;
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreTxt.Text) || string.IsNullOrWhiteSpace(EspecialidadTxt.Text) ||
                string.IsNullOrWhiteSpace(HorarioTxt.Text) || string.IsNullOrWhiteSpace(TelefonoTxt.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsHorarioValido(HorarioTxt.Text))
            {
                MessageBox.Show("El horario debe estar en el formato hh:00-hh:00, terminar en 00 y estar entre 00:00 y 23:59.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsTelefonoNumerico(TelefonoTxt.Text))
            {
                MessageBox.Show("El teléfono debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var doctores = CRUD.LeerTxt(rutaDoctores, Doctores.ParseFromTxt);

            // Actualizar el doctor seleccionado
            var doctor = doctores.FirstOrDefault(d => d.Id == doctorSeleccionadoId);
            if (doctor != null)
            {
                doctor.nombreCompleto = NombreTxt.Text;
                doctor.especialidad = EspecialidadTxt.Text;
                doctor.horarioSemanal = HorarioTxt.Text;
                doctor.telefono = TelefonoTxt.Text;

                // Reescribir el archivo con los datos actualizados
                CRUD.EscribirCsv(rutaDoctores, doctores);

                MessageBox.Show("Doctor actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(); // Recargar los datos en el DataGridView
            }
            else
            {
                MessageBox.Show("No se encontró el doctor seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsHorarioValido(string horario)
        {
            var regex = new Regex(@"^\d{2}:00-\d{2}:00$");
            if (!regex.IsMatch(horario))
            {
                return false;
            }

            var horas = horario.Split('-');
            if (!EsHoraValida(horas[0]) || !EsHoraValida(horas[1]))
            {
                return false;
            }

            var horaInicio = TimeSpan.Parse(horas[0]);
            var horaFin = TimeSpan.Parse(horas[1]);

            return horaInicio >= TimeSpan.Zero && horaInicio < TimeSpan.FromHours(24) &&
                   horaFin >= TimeSpan.Zero && horaFin < TimeSpan.FromHours(24);
        }

        private bool EsHoraValida(string hora)
        {
            var partes = hora.Split(':');
            if (int.TryParse(partes[0], out int horas) && horas >= 0 && horas < 24)
            {
                return true;
            }
            return false;
        }

        private bool EsTelefonoNumerico(string telefono)
        {
            return telefono.All(char.IsDigit);
        }


        private void HorariosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var filaSeleccionada = HorariosDGV.Rows[e.RowIndex];
                doctorSeleccionadoId = (int)filaSeleccionada.Cells["Id"].Value;
                NombreTxt.Text = filaSeleccionada.Cells["NombreCompleto"].Value.ToString();
                EspecialidadTxt.Text = filaSeleccionada.Cells["Especialidad"].Value.ToString();
                HorarioTxt.Text = filaSeleccionada.Cells["HorarioSemanal"].Value.ToString();
                TelefonoTxt.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
            }
        }



        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GuardarBtn_Click_1(object sender, EventArgs e) 
        { 
            
            if (string.IsNullOrWhiteSpace(NombreTxt.Text) || string.IsNullOrWhiteSpace(EspecialidadTxt.Text) ||
                string.IsNullOrWhiteSpace(HorarioTxt.Text) || string.IsNullOrWhiteSpace(TelefonoTxt.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var doctores = CRUD.LeerTxt(rutaDoctores, Doctores.ParseFromTxt);

            // Actualizar el doctor seleccionado
            var doctor = doctores.FirstOrDefault(d => d.Id == doctorSeleccionadoId);
            if (doctor != null)
            {
                doctor.nombreCompleto = NombreTxt.Text;
                doctor.especialidad = EspecialidadTxt.Text;
                doctor.horarioSemanal = HorarioTxt.Text;
                doctor.telefono = TelefonoTxt.Text;

                // Reescribir el archivo con los datos actualizados
                CRUD.EscribirCsv(rutaDoctores, doctores);

                MessageBox.Show("Doctor actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(); // Recargar los datos en el DataGridView
            }
            else
            {
                MessageBox.Show("No se encontró el doctor seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

