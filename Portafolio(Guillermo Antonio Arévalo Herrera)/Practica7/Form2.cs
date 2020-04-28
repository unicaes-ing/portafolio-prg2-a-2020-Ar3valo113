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
using System.Runtime.Serialization.Formatters.Binary;

namespace Practica7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public struct RegistroMascotas
        {
            public string Codigo;
            public string Nombre;
            public string Propietario;
            public string Especie;
            public string FechaNaciemiento;
            public Double Peso;
            public string Sexo;
        }
        Dictionary<string, RegistroMascotas> Registro = new Dictionary<string, RegistroMascotas>();
        RegistroMascotas Mascota = new RegistroMascotas();


        BinaryFormatter formatter = new BinaryFormatter();
        const string NOMBRE_ARCHIVO = "Mascotas.dat";

        string Nombre = @"^(([A-Z[ÁÉÍÓÚ][a-zñ[áéíóú]{1,})(\s)?)*[^\s]$";

        private void txt_Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && !txt_Peso.Text.Contains("."))
            {
                e.Handled = false;
            }
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_Nombre.Text, Nombre))
            {
                errorProvider1.SetError(txt_Nombre, "El nombre debe iniciar con letra mayúscula...");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string Nombre, Correo, Telefono;
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                fs = new FileStream("Propietarios.dat", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                cbo_Propietario.Items.Clear();
                while (true)
                {
                    Nombre = br.ReadString();
                    Correo = br.ReadString();
                    Telefono = br.ReadString();
                    cbo_Propietario.Items.Add(Nombre);
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
                }
            }

            if (File.Exists(NOMBRE_ARCHIVO))
            {
                try
                {
                    FileStream ReaderFS = new FileStream(NOMBRE_ARCHIVO, FileMode.Open, FileAccess.Read);
                    Registro = (Dictionary<string, RegistroMascotas>)formatter.Deserialize(ReaderFS);
                    ReaderFS.Close();

                }
                catch (Exception)
                {

                }
                if (Registro.Count > 0)
                {
                    dgv_Mascotas.Rows.Clear();

                    foreach (RegistroMascotas Mascota in Registro.Values)
                    {
                        dgv_Mascotas.Rows.Add(Mascota.Codigo, Mascota.Nombre, Mascota.Propietario, Mascota.Especie, Mascota.FechaNaciemiento, Mascota.Peso, Mascota.Sexo);
                    }
                    dgv_Mascotas.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("No Existen datos almacenados en el archivo...");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (mtx_Codigo.Text.Equals("") || !mtx_Codigo.MaskFull)
            {
                MessageBox.Show("Este campo no lo puede dejar en blanco... Ingrese el codigo de la mascota ");
                mtx_Codigo.Focus();
            }
            else if (txt_Nombre.Text == "" || !Regex.IsMatch(txt_Nombre.Text, Nombre))
            {
                MessageBox.Show("Este campo no lo puede dejar en blanco... Ingrese el nombre de la mascota");
                txt_Nombre.Focus();
            }
            else if (cbo_Propietario.SelectedIndex == -1)
            {
                MessageBox.Show("Este campo no lo puede dejar en blanco... Ingrese nombre de la lista de los propietarios");
            }
            else if (cbo_Especie.SelectedIndex == -1)
            {
                MessageBox.Show("Este campo no lo puede dejar en blanco...Elija la especie de su mascota en la lista de especies....");
            }

            else if (txt_Peso.Text == "" || txt_Peso.Text.StartsWith("."))
            {
                MessageBox.Show("Este campo no lo puede dejar en blanco...Ingrese el peso de su mascota");
                txt_Peso.Focus();
            }
            else
            {


                Mascota.Codigo = mtx_Codigo.Text;
                Mascota.Nombre = txt_Nombre.Text;
                Mascota.Propietario = cbo_Propietario.Text;
                Mascota.Especie = cbo_Especie.Text;
                Mascota.FechaNaciemiento = dtp_Fecha.Text;
                Mascota.Peso = Convert.ToDouble(txt_Peso.Text);
                if (rdo_Hembra.Checked)
                {
                    Mascota.Sexo = rdo_Hembra.Text;
                }
                else
                {
                    Mascota.Sexo = rdo_Macho.Text;
                }
                if (Registro.ContainsKey(mtx_Codigo.Text))
                {
                    MessageBox.Show("El codigo de mascota ya existe...Ingrese un codigo nuevo");
                    mtx_Codigo.Focus();
                }
                else
                {
                    Registro.Add(Mascota.Codigo, Mascota);

                    try
                    {
                        FileStream writerFs = new FileStream(NOMBRE_ARCHIVO, FileMode.Create, FileAccess.Write);
                        formatter.Serialize(writerFs, Registro);
                        writerFs.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No fue posible almacenar los datos...");
                    }
                    MessageBox.Show("Los datos han sido almacenados correctamente...");
                    dgv_Mascotas.Rows.Add(Mascota.Codigo, Mascota.Nombre, Mascota.Propietario, Mascota.Especie, Mascota.FechaNaciemiento, Mascota.Peso, Mascota.Sexo);
                    mtx_Codigo.Clear();
                    txt_Nombre.Clear();
                    cbo_Propietario.SelectedIndex = -1;
                    cbo_Especie.SelectedIndex = -1;
                    txt_Peso.Clear();

                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
