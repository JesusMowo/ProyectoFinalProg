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
    public partial class FormVerCitas : Form
    {
        public int UserId;
        public FormVerCitas(int userId)
        {
            InitializeComponent();
            this.UserId = userId;
            CargarCitas();
        }
        private void CargarCitas()
        {
            // Obtener la ruta de los archivos
            string rutaPacientes = Rutas.ObtenerRutaPacientes();
            string rutaCitas = Rutas.ObtenerRutaCitas();

            // Leer la lista de pacientes
            var pacientes = CRUD.LeerTxt(rutaPacientes, Paciente.ParseFromTxt);

            // Buscar al paciente asociado al UserId
            var paciente = pacientes.FirstOrDefault(p => p.IdUsuario == UserId);

            if (paciente == null)
            {
                MessageBox.Show("No se encontró un paciente asociado al usuario actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Leer la lista de citas
            var citas = CRUD.LeerTxt(rutaCitas, Citas.ParseFromTxt);

            // Filtrar las citas del paciente
            var citasDelPaciente = citas
                .Where(c => c.IdPaciente == paciente.Id)
                .Select(c => new
                {
                    Fecha = c.Dias.ToString("yyyy-MM-dd"),
                    Hora = c.horario,
                    Estado = c.estado
                })
                .ToList();

            // Mostrar las citas en el DataGridView
            CitasDGV.DataSource = citasDelPaciente;
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
