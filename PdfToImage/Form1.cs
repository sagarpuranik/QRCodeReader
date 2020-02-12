using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Pdf;

namespace PdfToImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument(txtPath.Text);

            for (int i = 0; i < document.Pages.Count; i++)
            {
                Image bmp = document.SaveAsImage(i);

                bmp.Save("converted\\" + i + ".bmp", ImageFormat.Bmp);
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPath_MouseUp(object sender, MouseEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF|*.pdf";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofd.FileName;
            }
        }
    }
}
