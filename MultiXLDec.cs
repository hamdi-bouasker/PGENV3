using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGENV3
{
    public partial class MultiXLDec : Form
    {
        public MultiXLDec()
        {
            InitializeComponent();
        }

        GetPathOrExtention gte = new GetPathOrExtention();
        private void DecryptXLFile(string fileName)
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Xlsx;
                FileStream inputStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);

                IWorkbook workbook = application.Workbooks.Open(inputStream, ExcelParseOptions.Default, false, TbDecPwd1.Text);
                IWorksheet worksheet = workbook.Worksheets[0];

                workbook.PasswordToOpen = string.Empty;

                FileStream outputStream = new FileStream(gte.GetDirPath(fileName) + "\\" + gte.GetfileName(fileName).Replace("Encrypted-", ""), FileMode.Create, FileAccess.Write);
                workbook.SaveAs(outputStream);
              
                outputStream.Close();
                inputStream.Close();
                workbook.Close();
            }
        }
        private async Task DecXLfiles()
        {
            if (TbDecPwd1.Text == "")
            {
                MessageBox.Show("Please insert the password!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            ofd.Multiselect = true;
            var tasks1 = new List<Task>();
            var tasks2 = new List<Task>();
            //var tasks3 = new List<Task>();

            if (TbDecPwd1.Text != "" && ofd.ShowDialog() == DialogResult.OK)
            {               
                    foreach (var file in ofd.FileNames)
                    {
                        if (gte.GetFileExtension(file) != ".xlsx")
                        {
                            LblProceeding.ResetText();
                            MessageBox.Show("File version is not supported!" + '\n' + '\n' + "Only Excel 2019 and above are supported!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (gte.GetFileExtension(ofd.FileName) == ".xlsx")
                        {
                        var task1 = Task.Run(() => DecryptXLFile(file));
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
        private void BtnXLFileDec_Click(object sender, EventArgs e)
        {
            _ = DecXLfiles();
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
