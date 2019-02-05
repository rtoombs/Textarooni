using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace TextProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String _path;
        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _path = dialog.FileName;
            }
        }

        private void go_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() {Filter = "PDF File|*.pdf", ValidateNames = true})
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //
                    String fontpath = @"C:/Users/ridid44/Desktop/";
                    BaseFont custom = BaseFont.CreateFont(fontpath + "SpeculoSans.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(custom, 12);

                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    
                    doc.Open();
                    doc.Add(new Paragraph("Here is a test of creating a PDF", font));
                    doc.Close();
                }
            }
        }
    }
}
