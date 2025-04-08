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
    public partial class FormHistorialMedico : Form
    {
        public int UserId;
        public FormHistorialMedico(int userId)
        {
            InitializeComponent();
            UserId = userId;

            CargarRegistrosEnDgv();
        }

        private void VolverBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        public static List<HistorialClinico> CargarRegistrosMedicosAtendidosPorDoctor(int userId)
        {
            // Obtener la ruta de los archivos
            string rutaDoctores = Rutas.ObtenerRutaDoctores();
            string rutaCitas = Rutas.ObtenerRutaCitas();
            string rutaHistoriales = Rutas.ObtenerRutaHistorialClinico();

            // Leer la lista de doctores
            var doctores = CRUD.LeerTxt(rutaDoctores, Doctores.ParseFromTxt);

            // Buscar al doctor asociado al UserId
            var doctor = doctores.FirstOrDefault(d => d.IdUsuario == userId);
            if (doctor == null) return new List<HistorialClinico>();

            // Leer la lista de citas
            var citas = CRUD.LeerTxt(rutaCitas, Citas.ParseFromTxt);

            // Filtrar las citas del doctor que están en estado "atendido"
            var idsCitasAtendidas = citas
                .Where(c => c.IdDoctor == doctor.Id && c.estado == "atendido")
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

        private void CargarRegistrosEnDgv()
        {
            // Obtener los registros médicos atendidos del doctor
            var registrosMedicos = CargarRegistrosMedicosAtendidosPorDoctor(UserId);

            // Asignar los datos al DataGridView
            dgvHistorialMedico.DataSource = registrosMedicos.Select(h => new
            {
                h.Id,
                h.IdCita,
                h.Diagnostico,
                h.Tratamiento,
                h.Observaciones,
                h.Fecha,
                h.evolucion
            }).ToList();
        }


        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}


