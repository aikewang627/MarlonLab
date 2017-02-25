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
            this.tbPositionNoSt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResumeNoSt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCVStart = new System.Windows.Forms.Button();
            this.btnJDGet = new System.Windows.Forms.Button();
            this.btnCVGet = new System.Windows.Forms.Button();
            this.tbResumeNoEnd = new System.Windows.Forms.TextBox();
            this.tbPositionNoEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJDStart
            // 
            this.btnJDStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJDStart.Location = new System.Drawing.Point(509, 41);
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
            this.rtbLog.Location = new System.Drawing.Point(11, 72);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(676, 353);
            this.rtbLog.TabIndex = 12;
            this.rtbLog.Text = "";
            // 
            // tbPositionNoSt
            // 
            this.tbPositionNoSt.Location = new System.Drawing.Point(68, 43);
            this.tbPositionNoSt.Name = "tbPositionNoSt";
            this.tbPositionNoSt.Size = new System.Drawing.Size(100, 21);
            this.tbPositionNoSt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "JD编号";
            // 
            // tbResumeNoSt
            // 
            this.tbResumeNoSt.Location = new System.Drawing.Point(68, 12);
            this.tbResumeNoSt.Name = "tbResumeNoSt";
            this.tbResumeNoSt.Size = new System.Drawing.Size(100, 21);
            this.tbResumeNoSt.TabIndex = 9;
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
            this.btnCVStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCVStart.Location = new System.Drawing.Point(509, 12);
            this.btnCVStart.Name = "btnCVStart";
            this.btnCVStart.Size = new System.Drawing.Size(55, 23);
            this.btnCVStart.TabIndex = 7;
            this.btnCVStart.Text = "匹配";
            this.btnCVStart.UseVisualStyleBackColor = true;
            this.btnCVStart.Click += new System.EventHandler(this.btnCVStart_Click);
            // 
            // btnJDGet
            // 
            this.btnJDGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJDGet.Location = new System.Drawing.Point(570, 41);
            this.btnJDGet.Name = "btnJDGet";
            this.btnJDGet.Size = new System.Drawing.Size(117, 23);
            this.btnJDGet.TabIndex = 14;
            this.btnJDGet.Text = "获得历史结果";
            this.btnJDGet.UseVisualStyleBackColor = true;
            this.btnJDGet.Click += new System.EventHandler(this.btnJDGet_Click);
            // 
            // btnCVGet
            // 
            this.btnCVGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCVGet.Location = new System.Drawing.Point(570, 12);
            this.btnCVGet.Name = "btnCVGet";
            this.btnCVGet.Size = new System.Drawing.Size(117, 23);
            this.btnCVGet.TabIndex = 15;
            this.btnCVGet.Text = "获取历史结果";
            this.btnCVGet.UseVisualStyleBackColor = true;
            // 
            // tbResumeNoEnd
            // 
            this.tbResumeNoEnd.Location = new System.Drawing.Point(197, 12);
            this.tbResumeNoEnd.Name = "tbResumeNoEnd";
            this.tbResumeNoEnd.Size = new System.Drawing.Size(100, 21);
            this.tbResumeNoEnd.TabIndex = 16;
            // 
            // tbPositionNoEnd
            // 
            this.tbPositionNoEnd.Location = new System.Drawing.Point(197, 43);
            this.tbPositionNoEnd.Name = "tbPositionNoEnd";
            this.tbPositionNoEnd.Size = new System.Drawing.Size(100, 21);
            this.tbPositionNoEnd.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "--";
            // 
            // frmCVJDMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 437);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPositionNoEnd);
            this.Controls.Add(this.tbResumeNoEnd);
            this.Controls.Add(this.btnCVGet);
            this.Controls.Add(this.btnJDGet);
            this.Controls.Add(this.btnJDStart);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.tbPositionNoSt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbResumeNoSt);
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
        private System.Windows.Forms.TextBox tbPositionNoSt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResumeNoSt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCVStart;
        private System.Windows.Forms.Button btnJDGet;
        private System.Windows.Forms.Button btnCVGet;
        private System.Windows.Forms.TextBox tbResumeNoEnd;
        private System.Windows.Forms.TextBox tbPositionNoEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}