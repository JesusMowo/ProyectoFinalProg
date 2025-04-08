using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Utils
{   // Contrato para que una clase pueda ser parseada desde y hacia Txt
    // Contrato para que una clase pueda ser parseada desde y hacia Txt
    public interface ITxtParsable<T>
    {
        static abstract T ParseFromTxt(string lineaCsv);
        string ToTxt();
    }

    // CRUD para manejar operaciones de lectura y escritura en archivos Txt
    public class CRUD
    {
        public static int ObtenerUltimoId(string ruta)
        {
            AsegurarArchivoExiste(ruta);

            var lines = File.ReadAllLines(ruta);
            if (lines.Length == 0)
            {
                return 0;
            }

            var lastLine = lines.Last();
            var campos = lastLine.Split(',');

            return int.Parse(campos[0]);
        }

        // Método para generar un nuevo ID
        public static int GenerarNuevoId(string ruta)
        {
            int ultimoId = ObtenerUltimoId(ruta);
            return ultimoId + 1;
        }

        // READ
        public static List<T> LeerTxt<T>(string ruta, Func<string, T> parseador)
        {
            AsegurarArchivoExiste(ruta);

            var lista = new List<T>();
            using (var sr = new StreamReader(ruta))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    lista.Add(parseador(linea));
                }
            }
            return lista;
        }

        // CREATE (append)
        public static void AgregarRegistro<T>(string ruta, T elemento) where T : ITxtParsable<T>
        {
            AsegurarArchivoExiste(ruta);

            try
            {
                using (var sw = new StreamWriter(ruta, true))
                {
                    // Escribir el nuevo registro
                    sw.WriteLine(elemento.ToTxt());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir en el archivo TXT: {ex.Message}");
            }
        }

        // UPDATE o DELETE (reescribe todo el archivo)
        public static void EscribirTxt<T>(string ruta, List<T> elementos) where T : ITxtParsable<T>
        {
            AsegurarArchivoExiste(ruta);

            using (var sw = new StreamWriter(ruta))
            {
                foreach (var item in elementos)
                {
                    sw.WriteLine(item.ToTxt());
                }
            }
        }

        private static void AsegurarArchivoExiste(string ruta)
        {
            if (!File.Exists(ruta))
            {
                File.Create(ruta).Close();
            }
        }
    }
}
