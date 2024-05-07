namespace PGENV3
{
    partial class DecFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecFile));
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnHidePWD2 = new System.Windows.Forms.Button();
            this.BtnHidePWD1 = new System.Windows.Forms.Button();
            this.BtnShowPWD2 = new System.Windows.Forms.Button();
            this.BtnShowPWD1 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblProceeding = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbDecPwd2 = new System.Windows.Forms.TextBox();
            this.TbDecPwd1 = new System.Windows.Forms.TextBox();
            this.BtnFileDec = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Decrypt a file";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnHidePWD2
            // 
            this.BtnHidePWD2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHidePWD2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHidePWD2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnHidePWD2.Image = ((System.Drawing.Image)(resources.GetObject("BtnHidePWD2.Image")));
            this.BtnHidePWD2.Location = new System.Drawing.Point(154, 271);
            this.BtnHidePWD2.Name = "BtnHidePWD2";
            this.BtnHidePWD2.Size = new System.Drawing.Size(23, 24);
            this.BtnHidePWD2.TabIndex = 32;
            this.BtnHidePWD2.UseVisualStyleBackColor = true;
            this.BtnHidePWD2.Visible = false;
            this.BtnHidePWD2.Click += new System.EventHandler(this.BtnHidePWD2_Click);
            // 
            // BtnHidePWD1
            // 
            this.BtnHidePWD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHidePWD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHidePWD1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnHidePWD1.Image = ((System.Drawing.Image)(resources.GetObject("BtnHidePWD1.Image")));
            this.BtnHidePWD1.Location = new System.Drawing.Point(154, 171);
            this.BtnHidePWD1.Name = "BtnHidePWD1";
            this.BtnHidePWD1.Size = new System.Drawing.Size(23, 24);
            this.BtnHidePWD1.TabIndex = 31;
            this.BtnHidePWD1.UseVisualStyleBackColor = true;
            this.BtnHidePWD1.Visible = false;
            this.BtnHidePWD1.Click += new System.EventHandler(this.BtnHidePWD1_Click);
            // 
            // BtnShowPWD2
            // 
            this.BtnShowPWD2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnShowPWD2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowPWD2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnShowPWD2.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowPWD2.Image")));
            this.BtnShowPWD2.Location = new System.Drawing.Point(449, 271);
            this.BtnShowPWD2.Name = "BtnShowPWD2";
            this.BtnShowPWD2.Size = new System.Drawing.Size(23, 24);
            this.BtnShowPWD2.TabIndex = 30;
            this.BtnShowPWD2.UseVisualStyleBackColor = true;
            this.BtnShowPWD2.Click += new System.EventHandler(this.BtnShowPWD2_Click);
            // 
            // BtnShowPWD1
            // 
            this.BtnShowPWD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnShowPWD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowPWD1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnShowPWD1.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowPWD1.Image")));
            this.BtnShowPWD1.Location = new System.Drawing.Point(449, 171);
            this.BtnShowPWD1.Name = "BtnShowPWD1";
            this.BtnShowPWD1.Size = new System.Drawing.Size(23, 24);
            this.BtnShowPWD1.TabIndex = 29;
            this.BtnShowPWD1.UseVisualStyleBackColor = true;
            this.BtnShowPWD1.Click += new System.EventHandler(this.BtnShowPWD1_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnExit.Location = new System.Drawing.Point(181, 468);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(259, 44);
            this.BtnExit.TabIndex = 28;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblProceeding
            // 
            this.LblProceeding.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProceeding.ForeColor = System.Drawing.Color.White;
            this.LblProceeding.Location = new System.Drawing.Point(184, 402);
            this.LblProceeding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProceeding.Name = "LblProceeding";
            this.LblProceeding.Size = new System.Drawing.Size(259, 41);
            this.LblProceeding.TabIndex = 27;
            this.LblProceeding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(183, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 41);
            this.label3.TabIndex = 26;
            this.label3.Text = "Repeat Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(183, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 41);
            this.label2.TabIndex = 25;
            this.label2.Text = "Enter Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbDecPwd2
            // 
            this.TbDecPwd2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TbDecPwd2.Location = new System.Drawing.Point(184, 271);
            this.TbDecPwd2.Name = "TbDecPwd2";
            this.TbDecPwd2.PasswordChar = '*';
            this.TbDecPwd2.Size = new System.Drawing.Size(259, 23);
            this.TbDecPwd2.TabIndex = 24;
            this.TbDecPwd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbDecPwd1
            // 
            this.TbDecPwd1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TbDecPwd1.Location = new System.Drawing.Point(184, 171);
            this.TbDecPwd1.Name = "TbDecPwd1";
            this.TbDecPwd1.PasswordChar = '*';
            this.TbDecPwd1.Size = new System.Drawing.Size(259, 23);
            this.TbDecPwd1.TabIndex = 23;
            this.TbDecPwd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnFileDec
            // 
            this.BtnFileDec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFileDec.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnFileDec.Location = new System.Drawing.Point(183, 332);
            this.BtnFileDec.Margin = new System.Windows.Forms.Padding(4);
            this.BtnFileDec.Name = "BtnFileDec";
            this.BtnFileDec.Size = new System.Drawing.Size(259, 44);
            this.BtnFileDec.TabIndex = 21;
            this.BtnFileDec.Text = "Select a file";
            this.BtnFileDec.UseVisualStyleBackColor = true;
            this.BtnFileDec.Click += new System.EventHandler(this.BtnFileDec_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressBar1.Location = new System.Drawing.Point(184, 420);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 23);
            this.progressBar1.TabIndex = 22;
            // 
            // DecFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(629, 538);
            this.ControlBox = false;
            this.Controls.Add(this.BtnHidePWD2);
            this.Controls.Add(this.BtnHidePWD1);
            this.Controls.Add(this.BtnShowPWD2);
            this.Controls.Add(this.BtnShowPWD1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblProceeding);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbDecPwd2);
            this.Controls.Add(this.TbDecPwd1);
            this.Controls.Add(this.BtnFileDec);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DecFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnHidePWD2;
        private System.Windows.Forms.Button BtnHidePWD1;
        private System.Windows.Forms.Button BtnShowPWD2;
        private System.Windows.Forms.Button BtnShowPWD1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblProceeding;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbDecPwd2;
        private System.Windows.Forms.TextBox TbDecPwd1;
        private System.Windows.Forms.Button BtnFileDec;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}