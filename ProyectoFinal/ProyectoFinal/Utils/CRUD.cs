using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Utils
{   // Contrato para que una clase pueda ser parseada desde y hacia CSV
    public interface ITxtParsable<T>
    {
        static abstract T ParseFromTxt(string lineaCsv);
        string ToTxt();
    }

    // CRUD para manejar operaciones de lectura y escritura en archivos CSV
    public class CRUD
    {
        public static int ObtenerUltimoId(string ruta)
        {
            if (!File.Exists(ruta))
            {
                return 0;
            }

            var lines = File.ReadAllLines(ruta);
            if (lines.Length < 2)
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
            var lista = new List<T>();
            using (var sr = new StreamReader(ruta))
            {
                string linea;
                bool encabezado = true;
                while ((linea = sr.ReadLine()) != null)
                {
                    if (encabezado)
                    {
                        encabezado = false;
                        continue;
                    }
                    lista.Add(parseador(linea));
                }
            }
            return lista;
        }

        // CREATE (append)
        public static void AgregarRegistro<T>(string ruta, T elemento) where T : ITxtParsable<T>
        {
            try
            {
                using (var sw = new StreamWriter(ruta, true))
                {
                    if (new FileInfo(ruta).Length == 0)
                    {
                        sw.WriteLine("Id,Username,Password,rol");
                    }
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
        public static void EscribirCsv<T>(string ruta, List<T> elementos, string encabezado) where T : ITxtParsable<T>
        {
            using (var sw = new StreamWriter(ruta))
            {
                sw.WriteLine(encabezado);
                foreach (var item in elementos)
                {
                    sw.WriteLine(item.ToTxt());
                }
            }
        }
    }
}
