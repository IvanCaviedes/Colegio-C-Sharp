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
    public partial class Pproveedores : Form
    {
        public Pproveedores()
        {
            InitializeComponent();
        }
        static string cargos;
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Pnproveedor nuevo = new Pnproveedor();
            nuevo.ShowDialog();
        }

        private void Pproveedores_Load(object sender, EventArgs e)
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

            LgestionProveedor f = new LgestionProveedor();
            DataTable tabla = new DataTable();
            tabla = f.cgeneral();
            dataGridView1.DataSource = tabla;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LgestionProveedor c = new LgestionProveedor();
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

            else if (consultageneral.Text == "Cedula")
            {
                tabla = c.cespecificoc(txtdatoconsulta.Text);
                dataGridView1.DataSource = tabla;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (consultageneral.Text == "Inactivos")
            {
                LgestionProveedor c = new LgestionProveedor();
                DataTable tabla = new DataTable();
                tabla = c.cespecifices();
                dataGridView1.DataSource = tabla;
            }
        }

        private void Olvicontra_Click(object sender, EventArgs e)
        {
            consultageneral.Text = "";
            Pproveedores_Load(null, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PactuProveedor actu = new PactuProveedor();
            string nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string cedula = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string tel = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string tel2 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string empresa = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string cel = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            string email = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            string estado = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            actu.actualizar(nombre, cedula, tel, tel2, empresa, cel, email, estado);
            actu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el usuario?", "eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LgestionProveedor eliminar = new LgestionProveedor();
                string cedul = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string exito = eliminar.elimi(cedul);


                if (exito == "1")
                {
                    MessageBox.Show("usuario eliminado con exito, para poder activarlo por favor consultelo y actualice el usuario", "informe de eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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
