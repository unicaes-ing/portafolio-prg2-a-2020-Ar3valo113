using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Digite la cantidad que desea del producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Digite el precio del producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }

            Double Cantidad = 0, Precio = 0, Total = 0, Descuento = 0;
            Cantidad = Int16.Parse(textBox1.Text);
            Precio = Double.Parse(textBox2.Text);

            textBox3.Text = Total.ToString();

            //Radiobuttons seleccionados
            #region
            if (radioButton1.Checked == true)
            {
                Descuento = 0;
                textBox4.Text = "0%";
            }
            else if (radioButton2.Checked == true)
            {
                Descuento = 0.05;
                textBox4.Text = "5%";
            }
            else if (radioButton3.Checked == true)
            {
                Descuento = 0.10;
                textBox4.Text = "10%";
            }
            else if (radioButton4.Checked == true)
            {
                Descuento = 0.15;
                textBox4.Text = "15%";
            }
            else if (radioButton5.Checked == true)
            {
                Descuento = 0.20;
                textBox4.Text = "20%";
            }
            #endregion
            Total = (Cantidad * Precio);
            Total = (Cantidad * Precio) - (Cantidad * Precio * Descuento);
            textBox3.Text = Total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Inicio = new Inicio();
            Inicio.Show();
        }
    }
}
