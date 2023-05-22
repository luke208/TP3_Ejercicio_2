namespace Punto_2
{
    partial class EliminarEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.CbEmpleado = new System.Windows.Forms.ComboBox();
            this.datEmpleadoSel = new System.Windows.Forms.DataGridView();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datEmpleadoSel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(244)))), ((int)(((byte)(0)))));
            this.lbNombre.Location = new System.Drawing.Point(12, 58);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(165, 20);
            this.lbNombre.TabIndex = 7;
            this.lbNombre.Text = "Seleccione Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Eliminar Empleado";
            // 
            // CbEmpleado
            // 
            this.CbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEmpleado.FormattingEnabled = true;
            this.CbEmpleado.Location = new System.Drawing.Point(214, 56);
            this.CbEmpleado.Name = "CbEmpleado";
            this.CbEmpleado.Size = new System.Drawing.Size(173, 26);
            this.CbEmpleado.TabIndex = 9;
            this.CbEmpleado.SelectedIndexChanged += new System.EventHandler(this.CbEmpleado_SelectedIndexChanged);
            // 
            // datEmpleadoSel
            // 
            this.datEmpleadoSel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datEmpleadoSel.Location = new System.Drawing.Point(16, 110);
            this.datEmpleadoSel.Name = "datEmpleadoSel";
            this.datEmpleadoSel.Size = new System.Drawing.Size(323, 121);
            this.datEmpleadoSel.TabIndex = 10;
            this.datEmpleadoSel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datEmpleadoSel_CellContentClick);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(367, 142);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(85, 49);
            this.btEliminar.TabIndex = 11;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.Red;
            this.btSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(367, 248);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(85, 50);
            this.btSalir.TabIndex = 12;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "LSLM ®";
            // 
            // EliminarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.datEmpleadoSel);
            this.Controls.Add(this.CbEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EliminarEmpleado";
            this.Text = "EliminarEmpleado";
            this.Load += new System.EventHandler(this.EliminarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datEmpleadoSel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbEmpleado;
        private System.Windows.Forms.DataGridView datEmpleadoSel;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label2;
    }
}