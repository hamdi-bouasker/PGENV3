using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;
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
    public partial class MultiWordDec : Form
    {
        public MultiWordDec()
        {
            InitializeComponent();
        }

        GetPathOrExtention gte = new GetPathOrExtention();
        private void DecryptDOCXFiles(string fileName)
        {

            //Load an existing Word document with password.
            FileStream inputStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            WordDocument document = new WordDocument(inputStream, FormatType.Docx, TbDecPwd1.Text);

            //Save the Word document.
            FileStream outputStream = new FileStream(gte.GetDirPath(fileName) + "\\" + gte.GetfileName(fileName).Replace("Encrypted-", ""), FileMode.Create, FileAccess.Write);
            document.Save(outputStream, FormatType.Docx);
            inputStream.Close();
            outputStream.Close();

        }

        private async Task DecwordFiles()
        {
            if (TbDecPwd1.Text == "")
            {
                MessageBox.Show("Please insert the password!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "docx files (*.docx)|*.docx|All files (*.*)|*.*";
            ofd.Multiselect = true;
            var tasks = new List<Task>();

            if (TbDecPwd1.Text != "" && ofd.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Visible = true;

                try
                {
                    foreach (string file in ofd.FileNames)
                    {
                        if (gte.GetFileExtension(file) != ".docx")
                        {
                            LblProceeding.ResetText();
                            MessageBox.Show("Files version is not supported!" + '\n' + '\n' + "Only Word version 2019 and above are supported!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (gte.GetFileExtension(file) == ".docx")
                        {
                            LblProceeding.Text = "Proceeding... Do not exit the software!";
                            var task = Task.Run(() => DecryptDOCXFiles(file)).ContinueWith(t => File.Delete(file)).ContinueWith(p => progressBar1.PerformStep());
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
                    MessageBox.Show("Error: Ensure the password is correct!" + '\n' + '\n' + "Ensure the files you want to decrypt are not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }
        private void BtnWordFileDec_Click(object sender, EventArgs e)
        {
            _ = DecwordFiles();
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
