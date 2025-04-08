using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using ProyectoFinal.Forms.Edicion;
using ProyectoFinal.Forms.Interfaces;


// imports de otros archivos
using ProyectoFinal.Modelos;
using ProyectoFinal.Utils;

namespace ProyectoFinal
{
    public partial class FormAdmin : Form
    {
        public Users user;
        public int UserId;
        public FormAdmin(Users user)
        {
            InitializeComponent();
            this.user = user;
            this.UserId = user.Id;
            UsernameLabel.Text = $"Bienvenido {this.user.username}";
        }

        private void NewDocBtn_Click(object sender, EventArgs e)
        {
            new FormRegisterUser(false).Show();
        }

        private void AlmacenBtn_Click(object sender, EventArgs e)
        {
            
            new FormAlmacen(UserId).Show();
        }

        private void HorariosBtn_Click(object sender, EventArgs e)
        {
            new FormEdicionDoctor().Show();
        }
    }
}
