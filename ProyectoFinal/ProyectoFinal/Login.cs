// imports de otros archivos
using ProyectoFinal.Modelos;
using ProyectoFinal.Utils;

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string user = UserTxtBox.Text;
            string password = PasswordTxtBox.Text;
            //string ruta = Path.Combine(
            //    AppDomain.CurrentDomain.BaseDirectory,
            //    "Txt",
            //    "Users.txt"
            //);
            string ruta = Rutas.ObtenerRuta();
            var users = CRUD.LeerTxt(ruta, Users.ParseFromTxt);
            bool loginSuccessful = false;

            foreach (var u in users)
            {
                if (u.Username == user && u.Password == password)
                {
                    MessageBox.Show("Bienvenido " + u.Username);
                    loginSuccessful = true;
                    MessageBox.Show("Rol" + u.rol);
                    switch (u.rol)
                    {
                        case "Admin":
                            MessageBox.Show("Bienvenido Administrador " + u.Username);
                            new FormAdmin(u).Show();
                            this.Hide();
                            break;
                        case "Doctor":
                            // Lógica para doctor
                            break;
                        case "Paciente":
                            new FormAdmin(u).Show();
                            this.Hide();
                            break;
                    }
                    break;
                }
            }

            if (!loginSuccessful)
            {
                MessageBox.Show("Error en el usuario o contraseña.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewAccBtn_Click(object sender, EventArgs e)
        {
            new FormRegisterPt().Show();
            this.Hide();
        }
    }
}
