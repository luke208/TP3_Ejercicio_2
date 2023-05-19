
namespace Lab3_Ejercicio2
{
    partial class VentanaCrearEmpleado
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
            this.TextoTitulo = new System.Windows.Forms.Label();
            this.texto1 = new System.Windows.Forms.Label();
            this.texto2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btCrear = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextoTitulo
            // 
            this.TextoTitulo.AutoSize = true;
            this.TextoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoTitulo.Location = new System.Drawing.Point(12, 9);
            this.TextoTitulo.Name = "TextoTitulo";
            this.TextoTitulo.Size = new System.Drawing.Size(343, 24);
            this.TextoTitulo.TabIndex = 0;
            this.TextoTitulo.Text = "Ingresar los Datos del Nuevo Empleado";
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto1.Location = new System.Drawing.Point(13, 60);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(73, 22);
            this.texto1.TabIndex = 1;
            this.texto1.Text = "Nombre";
            // 
            // texto2
            // 
            this.texto2.AutoSize = true;
            this.texto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto2.Location = new System.Drawing.Point(14, 113);
            this.texto2.Name = "texto2";
            this.texto2.Size = new System.Drawing.Size(74, 22);
            this.texto2.TabIndex = 2;
            this.texto2.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(132, 113);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(223, 20);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // btCrear
            // 
            this.btCrear.Location = new System.Drawing.Point(12, 175);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(96, 34);
            this.btCrear.TabIndex = 5;
            this.btCrear.Text = "Agregar";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(272, 175);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(96, 34);
            this.btVolver.TabIndex = 6;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // VentanaCrearEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 221);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.texto2);
            this.Controls.Add(this.texto1);
            this.Controls.Add(this.TextoTitulo);
            this.Name = "VentanaCrearEmpleado";
            this.Text = "VentanaCrearEmpleado";
            this.Load += new System.EventHandler(this.VentanaCrearEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextoTitulo;
        private System.Windows.Forms.Label texto1;
        private System.Windows.Forms.Label texto2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Button btVolver;
    }
}