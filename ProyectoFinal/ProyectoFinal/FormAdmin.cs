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
        private Users _user;

        public FormAdmin(Users user)
        {
            InitializeComponent();
            _user = user;
            UsernameLabel.Text = "Bienvenido " + _user.Username;
        }
    }
}
