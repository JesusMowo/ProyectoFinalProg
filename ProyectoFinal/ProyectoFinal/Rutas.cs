using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoFinal
{
    class Rutas
    {
        static string rutaDeAplicacion = AppDomain.CurrentDomain.BaseDirectory;

        public static string ObtenerRuta()
        {
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string ruta = Path.Combine(rutaDocumentos, "Users.txt");
            return ruta;
        }
    }
}
