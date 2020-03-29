using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class Pnclientes : Form
    {
        public Pnclientes()
        {
            InitializeComponent();
        }
        string q;
        static string nombre;
        string principio;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void registrado_por(string re)
        {
            nombre = re;
        }

        private void Pnclientes_Load(object sender, EventArgs e)
        {
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            Lgestioncliente reg = new Lgestioncliente();
            string registrado = reg.d(nombre);
            if (cllocrra.Text == "Calle")
            {
                principio = "CL.";

            }
            if (cllocrra.Text == "Carrera")
            {
                principio = "Cra.";

            }

            string direccion = principio + " " +"+"+ txtdireccion.Text +"+"+ "%23" + bunifuCustomTextbox1.Text;

            if (txtnomcliente.Text == "" || txtidentificacion.Text == "" || txttelefono.Text == "" || txtdireccion.Text == "" || txtcelular.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("los campos de usuario deben contener datos", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txttel2.Text == "")
            {
                q = "0";
            }
            else
            {
                q = txttel2.Text;
            }

            Lgestioncliente regis = new Lgestioncliente();
            string g = regis.registrarcliente(txtnomcliente.Text, txtidentificacion.Text, txttelefono.Text, direccion, txtcelular.Text, txtemail.Text, q, registrado);

            if (g == "1")
            {
                MessageBox.Show("Cliente registrado con exito", "Informacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnomcliente.Text = "";
                txtidentificacion.Text = "";
                txttelefono.Text = "";
                txtdireccion.Text = "";
                txtcelular.Text = "";
                txtemail.Text = "";
                txttel2.Text = "";

            }
            else
            {
                MessageBox.Show("cliente no registrado", "Informacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtidentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(null, e);
        }

        public void numeros(object sender, KeyPressEventArgs e)
        {

            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsLetter(e.KeyChar))

            {
                e.Handled = true;
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(null, e);
        }

        private void txtcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(null, e);
        }

        private void txttel2_TextChanged(object sender, EventArgs e)
        {
        }

        private void txttel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(null, e);
        }

        private void txtnomcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }
        public void sololetras(KeyPressEventArgs e)
        {

            if (Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static bool validaremail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.']\\w+)*\\.\\w+([-.']\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (validaremail(txtemail.Text))
            {

            }
            else
            {
                MessageBox.Show("direccion de correo electronico no valida", "error de correo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtemail.SelectAll();
                txtemail.Focus();
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if(cllocrra.Text == "")
            {
                MessageBox.Show("no puede ir vacio");
                cllocrra.Focus();
            }
        }

        private void cllocrra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtdireccion_Leave(object sender, EventArgs e)
        {
            if (txtdireccion.Text == "")
            {
                MessageBox.Show("no puede ir vacio");
                txtdireccion.Focus();
            }
        }

        private void bunifuCustomTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuCustomTextbox1.Text == "")
            {
                MessageBox.Show("no puede ir vacio");
                bunifuCustomTextbox1.Focus();
            }
        }
    }
}
