using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Security;


namespace PGENV3
{
    public partial class EncPDFFile : Form
    {
        public EncPDFFile()
        {
            InitializeComponent();
        }

        GetPathOrExtention gte = new GetPathOrExtention();

        private void EncryptPDFFile(string fileName)
        {
            //Load the PDF document.
            FileStream docStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            PdfLoadedDocument document = new PdfLoadedDocument(docStream);

            //Document security.
            PdfSecurity security = document.Security;
            //Specifies key size and encryption algorithm.
            security.KeySize = PdfEncryptionKeySize.Key256Bit;
            security.Algorithm = PdfEncryptionAlgorithm.AES;
            //Specifies encryption option.
            security.EncryptionOptions = PdfEncryptionOptions.EncryptAllContents;
            security.OwnerPassword = TbEncPwd2.Text;
            security.UserPassword = TbEncPwd2.Text;

            FileStream outputFileStream = new FileStream(gte.GetDirPath(fileName) + "\\Encrypted-" + gte.GetfileName(fileName), FileMode.Create, FileAccess.ReadWrite);

            //Save the PDF document to file stream.
            document.Save(outputFileStream);
            document.Close(true);
            docStream.Close();
            outputFileStream.Close();
        }

        private async Task EncPDFfile()
        {
            if (TbEncPwd1.Text != TbEncPwd2.Text || TbEncPwd1.Text == "" && TbEncPwd2.Text == "")
            {
                MessageBox.Show("Please insert the same password!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TbEncPwd1.Text.Length < 8 && TbEncPwd2.Text.Length < 8)
            {
                MessageBox.Show("Minimum password length is 8 characters!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";

            if (TbEncPwd1.Text == TbEncPwd2.Text && ofd.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    if (gte.GetFileExtension(ofd.FileName) == ".pdf")
                    {
                        LblProceeding.Text = "Proceeding... Do not exit the software!";
                        var task = Task.Run(() => EncryptPDFFile(ofd.FileName)).ContinueWith(t => File.Delete(ofd.FileName));
                        await task;
                        if (task.IsCompleted)
                        {
                            LblProceeding.Text = "Done!";
                            MessageBox.Show("File Successfully Encrypted!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LblProceeding.ResetText();
                        }

                    }
                }

                catch (Exception)
                {
                    LblProceeding.ResetText();
                    MessageBox.Show("Error: Ensure the password is correct!" + '\n' + '\n' + "Ensure the file you want to decrypt is not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnShowPWD2_Click(object sender, EventArgs e)
        {
            BtnHidePWD2.Visible = true;
            BtnShowPWD2.Visible = false;
            TbEncPwd2.PasswordChar = '\0';
        }

        private void BtnHidePWD1_Click(object sender, EventArgs e)
        {
            BtnShowPWD1.Visible = true;
            BtnHidePWD1.Visible = false;
            TbEncPwd1.PasswordChar = '*';
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
    }
}
