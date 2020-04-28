namespace Practica6
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NIT = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Sueldo = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.dgv_Lista = new System.Windows.Forms.DataGridView();
            this.NIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_BuscarNIT = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Quitar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lblTplanilla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sueldo:";
            // 
            // txt_NIT
            // 
            this.txt_NIT.Location = new System.Drawing.Point(66, 10);
            this.txt_NIT.Name = "txt_NIT";
            this.txt_NIT.Size = new System.Drawing.Size(430, 20);
            this.txt_NIT.TabIndex = 3;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(66, 36);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(177, 20);
            this.txt_Nombre.TabIndex = 4;
            // 
            // txt_Sueldo
            // 
            this.txt_Sueldo.Location = new System.Drawing.Point(66, 62);
            this.txt_Sueldo.Name = "txt_Sueldo";
            this.txt_Sueldo.Size = new System.Drawing.Size(177, 20);
            this.txt_Sueldo.TabIndex = 5;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(249, 60);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 6;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // dgv_Lista
            // 
            this.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NIT,
            this.Nombre,
            this.Sueldo});
            this.dgv_Lista.Location = new System.Drawing.Point(20, 89);
            this.dgv_Lista.Name = "dgv_Lista";
            this.dgv_Lista.Size = new System.Drawing.Size(476, 150);
            this.dgv_Lista.TabIndex = 7;
            // 
            // NIT
            // 
            this.NIT.HeaderText = "NIT";
            this.NIT.Name = "NIT";
            this.NIT.Width = 180;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "NIT:";
            // 
            // txt_BuscarNIT
            // 
            this.txt_BuscarNIT.Location = new System.Drawing.Point(66, 255);
            this.txt_BuscarNIT.Name = "txt_BuscarNIT";
            this.txt_BuscarNIT.Size = new System.Drawing.Size(210, 20);
            this.txt_BuscarNIT.TabIndex = 9;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(66, 281);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 10;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Quitar
            // 
            this.btn_Quitar.Location = new System.Drawing.Point(147, 281);
            this.btn_Quitar.Name = "btn_Quitar";
            this.btn_Quitar.Size = new System.Drawing.Size(75, 23);
            this.btn_Quitar.TabIndex = 11;
            this.btn_Quitar.Text = "Quitar";
            this.btn_Quitar.UseVisualStyleBackColor = true;
            this.btn_Quitar.Click += new System.EventHandler(this.btn_Quitar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Planilla:";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(474, 281);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 13;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // lblTplanilla
            // 
            this.lblTplanilla.AutoSize = true;
            this.lblTplanilla.Location = new System.Drawing.Point(440, 258);
            this.lblTplanilla.Name = "lblTplanilla";
            this.lblTplanilla.Size = new System.Drawing.Size(0, 13);
            this.lblTplanilla.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 313);
            this.Controls.Add(this.lblTplanilla);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Quitar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_BuscarNIT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_Lista);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_Sueldo);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_NIT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de empleados";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NIT;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Sueldo;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.DataGridView dgv_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_BuscarNIT;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Quitar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lblTplanilla;
    }
}