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
using System.Reflection;

namespace TextProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String _path;
        private const Int32 BufferSize = 128;
        private String _fontpath = "./SpeculoSans.ttf";

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _path = dialog.FileName;
                try
                {
                    BaseFont custom = BaseFont.CreateFont("./SpeculoSans.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    statusBox.ForeColor = Color.Green;
                    statusBox.Text = "Font Found. Lets Roll";
                    go.BackColor = Color.Green;
                    go.Enabled = true;
                }
                catch
                {
                    statusBox.ForeColor = Color.Red;
                    statusBox.Text = "Oops! Font not Found!";
                }
            }
        }

        private void go_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() {Filter = "PDF File|*.pdf", ValidateNames = true})
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //Custom Font. Need to add checking to see if font can be found.
                        BaseFont custom = BaseFont.CreateFont("./SpeculoSans.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        iTextSharp.text.Font font = new iTextSharp.text.Font(custom, 14);

                        //Initialize Document
                        iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        //doc.Add(new Paragraph("Here is a test of creating a PDF", font));          

                        using (var fs = File.OpenRead(_path))
                        {
                            using (var sr = new StreamReader(fs, Encoding.UTF8, true, BufferSize))
                            {
                                int lineCount = 0;
                                int wordCount = 0;
                                String textLine = "";
                                String line = sr.ReadToEnd();
                                String[] words = line.Split(' ');

                                foreach (string word in words)
                                {
                                    if (textLine.Length >= 102)
                                    {
                                        if (lineCount % 2 != 0)
                                        {
                                            char[] revArray = textLine.ToCharArray();
                                            Array.Reverse(revArray);
                                            doc.Add(new Paragraph(new String(revArray), font));
                                            textLine = "";
                                            textLine += word + " ";
                                            ++lineCount;
                                        }
                                        else
                                        {
                                            doc.Add(new Paragraph(textLine, font));
                                            textLine = "";
                                            textLine += word + " ";
                                            ++lineCount;
                                        }
                                    }
                                    else
                                    {
                                        textLine += word + " ";
                                    }
                                }

                                doc.Close();
                                statusBox.ForeColor = Color.Green;
                                statusBox.Text = "Done! No Detected Issues";
                            }
                        }
                    }
                    catch
                    {
                        statusBox.ForeColor = Color.Red;
                        statusBox.Text = "Errors. But I cant tell you what....";
                    }
                }
            }
        }
    }
}
