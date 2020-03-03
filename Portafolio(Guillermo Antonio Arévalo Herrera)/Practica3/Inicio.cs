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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form TabladeM = new Form1();
            TabladeM.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ABC = new Form2();
            ABC.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Dado = new Form3();
            Dado.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form BuscarN = new Form4();
            BuscarN.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form Pagos = new Form5();
            Pagos.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
