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
    public partial class pusuarios : Form
    {
        public pusuarios()
        {
            InitializeComponent();
        }
        string cargos;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PnUsuario f = new PnUsuario();
            f.ShowDialog();
        }

        private void Pusuarios_Load(object sender, EventArgs e)
        {
            
            Lgestionusuario f = new Lgestionusuario();
            DataTable tabla = new DataTable();
            tabla = f.cgeneral();
            dataGridView1.DataSource = tabla;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Lgestionusuario c = new Lgestionusuario();
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

            else if (consultageneral.Text == "Cargo")
            {
                if (txtdatoconsulta.Text == "")
                {
                    MessageBox.Show("los campos de usuario deben contener datos", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (txtdatoconsulta.Text == "a" || txtdatoconsulta.Text == "A" || txtdatoconsulta.Text == "admin" || txtdatoconsulta.Text == "Admin" || txtdatoconsulta.Text == "Administrador" || txtdatoconsulta.Text == "administrador")
                {
                    tabla = c.cespecificocargo("admi");
                    dataGridView1.DataSource = tabla;
                }
                else if (txtdatoconsulta.Text == "c" || txtdatoconsulta.Text == "C" || txtdatoconsulta.Text == "Caje" || txtdatoconsulta.Text == "caje" || txtdatoconsulta.Text == "Cajero" || txtdatoconsulta.Text == "cajero")
                {
                    tabla = c.cespecificocargo("caje");
                    dataGridView1.DataSource = tabla;
                }
                else if (txtdatoconsulta.Text == "d" || txtdatoconsulta.Text == "D" || txtdatoconsulta.Text == "Domi" || txtdatoconsulta.Text == "domi" || txtdatoconsulta.Text == "Domiciliario" || txtdatoconsulta.Text == "domiciliario")
                {
                    tabla = c.cespecificocargo("domi");
                    dataGridView1.DataSource = tabla;
                }
                else
                {
                    MessageBox.Show("Error cargo no existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Pusuarios_Load(null, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Pactuusuario actu = new Pactuusuario();
            string c = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string n = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string d = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string t1 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string t2 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string cel = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            string ep = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            string nes = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            string fpens = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            string email = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            string liscon = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            string nusu = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            string cargo = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            string estado = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            actu.actualizar(c, n, d, t1, t2, cel, ep, nes, fpens, email, liscon, nusu, cargo, estado);
            actu.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el usuario?", "eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Lgestionusuario eliminar = new Lgestionusuario();
                string cedul = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string exito =  eliminar.elimi(cedul);


                if (exito == "1")
                {
                    MessageBox.Show("usuario eliminado con exito, para poder activarlo por favor consultelo y actualice el usuario", "informe de eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void consultageneral_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtdatoconsulta_KeyPress_1(object sender, KeyPressEventArgs e)
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
                if (consultageneral.Text == "Cedula")
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
                else if (consultageneral.Text == "Nombre" || consultageneral.Text == "Cargo")
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

        private void consultageneral_SelectedIndexChanged(object sender, EventArgs e) { 
        
            if (consultageneral.Text == "Cedula")
            {
                txtdatoconsulta.Text = "";
            }
            else if (consultageneral.Text == "Nombre")
            {
                txtdatoconsulta.Text = "";
            }
            else if (consultageneral.Text == "Cargo")
            {
                txtdatoconsulta.Text = "";
            }
        }

        private void Olvicontra_Click(object sender, EventArgs e)
        {
            Pusuarios_Load(null,e);
        }

    }

     
}


