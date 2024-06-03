using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.XlsIO;

namespace PGENV3
{
    public partial class DecXLFile : Form
    {
        public DecXLFile()
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

        private async Task DecXLfile()
        {
            if (TbDecPwd1.Text == "")
            {
                MessageBox.Show("Please insert the password!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);       
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            ofd.Multiselect = false;

            if (TbDecPwd1.Text != "" && ofd.ShowDialog() == DialogResult.OK)
            {
                if (gte.GetFileExtension(ofd.FileName) != ".xlsx")
                {
                    LblProceeding.ResetText();
                    MessageBox.Show("File version is not supported!" + '\n' + '\n' + "Only Excel version 2019 and above are supported!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (gte.GetFileExtension(ofd.FileName) == ".xlsx")
                {
                    LblProceeding.Text = "Proceeding...Do not exit the software!";
                    var task = Task.Run(() => DecryptXLFile(ofd.FileName)).ContinueWith(t => { File.Delete(ofd.FileName); t.Wait(); });
                    try
                    {
                        await task;
                        LblProceeding.Text = "Done!";
                        MessageBox.Show("File Successfully Decrypted!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LblProceeding.ResetText();
                    }

                    catch (AggregateException)
                    {

                        MessageBox.Show("Ensure the password is correct!" + '\n' + '\n' + "Ensure the file you want to decrypt is not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LblProceeding.ResetText();
                        return;
                    }

                    catch (Exception)
                    {
                        LblProceeding.ResetText();
                        MessageBox.Show("Ensure the password is correct!" + '\n' + '\n' + "Ensure the file you want to decrypt is not opened in another software!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }           
        }

        private void BtnXLFileDec_Click(object sender, EventArgs e)
        {
            _ = DecXLfile();
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
