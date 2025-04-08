using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoFinal.Utils
{
    class Rutas
    {

        public static string ObtenerRutaUsers()
        {
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string ruta = Path.Combine(rutaDocumentos, "borrar", "Users.txt");
            return ruta;
        }
        public static string ObtenerRutaPacientes()
        {
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string ruta = Path.Combine(rutaDocumentos, "borrar", "Pacientes.txt");
            return ruta;
        }
        public static string ObtenerRutaDoctores()
        {
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string ruta = Path.Combine(rutaDocumentos, "borrar", "Doctores.txt");
            return ruta;
        }
        public static string ObtenerRutaCitas()
        {
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string ruta = Path.Combine(rutaDocumentos, "borrar", "Citas.txt");
            return ruta;
        }
        public static string ObtenerRutaProductos()
        {
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string ruta = Path.Combine(rutaDocumentos, "borrar", "Productos.txt");
            return ruta;
        }
        public static string ObtenerRutaAuditoria()
        {
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string ruta = Path.Combine(rutaDocumentos, "borrar", "Auditoria.txt");
            return ruta;
        }
    }
}

