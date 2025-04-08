using ProyectoFinal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Modelos
{
    public class Producto : ITxtParsable<Producto>
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
            return $"{Id}|{nombre}|{cantidad}";
        }

        public static List<Producto> ParseListFromTxt(string txt)
        {
            var productos = new List<Producto>();
            if (string.IsNullOrEmpty(txt)) return productos;

            var items = txt.Split(';');
            foreach (var item in items)
            {
                var campos = item.Split('|');
                if (campos.Length < 3) continue; // Validar formato básico
                productos.Add(new Producto
                {
                    Id = int.Parse(campos[0]),
                    nombre = campos[1],
                    cantidad = int.Parse(campos[2])
                });
            }
            return productos;
        }

        // Método de validación
        public bool EsValido()
        {
            return Id >= 0 && !string.IsNullOrWhiteSpace(nombre) && cantidad >= 0;
        }
    }
}
