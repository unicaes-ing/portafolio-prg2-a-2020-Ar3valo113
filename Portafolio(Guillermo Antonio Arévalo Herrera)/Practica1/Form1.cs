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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Ex1, Ex2, Ex3, Prom;

            Ex1 = double.Parse(textBox1.Text);
            Ex2 = double.Parse(textBox2.Text);
            Ex3 = double.Parse(textBox3.Text);

            Prom = (Ex1 * 0.25) + (Ex2 * 0.25) + (Ex3 * 0.50);
            textBox4.Text = Prom.ToString();
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
