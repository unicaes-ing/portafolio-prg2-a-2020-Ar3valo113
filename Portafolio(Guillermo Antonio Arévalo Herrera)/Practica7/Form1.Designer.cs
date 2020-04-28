namespace Practica7
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Mascotas = new System.Windows.Forms.Button();
            this.dgv_Lista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtx_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(313, 82);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 23;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(411, 355);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 25;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Mascotas
            // 
            this.btn_Mascotas.Location = new System.Drawing.Point(7, 355);
            this.btn_Mascotas.Name = "btn_Mascotas";
            this.btn_Mascotas.Size = new System.Drawing.Size(75, 23);
            this.btn_Mascotas.TabIndex = 24;
            this.btn_Mascotas.Text = "Mascotas";
            this.btn_Mascotas.UseVisualStyleBackColor = true;
            // 
            // dgv_Lista
            // 
            this.dgv_Lista.AllowUserToAddRows = false;
            this.dgv_Lista.AllowUserToDeleteRows = false;
            this.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_Lista.Location = new System.Drawing.Point(7, 130);
            this.dgv_Lista.Name = "dgv_Lista";
            this.dgv_Lista.ReadOnly = true;
            this.dgv_Lista.RowHeadersVisible = false;
            this.dgv_Lista.Size = new System.Drawing.Size(474, 192);
            this.dgv_Lista.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 185;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Correo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 185;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Teléfono";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // mtx_Telefono
            // 
            this.mtx_Telefono.Location = new System.Drawing.Point(115, 85);
            this.mtx_Telefono.Mask = "0000-0000";
            this.mtx_Telefono.Name = "mtx_Telefono";
            this.mtx_Telefono.Size = new System.Drawing.Size(80, 20);
            this.mtx_Telefono.TabIndex = 21;
            this.mtx_Telefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtx_Telefono_MaskInputRejected);
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(115, 48);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.ShortcutsEnabled = false;
            this.txt_Correo.Size = new System.Drawing.Size(273, 20);
            this.txt_Correo.TabIndex = 19;
            this.txt_Correo.TextChanged += new System.EventHandler(this.txt_Correo_TextChanged);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(115, 12);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.ShortcutsEnabled = false;
            this.txt_Nombre.Size = new System.Drawing.Size(273, 20);
            this.txt_Nombre.TabIndex = 17;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.txt_Nombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 385);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Mascotas);
            this.Controls.Add(this.dgv_Lista);
            this.Controls.Add(this.mtx_Telefono);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Mascotas;
        private System.Windows.Forms.DataGridView dgv_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.MaskedTextBox mtx_Telefono;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

