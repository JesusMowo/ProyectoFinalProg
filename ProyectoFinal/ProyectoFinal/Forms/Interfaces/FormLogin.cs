// imports de otros archivos
using ProyectoFinal.Forms.Interfaces;
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

            // Verificar usuarios registrados
            foreach (var u in users)
            {
                if (u.username == user && u.password == password)
                {
                    MessageBox.Show("Bienvenido " + u.username);
                    loginSuccessful = true;
                    switch (u.rol)
                    {
                        case "Admin":
                            MessageBox.Show("Bienvenido Administrador " + u.username);
                            new FormAdmin(u).Show();
                            this.Hide();
                            break;
                        case "Doctor":
                            MessageBox.Show("Bienvenido Doctor " + u.username);
                            break;
                        case "Paciente":
                            new FormPaciente(u).Show();
                            this.Hide();
                            break;
                    }
                    break;
                }
            }

            // Usuario administrador predefinido
            if (!loginSuccessful && user == "admin" && password == "123")
            {
                MessageBox.Show("Bienvenido Administrador predefinido");
                var adminUser = new Users
                {
                    username = "admin",
                    password = "123",
                    rol = "Admin"
                };
                new FormAdmin(adminUser).Show();
                this.Hide();
                loginSuccessful = true;
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
