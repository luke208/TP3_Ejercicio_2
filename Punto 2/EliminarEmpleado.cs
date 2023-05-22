using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Punto_2
{
    public partial class EliminarEmpleado : Form
    {
        Empleado seleccionado;
        ventanaPrincipal principal = Application.OpenForms.OfType<ventanaPrincipal>().FirstOrDefault();
        public EliminarEmpleado()
        {
            InitializeComponent();
            CargarListaEmpleados();
        }

        private void EliminarEmpleado_Load(object sender, EventArgs e)
        {
            
        }
        //Carga la lista de Empleados, en el controlbox
        private void CargarListaEmpleados()
        {
            CbEmpleado.Items.Clear(); //Limpia el controlbox, por alguna anterior
            //operacion realizada
            CbEmpleado.Text = "";
            IReadOnlyList<Empleado> empleados = principal.empleados;
            //Lee solo la lista de empleados, que se encuentra en la ventana principal
            foreach (Empleado i in empleados) //Realiza un for para ir mostrando por cada
                //linea los datos de cada empleado
            {
                CbEmpleado.Items.Add(i);
            }
            //Pero mostrara solo el nombre completo
            //Funcion nombrada en la Clase Empleado
            CbEmpleado.DisplayMember = "NombreCompleto";
        }
        public int buscarDatoEmpleado(string nombreemp,string apellidoemp)
        {
            int i = 0;
            List<Empleado> empleados = principal.empleados;
            foreach(Empleado j in empleados)
            {
                string nombre = empleados[i].Nombre;
                string apellido = empleados[i].Apellido;
                if(nombreemp==nombre && apellido == apellidoemp)
                {
                    break;
                }
                else
                {
                    i++;
                }
            }
            return i;

        }
        public void MostrarDatosEmpleados(Empleado sel)
        {
            List<Empleado> empleados = principal.empleados;

            datEmpleadoSel.DataSource = sel;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       

        //Boton para salir de la ventana, vuelve a la principal
        private void btSalir_Click(object sender, EventArgs e)
        {
            principal.Show();
            this.Close();
        }

        private void CbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbEmpleado.SelectedItem != null)
            {
                if (CbEmpleado.SelectedItem is Empleado empleadoSeleccionado)
                {
                    // Utiliza el empleadoSeleccionado para acceder a sus propiedades y mostrar los datos
                    List<Empleado> listaTemporal = new List<Empleado> { empleadoSeleccionado };
                    datEmpleadoSel.Rows.Clear();
                    datEmpleadoSel.Rows.Add(empleadoSeleccionado.Nombre, empleadoSeleccionado.Apellido);
                    datEmpleadoSel.DataSource = listaTemporal;
                }
            }
            
        }

        private void datEmpleadoSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
