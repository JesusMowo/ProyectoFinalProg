using ProyectoFinal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinal.Modelos
{
    public class Users : ITxtParsable<Users>
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string rol { get; set; }

        public static Users ParseFromTxt(string linea)
        {
            var campos = linea.Split(',');
            return new Users
            {
                Id = int.Parse(campos[0]),
                Username = campos[1],
                Password = campos[2],
                rol = campos[3]
            };
        }

        public string ToTxt()
        {
            return $"{Id},{Username},{Password},{rol}";
        }

        static Users ITxtParsable<Users>.ParseFromTxt(string linea)
        {
            return ParseFromTxt(linea);
        }
    }
}
  
