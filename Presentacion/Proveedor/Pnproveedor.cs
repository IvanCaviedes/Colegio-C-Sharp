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
    public partial class Pnproveedor : Form
    {
        public Pnproveedor()
        {
            InitializeComponent();
        }
        DataTable tabla = new DataTable();
        string q;
        static string nombre;

        public void registradoa(string re)
        {
            nombre = re;
        }

        private void Olvicontra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea registrar una nueva Eps?", "Nueva eps", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Pempresa nuevaempresa = new Pempresa();
                nuevaempresa.ShowDialog();
                txtnombre.Focus();
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            LgestionProveedor consuempresa = new LgestionProveedor();
            tabla = consuempresa.cempresa();
            cmbempresa.DataSource = tabla;
            cmbempresa.ValueMember = "Nombre_empresa";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            LgestionProveedor reg = new LgestionProveedor();
            string registrado = reg.d(nombre);

            if (txtnombre.Text == "" || txttelefono.Text == "" || txtcedula.Text == "" || cmbempresa.Text == "" || txtcelular.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("los campos de usuario deben contener datos", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txttelefono2.Text == "")
            {
                q = "0";
            }
            else
            {
                q = txttelefono2.Text;
            }

            LgestionProveedor regis = new LgestionProveedor();
            string g = regis.regisp(txtnombre.Text, txttelefono.Text, txtcedula.Text, cmbempresa.Text, txtcelular.Text, txtemail.Text, q, registrado);

            if (g == "1")
            {
                MessageBox.Show("Proveedor registrado con exito", "Informacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnombre.Text = "";
                txttelefono.Text = "";
                cmbempresa.Text = "";
                txtcedula.Text = "";
                txtcelular.Text = "";
                txtemail.Text = "";
                txttelefono2.Text = "";

            }
            else
            {
                MessageBox.Show("Proveedor no registrado", "Informacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Pnproveedor_Load(object sender, EventArgs e)
        {
            MessageBox.Show(nombre);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txttelefono2_KeyPress(object sender, KeyPressEventArgs e)
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
    }

}
