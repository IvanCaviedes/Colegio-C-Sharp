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
    public partial class Pempresa : Form
    {
        public Pempresa()
        {
            InitializeComponent();
        }

        private void btneps_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""|| textBox2.Text =="")
            {
                MessageBox.Show("espacios vacios", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LgestionProveedor empresa = new LgestionProveedor();
                string respuesta = empresa.empresareg(textBox1.Text,textBox2.Text);

                if (respuesta == "1")
                {
                    MessageBox.Show("Eps registrada con exito", "registrar eps", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("Eps no registrada", "registrar eps", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }
    }
}
