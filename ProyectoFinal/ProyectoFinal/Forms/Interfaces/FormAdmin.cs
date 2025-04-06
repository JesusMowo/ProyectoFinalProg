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
    public partial class FormAdmin : Form
    {
        public Users user;

        public FormAdmin(Users user)
        {
            InitializeComponent();
            this.user = user;
            UsernameLabel.Text = $"Bienvenido {this.user.username}";
        }

        private void NewDocBtn_Click(object sender, EventArgs e)
        {
            new FormRegisterUser(false).Show();
        }
    }
}
