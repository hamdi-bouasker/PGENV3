using Syncfusion.Pdf.Parsing;
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

namespace PGENV3
{
    public partial class MultiPDFDec : Form
    {
        public MultiPDFDec()
        {
            InitializeComponent();
        }

        GetPathOrExtention gte = new GetPathOrExtention();
        private void DecryptPDFFiles(string fileName)
        {
            //Load the PDF document
            FileStream docStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            PdfLoadedDocument loadedDocument = new PdfLoadedDocument(docStream, TbDecPwd1.Text);
            //Change the user password
            loadedDocument.Security.UserPassword = string.Empty;

            FileStream outputFileStream = new FileStream(gte.GetDirPath(fileName) + "\\" + gte.GetfileName(fileName).Replace("Encrypted-", ""), FileMode.Create, FileAccess.Write);
            //Save the PDF document to file stream.

            loadedDocument.Save(outputFileStream);
            //Close the document
            docStream.Close();
            loadedDocument.Close(true);
            outputFileStream.Close();
        }

        private async Task DecPDFfiles()
        {
            if (TbDecPwd1.Text == "")
            {
                MessageBox.Show("Please insert the password!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            ofd.Multiselect = true;
            var tasks = new List<Task>();

            if (TbDecPwd1.Text != "" && ofd.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Visible = true;

                try
                {
                    foreach (var file in ofd.FileNames)
                    {
                        if (gte.GetFileExtension(file) != ".pdf")
                        {
                            LblProceeding.ResetText();
                            MessageBox.Show("File version is not supported!" + '\n' + '\n' + "Only PDF supported!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (gte.GetFileExtension(file) == ".pdf")
                        {
                            LblProceeding.Text = "Proceeding... Do not exit the software!";
                            var task = Task.Run(() => DecryptPDFFiles(file)).ContinueWith(t => File.Delete(file)).ContinueWith(p => progressBar1.PerformStep());
                            tasks.Add(task);
                        }
                    }

                    await Task.WhenAll(tasks);
                    LblProceeding.Text = "Done!";
                    MessageBox.Show("Files Successfully Decrypted!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LblProceeding.ResetText();
                    progressBar1.Visible = false;

                }

                catch (Exception)
                {
                    LblProceeding.ResetText();
                    MessageBox.Show("Error: Ensure the password is correct!" + '\n' + '\n' + "Ensure the file you want to decrypt is not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void BtnPDFFileDec_Click(object sender, EventArgs e)
        {
            _ = DecPDFfiles();
        }

        private void BtnShowPWD1_Click(object sender, EventArgs e)
        {
            BtnShowPWD1.Visible = false;
            BtnHidePWD1.Visible = true;
            TbDecPwd1.PasswordChar = '\0';
        }

        private void BtnHidePWD1_Click(object sender, EventArgs e)
        {
            BtnShowPWD1.Visible = true;
            BtnHidePWD1.Visible = false;
            TbDecPwd1.PasswordChar = '*';
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
