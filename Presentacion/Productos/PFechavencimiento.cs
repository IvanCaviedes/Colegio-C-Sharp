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
    public partial class PFechavencimiento : Form
    {
        public PFechavencimiento()
        {
            InitializeComponent();
        }
        string c,v;
        string respuesta = "0";
        int entrada = 0,codi = 0;
        private void PFechavencimiento_Load(object sender, EventArgs e)
        {
            label1.Text = c;
            label3.Text = v;
        }
        public void cedula(string a,string b)
        {
            c = a;
            v = b;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (respuesta == "0")
            {
                MessageBox.Show("Debes registrar una fecha de vencimiento");
            }
            else
            {
                this.Close();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (codi == 0)
            {
                PCodigoQrbarras nuevo = new PCodigoQrbarras();
                nuevo.nombre(label3.Text);
                nuevo.ShowDialog();
                codi = codi + 1;
            }
            else
            {
                MessageBox.Show("Codigo de barras ya guardado");
            }
        }

        private void btneps_Click(object sender, EventArgs e)
        {           
                LgestionProducto Instancia = new LgestionProducto();

                 respuesta = Instancia.registrofecha(c,fechavencimiento.Value);

            if (respuesta == "1")
            {
                if (entrada == 0)
                {
                    MessageBox.Show("Registro de Producto exitoso " + "Tiene la posibilidad de registrar Fechas de vencimiento", "Registro de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    entrada = entrada + 1;
                }
                else
                {
                    MessageBox.Show("Tiene la posibilidad de registrar Fechas de vencimiento", "Registro de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
