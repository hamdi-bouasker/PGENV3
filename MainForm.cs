using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGENV3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.WhiteSmoke;
        }

        private void TsBtnGeneratePWD_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible = false;
            GeneratePasswords gp = new GeneratePasswords();
            gp.MdiParent = this;          
            gp.Show();
           
        }

        private void EncMultiFilesMenuItem_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible= false;
            MultiEncrypt mt = new MultiEncrypt();
            mt.MdiParent = this;
            mt.Show();
        }

        private void DecFileMenuItem_Click(object sender, EventArgs e)
        {
            DecWordFile decFile = new DecWordFile();
            decFile.MdiParent = this;
            decFile.Show();
        }

        private void EncWordFile_Click(object sender, EventArgs e)
        {
            EncWordFile encFile = new EncWordFile();
            encFile.MdiParent = this;
            encFile.Show();
        }
    }
}
