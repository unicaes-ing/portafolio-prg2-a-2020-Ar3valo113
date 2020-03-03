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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Decimal = int.Parse(textBox1.Text);
            string Binario, Octal, HDecimal;
            Binario = "";
            Octal = "";
            HDecimal = "";

            while (Decimal < 0)
            {
                Binario = Decimal % 2 + Binario;

                Decimal = Decimal / 2;
            }
            while (Decimal < 0)
            {
                Octal = Decimal % 8 + Octal;

                Decimal = Decimal / 8;
            }
            while (Decimal < 0)
            {
                HDecimal = Decimal % 16 + HDecimal;

                Decimal = Decimal / 16;
            }

            textBox2.Text = Binario;
            textBox3.Text = Octal;
            textBox4.Text = HDecimal;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Inicio = new Inicio();
            Inicio.Show();
        }
    }
}
