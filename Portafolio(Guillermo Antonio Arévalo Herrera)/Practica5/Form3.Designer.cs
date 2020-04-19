namespace Practica5
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
            this.lst_Sucursales = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_Ventas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_VentasTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sucursales:";
            // 
            // lst_Sucursales
            // 
            this.lst_Sucursales.FormattingEnabled = true;
            this.lst_Sucursales.Location = new System.Drawing.Point(16, 39);
            this.lst_Sucursales.Name = "lst_Sucursales";
            this.lst_Sucursales.Size = new System.Drawing.Size(232, 199);
            this.lst_Sucursales.TabIndex = 1;
            this.lst_Sucursales.SelectedIndexChanged += new System.EventHandler(this.lst_Sucursales_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ventas:";
            // 
            // lst_Ventas
            // 
            this.lst_Ventas.FormattingEnabled = true;
            this.lst_Ventas.Location = new System.Drawing.Point(312, 39);
            this.lst_Ventas.Name = "lst_Ventas";
            this.lst_Ventas.Size = new System.Drawing.Size(232, 199);
            this.lst_Ventas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total de ventas:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_VentasTotal
            // 
            this.lbl_VentasTotal.AutoSize = true;
            this.lbl_VentasTotal.Location = new System.Drawing.Point(399, 252);
            this.lbl_VentasTotal.Name = "lbl_VentasTotal";
            this.lbl_VentasTotal.Size = new System.Drawing.Size(0, 13);
            this.lbl_VentasTotal.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 338);
            this.Controls.Add(this.lbl_VentasTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_Ventas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_Sucursales);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Ventas de sucursales";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_Sucursales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_Ventas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_VentasTotal;
    }
}