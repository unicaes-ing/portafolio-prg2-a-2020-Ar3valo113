namespace Practica5
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
            this.label1 = new System.Windows.Forms.Label();
            this.lst_vendedores = new System.Windows.Forms.ListBox();
            this.btn_AZ = new System.Windows.Forms.Button();
            this.btn_ZA = new System.Windows.Forms.Button();
            this.btn_Quitar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendedores";
            // 
            // lst_vendedores
            // 
            this.lst_vendedores.FormattingEnabled = true;
            this.lst_vendedores.Location = new System.Drawing.Point(12, 39);
            this.lst_vendedores.Name = "lst_vendedores";
            this.lst_vendedores.Size = new System.Drawing.Size(232, 277);
            this.lst_vendedores.TabIndex = 1;
            // 
            // btn_AZ
            // 
            this.btn_AZ.Location = new System.Drawing.Point(262, 39);
            this.btn_AZ.Name = "btn_AZ";
            this.btn_AZ.Size = new System.Drawing.Size(99, 23);
            this.btn_AZ.TabIndex = 2;
            this.btn_AZ.Text = "Ordenar A - Z";
            this.btn_AZ.UseVisualStyleBackColor = true;
            this.btn_AZ.Click += new System.EventHandler(this.btn_AZ_Click);
            // 
            // btn_ZA
            // 
            this.btn_ZA.Location = new System.Drawing.Point(262, 85);
            this.btn_ZA.Name = "btn_ZA";
            this.btn_ZA.Size = new System.Drawing.Size(99, 23);
            this.btn_ZA.TabIndex = 3;
            this.btn_ZA.Text = "Ordenar Z - A";
            this.btn_ZA.UseVisualStyleBackColor = true;
            this.btn_ZA.Click += new System.EventHandler(this.btn_ZA_Click);
            // 
            // btn_Quitar
            // 
            this.btn_Quitar.Location = new System.Drawing.Point(262, 131);
            this.btn_Quitar.Name = "btn_Quitar";
            this.btn_Quitar.Size = new System.Drawing.Size(99, 23);
            this.btn_Quitar.TabIndex = 4;
            this.btn_Quitar.Text = "Quitar";
            this.btn_Quitar.UseVisualStyleBackColor = true;
            this.btn_Quitar.Click += new System.EventHandler(this.btn_Quitar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(262, 253);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(275, 20);
            this.txt_Nombre.TabIndex = 5;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(262, 293);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(99, 23);
            this.btn_Buscar.TabIndex = 6;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(471, 293);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(68, 23);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 333);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Quitar);
            this.Controls.Add(this.btn_ZA);
            this.Controls.Add(this.btn_AZ);
            this.Controls.Add(this.lst_vendedores);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de nombres";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_vendedores;
        private System.Windows.Forms.Button btn_AZ;
        private System.Windows.Forms.Button btn_ZA;
        private System.Windows.Forms.Button btn_Quitar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Salir;
    }
}

