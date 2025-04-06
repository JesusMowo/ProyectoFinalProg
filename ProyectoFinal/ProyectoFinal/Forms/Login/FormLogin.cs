// imports de otros archivos
using ProyectoFinal.Modelos;
using ProyectoFinal.Utils;

namespace ProyectoFinal
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string user = UserTxtBox.Text;
            string password = PasswordTxtBox.Text;
            string ruta = Rutas.ObtenerRutaUsers();
            var users = CRUD.LeerTxt(ruta, Users.ParseFromTxt);
            bool loginSuccessful = false;

            foreach (var u in users)
            {
                if (u.username == user && u.password == password)
                {
                    MessageBox.Show("Bienvenido " + u.username);
                    loginSuccessful = true;
                    MessageBox.Show("Rol" + u.rol);
                    switch (u.rol)
                    {
                        case "Admin":
                            MessageBox.Show("Bienvenido Administrador " + u.username);
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
            new FormRegisterUser(true).Show();
            this.Hide();
        }
    }
}
