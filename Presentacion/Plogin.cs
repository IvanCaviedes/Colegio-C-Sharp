using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Logica;

namespace Presentacion
{
    public partial class Plogin : Form
    {
        public Plogin()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //muestra la hora

            label6.Text = DateTime.Now.ToShortTimeString();
            //label6.Location = new Point(12, 351);
            //label6.Location = new Point(-2, 351);
          
            //muestra la fecha

            label7.Text = DateTime.Now.ToLongDateString();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //activa el timer de la hora 

            timer1.Enabled = true; 
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicacion?", "!ALERTA¡", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //cierra el proyecto

                Application.Exit();
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                //muestra la contraseña

                TxtContraseña.UseSystemPasswordChar = false;

            }
            else
            {
                //esconde la contraseña

                TxtContraseña.UseSystemPasswordChar = true; 
            }
        }

       

        private void botonlogin_Click(object sender, EventArgs e)
        { 
            //instancia y saca el tipo de usuario

           Llogin usu = new Llogin(); 
           string a = usu.tipou(Txtusuario.Text);

            //instancia y saca el nombre 
            Llogin num = new Llogin();
            string b = num.name(Txtusuario.Text);
           

            //valida que los datos no esten vacios 

            if (Txtusuario.Text == "" || TxtContraseña.Text == "")
            {
                //mensaje de alerta de espacios vacios

                MessageBox.Show("los campos de usuario deben contener datos", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {                           
                //instancia de clase login

                Llogin acceder = new Llogin();  
                int r = acceder.validar(Txtusuario.Text, TxtContraseña.Text);

                //instancia el siguiente formulario, datos correctos

                if (r == 1)
                {
                    Pmenu menu = new Pmenu();                   
                    menu.x(b,Txtusuario.Text,a);
                    menu.Show();
                    Pnclientes regis = new Pnclientes();
                    regis.registrado_por(Txtusuario.Text);
                    Pnproveedor regis1 = new Pnproveedor();
                    regis1.registradoa(Txtusuario.Text);
                    Pnproductos regis2 = new Pnproductos();
                    regis2.registradoa(Txtusuario.Text);
                    Pventas regis3 = new Pventas();
                    regis3.registrado_por(Txtusuario.Text);
                    ActuProducto regis4 = new ActuProducto();
                    regis4.cargo(a);
                    Pclientes regis5 = new Pclientes();
                    regis5.cargo(a);
                    Pproveedores regis6 = new Pproveedores();
                    regis6.cargo(a);
                    Pproductos regis7 = new Pproductos();
                    regis7.cargo(a);

                    this.Hide();
                }
                //mensaje de error, datos correctos

                else if (r == 0)
                {
                    MessageBox.Show("Error de ingreso, intente de nuevo", "Validación de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txtusuario.Text = "";
                    Txtusuario.Focus();
                    TxtContraseña.Text = "";
                }
                //error de servidor

                else if (r == 2)
                {
                    MessageBox.Show("Error de acceso, el servidor no es accesible", "Validación de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error); //sin coneccion al servidor
                    Txtusuario.Focus();

                }  
            }
        }

        private void Olvicontra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boton no habilitado", "Informe de Avance", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        //validar caracteres en los texbox

        private void Txtusuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtContraseña_KeyPress_1(object sender, KeyPressEventArgs e)
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
        }
        //valida el boton enter 
        private void Txtusuario_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                botonlogin_Click(null, e);
            }
        }

        private void TxtContraseña_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                botonlogin_Click(null, e);
            }
        }
    }
}
        
    


