using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    public class Empleado
    {
        // Los atributos de la clase
        private string nombre;
        private string apellido;

        //Metodos, el nombre y el apellido del empleado, ambos devuelven
        //y se le puede modificar el valor
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        //Funcion que muestra el email, formado por el nombre,apellido
        //y el final predefinido
        public string Email
        {
            get { return $"{nombre}{apellido}@company.com"; }
        }
        //Otra funcion dedicada a mostrar el nombre completo
        public string NombreCompleto
        {
            get { return $"{Apellido}, {nombre}"; }
        }
    }
}
