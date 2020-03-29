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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DataSet Nuevo;

        private void Form1_Load(object sender, EventArgs e)
        {
            CrystalReport1 Imprimir = new CrystalReport1();
            Imprimir.SetDataSource(Nuevo);
            crystalReportViewer1.ReportSource = Imprimir;
        }
    }
}
