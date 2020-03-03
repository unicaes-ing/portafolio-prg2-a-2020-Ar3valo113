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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random r = new Random();
            const int Cantidad = 15;
            int numR = 0, conteo = 0;

            while (conteo < Cantidad)
            {
                numR = r.Next(1, 7);
                listBox1.Items.Add(numR);
                conteo++;
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
