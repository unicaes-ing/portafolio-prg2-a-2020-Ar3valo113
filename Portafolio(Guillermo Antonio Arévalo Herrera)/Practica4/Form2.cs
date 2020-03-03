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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(textBox1.Text);
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int BuscarNum(int numeroBuscar, ListBox lista)
        {
            int cont = 0;
            foreach (int numero in lista.Items)
            {
                if (numero == numeroBuscar) cont++;
            }
            return cont;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int buscar = Convert.ToInt32(textBox2.Text);
                int c = BuscarNum(buscar, listBox1);
                MessageBox.Show("Se encuentra " + c + " veces");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese el numero que desea encontrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Inicio = new Inicio();
            Inicio.Show();
        }
    }
}
