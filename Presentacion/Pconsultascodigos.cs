using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;

namespace Presentacion
{
    public partial class Pconsultascodigos : Form
    {
        public Pconsultascodigos()
        {
            InitializeComponent();
        }
        string texto;
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Imagen png|*.png",
                InitialDirectory = @"C:\Users\ivanc\Desktop\codigos"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(ofd.FileName);
                BarcodeReader br = new BarcodeReader();
                texto = br.Decode((Bitmap)pictureBox2.Image).ToString();
            }
            dato();
            this.Close();
        }
        public string dato()
        {
            return texto;
        }
    }
}
