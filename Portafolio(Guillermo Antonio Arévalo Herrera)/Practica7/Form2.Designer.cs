namespace Practica7
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
            this.components = new System.ComponentModel.Container();
            this.mtx_Codigo = new System.Windows.Forms.MaskedTextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dgv_Mascotas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.rdo_Macho = new System.Windows.Forms.RadioButton();
            this.rdo_Hembra = new System.Windows.Forms.RadioButton();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.cbo_Especie = new System.Windows.Forms.ComboBox();
            this.cbo_Propietario = new System.Windows.Forms.ComboBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtx_Codigo
            // 
            this.mtx_Codigo.Location = new System.Drawing.Point(122, 7);
            this.mtx_Codigo.Mask = ">LL0000";
            this.mtx_Codigo.Name = "mtx_Codigo";
            this.mtx_Codigo.Size = new System.Drawing.Size(47, 20);
            this.mtx_Codigo.TabIndex = 35;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(540, 469);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 51;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // dgv_Mascotas
            // 
            this.dgv_Mascotas.AllowUserToAddRows = false;
            this.dgv_Mascotas.AllowUserToDeleteRows = false;
            this.dgv_Mascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_Mascotas.Location = new System.Drawing.Point(12, 271);
            this.dgv_Mascotas.Name = "dgv_Mascotas";
            this.dgv_Mascotas.ReadOnly = true;
            this.dgv_Mascotas.RowHeadersVisible = false;
            this.dgv_Mascotas.Size = new System.Drawing.Size(603, 183);
            this.dgv_Mascotas.TabIndex = 52;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Propietario";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Especie";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 83;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha Nacimiento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Peso";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 45;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Sexo";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 60;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(489, 238);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(126, 23);
            this.btn_Guardar.TabIndex = 50;
            this.btn_Guardar.Text = "Guardar Mascota";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // rdo_Macho
            // 
            this.rdo_Macho.AutoSize = true;
            this.rdo_Macho.Location = new System.Drawing.Point(197, 248);
            this.rdo_Macho.Name = "rdo_Macho";
            this.rdo_Macho.Size = new System.Drawing.Size(58, 17);
            this.rdo_Macho.TabIndex = 49;
            this.rdo_Macho.TabStop = true;
            this.rdo_Macho.Text = "Macho";
            this.rdo_Macho.UseVisualStyleBackColor = true;
            // 
            // rdo_Hembra
            // 
            this.rdo_Hembra.AutoSize = true;
            this.rdo_Hembra.Checked = true;
            this.rdo_Hembra.Location = new System.Drawing.Point(129, 248);
            this.rdo_Hembra.Name = "rdo_Hembra";
            this.rdo_Hembra.Size = new System.Drawing.Size(62, 17);
            this.rdo_Hembra.TabIndex = 47;
            this.rdo_Hembra.TabStop = true;
            this.rdo_Hembra.Text = "Hembra";
            this.rdo_Hembra.UseVisualStyleBackColor = true;
            // 
            // txt_Peso
            // 
            this.txt_Peso.Location = new System.Drawing.Point(122, 205);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.ShortcutsEnabled = false;
            this.txt_Peso.Size = new System.Drawing.Size(100, 20);
            this.txt_Peso.TabIndex = 45;
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha.Location = new System.Drawing.Point(122, 167);
            this.dtp_Fecha.MaxDate = new System.DateTime(2020, 4, 3, 0, 0, 0, 0);
            this.dtp_Fecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(111, 20);
            this.dtp_Fecha.TabIndex = 43;
            this.dtp_Fecha.Value = new System.DateTime(2020, 4, 3, 0, 0, 0, 0);
            // 
            // cbo_Especie
            // 
            this.cbo_Especie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Especie.FormattingEnabled = true;
            this.cbo_Especie.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Perico",
            "Tortuga",
            "Conejo",
            "Hámster"});
            this.cbo_Especie.Location = new System.Drawing.Point(122, 125);
            this.cbo_Especie.Name = "cbo_Especie";
            this.cbo_Especie.Size = new System.Drawing.Size(121, 21);
            this.cbo_Especie.TabIndex = 42;
            // 
            // cbo_Propietario
            // 
            this.cbo_Propietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Propietario.FormattingEnabled = true;
            this.cbo_Propietario.Location = new System.Drawing.Point(122, 86);
            this.cbo_Propietario.Name = "cbo_Propietario";
            this.cbo_Propietario.Size = new System.Drawing.Size(251, 21);
            this.cbo_Propietario.TabIndex = 39;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(122, 45);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.ShortcutsEnabled = false;
            this.txt_Nombre.Size = new System.Drawing.Size(251, 20);
            this.txt_Nombre.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Peso ( libras)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Fecha nac";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Especie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Propietario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Código mascota";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 499);
            this.Controls.Add(this.mtx_Codigo);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.dgv_Mascotas);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.rdo_Macho);
            this.Controls.Add(this.rdo_Hembra);
            this.Controls.Add(this.txt_Peso);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.cbo_Especie);
            this.Controls.Add(this.cbo_Propietario);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtx_Codigo;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dgv_Mascotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.RadioButton rdo_Macho;
        private System.Windows.Forms.RadioButton rdo_Hembra;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.ComboBox cbo_Especie;
        private System.Windows.Forms.ComboBox cbo_Propietario;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}