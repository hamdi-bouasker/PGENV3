using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGENV3
{
    public partial class MultiWordEnc : Form
    {
        public MultiWordEnc()
        {
            InitializeComponent();
        }

        GetPathOrExtention gte = new GetPathOrExtention();
        private void EncryptDOCXFile(string fileName)
        {
            FileStream inputStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            WordDocument document = new WordDocument(inputStream, FormatType.Docx);

            document.EncryptDocument(TbEncPwd2.Text);

            FileStream outputStream = new FileStream(gte.GetDirPath(fileName) + "\\Encrypted-" + gte.GetfileName(fileName), FileMode.Create, FileAccess.Write);

            document.Save(outputStream, FormatType.Docx);
            inputStream.Close();
            outputStream.Close();
            document.Close();
        }
        private async Task EncwordFile()
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
            ofd.Filter = "docx files (*.docx)|*.docx|All files (*.*)|*.*";
            ofd.Multiselect = true;
            var tasks1 = new List<Task>();
            var tasks2 = new List<Task>();
            var tasks3 = new List<Task>();
            if (TbEncPwd1.Text == TbEncPwd2.Text && ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    if (gte.GetFileExtension(file) != ".docx")
                    {
                        LblProceeding.ResetText();
                        MessageBox.Show("File version is not supported!" + '\n' + '\n' + "Only Word version 2019 and above are supported!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (gte.GetFileExtension(file) == ".docx")
                    {
                        var task1 = Task.Run(() => EncryptDOCXFile(file));
                        var task2 = task1.ContinueWith(t => File.Delete(file));
                        var task3 = task2.ContinueWith(t => LBLfileNames.Text = file);
                        tasks1.Add(task1);
                        tasks2.Add(task2);
                        tasks3.Add(task3);
                    }
                }
            }

            try
            {
                LblProceeding.Text = "Proceeding...Do not exit the software!";
                await Task.WhenAll(tasks1);
                LblProceeding.Text = "Encrypting the files...";
                await Task.Delay(1000);
                await Task.WhenAll(tasks2);
                LblProceeding.Text = "Almost done...";
                await Task.Delay(1000);
                await Task.WhenAll(tasks3);
                LblProceeding.Text = "Done!";
                MessageBox.Show("Files Successfully Encrypted!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LblProceeding.ResetText();
                LBLfileNames.ResetText();
            }

            catch (AggregateException)
            {               
                MessageBox.Show("Ensure the password is correct!" + '\n' + '\n' + "Ensure the files you want to encrypt are not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LblProceeding.ResetText();
                LBLfileNames.ResetText();
                return;
            }

            catch (Exception)
            {               
                MessageBox.Show("Ensure the password is correct!" + '\n' + '\n' + "Ensure the files you want to encrypt are not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LblProceeding.ResetText();
                LBLfileNames.ResetText();
                return;
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
            toolTip1.Show("Minimum password length is 8 characters!", TbEncPwd1);
        }
        private void TbEncPwd2_MouseDown(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Minimum password length is 8 characters!", TbEncPwd2);
        }
    }
}
