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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            num = Int16.Parse(textBox1.Text);

            if (num == 0)
            {
                label2.Text = "El numero romano de " + num + " no posee numero romano";
            }
            else if (num == 1)
            {
                label2.Text = "El numero romano de " + num + " es I";
            }
            else if (num == 2)
            {
                label2.Text = "El numero romano de " + num + " es II";
            }
            else if (num == 3)
            {
                label2.Text = "El numero romano de " + num + " es III";
            }
            else if (num == 4)
            {
                label2.Text = "El numero romano de " + num + " es IV";
            }
            else if (num == 5)
            {
                label2.Text = "El numero romano de " + num + " es V";
            }
            else if (num == 6)
            {
                label2.Text = "El numero romano de " + num + " es VI";
            }
            else if (num == 7)
            {
                label2.Text = "El numero romano de " + num + " es VII";
            }
            else if (num == 8)
            {
                label2.Text = "El numero romano de " + num + " es VIII";
            }
            else if (num == 9)
            {
                label2.Text = "El numero romano de " + num + " es IX";
            }
            else if (num == 10)
            {
                label2.Text = "El numero romano de " + num + " es X";
            }
            else if (num > 10)
            {
                label2.Text = "Digite numeros del 1 al 10";
            }
            else if (num < 0)
            {
                label2.Text = "Digite numeros del 1 al 10";
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
