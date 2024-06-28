using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;
using System;
using System.Collections.Generic;
using System.IO;
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
            FileStream inputStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            WordDocument document = new WordDocument(inputStream, FormatType.Docx, TbDecPwd1.Text);

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
            var tasks1 = new List<Task>();
            var tasks2 = new List<Task>();
            //var tasks3 = new List<Task>();

            if (TbDecPwd1.Text != "" && ofd.ShowDialog() == DialogResult.OK)
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
                        var task1 = Task.Run(() => DecryptDOCXFiles(file));
                        var task2 = task1.ContinueWith(t => File.Delete(file));
                        //var task3 = task2.ContinueWith(t => LBLfileNames.Text = file);
                        tasks1.Add(task1);
                        tasks2.Add(task2);
                        //LBLfileNames.Text = file;
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
                
            }

            catch (AggregateException)
            {
                
                MessageBox.Show("Ensure the password is correct!" + '\n' + '\n' + "Ensure the files you want to decrypt are not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LblProceeding.ResetText();
               
                return;
            }

            catch (Exception)
            {
                
                MessageBox.Show("Ensure the password is correct!" + '\n' + '\n' + "Ensure the files you want to decrypt are not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LblProceeding.ResetText();
                
                return;
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
