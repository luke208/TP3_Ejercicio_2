using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Punto_2
{
    public partial class ventanaPrincipal : Form
    {
        //Creo la lista de empleados, tiene de referencia a la variable empleado(nombre,apellido,email)
        List<Empleado> empleados= new List<Empleado>();
        int numEmpleado= 0;
        public ventanaPrincipal()
        {
            InitializeComponent();
            ver_canEmpleado(numEmpleado);
        }

        //Esta funcion sirve para agregar datos a la lista empleado
        public void nuevoEmpleado(string nombre, string apellido)
        {
            empleados.Add(new Empleado());
            empleados[numEmpleado].Nombre = nombre;
            empleados[numEmpleado].Apellido = apellido;
            numEmpleado++;
            ver_canEmpleado(numEmpleado);
        }
       
        public void ver_canEmpleado(int cant)
        {
            if (cant == 0)
            {
                btEliminar.Enabled = false;
                btVerLista.Enabled = false;
            }
            else
            {
                btEliminar.Enabled = true;
                btVerLista.Enabled = true;
            }
        }
        private void lbEmpleado_Click(object sender, EventArgs e)
        {
           string email = empleados[0].Email;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Si presiona el boton agregar, mostrara la ventana de Agregar empleado
        // Que se la nombro con el nombre: Agregar
        private void btAgregarEmpleado_Click(object sender, EventArgs e)
        {
             // Creo la ventana de agregar empleado
             //Utilizo la clase Agregar empleado, el nombre de la ventana se llama agregar
             //Esa variable guardara la direccion de la nueva ventana
             //Crea la ventana
             AgregarEmpleado agregar = new AgregarEmpleado();
             agregar.Show();
             this.Hide();
        }

        //El boton eliminar lleva a un formulario, para eliminar algun empleado
        private void btEliminar_Click(object sender, EventArgs e)
        { 
            EliminarEmpleado eliminar= new EliminarEmpleado(); 
            eliminar.Show(); 
            this.Hide();
        }
    }
}
