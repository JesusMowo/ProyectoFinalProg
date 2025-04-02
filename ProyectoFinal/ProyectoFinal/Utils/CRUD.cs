using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Utils
{   // Contrato para que una clase pueda ser parseada desde y hacia CSV
    public interface ICsvParsable<T>
    {
        static abstract T ParseFromCsv(string lineaCsv);
        string ToCsv();
    }
    public class CRUD
    {
        // READ
        public static List<T> LeerCsv<T>(string ruta, Func<string, T> parseador)
        {
            var lista = new List<T>();
            var rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ruta);
            using (var sr = new StreamReader(rutaCompleta))
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
        public static void AgregarRegistro<T>(string ruta, T elemento) where T : ICsvParsable<T>
        {
            var rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ruta);
            using (var sw = new StreamWriter(rutaCompleta, true))
            {
                sw.WriteLine(elemento.ToCsv());
            }
        }

        // UPDATE o DELETE (reescribe todo el archivo)
        public static void EscribirCsv<T>(string ruta, List<T> elementos, string encabezado) where T : ICsvParsable<T>
        {
            var rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ruta);
            using (var sw = new StreamWriter(rutaCompleta))
            {
                sw.WriteLine(encabezado);
                foreach (var item in elementos)
                {
                    sw.WriteLine(item.ToCsv());
                }
            }
        }
    }
}
