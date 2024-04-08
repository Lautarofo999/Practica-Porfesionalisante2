using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cliente
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

        public Cliente(string dni, string nombre, string email)
        {
            DNI = dni;
            Nombre = nombre;
            Email = email;
        }
    }
}
