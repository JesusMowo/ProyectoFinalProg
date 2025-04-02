using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinal.Modelos
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string name { get; set; }
        public string rol { get; set; }

        public static Users ParseFromCsv(string linea)
        {
            var campos = linea.Split(',');
            return new Users
            {
                Id = int.Parse(campos[0]),
                Username = campos[1],
                Password = campos[2],
                name = campos[3],
                rol = campos[4]
            };
        }

        public string ToCsv()
        {
            return $"{Id},{Username},{Password},{name},{rol}";
        }
    }
}
  
