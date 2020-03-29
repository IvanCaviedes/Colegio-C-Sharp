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
    public partial class Pfondodepensiones : Form
    {
        public Pfondodepensiones()
        {
            InitializeComponent();
        }

        private void btneps_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Espacios vacios", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Lgestionusuario pensiones = new Lgestionusuario();
                string respuesta = pensiones.rpensiones(textBox1.Text);

                if (respuesta == "1")
                {
                    MessageBox.Show("fondo registrado con exito ", "registrar fondo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (respuesta == "2")
                {
                    MessageBox.Show("fondo no registrado", "registrar fondo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
