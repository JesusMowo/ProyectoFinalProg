using ProyectoFinal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{
    class Doctores : ITxtParsable<Doctores>
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string nombreCompleto { get; set; }
        public string especialidad { get; set; }
        public string horarios { get; set; }
        public string telefono { get; set; }
        public static Doctores ParseFromTxt(string linea)
        {
            var campos = linea.Split(',');
            return new Doctores
            {
                Id = int.Parse(campos[0]),
                IdUsuario = int.Parse(campos[1]),
                nombreCompleto = campos[2],
                especialidad = campos[3],
                horarios = campos[4]
            };
        }

        public string ToTxt()
        {
            return $"{Id},{IdUsuario},{nombreCompleto},{especialidad},{horarios}";
        }
    }
}
