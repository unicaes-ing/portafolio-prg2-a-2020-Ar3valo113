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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string De, A;

            De = listBox1.SelectedItem.ToString();
            A = listBox2.SelectedItem.ToString();

            if (textBox1.Text == "")
            {
                MessageBox.Show("Digite un valor para convertir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
            }
            else if (De == A)
            {
                MessageBox.Show("Eliga otra unidad de longitud diferente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (De == "Pulgadas" && A == "Pies")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 12 + " Pies");
            }
            else if (De == "Pulgadas" && A == "Yardas")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 36 + " Yardas");
            }
            else if (De == "Pies" && A == "Pulgadas")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 0.0833333 + " Pulgadas");
            }
            else if (De == "Pies" && A == "Yardas")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 3 + " Yardas");
            }
            else if (De == "Yardas" && A == "Pulgadas")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 0.0277778 + " Pulgadas");
            }
            else if (De == "Yardas" && A == "Pies")
            {
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 0.333333 + " Pies");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox1.ClearSelected();
            listBox2.ClearSelected();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Inicio = new Inicio();
            Inicio.Show();
        }
    }
}
