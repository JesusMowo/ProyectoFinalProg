using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// imports de otros archivos
using ProyectoFinal.Modelos;
using ProyectoFinal.Utils;

namespace ProyectoFinal.Utils
{
    class GestorDeCitas
    {
        public static bool EsHorarioValido(string horarioDoctor, string horaInicio)
        {
            var horas = horarioDoctor.Split('-');
            var horaInicioDoctor = TimeSpan.Parse(horas[0]);
            var horaFinDoctor = TimeSpan.Parse(horas[1]);
            var hora = TimeSpan.Parse(horaInicio);

            return hora >= horaInicioDoctor && hora < horaFinDoctor;
        }

        public static bool TieneCitaEnHora(string rutaCitas, int idDoctor, string horaInicio)
        {
            var citas = LeerCitasDesdeTxt(rutaCitas);
            var hora = TimeSpan.Parse(horaInicio);
            return citas.Any(c => c.IdDoctor == idDoctor && TimeSpan.Parse(c.horario.Split('-')[0]) == hora);
        }

        public static bool PuedeAgendarCita(Doctores doctor, string rutaCitas, string horaInicio)
        {
            if (!EsHorarioValido(doctor.horarios, horaInicio))
            {
                return false;
            }

            if (TieneCitaEnHora(rutaCitas, doctor.Id, horaInicio))
            {
                return false;
            }

            return true;
        }

        private static List<Citas> LeerCitasDesdeTxt(string ruta)
        {
            var citas = new List<Citas>();
            using (var sr = new StreamReader(ruta))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    citas.Add(Citas.ParseFromTxt(linea));
                }
            }
            return citas;
        }
    }
}
