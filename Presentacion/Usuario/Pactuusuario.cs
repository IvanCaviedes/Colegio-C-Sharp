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
    public partial class Pactuusuario : Form
    {
        public Pactuusuario()
        {
            InitializeComponent();
        }
        DataTable tabla = new DataTable();
        string  c,ne, de,t1e,t2e,cele,epe,nese,fpense,emaile,liscone,nusue,cargoe,q,estadoe;

        private void cmblicencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbpensiones_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Cmbcargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void txtidentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void txtcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
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

        private void txttelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbestado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbeps_Enter_1(object sender, EventArgs e)
        {
            Lgestionusuario consueps = new Lgestionusuario();
            tabla = consueps.ceps();
            cmbeps.DataSource = tabla;
            cmbeps.ValueMember = "Nom_Eps";
        }

        private void cmbndestu_Enter(object sender, EventArgs e)
        {
            Lgestionusuario consunestudio = new Lgestionusuario();
            tabla = consunestudio.cnestudio();
            cmbndestu.DataSource = tabla;
            cmbndestu.ValueMember = "Nivel_estudio";
        }

        private void cmbpensiones_Enter(object sender, EventArgs e)
        {
            Lgestionusuario consupension = new Lgestionusuario();
            tabla = consupension.cpensiones();
            cmbpensiones.DataSource = tabla;
            cmbpensiones.ValueMember = "Nom_Pension";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea registrar un nuevo fondo de pensiones?", "Nueva fondo de pensiones", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Pfondodepensiones nueva = new Pfondodepensiones();
                nueva.ShowDialog();
                txtnombre.Focus();
            }
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

        private void Olvicontra_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea registrar una nueva Eps?", "Nueva eps", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                PEps nueva = new PEps();
                nueva.ShowDialog();
                txtnombre.Focus();
            }
        }

        private void btnacualizar_Click(object sender, EventArgs e)
        {
            if (Cmbcargo.Text == "" || txtnombre.Text == "" || txtidentificacion.Text == "" || txttelefono.Text == "" || txtdireccion.Text == "" || txtcelular.Text == "" || cmbndestu.Text == "" || cmbeps.Text == "" || cmbpensiones.Text == "" || txtemail.Text == "" || cmblicencia.Text == "" || nusuario.Text == "")
            {
                MessageBox.Show("los campos de usuario deben contener datos", "Error de actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txttelefono2.Text == "")
            {
                q = "0";
            }
            else
            {
                q = txttelefono2.Text;
            }
            Lgestionusuario actu = new Lgestionusuario();
            string g = actu.M(txtidentificacion.Text, txtnombre.Text, txtdireccion.Text, txttelefono.Text, q, txtcelular.Text, cmbeps.Text, cmbndestu.Text, cmbpensiones.Text, txtemail.Text, cmblicencia.Text, nusuario.Text, Cmbcargo.Text, cmbestado.Text);

            if (g == "1")
            {
                MessageBox.Show("usuario actualizado con exito", "Informacion de actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("usuario no actualizado", "Informacion de actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void actualizar(string ce, string n, string d, string t1, string t2, string cel, string ep, string nes, string fpens, string email, string liscon, string nusu, string cargo,string estado)
        {
            c = ce;
            ne = n;
            de = d;
            t1e = t1;
            t2e = t2;
            cele = cel;
            epe = ep;
            nese = nes;
            fpense = fpens;
            emaile = email;
            liscone = liscon;
            nusue = nusu;
            cargoe = cargo;
            estadoe = estado;
        }

        private void Pactuusuario_Load(object sender, EventArgs e)
        {
            if (estadoe == "a" || estadoe == "A")
            {
                cmbestado.Text = "Activo";
            }
            else if (estadoe == "i" || estadoe == "I")
            {
                cmbestado.Text = "Inactivo";
            }


            if (cargoe == "admi")
            {
                Cmbcargo.Text = "Administrador";
            }
            else if (cargoe == "caje")
            {
                Cmbcargo.Text = "Cajero";
            }
            else
            {
                Cmbcargo.Text = "Domiciliario";
            }


            if (liscone == "0")
            {
                cmblicencia.Text = "No";
            }
            else
            {
                cmblicencia.Text = "Si";
            }

            if (t2e == "0")
            {
                txttelefono2.Text = "";
            }
            else
            {
                txttelefono2.Text = t2e ;
            }

            cmbeps.Text = epe;
            txtidentificacion.Text = c;
            txtcelular.Text = cele;
            txtdireccion.Text = de;
            txtemail.Text = emaile;
            txtnombre.Text = ne;
            txttelefono.Text = t1e;
            cmbpensiones.Text = fpense;
            cmbndestu.Text = nese;
            cmbpensiones.Text = fpense;
            nusuario.Text = nusue;

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
