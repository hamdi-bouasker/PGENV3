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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.DecFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDecWordFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDecXLFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDecPDFFile = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
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
            this.toolStripSeparator4,
            this.BtnAbout,
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
            this.EncFileMenuItem});
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
            this.EncExcelFile.Click += new System.EventHandler(this.EncExcelFile_Click);
            // 
            // EncPDFFile
            // 
            this.EncPDFFile.Name = "EncPDFFile";
            resources.ApplyResources(this.EncPDFFile, "EncPDFFile");
            this.EncPDFFile.Click += new System.EventHandler(this.EncPDFFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // BtnAbout
            // 
            this.BtnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.BtnAbout, "BtnAbout");
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DecFileMenuItem});
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.Name = "toolStripButton3";
            // 
            // DecFileMenuItem
            // 
            this.DecFileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDecWordFile,
            this.MenuItemDecXLFile,
            this.MenuItemDecPDFFile});
            this.DecFileMenuItem.Name = "DecFileMenuItem";
            resources.ApplyResources(this.DecFileMenuItem, "DecFileMenuItem");
            // 
            // MenuItemDecWordFile
            // 
            this.MenuItemDecWordFile.Name = "MenuItemDecWordFile";
            resources.ApplyResources(this.MenuItemDecWordFile, "MenuItemDecWordFile");
            this.MenuItemDecWordFile.Click += new System.EventHandler(this.MenuItemDecWordFile_Click);
            // 
            // MenuItemDecXLFile
            // 
            this.MenuItemDecXLFile.Name = "MenuItemDecXLFile";
            resources.ApplyResources(this.MenuItemDecXLFile, "MenuItemDecXLFile");
            this.MenuItemDecXLFile.Click += new System.EventHandler(this.MenuItemDecXLFile_Click);
            // 
            // MenuItemDecPDFFile
            // 
            this.MenuItemDecPDFFile.Name = "MenuItemDecPDFFile";
            resources.ApplyResources(this.MenuItemDecPDFFile, "MenuItemDecPDFFile");
            this.MenuItemDecPDFFile.Click += new System.EventHandler(this.MenuItemDecPDFFile_Click);
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
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsBtnGeneratePWD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem EncFileMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem DecFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EncWordFile;
        private System.Windows.Forms.ToolStripMenuItem EncExcelFile;
        private System.Windows.Forms.ToolStripMenuItem EncPDFFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDecWordFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDecXLFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDecPDFFile;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

