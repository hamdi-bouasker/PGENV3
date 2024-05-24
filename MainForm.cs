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
            GeneratePasswords gp = new GeneratePasswords();
            gp.MdiParent = this;          
            gp.Show();
           
        }

        private void EncWordFile_Click(object sender, EventArgs e)
        {
            EncWordFile encFile = new EncWordFile();
            encFile.MdiParent = this;
            encFile.Show();
        }

        private void EncExcelFile_Click(object sender, EventArgs e)
        {
            EncXLFile EncXL = new EncXLFile();
            EncXL.MdiParent = this;
            EncXL.Show();
        }

        private void EncPDFFile_Click(object sender, EventArgs e)
        {
            EncPDFFile EncPDF = new EncPDFFile();
            EncPDF.MdiParent = this;
            EncPDF.Show();
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
            Help hp = new Help();
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
            MultipleWordEnc multipleWordEnc = new MultipleWordEnc();
            multipleWordEnc.MdiParent = this;
            multipleWordEnc.Show();
        }

        private void MenuItemMultipleXLEnc_Click(object sender, EventArgs e)
        {
            MultipleXLEnc multipleXLEnc = new MultipleXLEnc();
            multipleXLEnc.MdiParent = this;
            multipleXLEnc.Show();
        }

        private void MenuItemMultiplePDFEnc_Click(object sender, EventArgs e)
        {
            MultiPDFEnc multiPDFEnc = new MultiPDFEnc();
            multiPDFEnc.MdiParent = this;
            multiPDFEnc.Show();
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
    }
}
