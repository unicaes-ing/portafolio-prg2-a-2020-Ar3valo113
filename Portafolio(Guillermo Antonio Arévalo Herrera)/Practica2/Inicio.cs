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
            Form NumRomanos = new Form1();
            NumRomanos.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form CdP = new Form2();
            CdP.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form CdU = new Form3();
            CdU.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form RegistroUsuario = new Form4();
            RegistroUsuario.Show();
            this.Hide();
        }
    }
}
