using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class maps : Form
    {
        public maps()
        {
            InitializeComponent();
        }
        string direccion2;
        string di = "Cra. +136+%23136a-12, Bogotá";

        private void maps_Load(object sender, EventArgs e)
        {
            StringBuilder ubicacion = new StringBuilder();
            ubicacion.Append("https://www.google.com/maps/dir/" + di + "/" + direccion2);
            webBrowser1.Navigate(ubicacion.ToString());
        }
        public void direccion(string dir)
        {
            direccion2 = dir;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
