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
    public partial class Form3 : Form
    {
        string[][] Ventas = new string[5][];
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Ventas[0] = new string[3] {"10","20","5"};
            Ventas[1] = new string[2] {"20","15"};
            Ventas[2] = new string[1] {"5"};
            Ventas[3] = new string[2] {"25","10"};
            Ventas[4] = new string[1] {"15"};
            lst_Sucursales.Items.Clear();
            for (int i = 0; i < Ventas.GetLength(0); i++)
            {
                lst_Sucursales.Items.Add("Sucursal °" + (i + 1));
            }
        }

        private void lst_Sucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Total = 0;
            if (lst_Sucursales.SelectedIndex >= 0)
            {
                lst_Ventas.Items.Clear();
                foreach (string venta in Ventas[lst_Sucursales.SelectedIndex])
                {
                    lst_Ventas.Items.Add(venta);
                    Total += Convert.ToInt32(venta);
                }
            }

            lbl_VentasTotal.Text = string.Format("{0}{1}", "$", Total);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
