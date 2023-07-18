using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Office.Interop.Word;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using Xceed.Words.NET;
using Spire.Pdf;
using org.apache.pdfbox.pdmodel.fdf;
using com.sun.corba.se.spi.orbutil.threadpool;
using Word = Microsoft.Office.Interop.Word;

namespace vongquay
{
    public partial class Form1 : Form
    {
        int option, optionC;
        Microsoft.Office.Interop.Word.Document wordDoc { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void browser1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = @"All Files|*.*";
            openFileDialog1.FileName = "";
            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                Savet1.Text= System.IO.Path.GetFullPath(openFileDialog1.FileName);
            }
        }
        private void convert1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            if (option == 1)
            {
                string temp = Savet1.Text.Replace(".docx", ".pdf");
                string urlSave = Savet2.Text + "/" + Path.GetFileName(temp);
                wordDoc = app.Documents.Open(Savet1.Text);
                wordDoc.ExportAsFixedFormat(urlSave, Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                wordDoc.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);
                app.Quit();
                Marshal.ReleaseComObject(wordDoc);
                Marshal.ReleaseComObject(app);
                if (File.Exists(Path.GetFileName(temp)) == true)
                {
                    Process.Start(Path.GetFileName(temp));
                }
            }
            else
            {
                string urlOpen = Savet1.Text.Replace(".pdf", ".docx");
                string urlSave = Savet2.Text + "/" + Path.GetFileName(urlOpen);
                PdfDocument obj = new PdfDocument();
                obj.LoadFromFile(Savet1.Text);
                obj.SaveToFile(urlSave, FileFormat.DOCX);
               if(File.Exists(Path.GetFileName(urlSave)) == true)
                {
                    Process.Start(Path.GetFileName(urlSave));
                }

            }
        }

        public static void Merge(string[] filesToMerge, string outputFilename, bool insertPageBreaks, string documentTemplate)
        {
            object defaultTemplate = documentTemplate;
            object missing = System.Type.Missing;
            object pageBreak = Word.WdBreakType.wdSectionBreakNextPage;
            object outputFile = outputFilename;

            // Create a new Word application
            Word._Application wordApplication = new Word.Application();

            try
            {
                // Create a new file based on our template
                Word.Document wordDocument = wordApplication.Documents.Add(
                                              ref missing
                                            , ref missing
                                            , ref missing
                                            , ref missing);

                // Make a Word selection object.
                Word.Selection selection = wordApplication.Selection;

                //Count the number of documents to insert;
                int documentCount = filesToMerge.Length;

                //A counter that signals that we shoudn't insert a page break at the end of document.
                int breakStop = 0;

                // Loop thru each of the Word documents
                foreach (string file in filesToMerge)
                {
                    breakStop++;
                    // Insert the files to our template
                    selection.InsertFile(
                                                file
                                            , ref missing
                                            , ref missing
                                            , ref missing
                                            , ref missing);

                    //Do we want page breaks added after each documents?
                    if (insertPageBreaks && breakStop != documentCount)
                    {
                        selection.InsertBreak(ref pageBreak);
                    }
                }

                // Save the document to it's output file.
                wordDocument.SaveAs(
                                ref outputFile
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing
                            , ref missing);

                // Clean up!
                wordDocument = null;
            }
            catch (Exception ex)
            {
                //I didn't include a default error handler so i'm just throwing the error
                throw ex;
            }
            finally
            {
                // Finally, Close our Word application
                wordApplication.Quit(ref missing, ref missing, ref missing);
            }
        }
    

    private void save1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Savet2.Text = dialog.SelectedPath;
            }
        }

        private void optionWtP_CheckedChanged(object sender, EventArgs e)
        {
            option = 1;
            label1.Text = "Word to PDF";
        }

        private void optionPtW_CheckedChanged(object sender, EventArgs e)
        {
            option= 2;
            label1.Text = "PDF to Word";
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            panelCombine.Visible = false;
            panelConvert.Visible = true;
        }

        private void button_Combine_Click(object sender, EventArgs e)
        {
            panelConvert.Visible = false;
            panelCombine.Visible = true;
            
        }

        private void optionP_CheckedChanged(object sender, EventArgs e)
        {
            optionC = 2;
            label2.Text = "Combine PDF";
        }

        private void inputCBPaths_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = @"All Files|*.*";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Savet1.Text = System.IO.Path.GetFullPath(openFileDialog1.FileName);
            }
        }

        private void optionW_CheckedChanged(object sender, EventArgs e)
        {
            optionC = 1;
            label2.Text = "Combine Word";
        }
    }
}
