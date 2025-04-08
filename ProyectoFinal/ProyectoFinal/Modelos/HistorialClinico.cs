using ProyectoFinal.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{
    public class HistorialClinico : ITxtParsable<HistorialClinico>
    {
        public int Id { get; set; }
        public int IdCita { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string evolucion { get; set; }
        public List<Producto> ProductosUtilizados { get; set; } = new List<Producto>();

        public static HistorialClinico ParseFromTxt(string lineaCsv)
        {
            var campos = lineaCsv.Split(',');
            return new HistorialClinico
            {
                Id = int.Parse(campos[0]),
                IdCita = int.Parse(campos[1]),
                Diagnostico = campos[2],
                Tratamiento = campos[3],
                Observaciones = campos[4],
                Fecha = DateTime.Parse(campos[5]),
                evolucion = campos[6],
                ProductosUtilizados = Producto.ParseListFromTxt(campos[7])
            };
        }

        public string ToTxt()
        {
            return $"{Id},{IdCita}," +
                $"{Diagnostico},{Tratamiento},{Observaciones}," +
                $"{Fecha},{evolucion},{ToTxtList(ProductosUtilizados)}";
        }

        private static string ToTxtList(List<Producto> productos)
        {
            return string.Join(";", productos.Select(p => p.ToTxt()));
        }
    }
}
