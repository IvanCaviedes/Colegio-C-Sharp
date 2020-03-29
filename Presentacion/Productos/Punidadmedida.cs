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
    public partial class Punidadmedida : Form
    {
        public Punidadmedida()
        {
            InitializeComponent();
        }

        private void btneps_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("espacio vacio", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LgestionProducto unidad = new LgestionProducto();
                string respuesta = unidad.runidad(textBox1.Text);

                if (respuesta == "1")
                {
                    MessageBox.Show("Unidad de producto registrado con exito", "registrar Unidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("unidad de producto no registrada", "registrar unidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
