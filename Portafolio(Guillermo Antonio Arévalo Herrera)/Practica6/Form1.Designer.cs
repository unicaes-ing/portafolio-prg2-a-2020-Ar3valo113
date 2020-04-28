namespace Practica6
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
            this.txt_Empleado = new System.Windows.Forms.TextBox();
            this.lst_Empleados = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_Limpiar = new System.Windows.Forms.RadioButton();
            this.rdo_Ordenar = new System.Windows.Forms.RadioButton();
            this.rdo_Quitar = new System.Windows.Forms.RadioButton();
            this.rdo_Insertar = new System.Windows.Forms.RadioButton();
            this.rdo_Buscar = new System.Windows.Forms.RadioButton();
            this.rdo_Agregar = new System.Windows.Forms.RadioButton();
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado:";
            // 
            // txt_Empleado
            // 
            this.txt_Empleado.Location = new System.Drawing.Point(16, 29);
            this.txt_Empleado.Name = "txt_Empleado";
            this.txt_Empleado.Size = new System.Drawing.Size(135, 20);
            this.txt_Empleado.TabIndex = 1;
            // 
            // lst_Empleados
            // 
            this.lst_Empleados.FormattingEnabled = true;
            this.lst_Empleados.Location = new System.Drawing.Point(16, 78);
            this.lst_Empleados.Name = "lst_Empleados";
            this.lst_Empleados.Size = new System.Drawing.Size(135, 251);
            this.lst_Empleados.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_Limpiar);
            this.groupBox1.Controls.Add(this.rdo_Ordenar);
            this.groupBox1.Controls.Add(this.rdo_Quitar);
            this.groupBox1.Controls.Add(this.rdo_Insertar);
            this.groupBox1.Controls.Add(this.rdo_Buscar);
            this.groupBox1.Controls.Add(this.rdo_Agregar);
            this.groupBox1.Location = new System.Drawing.Point(178, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // rdo_Limpiar
            // 
            this.rdo_Limpiar.AutoSize = true;
            this.rdo_Limpiar.Location = new System.Drawing.Point(6, 134);
            this.rdo_Limpiar.Name = "rdo_Limpiar";
            this.rdo_Limpiar.Size = new System.Drawing.Size(58, 17);
            this.rdo_Limpiar.TabIndex = 5;
            this.rdo_Limpiar.TabStop = true;
            this.rdo_Limpiar.Text = "Limpiar";
            this.rdo_Limpiar.UseVisualStyleBackColor = true;
            // 
            // rdo_Ordenar
            // 
            this.rdo_Ordenar.AutoSize = true;
            this.rdo_Ordenar.Location = new System.Drawing.Point(6, 111);
            this.rdo_Ordenar.Name = "rdo_Ordenar";
            this.rdo_Ordenar.Size = new System.Drawing.Size(63, 17);
            this.rdo_Ordenar.TabIndex = 4;
            this.rdo_Ordenar.TabStop = true;
            this.rdo_Ordenar.Text = "Ordenar";
            this.rdo_Ordenar.UseVisualStyleBackColor = true;
            // 
            // rdo_Quitar
            // 
            this.rdo_Quitar.AutoSize = true;
            this.rdo_Quitar.Location = new System.Drawing.Point(6, 88);
            this.rdo_Quitar.Name = "rdo_Quitar";
            this.rdo_Quitar.Size = new System.Drawing.Size(53, 17);
            this.rdo_Quitar.TabIndex = 3;
            this.rdo_Quitar.TabStop = true;
            this.rdo_Quitar.Text = "Quitar";
            this.rdo_Quitar.UseVisualStyleBackColor = true;
            // 
            // rdo_Insertar
            // 
            this.rdo_Insertar.AutoSize = true;
            this.rdo_Insertar.Location = new System.Drawing.Point(6, 65);
            this.rdo_Insertar.Name = "rdo_Insertar";
            this.rdo_Insertar.Size = new System.Drawing.Size(60, 17);
            this.rdo_Insertar.TabIndex = 2;
            this.rdo_Insertar.TabStop = true;
            this.rdo_Insertar.Text = "Insertar";
            this.rdo_Insertar.UseVisualStyleBackColor = true;
            // 
            // rdo_Buscar
            // 
            this.rdo_Buscar.AutoSize = true;
            this.rdo_Buscar.Location = new System.Drawing.Point(6, 42);
            this.rdo_Buscar.Name = "rdo_Buscar";
            this.rdo_Buscar.Size = new System.Drawing.Size(58, 17);
            this.rdo_Buscar.TabIndex = 1;
            this.rdo_Buscar.TabStop = true;
            this.rdo_Buscar.Text = "Buscar";
            this.rdo_Buscar.UseVisualStyleBackColor = true;
            // 
            // rdo_Agregar
            // 
            this.rdo_Agregar.AutoSize = true;
            this.rdo_Agregar.Location = new System.Drawing.Point(6, 19);
            this.rdo_Agregar.Name = "rdo_Agregar";
            this.rdo_Agregar.Size = new System.Drawing.Size(62, 17);
            this.rdo_Agregar.TabIndex = 0;
            this.rdo_Agregar.TabStop = true;
            this.rdo_Agregar.Text = "Agregar";
            this.rdo_Agregar.UseVisualStyleBackColor = true;
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.Location = new System.Drawing.Point(178, 196);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(82, 23);
            this.btn_Ejecutar.TabIndex = 4;
            this.btn_Ejecutar.Text = "Ejecutar";
            this.btn_Ejecutar.UseVisualStyleBackColor = true;
            this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(178, 304);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(82, 23);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 339);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Ejecutar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lst_Empleados);
            this.Controls.Add(this.txt_Empleado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombre de empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Empleado;
        private System.Windows.Forms.ListBox lst_Empleados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_Limpiar;
        private System.Windows.Forms.RadioButton rdo_Ordenar;
        private System.Windows.Forms.RadioButton rdo_Quitar;
        private System.Windows.Forms.RadioButton rdo_Insertar;
        private System.Windows.Forms.RadioButton rdo_Buscar;
        private System.Windows.Forms.RadioButton rdo_Agregar;
        private System.Windows.Forms.Button btn_Ejecutar;
        private System.Windows.Forms.Button btn_Salir;
    }
}

