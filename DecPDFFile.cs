using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using System;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Security;

namespace PGENV3
{
    public partial class DecPDFFile : Form
    {
        public DecPDFFile()
        {
            InitializeComponent();
        }

        GetPathOrExtention gte = new GetPathOrExtention();

        private void DecryptPDFFile(string fileName)
        {           
            FileStream docStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            PdfLoadedDocument loadedDocument = new PdfLoadedDocument(docStream, TbDecPwd1.Text);
            
            loadedDocument.Security.UserPassword = string.Empty;

            FileStream outputFileStream = new FileStream(gte.GetDirPath(fileName) + "\\" + gte.GetfileName(fileName).Replace("Encrypted-", ""), FileMode.Create, FileAccess.Write);           

            loadedDocument.Save(outputFileStream);
      
            docStream.Close();
            loadedDocument.Close();
            outputFileStream.Close();
        }

        private async Task DecPDFfile()
        {
            if (TbDecPwd1.Text == "")
            {
                MessageBox.Show("Please insert the password!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            ofd.Multiselect = false;

            if (TbDecPwd1.Text != "" && ofd.ShowDialog() == DialogResult.OK)
            {
                if (gte.GetFileExtension(ofd.FileName) != ".pdf")
                {
                    LblProceeding.ResetText();
                    MessageBox.Show("File version is not supported!" + '\n' + '\n' + "Only PDF supported!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (gte.GetFileExtension(ofd.FileName) == ".pdf")
                {
                    LblProceeding.Text = "Proceeding...Do not exit the software!";
                    var task = Task.Run(() => DecryptPDFFile(ofd.FileName)).ContinueWith(t => { File.Delete(ofd.FileName); t.Wait(); });
                    try
                    {
                        await task;
                        LblProceeding.Text = "Done!";
                        MessageBox.Show("File Successfully Encrypted!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LblProceeding.ResetText();
                    }

                    catch (AggregateException)
                    {

                        MessageBox.Show("Ensure the password is correct!" + '\n' + '\n' + "Ensure the file you want to encrypt is not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LblProceeding.ResetText();
                        return;
                    }

                    catch (Exception)
                    {
                        LblProceeding.ResetText();
                        MessageBox.Show("Ensure the password is correct!" + '\n' + '\n' + "Ensure the file you want to encrypt is not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        } 
        private void BtnPDFFileDec_Click(object sender, System.EventArgs e)
        {
            _ = DecPDFfile();
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
