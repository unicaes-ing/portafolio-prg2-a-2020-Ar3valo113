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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Sumadenumeros = new Form1();
            Sumadenumeros.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Buscarnumeros = new Form2();
            Buscarnumeros.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Fibonacci = new Form3();
            Fibonacci.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form NumeroMayores = new Form4();
            NumeroMayores.Show();
            this.Hide();
        }
    }
}
