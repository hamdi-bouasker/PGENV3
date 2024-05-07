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
using System.Windows.Forms;

namespace PGENV3
{
    public partial class DecFile : Form
    {
        public DecFile()
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
        /// Decrypts an encrypted file with the FileEncrypt method through its path and the plain password.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        /// <param name="password"></param>
        private void FileDecrypt(string inputFile, string outputFile, string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);
            
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);
            
            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int read;
            byte[] buffer = new byte[1048576];

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex_CryptographicException)
            {
                MessageBox.Show("CryptographicException error: " + ex_CryptographicException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error by closing CryptoStream: " + ex.Message);
            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
            }
        }


        private void BtnFileDec_Click(object sender, EventArgs e)
        {
            string password1 = TbDecPwd1.Text;
            string password2 = TbDecPwd2.Text;
            OpenFileDialog ofd = new OpenFileDialog();
           
            try
            {
                if (password1 != password2)
                {
                    MessageBox.Show("Please repeat the same password!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (string.IsNullOrEmpty(password1) && string.IsNullOrEmpty(password2))
                {
                    MessageBox.Show("Please enter a password!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!string.IsNullOrEmpty(password1) && !string.IsNullOrEmpty(password2) && password2 == password1 && ofd.ShowDialog() == DialogResult.OK)

                {

                    // For additional security Pin the password of your files
                    GCHandle gch = GCHandle.Alloc(password2, GCHandleType.Pinned);
                    // Decrypt the file
                    Task task = Task.Run(() => FileDecrypt(ofd.FileName, ofd.FileName.Replace(".aes", ""), password2)).ContinueWith(t => File.Delete(ofd.FileName));
                    // To increase the security of the decryption, delete the used password from the memory !
                    LblProceeding.Text = "Done!";
                    MessageBox.Show("File successfully decrypted!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LblProceeding.Text = "";
                    ZeroMemory(gch.AddrOfPinnedObject(), password2.Length * 2);
                    gch.Free();
                }             
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnShowPWD1_Click(object sender, EventArgs e)
        {
            BtnShowPWD1.Visible = false;
            BtnHidePWD1.Visible = true;
            TbDecPwd1.PasswordChar = '\0';

        }

        private void BtnShowPWD2_Click(object sender, EventArgs e)
        {
            BtnHidePWD2.Visible = true;
            BtnShowPWD2.Visible = false;
            TbDecPwd2.PasswordChar = '\0';
        }

        private void BtnHidePWD1_Click(object sender, EventArgs e)
        {
            BtnShowPWD1.Visible = true;
            BtnHidePWD1.Visible = false;
            TbDecPwd1.PasswordChar = '*';
        }

        private void BtnHidePWD2_Click(object sender, EventArgs e)
        {
            BtnHidePWD2.Visible = false;
            BtnShowPWD2.Visible = true;
            TbDecPwd2.PasswordChar = '*';
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
