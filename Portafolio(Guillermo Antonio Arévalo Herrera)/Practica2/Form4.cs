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

namespace Practica2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string contraseña = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$";

            if (txtCorreo.Text.Contains("@") && txtCorreo.Text.Contains("."))
            {
                if (txtContraseña.Text == txtConfContraseña.Text)
                {
                    MessageBox.Show("Se ha registrado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCorreo.Clear();
                    txtContraseña.Clear();
                    txtConfContraseña.Clear();
                    txtCorreo.Focus();
                }
                else if (Regex.IsMatch(txtContraseña.Text, contraseña) == false)
                {
                    MessageBox.Show("Debe contener minimo 8 caracteres, una letra mayuscula y numeros");
                    txtContraseña.ForeColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Las contraseñas deben coincidir para registrarse.");
                }
            }
            else
            {
                MessageBox.Show("Agregue un correo electronico valido.");
            }
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            string contraseña = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$";
            if (Regex.IsMatch(txtContraseña.Text, contraseña) == false)
            {
                MessageBox.Show("Debe contener minimo 8 caracteres, una letra mayuscula y numeros");
                txtContraseña.ForeColor = Color.Red;
            }
        }

        private void txtContraseña_Validated(object sender, EventArgs e)
        {
            txtContraseña.ForeColor = Color.Green;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Inicio = new Inicio();
            Inicio.Show();
        }
    }
}
