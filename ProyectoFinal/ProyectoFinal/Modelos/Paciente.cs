using ProyectoFinal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{
    class Paciente : ITxtParsable<Paciente>
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string nombreCompleto { get; set; }
        public string edad { get; set; }
        public string historialClinico { get; set; }
        public string observaciones { get; set; }
        public static Paciente ParseFromTxt(string lineaCsv)
        {
            var campos = lineaCsv.Split(',');
            return new Paciente
            {
                Id = int.Parse(campos[0]),
                IdUsuario = int.Parse(campos[1]),
                nombreCompleto = campos[2],
                edad = campos[3],
                historialClinico = campos[4],
                observaciones = campos[5]
            };
        }

        public string ToTxt()
        {
            return $"{Id},{IdUsuario},{nombreCompleto},{edad},{historialClinico},{observaciones}";
        }
    }
}
