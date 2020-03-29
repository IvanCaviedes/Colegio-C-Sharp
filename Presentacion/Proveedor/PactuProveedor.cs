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
    public partial class PactuProveedor : Form
    {
        public PactuProveedor()
        {
            InitializeComponent();
        }
        DataTable tabla = new DataTable();
        string n, c, t1, t2, empre, celd, ema, est,q;

        private void cmbestado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
        }

        private void cmbempresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
        }

        private void txtcelular_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txttelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);
        }

        private void Olvicontra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea registrar una nueva Empresa?", "Nueva Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Pempresa nuevaempresa = new Pempresa();
                nuevaempresa.ShowDialog();
                txtnombre.Focus();
            }
        }

        private void cmbempresa_Enter(object sender, EventArgs e)
        {
            LgestionProveedor consuempresa = new LgestionProveedor();
            tabla = consuempresa.cempresa();
            cmbempresa.DataSource = tabla;
            cmbempresa.ValueMember = "Nombre_empresa";
        }

        private void PactuProveedor_Load(object sender, EventArgs e)
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
                txttelefono2.Text = "";
            }
            else
            {
                txttelefono2.Text = t2;
            }
            txtnombre.Text = n;
            txtcedula.Text = c;
            txttelefono.Text = t1;
            cmbempresa.Text = empre;
            txtcelular.Text = celd;
            txtemail.Text = ema;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if(txtnombre.Text == "" || txtcedula.Text == "" || txttelefono.Text == "" || cmbempresa.Text == "" || txtcelular.Text == "" || txtemail.Text == ""||cmbestado.Text =="")
            {
                MessageBox.Show("los campos de usuario deben contener datos", "Error de actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txttelefono2.Text == "")
            {
                q = "0";
            }
            else
            {
                q = txttelefono2.Text;
            }
            LgestionProveedor actu = new LgestionProveedor();
            string g = actu.M(txtnombre.Text, txtcedula.Text, txttelefono.Text, cmbempresa.Text, txtcelular.Text, txtemail.Text, q, cmbestado.Text);
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
        public void actualizar(string nombre, string cedula, string tel, string tel2, string empresa, string cel, string email, string estado)
        {
            n = nombre;
            c = cedula;
            t1 = tel;
            t2 = tel2;
            empre = empresa;
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
