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
    public partial class Pventas : Form
    {
        public Pventas()
        {
            InitializeComponent();
        }
        //DataSet datos = new DataSet();
        Int64 a = 0;
        int i = 0, f = 0,ap, asdf,cantidadvendida =0;
        string facturane;
        static string nombre;
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

                else
                {
                    if (Convert.ToInt32(numericUpDown1.Value) > Convert.ToInt32(txt2.Text))
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
        string codigoproducto;


        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || numericUpDown1.Value == 0)
            {
                MessageBox.Show("los campos deben contener datos");
            }
            else
            {
                dataGridView1.Visible = false;
                a = a + Convert.ToInt32(txt7.Text);
                Iva.Text = a.ToString();
                i = i + Convert.ToInt32(txt5.Text);
                Compra.Text = i.ToString();
                cantidadvendida = cantidadvendida +Convert.ToInt32(numericUpDown1.Value);
                dgv1.Rows.Add(codigoproducto, comboBox1.Text, txt5.Text, txt6.Text, Convert.ToString(numericUpDown1.Value), txt7.Text);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Lgestionventa FAC = new Lgestionventa();
            facturane = FAC.codfactura();
            if (facturane == "1")
            {
                label2.Text = facturane;
            }
            else
            {

                ap = Convert.ToInt32(facturane) + 1;
                label2.Text = ap.ToString();
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

                Lgestioncliente reg = new Lgestioncliente();
                string registrado = reg.d(nombre);
                string a = DateTime.Now.ToString("dd/MM/yyyy");
                Lgestionventa factura = new Lgestionventa();
                string c = factura.nfactura(a.ToString(), Iva.Text, cantidadvendida.ToString(), Compra.Text, "2", registrado, h);

                if (c == "1")
                {
                    for (f = 0; f < dgv1.Rows.Count; f++)
                    {
                        Lgestionventa detalles = new Lgestionventa();
                        detalles.detallesv(dgv1.Rows[f].Cells[0].Value.ToString(), label2.Text, dgv1.Rows[f].Cells[3].Value.ToString(), dgv1.Rows[f].Cells[4].Value.ToString(), dgv1.Rows[f].Cells[2].Value.ToString());
                    }
                    MessageBox.Show("factura de venta exitosa");
                    numericUpDown1.Value = 0;
                    dgv1.Rows.Clear();
                    Iva.Text = "0";
                    Compra.Text = "0";
                }


                //reportes 
                ConjuntoDaros datos = new ConjuntoDaros();
                ConjuntoDaros.FacturaRow columna = datos.Factura.NewFacturaRow();

                columna.Cantidad = cantidadvendida.ToString();
                columna.Fecha = DateTime.Now.ToString();
                columna.IvaTotal = Compra.Text;
                columna.TotalValor = Iva.Text;
                columna.Usuario = registrado;
                datos.Factura.Rows.Add(columna);

                //llenado de detalles

                for (int n = 0; n < dgv1.Rows.Count; n++)
                {
                    ConjuntoDaros.DetallesRow columna1 = datos.Detalles.NewDetallesRow();
                    columna1.CodFactura = label2.Text;
                    columna1.Nproducto = dgv1.Rows[n].Cells[1].Value.ToString();
                    columna1.UnidadesVendidas = dgv1.Rows[n].Cells[4].Value.ToString();
                    columna1.ValorIva = dgv1.Rows[n].Cells[2].Value.ToString();
                    columna1.ValorUnidad = dgv1.Rows[n].Cells[3].Value.ToString();
                    columna1.TotalProducto = dgv1.Rows[n].Cells[5].Value.ToString();
                    datos.Detalles.Rows.Add(columna1);

                }

                Form1 mostrar = new Form1();
                mostrar.Nuevo = datos;
                mostrar.Show();
            }

        }

        private void Pventas_Load(object sender, EventArgs e)
        {

        }
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            Lgestionventa c = new Lgestionventa();
            DataTable tabla = new DataTable();


            if (consultageneral.Text == "")
            {
                MessageBox.Show("los campos de usuario deben contener datos", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (consultageneral.Text == "Codigo" && txtdatoconsulta.Text == "")
            {
                MessageBox.Show("los campos de usuario deben contener datos", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (consultageneral.Text == "Codigo")
            { 
                tabla = c.cespecificacod(txtdatoconsulta.Text);
                dataGridView1.Visible = true;
                dataGridView1.DataSource = tabla;
            }

            else if (consultageneral.Text == "Fecha")
            {
                txtdatoconsulta.Text = "";
                tabla = c.especificofecha(dateTimePicker1.Value);
                dataGridView1.Visible = true;
                dataGridView1.DataSource = tabla;
            }
        }

        private void consultageneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (consultageneral.Text == "Codigo")
            {
                txtdatoconsulta.Visible = true;
                dateTimePicker1.Visible = false;
            }

            else if (consultageneral.Text == "Fecha")
            {

                txtdatoconsulta.Visible = false;
                dateTimePicker1.Visible = true;
            }

        }

        private void cmb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿desea eliminar este producto?", "!ALERTA¡", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dgv1.CurrentRow.Cells == null)
                {


                }
                else
                {
                    dgv1.Rows.RemoveAt(dgv1.CurrentRow.Index);
                    string c = dgv1.CurrentRow.Cells[3].Value.ToString();
                    string qw = dgv1.CurrentRow.Cells[2].Value.ToString();

                    a = a - Convert.ToInt32(c);
                    Iva.Text = a.ToString();

                    i = i - Convert.ToInt32(qw);
                    Compra.Text = i.ToString();
                }
            }
            else
            {

            }
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(null, e);
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
        public void registrado_por(string re)
        {
            nombre = re;
        }
    }
}
