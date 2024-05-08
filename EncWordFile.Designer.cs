namespace PGENV3
{
    partial class EncWordFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncWordFile));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnWordFileEnc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbEncPwd1 = new System.Windows.Forms.TextBox();
            this.TbEncPwd2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblProceeding = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnShowPWD1 = new System.Windows.Forms.Button();
            this.BtnShowPWD2 = new System.Windows.Forms.Button();
            this.BtnHidePWD1 = new System.Windows.Forms.Button();
            this.BtnHidePWD2 = new System.Windows.Forms.Button();
            this.labelImg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnWordFileEnc
            // 
            this.BtnWordFileEnc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWordFileEnc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnWordFileEnc.Location = new System.Drawing.Point(181, 334);
            this.BtnWordFileEnc.Margin = new System.Windows.Forms.Padding(4);
            this.BtnWordFileEnc.Name = "BtnWordFileEnc";
            this.BtnWordFileEnc.Size = new System.Drawing.Size(259, 44);
            this.BtnWordFileEnc.TabIndex = 9;
            this.BtnWordFileEnc.Text = "Select a file";
            this.BtnWordFileEnc.UseVisualStyleBackColor = true;
            this.BtnWordFileEnc.Click += new System.EventHandler(this.BtnWordFileEnc_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Encrypt Word File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbEncPwd1
            // 
            this.TbEncPwd1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TbEncPwd1.Location = new System.Drawing.Point(182, 173);
            this.TbEncPwd1.Name = "TbEncPwd1";
            this.TbEncPwd1.PasswordChar = '*';
            this.TbEncPwd1.Size = new System.Drawing.Size(259, 23);
            this.TbEncPwd1.TabIndex = 11;
            this.TbEncPwd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbEncPwd2
            // 
            this.TbEncPwd2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TbEncPwd2.Location = new System.Drawing.Point(182, 273);
            this.TbEncPwd2.Name = "TbEncPwd2";
            this.TbEncPwd2.PasswordChar = '*';
            this.TbEncPwd2.Size = new System.Drawing.Size(259, 23);
            this.TbEncPwd2.TabIndex = 12;
            this.TbEncPwd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(181, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 41);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(181, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 41);
            this.label3.TabIndex = 14;
            this.label3.Text = "Repeat Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblProceeding
            // 
            this.LblProceeding.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProceeding.ForeColor = System.Drawing.Color.White;
            this.LblProceeding.Location = new System.Drawing.Point(150, 408);
            this.LblProceeding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProceeding.Name = "LblProceeding";
            this.LblProceeding.Size = new System.Drawing.Size(321, 28);
            this.LblProceeding.TabIndex = 15;
            this.LblProceeding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnExit.Location = new System.Drawing.Point(179, 470);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(259, 44);
            this.BtnExit.TabIndex = 16;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnShowPWD1
            // 
            this.BtnShowPWD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnShowPWD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowPWD1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnShowPWD1.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowPWD1.Image")));
            this.BtnShowPWD1.Location = new System.Drawing.Point(446, 173);
            this.BtnShowPWD1.Name = "BtnShowPWD1";
            this.BtnShowPWD1.Size = new System.Drawing.Size(35, 24);
            this.BtnShowPWD1.TabIndex = 17;
            this.BtnShowPWD1.UseVisualStyleBackColor = true;
            this.BtnShowPWD1.Click += new System.EventHandler(this.BtnShowPWD1_Click);
            // 
            // BtnShowPWD2
            // 
            this.BtnShowPWD2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnShowPWD2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowPWD2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnShowPWD2.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowPWD2.Image")));
            this.BtnShowPWD2.Location = new System.Drawing.Point(447, 272);
            this.BtnShowPWD2.Name = "BtnShowPWD2";
            this.BtnShowPWD2.Size = new System.Drawing.Size(35, 24);
            this.BtnShowPWD2.TabIndex = 18;
            this.BtnShowPWD2.UseVisualStyleBackColor = true;
            this.BtnShowPWD2.Click += new System.EventHandler(this.BtnShowPWD2_Click);
            // 
            // BtnHidePWD1
            // 
            this.BtnHidePWD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHidePWD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHidePWD1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnHidePWD1.Image = ((System.Drawing.Image)(resources.GetObject("BtnHidePWD1.Image")));
            this.BtnHidePWD1.Location = new System.Drawing.Point(142, 173);
            this.BtnHidePWD1.Name = "BtnHidePWD1";
            this.BtnHidePWD1.Size = new System.Drawing.Size(35, 24);
            this.BtnHidePWD1.TabIndex = 19;
            this.BtnHidePWD1.UseVisualStyleBackColor = true;
            this.BtnHidePWD1.Visible = false;
            this.BtnHidePWD1.Click += new System.EventHandler(this.BtnHidePWD1_Click);
            // 
            // BtnHidePWD2
            // 
            this.BtnHidePWD2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHidePWD2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHidePWD2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnHidePWD2.Image = ((System.Drawing.Image)(resources.GetObject("BtnHidePWD2.Image")));
            this.BtnHidePWD2.Location = new System.Drawing.Point(141, 273);
            this.BtnHidePWD2.Name = "BtnHidePWD2";
            this.BtnHidePWD2.Size = new System.Drawing.Size(35, 24);
            this.BtnHidePWD2.TabIndex = 20;
            this.BtnHidePWD2.UseVisualStyleBackColor = true;
            this.BtnHidePWD2.Visible = false;
            this.BtnHidePWD2.Click += new System.EventHandler(this.BtnHidePWD2_Click);
            // 
            // labelImg
            // 
            this.labelImg.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImg.ForeColor = System.Drawing.Color.White;
            this.labelImg.Image = ((System.Drawing.Image)(resources.GetObject("labelImg.Image")));
            this.labelImg.Location = new System.Drawing.Point(265, 60);
            this.labelImg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImg.Name = "labelImg";
            this.labelImg.Size = new System.Drawing.Size(74, 53);
            this.labelImg.TabIndex = 21;
            this.labelImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EncWordFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(629, 527);
            this.Controls.Add(this.labelImg);
            this.Controls.Add(this.BtnHidePWD2);
            this.Controls.Add(this.BtnHidePWD1);
            this.Controls.Add(this.BtnShowPWD2);
            this.Controls.Add(this.BtnShowPWD1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblProceeding);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbEncPwd2);
            this.Controls.Add(this.TbEncPwd1);
            this.Controls.Add(this.BtnWordFileEnc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EncWordFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnWordFileEnc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbEncPwd1;
        private System.Windows.Forms.TextBox TbEncPwd2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblProceeding;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnShowPWD1;
        private System.Windows.Forms.Button BtnShowPWD2;
        private System.Windows.Forms.Button BtnHidePWD1;
        private System.Windows.Forms.Button BtnHidePWD2;
        private System.Windows.Forms.Label labelImg;
    }
}