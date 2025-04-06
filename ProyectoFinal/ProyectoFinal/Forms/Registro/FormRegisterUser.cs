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
using ProyectoFinal.Forms.Registro;

namespace ProyectoFinal
{
    public partial class FormRegisterUser : Form
    {

        Boolean B = false; // true = Paciente, false = Doctor
        public FormRegisterUser(Boolean B)
        {
            InitializeComponent();
            this.B = B;
        }

        private void ContinuarRegistro_Click(object sender, EventArgs e)
        {
            // Validar que el campo de usuario no esté vacío
            if (string.IsNullOrWhiteSpace(UserTxtBox.Text))
            {
                MessageBox.Show("El nombre de usuario es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que las contraseñas coincidan
            if (Password1TxtBox.Text != Password2TxtBox.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ruta = Rutas.ObtenerRutaUsers();

            // Validar que el usuario no exista ya en el sistema
            var usuariosExistentes = CRUD.LeerTxt(ruta, Users.ParseFromTxt);
            if (usuariosExistentes.Any(u => u.username.Equals(UserTxtBox.Text, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int nuevoId = CRUD.GenerarNuevoId(ruta);
            var nuevoUsuario = new Users
            {
                Id = nuevoId,
                username = UserTxtBox.Text,
                password = Password1TxtBox.Text,
                rol = ""
            };
            if (B)
            {
                nuevoUsuario.rol = "Paciente";
                new FormPacienteRegistro(nuevoUsuario).Show();
                this.Hide();
            }
            else
            {
                nuevoUsuario.rol = "Doctor";
                new FormRegistroDoc(nuevoUsuario).Show();
                this.Hide();
            }

            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (B)
            {
                new FormLogin().Show();
                this.Hide();
            }
            else
            {
                this.Hide();
            }
        }
    }
}
