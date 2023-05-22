namespace Punto_2
{
    partial class AgregarEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbAgregarEmpleado = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.btAgregarEmpleado = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft YaHei", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(244)))), ((int)(((byte)(0)))));
            this.lbNombre.Location = new System.Drawing.Point(21, 97);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(95, 28);
            this.lbNombre.TabIndex = 6;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft YaHei", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(244)))), ((int)(((byte)(0)))));
            this.lbApellido.Location = new System.Drawing.Point(20, 159);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(96, 28);
            this.lbApellido.TabIndex = 7;
            this.lbApellido.Text = "Apellido";
            // 
            // lbAgregarEmpleado
            // 
            this.lbAgregarEmpleado.AutoSize = true;
            this.lbAgregarEmpleado.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgregarEmpleado.ForeColor = System.Drawing.Color.Yellow;
            this.lbAgregarEmpleado.Location = new System.Drawing.Point(60, 9);
            this.lbAgregarEmpleado.Name = "lbAgregarEmpleado";
            this.lbAgregarEmpleado.Size = new System.Drawing.Size(351, 55);
            this.lbAgregarEmpleado.TabIndex = 8;
            this.lbAgregarEmpleado.Text = "Agregar Empleado";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(138, 105);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(183, 20);
            this.txbNombre.TabIndex = 9;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(138, 167);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(183, 20);
            this.txbApellido.TabIndex = 10;
            // 
            // btAgregarEmpleado
            // 
            this.btAgregarEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregarEmpleado.ForeColor = System.Drawing.Color.GreenYellow;
            this.btAgregarEmpleado.Location = new System.Drawing.Point(343, 129);
            this.btAgregarEmpleado.Name = "btAgregarEmpleado";
            this.btAgregarEmpleado.Size = new System.Drawing.Size(99, 30);
            this.btAgregarEmpleado.TabIndex = 11;
            this.btAgregarEmpleado.Text = "Agregar";
            this.btAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btAgregarEmpleado.Click += new System.EventHandler(this.btAgregarEmpleado_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.Red;
            this.btSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(343, 265);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(99, 30);
            this.btSalir.TabIndex = 12;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "LSLM ®";
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAgregarEmpleado);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lbAgregarEmpleado);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimizeBox = false;
            this.Name = "AgregarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "AgregarEmpleado";
            this.Load += new System.EventHandler(this.AgregarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbAgregarEmpleado;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Button btAgregarEmpleado;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label1;
    }
}