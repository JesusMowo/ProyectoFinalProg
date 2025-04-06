using ProyectoFinal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{
    class Citas : ITxtParsable<Citas>
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public int IdDoctor { get; set; }
        public string horario { get; set; }
        public static Citas ParseFromTxt(string lineaCsv)
        {
            var campos = lineaCsv.Split(',');
            return new Citas
            {
                Id = int.Parse(campos[0]),
                IdPaciente = int.Parse(campos[1]),
                IdDoctor = int.Parse(campos[2]),
                horario = campos[3]
            };
        }

        public string ToTxt()
        {
            return $"{Id},{IdPaciente},{IdDoctor},{horario}";
        }
    }
}
