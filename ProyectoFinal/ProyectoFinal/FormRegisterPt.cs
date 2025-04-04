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


namespace ProyectoFinal
{
    public partial class FormRegisterPt : Form
    {
        public FormRegisterPt()
        {
            InitializeComponent();
        }

        private void ContinuarRegistro_Click(object sender, EventArgs e)
        {
            if (Password1TxtBox.Text != Password2TxtBox.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            string ruta = Rutas.ObtenerRuta();
            int nuevoId = CRUD.GenerarNuevoId(ruta);

            var nuevoUsuario = new Users
            {
                Id = nuevoId,
                Username = UserTxtBox.Text,
                Password = Password1TxtBox.Text,
                rol = "Paciente"
            };
            MessageBox.Show(nuevoUsuario.ToTxt());
            CRUD.AgregarRegistro(ruta, nuevoUsuario);
            MessageBox.Show(ruta);
            MessageBox.Show("Usuario registrado con éxito.");
        }
    }
}
