using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using System.Text.RegularExpressions;

namespace Presentacion
{
    public partial class PnUsuario : Form
    {
        public PnUsuario()
        {
            InitializeComponent();
        }
        DataTable tabla = new DataTable();
        static string q, c, registrado,j;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void regis(string a)
        {
            Lgestionusuario v = new Lgestionusuario();
             c = v.d(a);
        }

        private void PnUsuario_Load(object sender, EventArgs e)
        {
            Lgestionusuario eps1 = new Lgestionusuario();
            tabla = eps1.ceps();
        }

        private void cmbeps_Enter(object sender, EventArgs e)
        {
            Lgestionusuario consueps = new Lgestionusuario();
            tabla = consueps.ceps();
            cmbeps.DataSource = tabla;
            cmbeps.ValueMember = "Nom_Eps";
        }

        private void Olvicontra_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("¿Desea registrar una nueva Eps?", "Nueva eps", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    PEps nueva = new PEps();
                    nueva.ShowDialog();
                txtnombre.Focus();
                }
        }

        private void cmbpensiones_Enter(object sender, EventArgs e)
        {
            Lgestionusuario consupension = new Lgestionusuario();
            tabla = consupension.cpensiones();
            cmbpensiones.DataSource = tabla;
            cmbpensiones.ValueMember = "Nom_Pension";
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea registrar un nuevo fondo de pensiones?", "Nueva fondo de pensiones", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
               Pfondodepensiones  nueva = new Pfondodepensiones();
                nueva.ShowDialog();
                txtnombre.Focus();
            }
        }

        private void cmbndestu_Enter(object sender, EventArgs e)
        {
            Lgestionusuario consunestudio = new Lgestionusuario();
            tabla = consunestudio.cnestudio();
            cmbndestu.DataSource = tabla;
            cmbndestu.ValueMember = "Nivel_estudio";
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea registrar un nuevo nivel de estudio?", "Nuevo nivel de estudio", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Pnestudio nueva1 = new Pnestudio();
                nueva1.ShowDialog();
                txtnombre.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Cmbcargo.Text == "" || txtnombre.Text == "" || txtidentificacion.Text == "" || txttelefono.Text == "" || txtdireccion.Text == "" || txtcelular.Text == "" || cmbndestu.Text == "" ||  cmbpensiones.Text == "" || txtemail.Text == "" || cmblicencia.Text == ""||cmbeps.Text == ""|| nusuario.Text == "")
            {
                MessageBox.Show("los campos de usuario deben contener datos", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txttelefono2.Text == "")
            {
                q = "0";
            }
            else
            {
                q = txttelefono2.Text;
            }
            Lgestionusuario regis = new Lgestionusuario();
            string g = regis.a(Cmbcargo.Text, txtnombre.Text, txtidentificacion.Text, txttelefono.Text, txtdireccion.Text, txtcelular.Text, cmbndestu.Text,cmbpensiones.Text, txtemail.Text, cmblicencia.Text, q,registrado,cmbeps.Text,nusuario.Text);
            j = g;
            validacion();
            
        }

        private void txtidentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(null,e);
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(null, e);
        }

        private void txtcelular_TextChanged(object sender, EventArgs e)
        {
        }

        private void txttelefono2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Cmbcargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbndestu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbeps_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmblicencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(null, e);
        }

        private void txttelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(null, e);
        }

        private void cmbpensiones_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void validacion()
        {
            if (j == "1")
            {
                MessageBox.Show("usuario registrado con exito", "Informacion registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cmbcargo.Text = "";
                txtnombre.Text = "" ;
                txtidentificacion.Text = ""; 
                txttelefono.Text = "" ;
                txtdireccion.Text = ""; 
                txtcelular.Text = ""; 
                cmbndestu.Text ="";                 
                cmbpensiones.Text = ""; 
                txtemail.Text ="" ;
                cmblicencia.Text = "";
                txttelefono2.Text = "";
                nusuario.Text = "";
            }
            else
            {
                MessageBox.Show("usuario no registrado", "Informacion registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void N(string usu)
        {
            registrado = usu;
        }


        public void numeros(object sender, KeyPressEventArgs e) {

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

        private void nusuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (validaremail(txtemail.Text))
            {

            }
            else
            {
                MessageBox.Show("direccion de correo electronico no valida", "error de correo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtemail.SelectAll();
                txtemail.Focus();
            }
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
        public static bool validaremail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.']\\w+)*\\.\\w+([-.']\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }   
 }

