using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;
using Microsoft.Win32;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

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

        private void BtnWordFileEnc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "docx files (*.docx)|*.docx|All files (*.*)|*.*";
            if (TbEncPwd1.Text != TbEncPwd2.Text)
            {
                MessageBox.Show("Repeat the same password!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (TbEncPwd1.Text == TbEncPwd2.Text && ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (gte.GetFileExtension(ofd.FileName) == ".docx")
                    {
                        EncryptDOCXFile(ofd.FileName);
                        File.Delete(ofd.FileName);
                        MessageBox.Show("File Successfully Encrypted!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    if (gte.GetFileExtension(ofd.FileName) != ".docx")
                    {
                        MessageBox.Show("File version is not supported!" + '\n' + '\n' + "Only Word 2019 version and above are supported!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }                  
                }

                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }

            }
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
