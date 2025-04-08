using ProyectoFinal.Forms.Registro;
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

namespace ProyectoFinal.Forms.Interfaces
{
    public partial class FormDoctores : Form
    {
        public int UserId;

        public FormDoctores(int userId)
        {
            InitializeComponent();
            this.UserId = userId;
            CargarCitas();
        }

        private void AtenderCitaBtn_Click(object sender, EventArgs e)
        {
            if (CitasDGV.SelectedRows.Count > 0) // Verifica que haya una fila seleccionada
            {
                // Obtén el ID de la cita de la fila seleccionada
                int idCita = Convert.ToInt32(CitasDGV.SelectedRows[0].Cells["Id"].Value);

                // Abre el formulario de registro de paciente atendido y pasa el ID de la cita
                var formRegistro = new FormRegistroPacienteAtendido(UserId, idCita);

                // Suscribirse al evento FormClosed para recargar las citas
                formRegistro.FormClosed += (s, args) => CargarCitas();

                formRegistro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una cita antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CargarCitas()
        {
            // Obtener la ruta de los archivos
            string rutaDoctores = Rutas.ObtenerRutaDoctores();
            string rutaCitas = Rutas.ObtenerRutaCitas();

            // Leer la lista de doctores
            var doctores = CRUD.LeerTxt(rutaDoctores, Doctores.ParseFromTxt);

            // Buscar al doctor asociado al UserId
            var doctor = doctores.FirstOrDefault(d => d.IdUsuario == UserId);

            // Leer la lista de citas
            var citas = CRUD.LeerTxt(rutaCitas, Citas.ParseFromTxt);

            // Filtrar las citas del doctor que no están atendidas
            var citasDelDoctor = citas
                .Where(c => c.IdDoctor == doctor.Id && c.estado != "atendido")
                .Select(c => new
                {
                    Id = c.Id,
                    Fecha = c.Dias.ToString("yyyy-MM-dd"),
                    Hora = c.horario,
                    Paciente = ObtenerNombrePaciente(c.IdPaciente),
                    Estado = c.estado
                })
                .ToList();

            // Mostrar las citas en el DataGridView
            CitasDGV.DataSource = citasDelDoctor;
        }
        private string ObtenerNombrePaciente(int idPaciente)
        {
            string rutaPacientes = Rutas.ObtenerRutaPacientes();
            var pacientes = CRUD.LeerTxt(rutaPacientes, Paciente.ParseFromTxt);
            var paciente = pacientes.FirstOrDefault(p => p.Id == idPaciente);
            return paciente != null ? paciente.nombreCompleto : "Desconocido";
        }

        private void HistorialMedicoBtn_Click(object sender, EventArgs e)
        {
            new FormHistorialMedico(UserId).Show();
        }
    }
}
