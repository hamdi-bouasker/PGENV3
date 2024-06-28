using Syncfusion.Pdf.Parsing;
using System;
using System.Collections.Generic;
using System.IO;
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
            FileStream docStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            PdfLoadedDocument loadedDocument = new PdfLoadedDocument(docStream, TbDecPwd1.Text);
           
            loadedDocument.Security.UserPassword = string.Empty;

            FileStream outputFileStream = new FileStream(gte.GetDirPath(fileName) + "\\" + gte.GetfileName(fileName).Replace("Encrypted-", ""), FileMode.Create, FileAccess.Write);
           
            loadedDocument.Save(outputFileStream);          
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
            var tasks1 = new List<Task>();
            var tasks2 = new List<Task>();
            //var tasks3 = new List<Task>();

            if (TbDecPwd1.Text != "" && ofd.ShowDialog() == DialogResult.OK)
            {                
               
                foreach (var file in ofd.FileNames)
                {
                    if (gte.GetFileExtension(file) != ".pdf")
                    {
                        LblProceeding.ResetText();
                        MessageBox.Show("Please select PDF files only!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (gte.GetFileExtension(file) == ".pdf")
                    {
                        var task1 = Task.Run(() => DecryptPDFFiles(file));
                        var task2 = task1.ContinueWith(t => File.Delete(file));
                        //var task3 = task2.ContinueWith(t => LBLfileNames.Text = file);
                        tasks1.Add(task1);
                        tasks2.Add(task2);
                        //tasks3.Add(task3);
                    }
                }
            }

            try
            {
                LblProceeding.Text = "Proceeding...Do not exit the software!";
                await Task.WhenAll(tasks1);
                LblProceeding.Text = "Decrypting the files...";
                await Task.Delay(1000);
                await Task.WhenAll(tasks2);
                LblProceeding.Text = "Almost done...";
                await Task.Delay(1000);
                //await Task.WhenAll(tasks3);
                LblProceeding.Text = "Done!";
                MessageBox.Show("Files Successfully Decrypted!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LblProceeding.ResetText();
                //LBLfileNames.ResetText();
            }

            catch (AggregateException)
            {
                MessageBox.Show("Ensure the password is correct!" + '\n' + '\n' + "Ensure the files you want to decrypt are not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LblProceeding.ResetText();
                //LBLfileNames.ResetText();
                return;
            }

            catch (Exception)
            {
                MessageBox.Show("Ensure the password is correct!" + '\n' + '\n' + "Ensure the files you want to decrypt are not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LblProceeding.ResetText();
                //LBLfileNames.ResetText();
                return;
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
