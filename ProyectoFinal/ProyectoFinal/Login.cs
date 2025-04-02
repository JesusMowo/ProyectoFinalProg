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

            var users = CRUD.LeerCsv("Csv/users.csv", Users.ParseFromCsv);
            bool loginSuccessful = false;

            foreach (var u in users)
            {
                if (u.Username == user && u.Password == password)
                {
                    MessageBox.Show("Bienvenido " + u.name);
                    loginSuccessful = true;
                    switch (u.rol)
                    {
                        case "Admin":
                            new FormAdmin(u).Show();
                            break;
                        case "Doctor":
                            // Lógica para doctor
                            break;
                        case "Paciente":
                            // Lógica para paciente
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
    }
}
