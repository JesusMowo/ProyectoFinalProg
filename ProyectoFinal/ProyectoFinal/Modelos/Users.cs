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
        public string username { get; set; }
        public string password { get; set; }
        public string rol { get; set; }

        public static Users ParseFromTxt(string linea)
        {
            var campos = linea.Split(',');
            return new Users
            {
                Id = int.Parse(campos[0]),
                username = campos[1],
                password = campos[2],
                rol = campos[3]
            };
        }

        public string ToTxt()
        {
            return $"{Id},{username},{password},{rol}";
        }

        static Users ITxtParsable<Users>.ParseFromTxt(string linea)
        {
            return ParseFromTxt(linea);
        }
    }
}
  
