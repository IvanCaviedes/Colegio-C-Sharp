using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class Pmenu : Form
    {

        public Pmenu()
        {
            InitializeComponent();
        }
        static string usu;

        //codigo para abrir dormulario en un panel
        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }

        private void mostrarlogo()
        {
            //llamar formilario para mostrar logo
            AbrirFormInPanel(new Plogo());
        }
        private void mostrarlogoAlCerrarForm(object sender, FormClosedEventArgs e)
        {
            mostrarlogo();
        }
        //metodo de validacion de usuario
        public void x(string a,string b,string c)
        {
            usu = c; //guarda en una variable global el nombre de usuario
            Lgestionusuario ge = new Lgestionusuario(); //instancia lgestionusuario
            string q = ge.d(b);//recibe al cedula del usuario y sobrecarga 
            PnUsuario reg = new PnUsuario(); //instancia pnusuario
            reg.N(q);//envia la cedula del usuaio al metodod n de pnusuario

            if (c == "admi") //valida tipo de usuario y 
            {
                
                Usuario.Text = "Administrador";
                LogAdm.Visible = true;
                label7.Text = a;
                label6.Text = b;
                label4.Text = "Administrador";
                coheadm.Visible = true;
                admi.Visible = true;
            }
            else if(c=="caje")
                
             {
                Usuario.Text = "Cajero";
                Logcajero.Visible = true;
                label7.Text = a;
                label6.Text = b;
                label4.Text = "Cajero";
                coheCjero.Visible = true;
                caje.Visible = true;
                //cambia de color los controles principales
                BarraTitulo.BackColor = Color.FromArgb(192, 189, 125);
                panel1.BackColor = Color.FromArgb(138, 131, 98);
                panelMenu.BackColor = Color.FromArgb(89, 87, 65);
                //inabilita botones
                btnUsuarios.Enabled = false;
                //color del boton
                btnreportes.Normalcolor = Color.FromArgb(138, 131, 98);
                btnClientes.Normalcolor = Color.FromArgb(138, 131, 98);
                btnVentas.Normalcolor = Color.FromArgb(138, 131, 98);
                btnProductos.Normalcolor = Color.FromArgb(138, 131, 98);
                btnDomicilios.Normalcolor = Color.FromArgb(138, 131, 98);
                btnfacproveedor.Normalcolor = Color.FromArgb(138, 131, 98);
                btnProveedores.Normalcolor = Color.FromArgb(138, 131, 98);
                btnlugar.Normalcolor = Color.FromArgb(138, 131, 98);
                //color de animacion
                btnreportes.OnHovercolor = Color.FromArgb(192, 189, 125);
                btnClientes.OnHovercolor = Color.FromArgb(192, 189, 125);
                btnVentas.OnHovercolor = Color.FromArgb(192, 189, 125);
                btnProductos.OnHovercolor = Color.FromArgb(192, 189, 125);
                btnDomicilios.OnHovercolor = Color.FromArgb(192, 189, 125);
                btnfacproveedor.OnHovercolor = Color.FromArgb(192, 189, 125);
                btnProveedores.OnHovercolor = Color.FromArgb(192, 189, 125);
                btnlugar.OnHovercolor = Color.FromArgb(192, 189, 125);
                //boton activo
                btnreportes.Activecolor = Color.FromArgb(192, 189, 125);
                btnClientes.Activecolor = Color.FromArgb(192, 189, 125);
                btnVentas.Activecolor = Color.FromArgb(192, 189, 125);
                btnProductos.Activecolor = Color.FromArgb(192, 189, 125);
                btnDomicilios.Activecolor = Color.FromArgb(192, 189, 125);
                btnfacproveedor.Activecolor = Color.FromArgb(192, 189, 125);
                btnProveedores.Activecolor = Color.FromArgb(192, 189, 125);
                btnlugar.Activecolor = Color.FromArgb(192, 189, 125);
            }
            else if(c=="domi")
            {
                Usuario.Text = "Domiciliario";
                Logdomiciliario.Visible = true;
                label7.Text = a;
                label6.Text = b;
                label4.Text = "Domiciliario";
                cohedomicili.Visible = true;
                domi.Visible = true;
                //cambia de color los controles principales
                BarraTitulo.BackColor = Color.FromArgb(150, 197, 188);
                panel1.BackColor = Color.FromArgb(99, 129, 125);
                panelMenu.BackColor = Color.FromArgb(66, 87, 76);
                //inabilita botones
                btnUsuarios.Enabled = false;
                btnProveedores.Enabled = false;
                btnfacproveedor.Enabled = false;
                //color del boton
                btnreportes.Normalcolor = Color.FromArgb(99, 129, 125);
                btnClientes.Normalcolor = Color.FromArgb(99, 129, 125);
                btnVentas.Normalcolor = Color.FromArgb(99, 129, 125);
                btnProductos.Normalcolor = Color.FromArgb(99, 129, 125);
                btnDomicilios.Normalcolor = Color.FromArgb(99, 129, 125);
                btnfacproveedor.Normalcolor = Color.FromArgb(99, 129, 125);
                btnProveedores.Normalcolor = Color.FromArgb(99, 129, 125);
                btnlugar.Normalcolor = Color.FromArgb(99, 129, 125);
                //color de animacion
                btnreportes.OnHovercolor = Color.FromArgb(150, 197, 188);
                btnClientes.OnHovercolor = Color.FromArgb(150, 197, 188);
                btnVentas.OnHovercolor = Color.FromArgb(150, 197, 188);
                btnProductos.OnHovercolor = Color.FromArgb(150, 197, 188);
                btnDomicilios.OnHovercolor = Color.FromArgb(150, 197, 188);
                btnfacproveedor.OnHovercolor = Color.FromArgb(150, 197, 188);
                btnProveedores.OnHovercolor = Color.FromArgb(150, 197, 188);
                btnlugar.OnHovercolor = Color.FromArgb(150, 197, 188);
                //boton activo
                btnreportes.Activecolor = Color.FromArgb(150, 197, 188);
                btnClientes.Activecolor = Color.FromArgb(150, 197, 188);
                btnVentas.Activecolor = Color.FromArgb(150, 197, 188);
                btnProductos.Activecolor = Color.FromArgb(150, 197, 188);
                btnDomicilios.Activecolor = Color.FromArgb(150, 197, 188);
                btnfacproveedor.Activecolor = Color.FromArgb(150, 197, 188);
                btnProveedores.Activecolor = Color.FromArgb(150, 197, 188);
                btnlugar.Activecolor = Color.FromArgb(150, 197, 188);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //muestra la hora

            lblHora.Text = DateTime.Now.ToShortTimeString();

            //muestra la fecha

            lbFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Pmenu_Load(object sender, EventArgs e)
        {
            //activa el timer de la hora 

            timer1.Enabled = true;
            AbrirFormInPanel(new Plogo());
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?","Cerrar aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //cierra el proyecto

                Application.Exit();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //efecto del menu

            if (panelMenu.Width == 249)
            {
                this.tmOcultarMenu.Enabled = true;
            }
            else if (panelMenu.Width == 53)
                this.tmMostrarMenu.Enabled = true;
        }


        private void tmOcultarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 53)
            {
                this.tmOcultarMenu.Enabled = false;
            }
            else
            {
                panelMenu.Width = panelMenu.Width - 49;
            
            }
        }

        private void tmMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 249)
            {
                this.tmMostrarMenu.Enabled = false;
            }
            else
            {
                panelMenu.Width = panelMenu.Width + 49;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //minimiza el proyecto

            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //cierra cesion
                Plogin cerrarcesion = new Plogin(); 
                cerrarcesion.Show();
                this.Hide();
            }
        }
        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            mostrarlogo();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

            pusuarios frm = new pusuarios();
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormInPanel(frm);
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            Preportes frq = new Preportes();
            frq.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormInPanel(frq);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Pclientes frw = new Pclientes();
            frw.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormInPanel(frw);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Pventas fre = new Pventas();
            fre.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormInPanel(fre);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Pproductos frr = new Pproductos();
            frr.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormInPanel(frr);
        }

        private void btnDomicilios_Click(object sender, EventArgs e)
        {
         PnDomicilios frt = new PnDomicilios();
            frt.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormInPanel(frt);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Pproveedores fry = new Pproveedores();
            fry.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormInPanel(fry);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            PnFProveedor fru = new PnFProveedor();
            fru.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormInPanel(fru);
        }

        private void btnlugar_Click(object sender, EventArgs e)
        {
            maps fru = new maps();
            fru.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormInPanel(fru);
        }
    }
        }
        


