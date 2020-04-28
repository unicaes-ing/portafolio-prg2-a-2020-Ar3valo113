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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public struct Lista
        {
            public string NIT;
            public string Nombre;
            private double Sueldo;

            public void SetSueldo(double sueldo)
            {
                if (sueldo >= 0)
                {
                    this.Sueldo = sueldo;
                }
            }
            public double GetSueldo()
            {
                return Sueldo;
            }
        }

        //Diccionario
        Dictionary<string, string> NitEmpleado = new Dictionary<string, string>();

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Datos = new DataGridViewRow();
            Datos.CreateCells(dgv_Lista);
            if (txt_NIT.Text.Length > 3)
            {
                if(txt_Nombre.Text.Length > 0)
                {
                    if(txt_Sueldo.Text.Length > 0)
                    {
                        Datos.Cells[0].Value = txt_NIT.Text;
                        Datos.Cells[1].Value =txt_Nombre.Text;
                        Datos.Cells[2].Value = " $ " + txt_Sueldo.Text;
                        dgv_Lista.Rows.Add(Datos);
                        NitEmpleado.Add(txt_NIT.Text, txt_Nombre.Text);
                        txt_NIT.Clear();
                        txt_Nombre.Clear();
                        txt_Sueldo.Clear();
                        txt_NIT.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la cantidad de sueldo para agregarlo a la lista.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el nombre del empleado para agregarlo a la lista.");
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingrese el NIT correspondiente del empleado para agregarlo a la lista.");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_BuscarNIT.Text.Length > 0)
            {
                if (!NitEmpleado.ContainsKey(txt_BuscarNIT.Text))
                {
                    MessageBox.Show("El NIT que ingreso no existe actualmente.");
                    txt_BuscarNIT.Clear();
                    txt_BuscarNIT.Focus();
                }
                else
                {
                    MessageBox.Show("Empleado: " + NitEmpleado[txt_BuscarNIT.Text]);
                    txt_BuscarNIT.Clear();
                    txt_BuscarNIT.Focus();
                }
            }
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            if(txt_BuscarNIT.Text.Length > 0)
            {
                if (!NitEmpleado.ContainsKey(txt_BuscarNIT.Text))
                {
                    MessageBox.Show("El NIT que ingreso no existe actualmente.");
                    txt_BuscarNIT.Clear();
                    txt_BuscarNIT.Focus();
                }
                else
                {
                    DataGridViewRow Datos = new DataGridViewRow();
                    Datos.CreateCells(dgv_Lista);
                    NitEmpleado.Clear();
                    dgv_Lista.Rows.Remove(dgv_Lista.CurrentRow);
                }
            }
        }
    }
}
