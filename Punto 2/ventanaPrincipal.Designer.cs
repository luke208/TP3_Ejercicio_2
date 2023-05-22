namespace Punto_2
{
    partial class ventanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbEmpleado = new System.Windows.Forms.Label();
            this.btAgregarEmpleado = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btVerLista = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.AutoSize = true;
            this.lbEmpleado.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpleado.ForeColor = System.Drawing.Color.Cyan;
            this.lbEmpleado.Location = new System.Drawing.Point(78, 9);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(298, 55);
            this.lbEmpleado.TabIndex = 0;
            this.lbEmpleado.Text = "BD EMPLEADOS";
            this.lbEmpleado.Click += new System.EventHandler(this.lbEmpleado_Click);
            // 
            // btAgregarEmpleado
            // 
            this.btAgregarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarEmpleado.Location = new System.Drawing.Point(65, 93);
            this.btAgregarEmpleado.Name = "btAgregarEmpleado";
            this.btAgregarEmpleado.Size = new System.Drawing.Size(99, 30);
            this.btAgregarEmpleado.TabIndex = 1;
            this.btAgregarEmpleado.Text = "Agregar";
            this.btAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btAgregarEmpleado.Click += new System.EventHandler(this.btAgregarEmpleado_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(259, 93);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(99, 30);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btVerLista
            // 
            this.btVerLista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerLista.Location = new System.Drawing.Point(160, 155);
            this.btVerLista.Name = "btVerLista";
            this.btVerLista.Size = new System.Drawing.Size(99, 30);
            this.btVerLista.TabIndex = 3;
            this.btVerLista.Text = "Ver lista";
            this.btVerLista.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.Red;
            this.btSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(331, 268);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(99, 30);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "LSLM ®";
            // 
            // ventanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btVerLista);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAgregarEmpleado);
            this.Controls.Add(this.lbEmpleado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmpleado;
        private System.Windows.Forms.Button btAgregarEmpleado;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btVerLista;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label1;
    }
}

