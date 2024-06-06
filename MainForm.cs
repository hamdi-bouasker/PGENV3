using System;
using System.Drawing;
using System.Linq;
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
            GeneratePasswords gp = new GeneratePasswords();
            gp.MdiParent = this;          
            gp.Show();          
        }
        private void EncWordFile_Click(object sender, EventArgs e)
        {
            EncWordFile encFile = new EncWordFile();
            encFile.MdiParent = this;
            encFile.Show();
            MessageBox.Show("Backup your file before the encryption!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void EncExcelFile_Click(object sender, EventArgs e)
        {
            EncXLFile EncXL = new EncXLFile();
            EncXL.MdiParent = this;
            EncXL.Show();
            MessageBox.Show("Backup your file before the encryption!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void EncPDFFile_Click(object sender, EventArgs e)
        {
            EncPDFFile EncPDF = new EncPDFFile();
            EncPDF.MdiParent = this;
            EncPDF.Show();
            MessageBox.Show("Backup your file before the encryption!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MenuItemDecWordFile_Click(object sender, EventArgs e)
        {
            DecWordFile decWordFile = new DecWordFile();
            decWordFile.MdiParent = this;
            decWordFile.Show();
        }
        private void MenuItemDecXLFile_Click(object sender, EventArgs e)
        {
            DecXLFile decXL = new DecXLFile();
            decXL.MdiParent = this;
            decXL.Show();
        }
        private void MenuItemDecPDFFile_Click(object sender, EventArgs e)
        {
            DecPDFFile decPDF = new DecPDFFile();
            decPDF.MdiParent = this;
            decPDF.Show();
        }
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            HelpForm hp = new HelpForm();
            hp.MdiParent = this;
            hp.Show();
        }
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.MdiParent = this;
            aboutBox1.Show();
        }
        private void MenuItemMultipleWordEnc_Click(object sender, EventArgs e)
        {
            MultiWordEnc multipleWordEnc = new MultiWordEnc();
            multipleWordEnc.MdiParent = this;
            multipleWordEnc.Show();
            MessageBox.Show("Backup your files before the encryption!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MenuItemMultipleXLEnc_Click(object sender, EventArgs e)
        {
            MultipleXLEnc multipleXLEnc = new MultipleXLEnc();
            multipleXLEnc.MdiParent = this;
            multipleXLEnc.Show();
            MessageBox.Show("Backup your files before the encryption!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MenuItemMultiplePDFEnc_Click(object sender, EventArgs e)
        {
            MultiPDFEnc multiPDFEnc = new MultiPDFEnc();
            multiPDFEnc.MdiParent = this;
            multiPDFEnc.Show();
            MessageBox.Show("Backup your files before the encryption!", "P-GEN", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MenuItemMultipleWordDec_Click(object sender, EventArgs e)
        {
            MultiWordDec multiWordDec = new MultiWordDec(); 
            multiWordDec.MdiParent = this;
            multiWordDec.Show();
        }
        private void MenuItemMultipleXLDec_Click(object sender, EventArgs e)
        {
            MultiXLDec multiXLDec = new MultiXLDec();
            multiXLDec.MdiParent = this;
            multiXLDec.Show();
        }
        private void MenuItemMultiplePDFDec_Click(object sender, EventArgs e)
        {
            MultiPDFDec multiPDFDec = new MultiPDFDec();
            multiPDFDec.MdiParent = this;
            multiPDFDec.Show();
        }

        private void Readme_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.MdiParent = this;
            helpForm.Show();
        }
    }
}
