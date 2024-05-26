using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGENV3
{
    public partial class MultiPDFEnc : Form
    {
        public MultiPDFEnc()
        {
            InitializeComponent();
        }

        GetPathOrExtention gte = new GetPathOrExtention();
        private void EncryptPDFFile(string fileName)
        {
            FileStream docStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            PdfLoadedDocument document = new PdfLoadedDocument(docStream);

            PdfSecurity security = document.Security;
            
            security.KeySize = PdfEncryptionKeySize.Key256Bit;
            security.Algorithm = PdfEncryptionAlgorithm.AES;
          
            security.EncryptionOptions = PdfEncryptionOptions.EncryptAllContents;
            security.OwnerPassword = TbEncPwd2.Text;
            security.UserPassword = TbEncPwd2.Text;

            FileStream outputFileStream = new FileStream(gte.GetDirPath(fileName) + "\\Encrypted-" + gte.GetfileName(fileName), FileMode.Create, FileAccess.ReadWrite);

            document.Save(outputFileStream);           
            docStream.Close();
            outputFileStream.Close();
            document.Close();
        }
        private async Task EncPDFfile()
        {
            if (TbEncPwd1.Text != TbEncPwd2.Text)
            {
                MessageBox.Show("Please insert the same password!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TbEncPwd1.Text == "" && TbEncPwd2.Text == "")
            {
                MessageBox.Show("Please enter a password!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TbEncPwd1.Text.Length < 8 && TbEncPwd2.Text.Length < 8)
            {
                MessageBox.Show("Minimum password length is 8 characters!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            ofd.Multiselect = true;
            var tasks = new List<Task>();

            if (TbEncPwd1.Text == TbEncPwd2.Text && ofd.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Visible = true;

                try
                {
                    foreach (string file in ofd.FileNames)
                    {
                        if (gte.GetFileExtension(file) != ".pdf")
                        {
                            LblProceeding.ResetText();
                            MessageBox.Show("Please select PDF files only!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (gte.GetFileExtension(file) == ".pdf")
                        {                           
                            LblProceeding.Text = "Proceeding... Do not exit the software!";
                            var task = Task.Run(() => EncryptPDFFile(file)).ContinueWith(t => File.Delete(file)).ContinueWith(p => progressBar1.PerformStep());
                            tasks.Add(task);                            
                        }
                    }

                    await Task.WhenAll(tasks);
                    LblProceeding.Text = "Done!";
                    MessageBox.Show("Files Successfully Encrypted!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LblProceeding.ResetText();
                    progressBar1.Visible = false;
                }

                catch (Exception)
                {
                    LblProceeding.ResetText();
                    MessageBox.Show("Ensure the password is correct!" + '\n' + '\n' + "Ensure the files you want to encrypt are not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void BtnPDFFileEnc_Click(object sender, EventArgs e)
        {
            _ = EncPDFfile();
        }
        private void BtnShowPWD1_Click(object sender, EventArgs e)
        {
            BtnShowPWD1.Visible = false;
            BtnHidePWD1.Visible = true;
            TbEncPwd1.PasswordChar = '\0';
        }
        private void BtnHidePWD1_Click(object sender, EventArgs e)
        {
            BtnShowPWD1.Visible = true;
            BtnHidePWD1.Visible = false;
            TbEncPwd1.PasswordChar = '*';
        }
        private void BtnShowPWD2_Click(object sender, EventArgs e)
        {
            BtnHidePWD2.Visible = true;
            BtnShowPWD2.Visible = false;
            TbEncPwd2.PasswordChar = '\0';
        }
        private void BtnHidePWD2_Click(object sender, EventArgs e)
        {
            BtnHidePWD2.Visible = false;
            BtnShowPWD2.Visible = true;
            TbEncPwd2.PasswordChar = '*';
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TbEncPwd1_MouseDown(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Minimum password length is 8 characters!", TbEncPwd1);
        }
        private void TbEncPwd2_MouseDown(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Minimum password length is 8 characters!", TbEncPwd2);
        }
    }
}
