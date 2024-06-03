using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGENV3
{
    public partial class DecWordFile : Form
    {
        public DecWordFile()
        {
            InitializeComponent();
        }

        GetPathOrExtention gte = new GetPathOrExtention();
        private void DecryptDOCXFile(string fileName)
        {
            FileStream inputStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            WordDocument document = new WordDocument(inputStream, FormatType.Docx, TbDecPwd1.Text);

            //Save the Word document.
            FileStream outputStream = new FileStream(gte.GetDirPath(fileName) + "\\" + gte.GetfileName(fileName).Replace("Encrypted-", ""), FileMode.Create, FileAccess.Write);
            document.Save(outputStream, FormatType.Docx);
            inputStream.Close();
            outputStream.Close();
            document.Close();
        }

        private async Task DecwordFile()
        {
            if (TbDecPwd1.Text == "")
            {
                MessageBox.Show("Please insert the password!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "docx files (*.docx)|*.docx|All files (*.*)|*.*";
            ofd.Multiselect = false;

            if (TbDecPwd1.Text != "" && ofd.ShowDialog() == DialogResult.OK)
            {
                if (gte.GetFileExtension(ofd.FileName) != ".docx")
                {
                    LblProceeding.ResetText();
                    MessageBox.Show("File version is not supported!" + '\n' + '\n' + "Only Word version 2019 and above are supported!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (gte.GetFileExtension(ofd.FileName) == ".docx")
            {
                LblProceeding.Text = "Proceeding... Do not exit the software!";
                var task = Task.Run(() => DecryptDOCXFile(ofd.FileName)).ContinueWith(t => { File.Delete(ofd.FileName); t.Wait(); });
                try
                {
                    await task;
                    LblProceeding.Text = "Done!";
                    MessageBox.Show("File Successfully Encrypted!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LblProceeding.ResetText();
                }

                catch (AggregateException)
                {

                    MessageBox.Show("Ensure the password is correct!" + '\n' + '\n' + "Ensure the files you want to encrypt is not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BtnShowPWD1_Click_1(object sender, EventArgs e)
        {
            BtnShowPWD1.Visible = false;
            BtnHidePWD1.Visible = true;
            TbDecPwd1.PasswordChar = '\0';
        }

        private void BtnHidePWD1_Click_1(object sender, EventArgs e)
        {

            BtnShowPWD1.Visible = true;
            BtnHidePWD1.Visible = false;
            TbDecPwd1.PasswordChar = '*';
        }

        private void BtnWordFileDec_Click_1(object sender, EventArgs e)
        {
            _ = DecwordFile();
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }       
    }
}
