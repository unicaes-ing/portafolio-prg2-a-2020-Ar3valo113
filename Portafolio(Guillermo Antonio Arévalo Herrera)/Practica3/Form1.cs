using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0, R = 0;
            num = Int16.Parse(textBox1.Text);
            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                R = (num * i);
                listBox1.Items.Add(num + " * " + i + " = " + R);
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
