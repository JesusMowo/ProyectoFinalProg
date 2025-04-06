using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// imports de otros archivos
using ProyectoFinal.Modelos;
using ProyectoFinal.Utils;

namespace ProyectoFinal.Forms.Registro
{
    public partial class FormPacienteRegistro : Form
    {
        private Users _user;

        public FormPacienteRegistro(Users u)
        {
            InitializeComponent();
            _user = u;
        }

        private void RegistrarBtn_Click(object sender, EventArgs e)
        {
            // Validar que el nombre completo y la edad no estén vacíos
            if (string.IsNullOrWhiteSpace(FullnameTxtBox.Text))
            {
                MessageBox.Show("El nombre completo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(EdadTxtBox.Text))
            {
                MessageBox.Show("La edad es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que la edad sea un número válido
            if (!int.TryParse(EdadTxtBox.Text, out int edad))
            {
                MessageBox.Show("La edad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Crear el nuevo paciente
            string rutaUser = Rutas.ObtenerRutaUsers();
            string ruta = Rutas.ObtenerRutaPacientes();
            int nuevoId = CRUD.GenerarNuevoId(ruta);
            var nuevoPaciente = new Paciente
            {
                Id = nuevoId,
                IdUsuario = _user.Id,
                nombreCompleto = FullnameTxtBox.Text,
                edad = EdadTxtBox.Text,
                historialClinico = HistorialRTbox.Text,
                observaciones = ObservacionesRTBox.Text
            };
            CRUD.AgregarRegistro(rutaUser, _user);
            CRUD.AgregarRegistro(ruta, nuevoPaciente);
            MessageBox.Show("Paciente registrado correctamente.");
            new FormLogin().Show();
            this.Hide();
        }
    }
}
