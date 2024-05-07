using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace PGENV3
{
    public partial class MultiEncrypt : Form
    {
        public MultiEncrypt()
        {
            InitializeComponent();
        }

        //  Call this function to remove the key from memory after use for security
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        /// <summary>
        /// Creates a random salt that will be used to encrypt your file. This method is required on FileEncrypt.
        /// </summary>
        /// <returns></returns>
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    // Fille the buffer with the generated data
                    rng.GetBytes(data);
                }
            }

            return data;
        }

        /// <summary>
        /// Encrypts a file from its path and a plain password.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="password"></param>
        private void FileEncrypt(string inputFile, string password)
        {
            //http://stackoverflow.com/questions/27645527/aes-encryption-on-large-files

            //generate random salt
            byte[] salt = GenerateRandomSalt();

            //create output file name
            FileStream fsCrypt = new FileStream(inputFile + ".aes", FileMode.Create);

            //convert password string to byte arrray
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            //Set Rijndael symmetric encryption algorithm
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            //http://stackoverflow.com/questions/2659214/why-do-i-need-to-use-the-rfc2898derivebytes-class-in-net-instead-of-directly
            //"What it does is repeatedly hash the user password along with the salt." High iteration counts.
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            //Cipher modes: http://security.stackexchange.com/questions/52665/which-is-the-best-cipher-mode-and-padding-mode-for-aes-encryption
            AES.Mode = CipherMode.CFB;

            // write salt to the begining of the output file, so in this case can be random every time
            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            //create a buffer (1mb) so only this amount will allocate in the memory and not the whole file
            byte[] buffer = new byte[1048576];
            int read;

            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents(); // -> for responsive GUI, using Task will be better!
                    cs.Write(buffer, 0, read);
                }

                // Close up
                fsIn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }

        private async Task EncMultiFiles()
        {
            string password1 = TbEncPwd1.Text;
            string password2 = TbEncPwd2.Text;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            progressBar1.Value = 0;
            progressBar1.Visible = true;
            var tasks = new List<Task>();
            LblProceeding.Text = "";

            //if (string.IsNullOrEmpty(password1) && string.IsNullOrEmpty(password2))
            //{
            //    MessageBox.Show("Please insert password!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (password1 != password2)
            //{
            //    MessageBox.Show("Please retype the same password!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (ofd.ShowDialog() != DialogResult.OK)
            //{
            //    MessageBox.Show("Encryption canceled!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            try
            {
                if (string.IsNullOrEmpty(password1) && string.IsNullOrEmpty(password2))
                {
                    MessageBox.Show("Please insert password!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password1 != password2)
                {
                    MessageBox.Show("Please insert the same password in both boxes!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //if (ofd.ShowDialog() != DialogResult.OK)
                //{
                //    MessageBox.Show("Encryption canceled!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}


                if (!string.IsNullOrEmpty(password1) && !string.IsNullOrEmpty(password2) && password2 == password1 && ofd.ShowDialog() == DialogResult.OK)
                {
                    // For additional security Pin the password of your files
                    LblProceeding.Text = "Proceeding...";
                    GCHandle gch = GCHandle.Alloc(password2, GCHandleType.Pinned);
                    foreach (string file in ofd.FileNames)
                    {
                        var task = Task.Run(() => FileEncrypt(file, password2)).ContinueWith(t => File.Delete(file)).ContinueWith(p => { progressBar1.Maximum = tasks.Count; progressBar1.PerformStep(); });
                        tasks.Add(task);
                    }

                    await Task.WhenAll(tasks);
                    LblProceeding.Text = "Done!";
                    // To increase the security of the encryption, delete the given password from the memory !
                    ZeroMemory(gch.AddrOfPinnedObject(), password2.Length * 2);
                    gch.Free();
                    MessageBox.Show("Files Successfully Encrypted", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LblProceeding.Text = "";
                    progressBar1.Value = 0;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEncMultiFiles_Click(object sender, EventArgs e)
        {
            _ = EncMultiFiles();
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
    }
}
