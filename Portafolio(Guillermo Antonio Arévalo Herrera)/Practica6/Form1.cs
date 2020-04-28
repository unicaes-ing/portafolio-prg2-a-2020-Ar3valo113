using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Practica6
{
    public partial class Form1 : Form
    {
        List<string> Empleados = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdo_Agregar.Checked = true;
            Empleados.Add("Juan");
            Empleados.Add("Mario");
            Empleados.Add("Alberto");
            foreach (string empleado in Empleados)
            {
                lst_Empleados.Items.Add(empleado);
            }
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            //Boton Agregar
            if (rdo_Agregar.Checked == true)
            {
                if(txt_Empleado.Text != string.Empty)
                {
                    Empleados.Add(txt_Empleado.Text);
                    lst_Empleados.Items.Clear();
                    foreach (string empleado in Empleados)
                    {
                        lst_Empleados.Items.Add(empleado);
                    }
                    txt_Empleado.Clear();
                    txt_Empleado.Focus();
                }
            }

            //Boton Buscar
            int buscar = Empleados.IndexOf(txt_Empleado.Text);
            if(rdo_Buscar.Checked == true)
            {
                if(buscar >= 0)
                {
                    lst_Empleados.SelectedIndex = buscar;
                }
                else
                {
                    MessageBox.Show("El nombre que busca no se encuentra en la lista", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Boton insertar
            if (rdo_Insertar.Checked == true)
            {
                if(txt_Empleado.Text != string.Empty)
                {
                    Empleados.Insert(0, txt_Empleado.Text);
                    lst_Empleados.Items.Clear();
                    foreach (string empleado in Empleados)
                    {
                        lst_Empleados.Items.Add(empleado);
                    }
                    txt_Empleado.Clear();
                    txt_Empleado.Focus();
                }
            }

            //Boton Quitar
            if(rdo_Quitar.Checked == true)
            {
                lst_Empleados.Items.RemoveAt(lst_Empleados.SelectedIndex);
            }

            //Boton Ordenar
            if(rdo_Ordenar.Checked == true)
            {
                lst_Empleados.Items.Clear();
                Empleados.Sort();
                foreach (string empleado in Empleados)
                {
                    lst_Empleados.Items.Add(empleado);
                }
            }

            //Boton Limpiar
            if(rdo_Limpiar.Checked == true)
            {
                Empleados.Clear();
                lst_Empleados.Items.Clear();
                foreach(string empleado in Empleados)
                {
                    lst_Empleados.Items.Add(empleado);
                }
            }


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
