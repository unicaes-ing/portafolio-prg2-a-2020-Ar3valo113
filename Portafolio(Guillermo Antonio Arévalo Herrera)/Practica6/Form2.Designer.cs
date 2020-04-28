namespace Practica6
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Quitar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lsv_Productos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // mtb_Telefono
            // 
            this.mtb_Telefono.Location = new System.Drawing.Point(71, 10);
            this.mtb_Telefono.Mask = "00000000";
            this.mtb_Telefono.Name = "mtb_Telefono";
            this.mtb_Telefono.Size = new System.Drawing.Size(60, 20);
            this.mtb_Telefono.TabIndex = 2;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(71, 36);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(167, 20);
            this.txt_Nombre.TabIndex = 3;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(261, 8);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(261, 37);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 5;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Quitar
            // 
            this.btn_Quitar.Location = new System.Drawing.Point(261, 66);
            this.btn_Quitar.Name = "btn_Quitar";
            this.btn_Quitar.Size = new System.Drawing.Size(75, 23);
            this.btn_Quitar.TabIndex = 6;
            this.btn_Quitar.Text = "Quitar";
            this.btn_Quitar.UseVisualStyleBackColor = true;
            this.btn_Quitar.Click += new System.EventHandler(this.btn_Quitar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Productos:";
            // 
            // lsv_Productos
            // 
            this.lsv_Productos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsv_Productos.HideSelection = false;
            this.lsv_Productos.Location = new System.Drawing.Point(10, 104);
            this.lsv_Productos.Name = "lsv_Productos";
            this.lsv_Productos.Size = new System.Drawing.Size(228, 193);
            this.lsv_Productos.TabIndex = 8;
            this.lsv_Productos.UseCompatibleStateImageBehavior = false;
            this.lsv_Productos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Telefono";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 100;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(261, 274);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 309);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lsv_Productos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Quitar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.mtb_Telefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de clientes";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtb_Telefono;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Quitar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lsv_Productos;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}