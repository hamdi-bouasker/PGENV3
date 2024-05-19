using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;


namespace PGENV3
{
    public partial class EncWordFile : Form
    {
        public EncWordFile()
        {
            InitializeComponent();
        }

        GetPathOrExtention gte = new GetPathOrExtention();
        private void EncryptDOCXFile(string fileName)
        {
            
            // Load an existing Word document.
            FileStream inputStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            WordDocument document = new WordDocument(inputStream, FormatType.Docx);

            // Encrypt the Word document with a password.
            document.EncryptDocument(TbEncPwd2.Text);

            // Save the encrypted Word document.
            FileStream outputStream = new FileStream(gte.GetDirPath(fileName) + "\\Encrypted-" + gte.GetfileName(fileName), FileMode.Create, FileAccess.Write);
            
            document.Save(outputStream, FormatType.Docx);
            inputStream.Close();
            outputStream.Close();
        }

        private async Task EncwordFile()
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
            ofd.Filter = "docx files (*.docx)|*.docx|All files (*.*)|*.*";

            if (TbEncPwd1.Text == TbEncPwd2.Text && ofd.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    if (gte.GetFileExtension(ofd.FileName) == ".docx")
                    {
                        LblProceeding.Text = "Proceeding... Do not exit the software!";
                        var task = Task.Run(() => EncryptDOCXFile(ofd.FileName)).ContinueWith(t => File.Delete(ofd.FileName));
                        await task;
                        
                        if (task.IsCompleted)
                        {
                            LblProceeding.Text = "Done!";
                            MessageBox.Show("File Successfully Encrypted!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LblProceeding.ResetText();
                        }

                    }

                    if (gte.GetFileExtension(ofd.FileName) != ".docx")
                    {
                        LblProceeding.ResetText();
                        MessageBox.Show("File version is not supported!" + '\n' + '\n' + "Only Word version 2019 and above are supported!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                }

                catch (Exception)
                {
                    LblProceeding.ResetText();
                    MessageBox.Show("Error: Ensure the file you want to enccrypt is not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void BtnWordFileEnc_Click(object sender, EventArgs e)
        {
            _ = EncwordFile();
            
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
            toolTip1.Show("Minimum password length is 8 characters!", this.TbEncPwd1);
        }

        private void TbEncPwd2_MouseDown(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Minimum password length is 8 characters!", this.TbEncPwd2);
        }
    }
}
