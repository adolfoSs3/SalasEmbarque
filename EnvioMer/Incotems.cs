using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;

namespace EnvioMer
{
    public partial class Incotems : Form
    {
        PdfViewer pdf;
        public Incotems()
        {
            InitializeComponent();

            pdf = new PdfViewer();
            pdf.Size = new Size(1000, 1000);
            pdf.Location = new Point(10, 40);

            Controls.Add(pdf);           
            PdfDocument pdfDocument = PdfDocument.Load(Application.StartupPath + "/tabla-europea-incoterms-2020.pdf");
            pdf.Document = pdfDocument;
        }
    }
}
