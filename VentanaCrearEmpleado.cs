using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3_Ejercicio2.Archivos_de_Recursos;

namespace Lab3_Ejercicio2
{
    public partial class VentanaCrearEmpleado : Form
    {
        public List<Empleado> empleados = null;


        public VentanaCrearEmpleado()
        {
            InitializeComponent();
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if ((txtNombre.Text != "")&&(txtApellido.Text != ""))
            {
                btCrear.Enabled = true;
            }
            else
            {
                btCrear.Enabled = false;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if ((txtNombre.Text != "") && (txtApellido.Text != ""))
            {
                btCrear.Enabled = true;
            }
            else
            {
                btCrear.Enabled = false;
            }
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;

            Empleado NuevoEmp = new Empleado(txtNombre.Text, txtApellido.Text);

            empleados.Add(NuevoEmp);

            txtNombre.Enabled = true;
            txtApellido.Enabled = true;

            btVolver_Click(sender, e);
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtNombre.Clear();
            btCrear.Enabled = false;

            this.Hide();
            this.Owner.Show();
        }

        private void VentanaCrearEmpleado_Load(object sender, EventArgs e)
        {
            btCrear.Enabled = false;
        }
    }
}
