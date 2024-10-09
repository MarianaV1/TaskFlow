using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.PdfViewer.Asp;
using Spire.PdfViewer.Forms;

namespace Proyecto_Agenda_RamirezBenjamin_MauricioChad
{
    public partial class VentanaTutorial2 : Form
    {
        public VentanaTutorial2()
        {
            InitializeComponent();
        }

        private void VentanaTutorial2_Load(object sender, EventArgs e)
        {

        }

        private void pdfDocumentViewer1_Click(object sender, EventArgs e)
        {
            string pdfDoc = @"C:\Users\maria\OneDrive\Desktop\Manual_Usuario.pdf";
            if (File.Exists(pdfDoc))
            {
                this.pdfDocumentViewer1.LoadFromFile(pdfDoc);
            }
            else
            {
                MessageBox.Show("El archivo no existe");
            }
        }
    }
}
