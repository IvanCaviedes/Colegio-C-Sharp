using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class ActuProducto : Form
    {
        public ActuProducto()
        {
            InitializeComponent();
        }
        string c, n, valor, ivaa, esta, canti,g;
        static string cargo30;

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" || txtvalorunidad.Text == "" || cmbestado.Text == "")
            {
                MessageBox.Show("los campos de usuario deben contener datos", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LgestionProducto regis = new LgestionProducto();
                g = regis.actuproducto(txtnombre.Text, txtvalorunidad.Text, nudiva.Value, label17.Text, cmbestado.Text, nudcantidad.Value);

                if (g == "1")
                {
                    MessageBox.Show("Producto registrado con exito", "Informacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Producto no registrado", "Informacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void txtvalorunidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void cmbestado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void nudiva_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ActuProducto_Load(object sender, EventArgs e)
        {
            if (esta == "a" || esta == "A")
            {
                cmbestado.Text = "Activo";
            }
            else if (esta == "i" || esta == "I")
            {
                cmbestado.Text = "Inactivo";
            }
            if (cargo30 == "admi")
            {
                nudcantidad.Enabled = true;
            }
            else
            {
                nudcantidad.Enabled = false;
            }
            txtnombre.Text = n;
            txtvalorunidad.Text = valor;
            label17.Text = c;
            nudiva.Value = Convert.ToDecimal(ivaa);
            nudcantidad.Value = Convert.ToDecimal(canti);

        }

        public void actualizar(string cod, string nombre, string vporunidad, string iva, string estado,string cantidad)
        {
            c = cod;
            n = nombre;
            valor = vporunidad;
            ivaa = iva;
            esta = estado;
            canti = cantidad;
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
        public void numeros(KeyPressEventArgs e)
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

        public void cargo (string a)
        {
            cargo30 = a;
        }
    }
}
