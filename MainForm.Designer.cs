
namespace Lab3_Ejercicio2
{
    partial class MainForm
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
            this.btAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmpleo = new System.Windows.Forms.DataGridView();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleo)).BeginInit();
            this.SuspendLayout();
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(624, 453);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(108, 34);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "Agregar Empleado";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Empleados 2023";
            // 
            // dgvEmpleo
            // 
            this.dgvEmpleo.AllowUserToAddRows = false;
            this.dgvEmpleo.AllowUserToDeleteRows = false;
            this.dgvEmpleo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombre,
            this.clmEmail});
            this.dgvEmpleo.Location = new System.Drawing.Point(19, 90);
            this.dgvEmpleo.MultiSelect = false;
            this.dgvEmpleo.Name = "dgvEmpleo";
            this.dgvEmpleo.ReadOnly = true;
            this.dgvEmpleo.Size = new System.Drawing.Size(582, 397);
            this.dgvEmpleo.TabIndex = 2;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre Completo";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmEmail
            // 
            this.clmEmail.HeaderText = "Correo Eléctronico";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            this.clmEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 501);
            this.Controls.Add(this.dgvEmpleo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAgregar);
            this.Name = "MainForm";
            this.Text = "Empleados 2023";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpleo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
    }
}

