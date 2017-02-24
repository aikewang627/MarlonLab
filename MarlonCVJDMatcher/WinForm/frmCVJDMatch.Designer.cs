namespace MarlonCVJDMatcher.WinForm
{
    partial class frmCVJDMatch
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
            this.btnJDStart = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tbPositionNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResumeNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCVStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJDStart
            // 
            this.btnJDStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJDStart.Location = new System.Drawing.Point(536, 10);
            this.btnJDStart.Name = "btnJDStart";
            this.btnJDStart.Size = new System.Drawing.Size(55, 23);
            this.btnJDStart.TabIndex = 13;
            this.btnJDStart.Text = "匹配";
            this.btnJDStart.UseVisualStyleBackColor = true;
            this.btnJDStart.Click += new System.EventHandler(this.btnJDStart_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.Location = new System.Drawing.Point(11, 39);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(580, 386);
            this.rtbLog.TabIndex = 12;
            this.rtbLog.Text = "";
            // 
            // tbPositionNo
            // 
            this.tbPositionNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPositionNo.Location = new System.Drawing.Point(430, 10);
            this.tbPositionNo.Name = "tbPositionNo";
            this.tbPositionNo.Size = new System.Drawing.Size(100, 21);
            this.tbPositionNo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "JD编号";
            // 
            // tbResumeNo
            // 
            this.tbResumeNo.Location = new System.Drawing.Point(68, 12);
            this.tbResumeNo.Name = "tbResumeNo";
            this.tbResumeNo.Size = new System.Drawing.Size(100, 21);
            this.tbResumeNo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "CV编号";
            // 
            // btnCVStart
            // 
            this.btnCVStart.Location = new System.Drawing.Point(174, 10);
            this.btnCVStart.Name = "btnCVStart";
            this.btnCVStart.Size = new System.Drawing.Size(55, 23);
            this.btnCVStart.TabIndex = 7;
            this.btnCVStart.Text = "匹配";
            this.btnCVStart.UseVisualStyleBackColor = true;
            this.btnCVStart.Click += new System.EventHandler(this.btnCVStart_Click);
            // 
            // frmCVJDMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 437);
            this.Controls.Add(this.btnJDStart);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.tbPositionNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbResumeNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCVStart);
            this.Name = "frmCVJDMatch";
            this.Text = "frmCVJDMatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJDStart;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.TextBox tbPositionNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResumeNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCVStart;
    }
}