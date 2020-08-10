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
using System.Security;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDF_Page_Deleter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeOpenFileDialog();

        }

        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.openFileDialog1.Filter =
                "PDFs (*.PDF)|*.PDF|" +
                "All files (*.*)|*.*";

            //  Allow the user to select multiple images.
            this.openFileDialog1.Multiselect = true;
            //                   ^  ^  ^  ^  ^  ^  ^

            this.openFileDialog1.Title = "PDFs to Remove a Page From";
        }


        private void butSelectPDFs_Click(object sender, EventArgs e)
        {
            int start = 0;
            int end = 0;

            // Validate the Page ranges.
            try
            {
                start = Int32.Parse(tbStartPage.Text);
                end = Int32.Parse(tbEndPage.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get start and end page numbers.  Please make sure they are numbers and try again." + ex.Message);
                return;
            }

            if (start <= 0 || end <= 0 || end < start)
            {
                MessageBox.Show(
                    "Something is wrong with the page numbers.  They can not be negative, and start must be less than or equal to end.");
                return;
            }


            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                
                string dirPath = Path.GetDirectoryName(openFileDialog1.FileNames[0]);
                dirPath = dirPath + "\\processed";
                try
                {
                    Directory.CreateDirectory(dirPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to create output directory: " + dirPath + "  Exception: " + ex.Message);
                    return;
                }
                

                // Read the files
                foreach (String file in openFileDialog1.FileNames)
                {
                    // Process each PDF.
                    try
                    {
                        MessageBox.Show("Processing File: " + file);
                        string fileName = Path.GetFileName(file);
                        string outputPath = dirPath + "\\" + fileName;

                        // Open the PDF file.
                        PdfDocument inputDocument = PdfReader.Open(file, PdfDocumentOpenMode.Import);
                        PdfDocument outputDocument = new PdfDocument();

                        int pageCount = inputDocument.PageCount;
                        for (int i = 0; i < pageCount; i++)
                        {
                            if (i < (start - 1) || i > (end - 1))
                            {
                                PdfPage page = inputDocument.Pages[i];
                                outputDocument.AddPage(page);
                            }
                        }

                        // output the new PDF
                        outputDocument.Save(outputPath);
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                                        "Error message: " + ex.Message + "\n\n" +
                                        "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot process the pdf: " + file.Substring(file.LastIndexOf('\\'))
                                                                     + ". You may not have permission to read the file, or " +
                                                                     "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
