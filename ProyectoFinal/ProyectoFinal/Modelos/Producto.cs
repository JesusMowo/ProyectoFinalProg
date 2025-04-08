using ProyectoFinal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{
    class Producto : ITxtParsable<Producto>
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public static Producto ParseFromTxt(string lineaCsv)
        {
            var campos = lineaCsv.Split(',');
            return new Producto
            {
                Id = int.Parse(campos[0]),
                nombre = campos[1],
                cantidad = int.Parse(campos[2])
            };
        }

        public string ToTxt()
        {
            return $"{Id},{nombre},{cantidad}";
        }
    }
}
