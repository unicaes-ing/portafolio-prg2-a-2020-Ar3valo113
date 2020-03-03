using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static double Suma(Double N1, Double N2, Double N3, Double N4)
        {
            Double Total;
            Total = (N1 + N2 + N3 + N4);
            return Total;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Double Numero1 = Convert.ToDouble(textBox1.Text);
            Double Numero2 = Convert.ToDouble(textBox2.Text);
            Double Numero3 = Convert.ToDouble(textBox3.Text);
            Double Numero4 = Convert.ToDouble(textBox4.Text);
            Double Stotal = Suma(Numero1, Numero2, Numero3, Numero4);
            label6.Text = Convert.ToString(Stotal);

            if (Numero1 <= 0 & Numero2 <= 0 & Numero3 <= 0 & Numero4 <= 0)
            {
                label6.Text = "";
                MessageBox.Show("Digite los numeros para realizar la suma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Inicio = new Inicio();
            Inicio.Show();
        }
    }
}
