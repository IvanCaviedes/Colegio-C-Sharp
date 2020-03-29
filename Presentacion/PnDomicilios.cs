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
    public partial class PnDomicilios : Form
    {
        public PnDomicilios()
        {
            InitializeComponent();
        }
        int a = 0, i = 0,f=0;
        string codigoproducto;
        string factura;


        string dir;

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            Lgestiondomicilio domiciliarios = new Lgestiondomicilio();
            tabla = domiciliarios.ndomiciliario();
            comboBox2.DataSource = tabla;
            comboBox2.ValueMember = "Nombre_completo";
        }

        private void cmb1_Enter(object sender, EventArgs e)
        {
            Lgestionventa Instancia = new Lgestionventa();
            DataTable ConjuntoDatos = new DataTable();
            ConjuntoDatos = Instancia.Lconsultatipo();
            cmb1.DataSource = ConjuntoDatos;
            cmb1.ValueMember = "Tipo_producto";
        }

        private void cmb1_Leave(object sender, EventArgs e)
        {
            Lgestionventa Instancia2 = new Lgestionventa();
            DataTable ConjuntoDatos2 = new DataTable();
            ConjuntoDatos2 = Instancia2.LconsultaProducto(cmb1.Text);
            comboBox1.DataSource = ConjuntoDatos2;
            comboBox1.ValueMember = "Nombre";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lgestionventa instancia = new Lgestionventa();
            if (txt4.Text == "")
            {
                string a = "1";
                string nombre = instancia.LConsultarCliente(a);
                lbl4.Text = nombre;
            }
            else
            {
                string nombre1 = instancia.LConsultarCliente(txt4.Text);
                lbl4.Text = nombre1;
            }


            if (cmb1.Text == "" || comboBox1.Text == "")
            {


            }
            else
            {
                Lgestionventa Instancia = new Lgestionventa();
                DataTable ConjuntoDatos4 = new DataTable();
                ConjuntoDatos4 = Instancia.LDatosProducto(comboBox1.Text);
                txt6.Text = ConjuntoDatos4.Rows[0][3].ToString();
                txt2.Text = ConjuntoDatos4.Rows[0][2].ToString();
                txt5.Text = ConjuntoDatos4.Rows[0][4].ToString();
                codigoproducto = ConjuntoDatos4.Rows[0][0].ToString();
            }

            if (comboBox1.Text == "")
            {




            }
            else
            {
                if (txt2.Text == "")
                {
                    MessageBox.Show("Debe seleccionar un producto de la lista", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmb1.Focus();
                }
                else if (Convert.ToInt32(numericUpDown1.Value) > Convert.ToInt32(txt2.Text))
                {
                    numericUpDown1.Value = Convert.ToDecimal(txt2.Text);
                    MessageBox.Show("El valor a vender no puede ser mayor a la cantidad disponible", "Verificación de cantidades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Lgestionventa Instancia3 = new Lgestionventa();
                    int total = Convert.ToInt32(txt6.Text) * Convert.ToInt32(numericUpDown1.Value);

                    string sd = Instancia3.ValorIVA(txt6.Text, Convert.ToString(numericUpDown1.Value), txt5.Text);
                    int asd = Convert.ToInt32(total.ToString()) + Convert.ToInt32(sd.ToString());
                    txt7.Text = asd.ToString();
                }
            }
        }

        private void PnDomicilios_Load(object sender, EventArgs e)
        {
            Lgestionventa FAC = new Lgestionventa();
            factura = FAC.codfactura();

            if (factura == "1")
            {
                label2.Text = "1";
            }
            else
            {

                int a = Convert.ToInt32(factura) + 1;
                label2.Text = a.ToString();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (cmb1.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("los datos no pueden ir vacios");

            }
            else
            {
                string h;
                if (label4.Text == "Cliente - Nombres y apellidos" || txt4.Text == "")
                {
                    h = "1";
                }
                else
                {
                    h = txt4.Text;
                }

                string a = DateTime.Now.ToString("dd/MM/yyyy");
                Lgestionventa factura = new Lgestionventa();
                string c = factura.nfactura(Convert.ToString(a), Iva.Text, "1", Compra.Text, "2", "123456789", h);

                if (c == "1")
                {
                    for (f = 0; f < dgv1.Rows.Count; f++)
                    {
                        Lgestionventa detalles = new Lgestionventa();
                        detalles.detallesv(dgv1.Rows[f].Cells[0].Value.ToString(), label2.Text, dgv1.Rows[f].Cells[3].Value.ToString(), dgv1.Rows[f].Cells[4].Value.ToString(), dgv1.Rows[f].Cells[2].Value.ToString());
                    }
                    MessageBox.Show("factura de venta exitosa");
                }
                if(label14.Text == "Cliente - Nombres y apellidos"||label14.Text == "cliente de prueba"||txt4.Text == "")
                {


                }
                else
                {
                    Lgestiondomicilio direccion = new Lgestiondomicilio();
                     dir = direccion.dircliente(txt4.Text);
                    Mostrarruta.Visible = true;

                }
            }
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(null, e);
        }

        private void Mostrarruta_Click(object sender, EventArgs e)
        {
            maps instancia23 = new maps();
            instancia23.direccion(dir);
            instancia23.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || numericUpDown1.Value == 0)
            {
                MessageBox.Show("los campos deben contener datos");
            }
            else
            {

                a = a + Convert.ToInt32(txt7.Text);
                Iva.Text = a.ToString();
                i = i + Convert.ToInt32(txt5.Text);
                Compra.Text = i.ToString();
                dgv1.Rows.Add(codigoproducto, comboBox1.Text, txt5.Text, txt6.Text, Convert.ToString(numericUpDown1.Value), txt7.Text);
            }
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
    }
}
