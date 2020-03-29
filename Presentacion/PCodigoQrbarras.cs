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
    public partial class PCodigoQrbarras : Form
    {
        public PCodigoQrbarras()
        {
            InitializeComponent();
        }
        string a;
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void nombre(string producto)
        {
            a = producto;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {

            }
            else if (comboBox1.Text == "Qr")
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(br.Write(a), 479, 372);
                pictureBox1.Image = bm;
            }
            else
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.CODE_128;
                Bitmap bm = new Bitmap(br.Write(a), 479, 372);
                pictureBox1.Image = bm;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Seleccione algun codigo");
            }
            else
            { 

                if (comboBox1.Text == "Qr")
                {
                    SaveFileDialog sfd = new SaveFileDialog()
                    {
                        Filter = "Imagen png|*.png",
                        InitialDirectory = @"C:\Users\ivanc\Desktop\codigos\Qr"
                    };
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image.Save(sfd.FileName);
                        this.Close();
                    }
                }
                else
                {
                    SaveFileDialog sfd = new SaveFileDialog()
                    {
                        Filter = "Imagen png|*.png",
                        InitialDirectory = @"C:\Users\ivanc\Desktop\codigos\Barras"
                    };
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image.Save(sfd.FileName);
                        this.Close();
                    }
                }
            }
        }

        private void PCodigoQrbarras_Load(object sender, EventArgs e)
        {
            label3.Text = a;
        }
    }
}
