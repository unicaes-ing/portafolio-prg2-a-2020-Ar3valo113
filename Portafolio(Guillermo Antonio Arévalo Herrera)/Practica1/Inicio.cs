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
            Form Promedio = new Form1();
            Promedio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Sistemas = new Form2();
            Sistemas.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Libros = new Form4();
            Libros.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Inversiones = new Form3();
            Inversiones.Show();
            this.Hide();
        }
    }
}
