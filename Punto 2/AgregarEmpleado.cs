using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_2
{
    public partial class AgregarEmpleado : Form
    {
        //Esto hace referencia a la ventana principal
        //Esta variable apuntara a esa ventana
        //Se utiliza la funcion application openforms(Abre todos los formularios)
        // Ese formulario es del tipo principal
        // Y tomara al primero que cargue el programa
        ventanaPrincipal principal= Application.OpenForms.OfType<ventanaPrincipal>().FirstOrDefault();

        public AgregarEmpleado()
        {
            InitializeComponent();

        }

        private void btAgregarEmpleado_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text;
            string apellido = txbApellido.Text;
            principal.Show();
            principal.nuevoEmpleado(nombre,apellido);
            this.Close();
            
        }
        
        private void btSalir_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
           
        }
    }
}
