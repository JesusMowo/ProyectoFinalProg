using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

// imports de otros archivos
using ProyectoFinal.Modelos;
using ProyectoFinal.Utils;

namespace ProyectoFinal.Forms.Registro
{
    public partial class FormRegistroDoc : Form
    {
        public Users user;

        public FormRegistroDoc(Users u)
        {
            user = u;
            InitializeComponent();
        }

        private void RegistroDocBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FullnameDocTxt.Text))
            {
                MessageBox.Show("El nombre completo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(EspecialidadTxt.Text))
            {
                MessageBox.Show("La especialidad es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(HorarioTxt.Text))
            {
                MessageBox.Show("El horario es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsHorarioValido(HorarioTxt.Text))
            {
                MessageBox.Show("El horario debe estar en el formato hh:00-hh:00, terminar en 00 y estar entre 00:00 y 23:59.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(TelefonoTxt.Text))
            {
                MessageBox.Show("El teléfono es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsTelefonoNumerico(TelefonoTxt.Text))
            {
                MessageBox.Show("El teléfono debe contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string rutaUser = Rutas.ObtenerRutaUsers();
            string ruta = Rutas.ObtenerRutaDoctores();
            int nuevoId = CRUD.GenerarNuevoId(ruta);
            var nuevoDoctor = new Doctores
            {
                Id = nuevoId,
                IdUsuario = user.Id,
                nombreCompleto = FullnameDocTxt.Text,
                especialidad = EspecialidadTxt.Text,
                horarioSemanal = HorarioTxt.Text,
                telefono = TelefonoTxt.Text
            };
            CRUD.AgregarRegistro(rutaUser, user);
            CRUD.AgregarRegistro(ruta, nuevoDoctor);
            MessageBox.Show("Doctor registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            new FormAdmin(user);
        }

        private bool EsHorarioValido(string horario)
        {
            var regex = new Regex(@"^\d{2}:00-\d{2}:00$");
            if (!regex.IsMatch(horario))
            {
                return false;
            }

            var horas = horario.Split('-');
            if (!EsHoraValida(horas[0]) || !EsHoraValida(horas[1]))
            {
                return false;
            }

            var horaInicio = TimeSpan.Parse(horas[0]);
            var horaFin = TimeSpan.Parse(horas[1]);

            return horaInicio >= TimeSpan.Zero && horaInicio < TimeSpan.FromHours(24) &&
                   horaFin >= TimeSpan.Zero && horaFin < TimeSpan.FromHours(24);
        }

        private bool EsHoraValida(string hora)
        {
            var partes = hora.Split(':');
            if (int.TryParse(partes[0], out int horas) && horas >= 0 && horas < 24)
            {
                return true;
            }
            return false;
        }

        private bool EsTelefonoNumerico(string telefono)
        {
            return telefono.All(char.IsDigit);
        }
    }
}
