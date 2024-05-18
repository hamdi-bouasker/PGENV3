namespace PGENV3
{
    partial class GeneratePasswords
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnClearInputs = new System.Windows.Forms.Button();
            this.BtnExportPWD = new System.Windows.Forms.Button();
            this.BtnCopyPWD = new System.Windows.Forms.Button();
            this.BtnGeneratePWD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NUDNumInput = new System.Windows.Forms.NumericUpDown();
            this.NUDCharsInput = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pwdOutput = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LblProceeding = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCharsInput)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnClearInputs);
            this.panel1.Controls.Add(this.BtnExportPWD);
            this.panel1.Controls.Add(this.BtnCopyPWD);
            this.panel1.Controls.Add(this.BtnGeneratePWD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NUDNumInput);
            this.panel1.Controls.Add(this.NUDCharsInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 510);
            this.panel1.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.AutoSize = true;
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnExit.Location = new System.Drawing.Point(55, 449);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(179, 39);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnClearInputs
            // 
            this.BtnClearInputs.AutoSize = true;
            this.BtnClearInputs.BackColor = System.Drawing.Color.White;
            this.BtnClearInputs.FlatAppearance.BorderSize = 0;
            this.BtnClearInputs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnClearInputs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnClearInputs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearInputs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnClearInputs.Location = new System.Drawing.Point(55, 387);
            this.BtnClearInputs.Name = "BtnClearInputs";
            this.BtnClearInputs.Size = new System.Drawing.Size(179, 39);
            this.BtnClearInputs.TabIndex = 8;
            this.BtnClearInputs.Text = "Clear";
            this.BtnClearInputs.UseVisualStyleBackColor = false;
            this.BtnClearInputs.Click += new System.EventHandler(this.BtnClearInputs_Click);
            // 
            // BtnExportPWD
            // 
            this.BtnExportPWD.AutoSize = true;
            this.BtnExportPWD.BackColor = System.Drawing.Color.White;
            this.BtnExportPWD.FlatAppearance.BorderSize = 0;
            this.BtnExportPWD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnExportPWD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnExportPWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportPWD.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnExportPWD.Location = new System.Drawing.Point(55, 328);
            this.BtnExportPWD.Name = "BtnExportPWD";
            this.BtnExportPWD.Size = new System.Drawing.Size(179, 39);
            this.BtnExportPWD.TabIndex = 7;
            this.BtnExportPWD.Text = "Export as TXT File";
            this.BtnExportPWD.UseVisualStyleBackColor = false;
            this.BtnExportPWD.Click += new System.EventHandler(this.BtnExportPWD_Click);
            // 
            // BtnCopyPWD
            // 
            this.BtnCopyPWD.AutoSize = true;
            this.BtnCopyPWD.BackColor = System.Drawing.Color.White;
            this.BtnCopyPWD.FlatAppearance.BorderSize = 0;
            this.BtnCopyPWD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCopyPWD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCopyPWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopyPWD.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnCopyPWD.Location = new System.Drawing.Point(55, 267);
            this.BtnCopyPWD.Name = "BtnCopyPWD";
            this.BtnCopyPWD.Size = new System.Drawing.Size(179, 39);
            this.BtnCopyPWD.TabIndex = 6;
            this.BtnCopyPWD.Text = "Copy";
            this.BtnCopyPWD.UseVisualStyleBackColor = false;
            this.BtnCopyPWD.Click += new System.EventHandler(this.BtnCopyPWD_Click);
            // 
            // BtnGeneratePWD
            // 
            this.BtnGeneratePWD.AutoSize = true;
            this.BtnGeneratePWD.BackColor = System.Drawing.Color.White;
            this.BtnGeneratePWD.FlatAppearance.BorderSize = 0;
            this.BtnGeneratePWD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.BtnGeneratePWD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGeneratePWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeneratePWD.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnGeneratePWD.Location = new System.Drawing.Point(55, 208);
            this.BtnGeneratePWD.Name = "BtnGeneratePWD";
            this.BtnGeneratePWD.Size = new System.Drawing.Size(179, 39);
            this.BtnGeneratePWD.TabIndex = 5;
            this.BtnGeneratePWD.Text = "Generate Passwords";
            this.BtnGeneratePWD.UseVisualStyleBackColor = false;
            this.BtnGeneratePWD.Click += new System.EventHandler(this.BtnGeneratePWD_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(69, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "How many passwords ?";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(69, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "How many characters ?";
            // 
            // NUDNumInput
            // 
            this.NUDNumInput.BackColor = System.Drawing.Color.White;
            this.NUDNumInput.ForeColor = System.Drawing.Color.MidnightBlue;
            this.NUDNumInput.Location = new System.Drawing.Point(55, 149);
            this.NUDNumInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDNumInput.Name = "NUDNumInput";
            this.NUDNumInput.Size = new System.Drawing.Size(179, 27);
            this.NUDNumInput.TabIndex = 2;
            this.NUDNumInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDNumInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDNumInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUDNumInput_MouseDown);
            // 
            // NUDCharsInput
            // 
            this.NUDCharsInput.BackColor = System.Drawing.Color.White;
            this.NUDCharsInput.ForeColor = System.Drawing.Color.MidnightBlue;
            this.NUDCharsInput.Location = new System.Drawing.Point(55, 62);
            this.NUDCharsInput.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.NUDCharsInput.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NUDCharsInput.Name = "NUDCharsInput";
            this.NUDCharsInput.Size = new System.Drawing.Size(179, 27);
            this.NUDCharsInput.TabIndex = 1;
            this.NUDCharsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDCharsInput.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NUDCharsInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NUDCharsInput_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.LblProceeding);
            this.panel2.Controls.Add(this.pwdOutput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(286, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 510);
            this.panel2.TabIndex = 1;
            // 
            // pwdOutput
            // 
            this.pwdOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pwdOutput.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pwdOutput.Location = new System.Drawing.Point(18, 39);
            this.pwdOutput.Multiline = true;
            this.pwdOutput.Name = "pwdOutput";
            this.pwdOutput.ReadOnly = true;
            this.pwdOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pwdOutput.Size = new System.Drawing.Size(450, 353);
            this.pwdOutput.TabIndex = 1;
            this.pwdOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pwdOutput.Visible = false;
            // 
            // LblProceeding
            // 
            this.LblProceeding.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProceeding.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblProceeding.Location = new System.Drawing.Point(29, 449);
            this.LblProceeding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProceeding.Name = "LblProceeding";
            this.LblProceeding.Size = new System.Drawing.Size(439, 28);
            this.LblProceeding.TabIndex = 16;
            this.LblProceeding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GeneratePasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneratePasswords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Passwords";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCharsInput)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDNumInput;
        private System.Windows.Forms.NumericUpDown NUDCharsInput;
        private System.Windows.Forms.Button BtnGeneratePWD;
        private System.Windows.Forms.Button BtnClearInputs;
        private System.Windows.Forms.Button BtnExportPWD;
        private System.Windows.Forms.Button BtnCopyPWD;
        private System.Windows.Forms.TextBox pwdOutput;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblProceeding;
    }
}