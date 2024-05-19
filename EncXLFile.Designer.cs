namespace PGENV3
{
    partial class EncXLFile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncXLFile));
            this.labelImg = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblProceeding = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbEncPwd2 = new System.Windows.Forms.TextBox();
            this.TbEncPwd1 = new System.Windows.Forms.TextBox();
            this.BtnXLFileEnc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnShowPWD1 = new System.Windows.Forms.Label();
            this.BtnShowPWD2 = new System.Windows.Forms.Label();
            this.BtnHidePWD1 = new System.Windows.Forms.Label();
            this.BtnHidePWD2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelImg
            // 
            this.labelImg.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImg.ForeColor = System.Drawing.Color.White;
            this.labelImg.Image = ((System.Drawing.Image)(resources.GetObject("labelImg.Image")));
            this.labelImg.Location = new System.Drawing.Point(301, 54);
            this.labelImg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImg.Name = "labelImg";
            this.labelImg.Size = new System.Drawing.Size(74, 53);
            this.labelImg.TabIndex = 35;
            this.labelImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.BtnExit.Location = new System.Drawing.Point(215, 489);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(259, 44);
            this.BtnExit.TabIndex = 30;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // LblProceeding
            // 
            this.LblProceeding.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProceeding.ForeColor = System.Drawing.Color.White;
            this.LblProceeding.Location = new System.Drawing.Point(187, 415);
            this.LblProceeding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProceeding.Name = "LblProceeding";
            this.LblProceeding.Size = new System.Drawing.Size(321, 28);
            this.LblProceeding.TabIndex = 29;
            this.LblProceeding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(217, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 41);
            this.label3.TabIndex = 28;
            this.label3.Text = "Repeat Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 41);
            this.label2.TabIndex = 27;
            this.label2.Text = "Enter Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbEncPwd2
            // 
            this.TbEncPwd2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.TbEncPwd2.Location = new System.Drawing.Point(218, 267);
            this.TbEncPwd2.Name = "TbEncPwd2";
            this.TbEncPwd2.PasswordChar = '*';
            this.TbEncPwd2.Size = new System.Drawing.Size(259, 22);
            this.TbEncPwd2.TabIndex = 26;
            this.TbEncPwd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbEncPwd2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TbEncPwd2_MouseDown);
            // 
            // TbEncPwd1
            // 
            this.TbEncPwd1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.TbEncPwd1.Location = new System.Drawing.Point(218, 167);
            this.TbEncPwd1.Name = "TbEncPwd1";
            this.TbEncPwd1.PasswordChar = '*';
            this.TbEncPwd1.Size = new System.Drawing.Size(259, 22);
            this.TbEncPwd1.TabIndex = 25;
            this.TbEncPwd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbEncPwd1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TbEncPwd1_MouseDown);
            // 
            // BtnXLFileEnc
            // 
            this.BtnXLFileEnc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXLFileEnc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.BtnXLFileEnc.Location = new System.Drawing.Point(217, 328);
            this.BtnXLFileEnc.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXLFileEnc.Name = "BtnXLFileEnc";
            this.BtnXLFileEnc.Size = new System.Drawing.Size(259, 44);
            this.BtnXLFileEnc.TabIndex = 23;
            this.BtnXLFileEnc.Text = "Select a file";
            this.BtnXLFileEnc.UseVisualStyleBackColor = true;
            this.BtnXLFileEnc.Click += new System.EventHandler(this.BtnXLFileEnc_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(237, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "Encrypt Excel File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnShowPWD1
            // 
            this.BtnShowPWD1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.BtnShowPWD1.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowPWD1.Image")));
            this.BtnShowPWD1.Location = new System.Drawing.Point(486, 162);
            this.BtnShowPWD1.Margin = new System.Windows.Forms.Padding(3);
            this.BtnShowPWD1.Name = "BtnShowPWD1";
            this.BtnShowPWD1.Size = new System.Drawing.Size(26, 33);
            this.BtnShowPWD1.TabIndex = 36;
            this.BtnShowPWD1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnShowPWD1.Click += new System.EventHandler(this.BtnShowPWD1_Click_1);
            // 
            // BtnShowPWD2
            // 
            this.BtnShowPWD2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.BtnShowPWD2.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowPWD2.Image")));
            this.BtnShowPWD2.Location = new System.Drawing.Point(486, 262);
            this.BtnShowPWD2.Margin = new System.Windows.Forms.Padding(3);
            this.BtnShowPWD2.Name = "BtnShowPWD2";
            this.BtnShowPWD2.Size = new System.Drawing.Size(26, 33);
            this.BtnShowPWD2.TabIndex = 37;
            this.BtnShowPWD2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnShowPWD2.Click += new System.EventHandler(this.BtnShowPWD2_Click_1);
            // 
            // BtnHidePWD1
            // 
            this.BtnHidePWD1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.BtnHidePWD1.Image = ((System.Drawing.Image)(resources.GetObject("BtnHidePWD1.Image")));
            this.BtnHidePWD1.Location = new System.Drawing.Point(185, 160);
            this.BtnHidePWD1.Margin = new System.Windows.Forms.Padding(3);
            this.BtnHidePWD1.Name = "BtnHidePWD1";
            this.BtnHidePWD1.Size = new System.Drawing.Size(26, 33);
            this.BtnHidePWD1.TabIndex = 38;
            this.BtnHidePWD1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnHidePWD1.Visible = false;
            this.BtnHidePWD1.Click += new System.EventHandler(this.BtnHidePWD1_Click_1);
            // 
            // BtnHidePWD2
            // 
            this.BtnHidePWD2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.BtnHidePWD2.Image = ((System.Drawing.Image)(resources.GetObject("BtnHidePWD2.Image")));
            this.BtnHidePWD2.Location = new System.Drawing.Point(185, 260);
            this.BtnHidePWD2.Margin = new System.Windows.Forms.Padding(3);
            this.BtnHidePWD2.Name = "BtnHidePWD2";
            this.BtnHidePWD2.Size = new System.Drawing.Size(26, 33);
            this.BtnHidePWD2.TabIndex = 39;
            this.BtnHidePWD2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnHidePWD2.Visible = false;
            this.BtnHidePWD2.Click += new System.EventHandler(this.BtnHidePWD2_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "P-GEN";
            // 
            // EncXLFile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.ControlBox = false;
            this.Controls.Add(this.BtnHidePWD2);
            this.Controls.Add(this.BtnHidePWD1);
            this.Controls.Add(this.BtnShowPWD2);
            this.Controls.Add(this.BtnShowPWD1);
            this.Controls.Add(this.labelImg);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblProceeding);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbEncPwd2);
            this.Controls.Add(this.TbEncPwd1);
            this.Controls.Add(this.BtnXLFileEnc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EncXLFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImg;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblProceeding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbEncPwd2;
        private System.Windows.Forms.TextBox TbEncPwd1;
        private System.Windows.Forms.Button BtnXLFileEnc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label BtnShowPWD1;
        private System.Windows.Forms.Label BtnShowPWD2;
        private System.Windows.Forms.Label BtnHidePWD1;
        private System.Windows.Forms.Label BtnHidePWD2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}