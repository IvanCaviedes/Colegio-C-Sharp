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
    public partial class PactuCliente : Form
    {
        public PactuCliente()
        {
            InitializeComponent();
        }
        string c, n, t1, t2, direx, celd, ema, est,q;

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
        }

        private void txtcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
        }

        private void txttel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
        }

        private void txtidentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
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

        private void txtnomcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void cmbestado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PactuCliente_Load(object sender, EventArgs e)
        {
            if (est == "a" || est == "A")
            {
                cmbestado.Text = "Activo";
            }
            else
            {
                cmbestado.Text = "Inactivo";
            }

            if (t2 == "0")
            {
                txttel2.Text = "";
            }
            else
            {
                txttel2.Text = t2;
            }
            txtnomcliente.Text= n;
            txtidentificacion.Text = c;
            txttelefono.Text= t1;
            txtdireccion.Text = direx;
            txtcelular.Text= celd;
            txtemail.Text= ema;
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (txtnomcliente.Text == "" || txtidentificacion.Text == "" || txttelefono.Text == "" || txtdireccion.Text == "" || txtcelular.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("los campos de usuario deben contener datos", "Error de actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { 
                if (txttel2.Text == "")
                {
                    q = "0";
                }
                else
                {
                    q = txttel2.Text;
                }
                Lgestioncliente actu = new Lgestioncliente();
                string g = actu.M(txtnomcliente.Text, txtidentificacion.Text, txttelefono.Text, txtdireccion.Text, txtcelular.Text, txtemail.Text, q, cmbestado.Text);
                if (g == "1")
                {
                    MessageBox.Show("Cliente actualizado con exito", "Informacion de actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Cliente no actualizado", "Informacion de actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void actualizar(string nombre,string  cedula,string  tel, string tel2, string dire, string cel, string email, string estado)
        {
            n = nombre;
            c = cedula;
            t1 = tel;
            t2 = tel2;
            direx = dire;
            celd = cel;
            ema = email;
            est = estado;
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
        public void solonumeros(KeyPressEventArgs e)
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
    }
}
