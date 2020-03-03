using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            comboBox1.Items.Add("EL DIARIO DE ANA FRANK");
            comboBox1.Items.Add("CURVA DEL APRENDIZAJE: UN ENFOQUE NEURO");
            comboBox1.Items.Add("DON QUIJOTE DE LA MANCHA");
            comboBox1.Items.Add("LA DIVINA COMEDIA");
            comboBox1.Items.Add("EL EXTRANJERO");
            textBox2.Text = "$ ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Total, TPagar, Impuesto, STotal;
            int cantidad;

            cantidad = Convert.ToInt32(textBox1.Text);

            if (comboBox1.Text == "EL DIARIO DE ANA FRANK")
            {
                Total = (cantidad * 18.50);
                Impuesto = (Total * 0.13);
                STotal = (Total - Impuesto);
                TPagar = (Impuesto + STotal);
                textBox4.Text = STotal.ToString();
                textBox4.Text = "$" + STotal;
                textBox5.Text = Impuesto.ToString();
                textBox5.Text = "$" + Impuesto;
                textBox6.Text = Total.ToString();
                textBox6.Text = "$" + TPagar;
            }
            else if (comboBox1.Text == "CURVA DEL APRENDIZAJE: UN ENFOQUE NEURO")
            {
                Total = (cantidad * 15.00);
                Impuesto = (Total * 0.13);
                STotal = (Total - Impuesto);
                TPagar = (Impuesto + STotal);
                textBox4.Text = STotal.ToString();
                textBox4.Text = "$" + STotal;
                textBox5.Text = Impuesto.ToString();
                textBox5.Text = "$" + Impuesto;
                textBox6.Text = Total.ToString();
                textBox6.Text = "$" + TPagar;
            }
            else if (comboBox1.Text == "DON QUIJOTE DE LA MANCHA")
            {
                Total = (cantidad * 23.00);
                Impuesto = (Total * 0.13);
                STotal = (Total - Impuesto);
                TPagar = (Impuesto + STotal);
                textBox4.Text = STotal.ToString();
                textBox4.Text = "$" + STotal;
                textBox5.Text = Impuesto.ToString();
                textBox5.Text = "$" + Impuesto;
                textBox6.Text = Total.ToString();
                textBox6.Text = "$" + TPagar;
            }
            else if (comboBox1.Text == "LA DIVINA COMEDIA")
            {
                Total = (cantidad * 10.00);
                Impuesto = (Total * 0.13);
                STotal = (Total - Impuesto);
                TPagar = (Impuesto + STotal);
                textBox4.Text = STotal.ToString();
                textBox4.Text = "$" + STotal;
                textBox5.Text = Impuesto.ToString();
                textBox5.Text = "$" + Impuesto;
                textBox6.Text = Total.ToString();
                textBox6.Text = "$" + TPagar;
            }
            else if (comboBox1.Text == "EL EXTRANJERO")
            {
                Total = (cantidad * 12.50);
                Impuesto = (Total * 0.13);
                STotal = (Total - Impuesto);
                TPagar = (Impuesto + STotal);
                textBox4.Text = STotal.ToString();
                textBox4.Text = "$" + STotal;
                textBox5.Text = Impuesto.ToString();
                textBox5.Text = "$" + Impuesto;
                textBox6.Text = Total.ToString();
                textBox6.Text = "$" + TPagar;
            }
            else if (comboBox1.Text == "-")
            {
                MessageBox.Show("Seleccione el libro que desea adquirir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Seleccione el libro que desea adquirir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Inicio = new Inicio();
            Inicio.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "EL DIARIO DE ANA FRANK")
            {
               string precio = "$" + 18.50;
                textBox2.Text = precio;
            }
            else if (comboBox1.Text == "CURVA DEL APRENDIZAJE: UN ENFOQUE NEURO")
            {
                string precio = "$" + 15.00;
                textBox2.Text = precio;
            }
            else if (comboBox1.Text == "DON QUIJOTE DE LA MANCHA")
            {
                string precio = "$" + 23.00;
                textBox2.Text = precio;
            }
            else if (comboBox1.Text == "LA DIVINA COMEDIA")
            {
                string precio = "$" + 10.00;
                textBox2.Text = precio;
            }
            else if (comboBox1.Text == "EL EXTRANJERO")
            {
                string precio = "$" + 12.50;
                textBox2.Text = precio;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Focus();
            comboBox1.Text = "-";
        }
    }
}
