using System;
using System.Web.Security;
using System.IO;
using System.Windows.Forms;

namespace PGENV3
{
    public partial class GeneratePasswords : Form
    {
        public GeneratePasswords()
        {
            InitializeComponent();
        }

        private void BtnGeneratePWD_Click(object sender, EventArgs e)
        {
            int length = int.Parse(NUDCharsInput.Text);
            int num = int.Parse(NUDNumInput.Text);
            pwdOutput.Clear();
            LblProceeding.ResetText();
            try
            {
                
                for (int i = 0; i < num; i++)
                {

                    string password = Membership.GeneratePassword(length, length / 3).Replace('.', '?').Replace(';', '!').Replace(':', '#').Replace('_', '}');
                    pwdOutput.AppendText(password + Environment.NewLine);
                    LblProceeding.Text = "Done!";
                }
                
                pwdOutput.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCopyPWD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pwdOutput.Text))
            {
                Clipboard.SetText(pwdOutput.Text);
                NUDCharsInput.Value = NUDCharsInput.Minimum;
                NUDNumInput.Value = NUDNumInput.Minimum;
                pwdOutput.Clear();
                LblProceeding.ResetText();
                pwdOutput.Visible = false;
                MessageBox.Show("Password Copied!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is no password to copy!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExportPWD_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (!string.IsNullOrEmpty(pwdOutput.Text) && saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.Write(pwdOutput.Text);
                    MessageBox.Show("Passwords successfully exported to TXT file!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NUDCharsInput.Value = NUDCharsInput.Minimum;
                    NUDNumInput.Value = NUDNumInput.Minimum;
                    pwdOutput.Clear();
                    LblProceeding.ResetText();
                    pwdOutput.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("There is no passwords to export!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClearInputs_Click(object sender, EventArgs e)
        {
            NUDCharsInput.Value = NUDCharsInput.Minimum;
            NUDNumInput.Value = NUDNumInput.Minimum;
            pwdOutput.Clear();
            LblProceeding.ResetText();
            pwdOutput.Visible = false;
            MessageBox.Show("All inputs are reset!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NUDCharsInput_MouseDown(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Minimum is 16 and Maximum is 128", this.NUDCharsInput);
        }

        private void NUDNumInput_MouseDown(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Minimum is 1 and Maximum is 100", this.NUDNumInput);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
