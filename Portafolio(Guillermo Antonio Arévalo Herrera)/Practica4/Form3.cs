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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static int Fibonacci (int numero)
        {
            int resultado;

            if (numero == 0)
            {
                return 0;
            }
            else if (numero == 1)
            {
                return 1;
            }
            else
            {
                resultado = Fibonacci(numero - 1) + Fibonacci(numero - 2);
                return resultado;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Fibonacci(Convert.ToInt32(textBox1.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Inicio = new Inicio();
            Inicio.Show();
        }
    }
}
