using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Form2 : Form
    {
        int[,] MatrizA = new int[5, 5];
        int[,] MatrizB = new int[5, 5];

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Random num = new Random();
            for (int f = 0; f < MatrizA.GetLength(0); f++)
            {
                dataGridView1.Rows.Add();
                for (int c = 0; c < MatrizB.GetLength(1); c++)
                {
                    MatrizA[f, c] = num.Next(10, 91);
                    dataGridView1.Rows[f].Cells[c].Value = MatrizA[f, c];
                }
            }

            dataGridView2.ColumnCount = 5;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int f = 0; f < MatrizA.GetLength(0); f++)
            {
                dataGridView2.Rows.Add();
                for (int c = 0; c < MatrizB.GetLength(1); c++)
                {
                    MatrizA[f, c] = num.Next(10, 91);
                    dataGridView2.Rows[f].Cells[c].Value = MatrizA[f, c];
                }
            }
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();

            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();

            int[,] Resultado = new int[5, 5];
            if (radioButton1.Checked)
            {
                dataGridView3.ColumnCount = 5;
                dataGridView3.AllowUserToAddRows = false;
                dataGridView3.ColumnHeadersVisible = false;
                dataGridView3.RowHeadersVisible = false;
                dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                for (int f = 0; f < MatrizA.GetLength(0); f++)
                {
                    dataGridView3.Rows.Add();
                    for (int c = 0; c < MatrizB.GetLength(1); c++)
                    {
                        Resultado[f, c] = MatrizB[f,c] + MatrizA[f,c];
                        dataGridView3.Rows[f].Cells[c].Value = Resultado[f, c];
                    }
                }
                dataGridView3.ClearSelection();
            }
            else if (radioButton2.Checked)
            {
                dataGridView3.ColumnCount = 5;
                dataGridView3.AllowUserToAddRows = false;
                dataGridView3.ColumnHeadersVisible = false;
                dataGridView3.RowHeadersVisible = false;
                dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                for (int f = 0; f < MatrizA.GetLength(0); f++)
                {
                    dataGridView3.Rows.Add();
                    for (int c = 0; c < MatrizB.GetLength(1); c++)
                    {
                        Resultado[f, c] = MatrizB[f, c] * MatrizA[f, c];
                        dataGridView3.Rows[f].Cells[c].Value = Resultado[f, c];
                    }
                }
                dataGridView3.ClearSelection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
