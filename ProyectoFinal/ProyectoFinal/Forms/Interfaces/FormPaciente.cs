using ProyectoFinal.Forms.Registro;
using ProyectoFinal.Modelos;
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
    public partial class FormPaciente : Form
    {
        public Users User;
        public int UserId;
        public FormPaciente(Users User)
        {
            InitializeComponent();
            this.User = User;
            this.UserId = User.Id;
        }

        private void CrearCitaBtn_Click(object sender, EventArgs e)
        {
            new FormRegistroCita(UserId).Show();
        }

        private void VerCitasBtn_Click(object sender, EventArgs e)
        {
            new FormVerCitas(UserId).Show();
        }

        private void HistorialClinicoBtn_Click(object sender, EventArgs e)
        {
            new FormHistorialPaciente(UserId).Show();
        }
    }
}
