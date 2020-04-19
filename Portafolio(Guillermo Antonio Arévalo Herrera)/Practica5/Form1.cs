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

    public partial class Form1 : Form
    {
        string[] Vendedores = new string[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Vendedores[0] = "Jose Humberto";
            Vendedores[1] = "Oscar Muñoz";
            Vendedores[2] = "David Jimenez";
            Vendedores[3] = "Fares Galan";
            Vendedores[4] = "Rodrigo Ernesto";
            Vendedores[5] = "Marin Larios";
            Vendedores[6] = "Jaime Bolaños";
            Vendedores[7] = "Felipe Bolaños";
            Vendedores[8] = "Jose Antonio";
            Vendedores[9] = "Juan Arévalo";
            foreach (string vendedor in Vendedores)
            {
                lst_vendedores.Items.Add(vendedor);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AZ_Click(object sender, EventArgs e)
        {
            if (lst_vendedores.Items.Count > 1)
            {
                lst_vendedores.Items.Clear();
                Array.Sort(Vendedores);
                foreach (string vendedor in Vendedores)
                {
                    lst_vendedores.Items.Add(vendedor);
                }
            }
        }

        private void btn_ZA_Click(object sender, EventArgs e)
        {
            if (lst_vendedores.Items.Count > 1)
            {
                lst_vendedores.Items.Clear();
                Array.Sort(Vendedores);
                Array.Reverse(Vendedores);
                foreach (string vendedor in Vendedores)
                {
                    lst_vendedores.Items.Add(vendedor);
                }
            }
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            lst_vendedores.Items.Remove(lst_vendedores.Items[lst_vendedores.SelectedIndex]);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            int buscar = Array.IndexOf(Vendedores, txt_Nombre.Text); 
            if (buscar >= 0) 
            { 
                lst_vendedores.SelectedIndex = buscar; 
            
            } 
            else 
            { 
                MessageBox.Show("El nombre que desea buscar no se encuentra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
