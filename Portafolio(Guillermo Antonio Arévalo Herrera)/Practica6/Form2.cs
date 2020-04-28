using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica6
{
    public partial class Form2 : Form
    {
        Dictionary<int, string> Clientes = new Dictionary<int, string>();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {  
            Clientes.Add(7192_5409, "Guillermo Antonio");
            Clientes.Add(5408_9232, "Juan Antonio");

            foreach (KeyValuePair<int,string> Cliente in Clientes)
            {
                ListViewItem lista = lsv_Productos.Items.Add(Cliente.Key.ToString());
                lista.SubItems.Add(Cliente.Value);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if(mtb_Telefono.Text != string.Empty && txt_Nombre.Text != string.Empty)
            {
                Clientes.Add(Convert.ToInt32(mtb_Telefono.Text), txt_Nombre.Text);
                ListViewItem lista = lsv_Productos.Items.Add(mtb_Telefono.Text);
                lista.SubItems.Add(txt_Nombre.Text);
            }
            else
            {
                MessageBox.Show("Ingrese todos datos para agregar a un cliente.", "ERROR" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if(mtb_Telefono.Text.Length > 0)
            {
                if(!Clientes.ContainsKey(Convert.ToInt32(mtb_Telefono.Text)))
                {
                    MessageBox.Show("Ese producto no existe en el diccionario.");
                    mtb_Telefono.Clear();
                    mtb_Telefono.Focus();
                }
                else
                {
                    txt_Nombre.Text = Clientes[Convert.ToInt32(mtb_Telefono.Text)];
                    mtb_Telefono.Focus();
                }
            }
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in lsv_Productos.SelectedItems)
            {
                lista.Remove();
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
