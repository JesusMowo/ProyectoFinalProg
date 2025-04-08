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
    public partial class FormHistorialPaciente : Form
    {
        public int UserId;
        public FormHistorialPaciente(int userId)
        {
            InitializeComponent();
            UserId = userId;

            CargarRegistrosEnDgv();
        }
        private void CargarRegistrosEnDgv()
        {
            // Obtener los registros médicos del paciente
            var registrosMedicos = CargarRegistrosMedicosPorPaciente(UserId);

            // Asignar los datos al DataGridView
            dgvHistorialPaciente.DataSource = registrosMedicos.Select(h => new
            {
                h.Id,
                h.Fecha,
                h.Diagnostico,
                h.Tratamiento
            }).ToList();
        }

        public static List<HistorialClinico> CargarRegistrosMedicosPorPaciente(int userId)
        {
            // Obtener la ruta de los archivos
            string rutaPacientes = Rutas.ObtenerRutaPacientes();
            string rutaCitas = Rutas.ObtenerRutaCitas();
            string rutaHistoriales = Rutas.ObtenerRutaHistorialClinico();

            // Leer la lista de pacientes
            var pacientes = CRUD.LeerTxt(rutaPacientes, Paciente.ParseFromTxt);

            // Buscar al paciente asociado al UserId
            var paciente = pacientes.FirstOrDefault(p => p.IdUsuario == userId);
            if (paciente == null) return new List<HistorialClinico>();

            // Leer la lista de citas
            var citas = CRUD.LeerTxt(rutaCitas, Citas.ParseFromTxt);

            // Filtrar las citas del paciente que están en estado "atendido"
            var idsCitasAtendidas = citas
                .Where(c => c.IdPaciente == paciente.Id && c.estado == "atendido")
                .Select(c => c.Id)
                .ToList();

            // Leer la lista de historiales clínicos
            var historiales = CRUD.LeerTxt(rutaHistoriales, HistorialClinico.ParseFromTxt);

            // Filtrar los historiales que coincidan con las citas atendidas
            var registrosMedicos = historiales
                .Where(h => idsCitasAtendidas.Contains(h.IdCita))
                .ToList();

            return registrosMedicos;
        }
        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
