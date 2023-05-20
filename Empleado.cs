using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Ejercicio2
{
    public class Empleado
    {
        private int id { get; set; }
        private string nombre {get; set;}
        private string apellido { get; set; }
        private string nombre_completo { get; set; }
        private string email { get; set; }

        public Empleado()
        {

        }

        public Empleado(string nom, string ape)
        {
            nombre = nom;
            apellido = ape;

            nombre_completo = string.Concat(nom, ' ', ape);
            email = string.Concat(nom.ToLower(), '.', ape.ToLower(), "@company.com");
        }

        public string GetCompleto()
        {
            return nombre_completo;
        }

        public string GetEmail()
        {
            return email;
        }
    }
}
