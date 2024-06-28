namespace PGENV3
{
    partial class MultiPDFDec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiPDFDec));
            this.labelImg = new System.Windows.Forms.Label();
            this.BtnHidePWD1 = new System.Windows.Forms.Button();
            this.BtnShowPWD1 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblProceeding = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbDecPwd1 = new System.Windows.Forms.TextBox();
            this.BtnPDFFileDec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelImg
            // 
            this.labelImg.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImg.ForeColor = System.Drawing.Color.White;
            this.labelImg.Image = ((System.Drawing.Image)(resources.GetObject("labelImg.Image")));
            this.labelImg.Location = new System.Drawing.Point(240, 48);
            this.labelImg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImg.Name = "labelImg";
            this.labelImg.Size = new System.Drawing.Size(74, 53);
            this.labelImg.TabIndex = 56;
            this.labelImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnHidePWD1
            // 
            this.BtnHidePWD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHidePWD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHidePWD1.ForeColor = System.Drawing.Color.White;
            this.BtnHidePWD1.Image = ((System.Drawing.Image)(resources.GetObject("BtnHidePWD1.Image")));
            this.BtnHidePWD1.Location = new System.Drawing.Point(114, 190);
            this.BtnHidePWD1.Name = "BtnHidePWD1";
            this.BtnHidePWD1.Size = new System.Drawing.Size(35, 24);
            this.BtnHidePWD1.TabIndex = 55;
            this.BtnHidePWD1.UseVisualStyleBackColor = true;
            this.BtnHidePWD1.Visible = false;
            this.BtnHidePWD1.Click += new System.EventHandler(this.BtnHidePWD1_Click);
            // 
            // BtnShowPWD1
            // 
            this.BtnShowPWD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnShowPWD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowPWD1.ForeColor = System.Drawing.Color.White;
            this.BtnShowPWD1.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowPWD1.Image")));
            this.BtnShowPWD1.Location = new System.Drawing.Point(418, 190);
            this.BtnShowPWD1.Name = "BtnShowPWD1";
            this.BtnShowPWD1.Size = new System.Drawing.Size(35, 24);
            this.BtnShowPWD1.TabIndex = 54;
            this.BtnShowPWD1.UseVisualStyleBackColor = true;
            this.BtnShowPWD1.Click += new System.EventHandler(this.BtnShowPWD1_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BtnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(151, 531);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(259, 44);
            this.BtnExit.TabIndex = 53;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblProceeding
            // 
            this.LblProceeding.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProceeding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.LblProceeding.Location = new System.Drawing.Point(121, 425);
            this.LblProceeding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProceeding.Name = "LblProceeding";
            this.LblProceeding.Size = new System.Drawing.Size(321, 28);
            this.LblProceeding.TabIndex = 52;
            this.LblProceeding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(153, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 41);
            this.label2.TabIndex = 51;
            this.label2.Text = "Enter Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbDecPwd1
            // 
            this.TbDecPwd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TbDecPwd1.ForeColor = System.Drawing.Color.White;
            this.TbDecPwd1.Location = new System.Drawing.Point(154, 191);
            this.TbDecPwd1.Name = "TbDecPwd1";
            this.TbDecPwd1.PasswordChar = '*';
            this.TbDecPwd1.Size = new System.Drawing.Size(259, 23);
            this.TbDecPwd1.TabIndex = 50;
            this.TbDecPwd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnPDFFileDec
            // 
            this.BtnPDFFileDec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BtnPDFFileDec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPDFFileDec.ForeColor = System.Drawing.Color.White;
            this.BtnPDFFileDec.Location = new System.Drawing.Point(154, 300);
            this.BtnPDFFileDec.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPDFFileDec.Name = "BtnPDFFileDec";
            this.BtnPDFFileDec.Size = new System.Drawing.Size(259, 44);
            this.BtnPDFFileDec.TabIndex = 49;
            this.BtnPDFFileDec.Text = "Select The Files";
            this.BtnPDFFileDec.UseVisualStyleBackColor = false;
            this.BtnPDFFileDec.Click += new System.EventHandler(this.BtnPDFFileDec_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(179, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 41);
            this.label1.TabIndex = 48;
            this.label1.Text = "Decrypt PDF Files";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // MultiPDFDec
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 580);
            this.ControlBox = false;
            this.Controls.Add(this.labelImg);
            this.Controls.Add(this.BtnHidePWD1);
            this.Controls.Add(this.BtnShowPWD1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblProceeding);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbDecPwd1);
            this.Controls.Add(this.BtnPDFFileDec);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MultiPDFDec";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImg;
        private System.Windows.Forms.Button BtnHidePWD1;
        private System.Windows.Forms.Button BtnShowPWD1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblProceeding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbDecPwd1;
        private System.Windows.Forms.Button BtnPDFFileDec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}