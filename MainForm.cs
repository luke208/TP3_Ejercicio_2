using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Ejercicio2
{
    public partial class MainForm : Form
    {
        static public List<Empleado> workers = new List<Empleado>();
        private Empleado Ultimo;

        VentanaCrearEmpleado VenCrearEmpleado = new VentanaCrearEmpleado();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            VenCrearEmpleado.Owner = this;

            VenCrearEmpleado.empleados = workers;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VenCrearEmpleado.Show();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if(workers.Count != 0)
            {
                Ultimo = workers.Last();

                dgvEmpleo.Rows.Add(Ultimo.GetCompleto(), Ultimo.GetEmail());
            }
        }
    }
}
