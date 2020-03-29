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
    public partial class Pnproductos : Form
    {
        public Pnproductos()
        {
            InitializeComponent();
        }
        DataTable tabla = new DataTable();
        static string nombre;
        private void Olvicontra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea registrar un nuevo tipo de producto?", "Tipo de producto", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Ptipo nuevotipo = new Ptipo();
                nuevotipo.ShowDialog();
                txtnombre.Focus();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea registrar una mueva unidad de medida?", "Nueva unidad de medida", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Punidadmedida nuevaunidad = new Punidadmedida();
                nuevaunidad.ShowDialog();
                txtnombre.Focus();
            }
        }

        private void cmbtipo_Enter(object sender, EventArgs e)
        {
            LgestionProducto consutipo = new LgestionProducto();
            tabla = consutipo.ctipo();
            cmbtipo.DataSource = tabla;
            cmbtipo.ValueMember = "Tipo_producto";
        }

        private void cmbunidad_Enter(object sender, EventArgs e)
        {
            LgestionProducto consuunidad = new LgestionProducto();
            tabla = consuunidad.cunidadmedida();
            cmbunidad.DataSource = tabla;
            cmbunidad.ValueMember = "Unidad_medida";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            LgestionProducto reg = new LgestionProducto();
            string registrado = reg.d(nombre);
            string g="";


            if (txtnombre.Text == "" || cmbtipo.Text == "" || cmbunidad.Text == "" || nudcontenido.Value == 0 || nudcantidad.Value == 0 || txtvalorunidad.Text == "" || txtimbima.Text == "" || cmbempresa.Text == "" || cmbproveedor.Text == "")
            {
                MessageBox.Show("los campos de usuario deben contener datos", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LgestionProducto regis = new LgestionProducto();
                g = regis.regisproducto(txtnombre.Text, cmbtipo.Text, cmbunidad.Text, nudcontenido.Value, nudcantidad.Value, txtvalorunidad.Text, txtimbima.Text, nombre, nudiva.Value, cmbproveedor.Text);
            }
            if (g == "1")
            {
                PFechavencimiento cargar = new PFechavencimiento();
                LgestionProducto codproducto = new LgestionProducto();
                string a = codproducto.codpro(txtnombre.Text);
                cargar.cedula(a,txtnombre.Text);
                txtnombre.Text = "";
                cmbtipo.Text = "";
                cmbunidad.Text = "";
                nudcontenido.Value = 0;
                nudcantidad.Value = 0;
                txtvalorunidad.Text = "";
                txtimbima.Text = "";
                nudiva.Value = 0;
                cmbempresa.Text = "";
                cmbproveedor.Text = "";
                nudiva.Value = 0;
                cargar.ShowDialog();


            }
            else
            {
                MessageBox.Show("Proveedor no registrado", "Informacion de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void registradoa(string re)
        {
            nombre = re;
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            cmbproveedor.Text = "";
            LgestionProducto consuempresa = new LgestionProducto();
            tabla = consuempresa.cempresa();
            cmbempresa.DataSource = tabla;
            cmbempresa.ValueMember = "Nombre_empresa";
        }

        private void cmbempresa_Leave(object sender, EventArgs e)
        {
            LgestionProducto consproveedor = new LgestionProducto();
            DataTable tabla2 = new DataTable();
            tabla2 = consproveedor.cproveedor(cmbempresa.Text);
            cmbproveedor.DataSource = tabla2;
            cmbproveedor.ValueMember = "nombre";
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
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

        private void cmbtipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbunidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtvalorunidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void cmbempresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
