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
    public partial class Pproductos : Form
    {
        public Pproductos()
        {
            InitializeComponent();
        }
        string datocod;
        static string cargos;
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Pnproductos nuevo = new Pnproductos();
            nuevo.ShowDialog();
        }

        private void Pproductos_Load(object sender, EventArgs e)
        {
            if (cargos == "admi")
            {

            }
            else if (cargos == "caje")
            {
                pictureBox1.BackColor = Color.FromArgb(138, 131, 98);
            }
            else
            {
                pictureBox1.BackColor = Color.FromArgb(99, 129, 125);

            }

            LgestionProducto f = new LgestionProducto();
            DataTable tabla = new DataTable();
            tabla = f.cgeneral();
            dataGridView1.DataSource = tabla;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LgestionProducto c = new LgestionProducto();
            DataTable tabla = new DataTable();

            if (consultageneral.Text == "" || txtdatoconsulta.Text == "")
            {
                MessageBox.Show("los campos de usuario deben contener datos", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (consultageneral.Text == "Nombre")
            {
                tabla = c.cespecificon(txtdatoconsulta.Text);
                dataGridView1.DataSource = tabla;
            }

            else if (consultageneral.Text == "Codigo")
            {
                tabla = c.cespecificoc(txtdatoconsulta.Text);
                dataGridView1.DataSource = tabla;
            }
            else
            {
                MessageBox.Show("Error cargo no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultageneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (consultageneral.Text == "Estado")
            {
                LgestionProducto f = new LgestionProducto();
                DataTable tabla = new DataTable();
                tabla = f.cestado();
                dataGridView1.DataSource = tabla;
            }
            else if (consultageneral.Text == "Qr y Barras")
            {

                if (MessageBox.Show("¿Desea consultar por Qr y Barras?", "Consultar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Pconsultascodigos consulta = new Pconsultascodigos();
                    consulta.ShowDialog();
                    datocod = consulta.dato();
                    LgestionProducto c = new LgestionProducto();
                    DataTable tabla = new DataTable();
                    tabla = c.cespecificon(datocod);
                    dataGridView1.DataSource = tabla;
                }


            }
        }

        private void Olvicontra_Click(object sender, EventArgs e)
        {
            Pproductos_Load(null, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ActuProducto act = new ActuProducto();
                string cod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string vporunidad = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                string iva = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string estado = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                string cantidad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                act.actualizar(cod, nombre, vporunidad, iva, estado,cantidad);
                act.ShowDialog();
            }
            catch {
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el usuario?", "eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LgestionProducto eliminar = new LgestionProducto();
                string cedul = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string exito = eliminar.elimi(cedul);


                if (exito == "1")
                {
                    MessageBox.Show("usuario eliminado con exito, para poder activarlo por favor consultelo y actualice el usuario", "informe de eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void txtdatoconsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (consultageneral.Text == "")
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (Char.IsSymbol(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (consultageneral.Text == "Codigo")
                {
                    if (Char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    if (Char.IsSymbol(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    if (Char.IsPunctuation(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
                else if (consultageneral.Text == "Nombre")
                {
                    if (Char.IsNumber(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    if (Char.IsSymbol(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    if (Char.IsPunctuation(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void consultageneral_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void cargo(string car)
        {
            cargos = car;
        }
    }
}
