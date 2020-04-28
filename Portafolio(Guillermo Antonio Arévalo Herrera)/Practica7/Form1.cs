using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Practica7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string nombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{1,})(\s)?)*[^\s]$";
        string correo = @"^\S[_a-zA-Z0-9-]+(.[_a-zA-Z0-9-]+)@\S[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{1,4})\S$";
        string tele = @"^([2|6|7][0-9]{3})-([0-9]{4})$";

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Nombre.Text, nombre))
            {
                errorProvider1.SetError(txt_Nombre, "El nombre debe iniciar con letra mayúscula...");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_Correo_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Correo.Text, correo))
            {
                errorProvider1.SetError(txt_Correo, "Ingrese su correo...");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void mtx_Telefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (!Regex.IsMatch(mtx_Telefono.Text, tele))
            {
                errorProvider1.SetError(mtx_Telefono, "Su  número de telefono debe iniciar con 2, 6 o 7...");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == "" || !Regex.IsMatch(txt_Nombre.Text, nombre))
            {
                MessageBox.Show("Este campo no lo tiene que dejar en blanco... Ingrese su nombre");
                txt_Nombre.Focus();
            }
            else if (txt_Correo.Text == "" || !Regex.IsMatch(txt_Correo.Text, correo) || txt_Correo.Text.Contains(";") || txt_Correo.Text.Contains(":"))
            {
                MessageBox.Show("Este campo no lo tiene que dejar en blanco... Ingrese su nombre");
                txt_Correo.Focus();
            }
            else if (mtx_Telefono.Text == "" || !Regex.IsMatch(mtx_Telefono.Text, tele) || !mtx_Telefono.MaskFull)
            {
                MessageBox.Show("Este campo no lo tiene que dejar en blanco...Ingrsee su numero de telefono");
                mtx_Telefono.Focus();
            }
            else
            {
                FileStream fs = null;
                BinaryWriter bw = null;
                try
                {
                    fs = new FileStream("Propietarios.dat", FileMode.Append, FileAccess.Write);
                    bw = new BinaryWriter(fs);
                    bw.Write(txt_Nombre.Text);
                    bw.Write(txt_Correo.Text);
                    bw.Write(mtx_Telefono.Text);
                    MessageBox.Show("Los datos han sido almacenados correctamente...");
                    dgv_Lista.Rows.Add(txt_Nombre.Text, txt_Correo.Text, mtx_Telefono.Text);
                    dgv_Lista.ClearSelection();
                    txt_Nombre.Clear();
                    txt_Correo.Clear();
                    mtx_Telefono.Clear();
                    txt_Nombre.Focus();
                }
                catch (Exception)
                {

                    MessageBox.Show("Ingrese los datos correctamente...");
                }
                finally
                {
                    if (bw != null)
                    {
                        bw.Close();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Nombre, Correo, Telefono;
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                fs = new FileStream("Propietarios.dat", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                dgv_Lista.Rows.Clear();
                while (true)
                {
                    Nombre = br.ReadString();
                    Correo = br.ReadString();
                    Telefono = br.ReadString();
                    dgv_Lista.Rows.Add(Nombre, Correo, Telefono);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (br != null)
                {
                    br.Close();
                    dgv_Lista.ClearSelection();
                }
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            if (dgv_Lista.Rows.Count > 0)
            {
                Form2 form = new Form2();
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("No existen datos de propietario...\nDebe ingresar almenos un propietario...");
                txt_Nombre.Focus();
            }
        }
    }
}
