namespace PGENV3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsBtnGeneratePWD = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.EncFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EncWordFile = new System.Windows.Forms.ToolStripMenuItem();
            this.EncExcelFile = new System.Windows.Forms.ToolStripMenuItem();
            this.EncPDFFile = new System.Windows.Forms.ToolStripMenuItem();
            this.EncMultiFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EncMultipleWord = new System.Windows.Forms.ToolStripMenuItem();
            this.EncMultipleExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.EncMultiplePDF = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.DecFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DecMultiFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtnGeneratePWD,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.toolStripButton5,
            this.toolStripButton3});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // TsBtnGeneratePWD
            // 
            resources.ApplyResources(this.TsBtnGeneratePWD, "TsBtnGeneratePWD");
            this.TsBtnGeneratePWD.Name = "TsBtnGeneratePWD";
            this.TsBtnGeneratePWD.Click += new System.EventHandler(this.TsBtnGeneratePWD_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EncFileMenuItem,
            this.EncMultiFilesMenuItem});
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            // 
            // EncFileMenuItem
            // 
            this.EncFileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EncWordFile,
            this.EncExcelFile,
            this.EncPDFFile});
            this.EncFileMenuItem.Name = "EncFileMenuItem";
            resources.ApplyResources(this.EncFileMenuItem, "EncFileMenuItem");
            // 
            // EncWordFile
            // 
            this.EncWordFile.Name = "EncWordFile";
            resources.ApplyResources(this.EncWordFile, "EncWordFile");
            this.EncWordFile.Click += new System.EventHandler(this.EncWordFile_Click);
            // 
            // EncExcelFile
            // 
            this.EncExcelFile.Name = "EncExcelFile";
            resources.ApplyResources(this.EncExcelFile, "EncExcelFile");
            // 
            // EncPDFFile
            // 
            this.EncPDFFile.Name = "EncPDFFile";
            resources.ApplyResources(this.EncPDFFile, "EncPDFFile");
            // 
            // EncMultiFilesMenuItem
            // 
            this.EncMultiFilesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EncMultipleWord,
            this.EncMultipleExcel,
            this.EncMultiplePDF});
            this.EncMultiFilesMenuItem.Name = "EncMultiFilesMenuItem";
            resources.ApplyResources(this.EncMultiFilesMenuItem, "EncMultiFilesMenuItem");
            this.EncMultiFilesMenuItem.Click += new System.EventHandler(this.EncMultiFilesMenuItem_Click);
            // 
            // EncMultipleWord
            // 
            this.EncMultipleWord.Name = "EncMultipleWord";
            resources.ApplyResources(this.EncMultipleWord, "EncMultipleWord");
            // 
            // EncMultipleExcel
            // 
            this.EncMultipleExcel.Name = "EncMultipleExcel";
            resources.ApplyResources(this.EncMultipleExcel, "EncMultipleExcel");
            // 
            // EncMultiplePDF
            // 
            this.EncMultiplePDF.Name = "EncMultiplePDF";
            resources.ApplyResources(this.EncMultiplePDF, "EncMultiplePDF");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButton4, "toolStripButton4");
            this.toolStripButton4.Name = "toolStripButton4";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripButton5, "toolStripButton5");
            this.toolStripButton5.Name = "toolStripButton5";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DecFileMenuItem,
            this.DecMultiFilesMenuItem});
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.Name = "toolStripButton3";
            // 
            // DecFileMenuItem
            // 
            this.DecFileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordToolStripMenuItem2,
            this.excelToolStripMenuItem2,
            this.pDFToolStripMenuItem2});
            this.DecFileMenuItem.Name = "DecFileMenuItem";
            resources.ApplyResources(this.DecFileMenuItem, "DecFileMenuItem");
            this.DecFileMenuItem.Click += new System.EventHandler(this.DecFileMenuItem_Click);
            // 
            // wordToolStripMenuItem2
            // 
            this.wordToolStripMenuItem2.Name = "wordToolStripMenuItem2";
            resources.ApplyResources(this.wordToolStripMenuItem2, "wordToolStripMenuItem2");
            // 
            // excelToolStripMenuItem2
            // 
            this.excelToolStripMenuItem2.Name = "excelToolStripMenuItem2";
            resources.ApplyResources(this.excelToolStripMenuItem2, "excelToolStripMenuItem2");
            // 
            // pDFToolStripMenuItem2
            // 
            this.pDFToolStripMenuItem2.Name = "pDFToolStripMenuItem2";
            resources.ApplyResources(this.pDFToolStripMenuItem2, "pDFToolStripMenuItem2");
            // 
            // DecMultiFilesMenuItem
            // 
            this.DecMultiFilesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordToolStripMenuItem3,
            this.excelToolStripMenuItem3,
            this.pDFToolStripMenuItem3});
            this.DecMultiFilesMenuItem.Name = "DecMultiFilesMenuItem";
            resources.ApplyResources(this.DecMultiFilesMenuItem, "DecMultiFilesMenuItem");
            // 
            // wordToolStripMenuItem3
            // 
            this.wordToolStripMenuItem3.Name = "wordToolStripMenuItem3";
            resources.ApplyResources(this.wordToolStripMenuItem3, "wordToolStripMenuItem3");
            // 
            // excelToolStripMenuItem3
            // 
            this.excelToolStripMenuItem3.Name = "excelToolStripMenuItem3";
            resources.ApplyResources(this.excelToolStripMenuItem3, "excelToolStripMenuItem3");
            // 
            // pDFToolStripMenuItem3
            // 
            this.pDFToolStripMenuItem3.Name = "pDFToolStripMenuItem3";
            resources.ApplyResources(this.pDFToolStripMenuItem3, "pDFToolStripMenuItem3");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsBtnGeneratePWD;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem EncFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EncMultiFilesMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem DecFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DecMultiFilesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EncWordFile;
        private System.Windows.Forms.ToolStripMenuItem EncExcelFile;
        private System.Windows.Forms.ToolStripMenuItem EncPDFFile;
        private System.Windows.Forms.ToolStripMenuItem EncMultipleWord;
        private System.Windows.Forms.ToolStripMenuItem EncMultipleExcel;
        private System.Windows.Forms.ToolStripMenuItem EncMultiplePDF;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem3;
    }
}

