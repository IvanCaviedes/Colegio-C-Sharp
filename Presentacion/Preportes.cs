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
    public partial class Preportes : Form
    {
        public Preportes()
        {
            InitializeComponent();
        }

        private void Preportes_Load(object sender, EventArgs e)
        {
            this.chart1.Series["Usuarios"].Points.AddXY("Registrados", 33);
            this.chart1.Series["Usuarios"].Points.AddXY("Actalizados", 23);
            this.chart1.Series["Usuarios"].Points.AddXY("inactivados", 10);
            this.chart1.Series["Usuarios"].Points.AddXY("ventas", 70);


            this.chart1.Series["Clientes"].Points.AddXY("Registrados", 70);
            this.chart1.Series["Clientes"].Points.AddXY("Actalizados", 15);
            this.chart1.Series["Clientes"].Points.AddXY("inactivados", 12);
            this.chart1.Series["Clientes"].Points.AddXY("ventas", 130);


            this.chart1.Series["Productos"].Points.AddXY("Registrados", 250);
            this.chart1.Series["Productos"].Points.AddXY("Actalizados", 90);
            this.chart1.Series["Productos"].Points.AddXY("inactivados", 30);
            this.chart1.Series["Productos"].Points.AddXY("ventas", 300);


            this.chart1.Series["Proveedores"].Points.AddXY("Registrados", 12);
            this.chart1.Series["Proveedores"].Points.AddXY("Actalizados", 20);
            this.chart1.Series["Proveedores"].Points.AddXY("inactivados", 30);
            this.chart1.Series["Proveedores"].Points.AddXY("ventas", 40);
        }
    }
}
