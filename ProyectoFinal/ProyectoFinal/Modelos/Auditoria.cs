using ProyectoFinal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{
    public class Auditoria : ITxtParsable<Auditoria>
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdProducto { get; set; }
        public int CantidadMovida { get; set; }
        public DateTime Fecha { get; set; }

        public static Auditoria ParseFromTxt(string linea)
        {
            var campos = linea.Split(',');
            return new Auditoria
            {
                Id = int.Parse(campos[0]),
                IdUsuario = int.Parse(campos[1]),
                IdProducto = int.Parse(campos[2]),
                CantidadMovida = int.Parse(campos[3]),
                Fecha = DateTime.Parse(campos[4])
            };
        }

        public string ToTxt()
        {
            return $"{Id},{IdUsuario},{IdProducto},{CantidadMovida},{Fecha}";
        }
    }
}
