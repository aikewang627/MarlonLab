namespace MarlonCVJDMatcher.WinForm
{
    partial class frmSegment
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
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.rtbSourceText = new System.Windows.Forms.RichTextBox();
            this.rtbResultText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.Location = new System.Drawing.Point(12, 298);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(825, 110);
            this.rtbLog.TabIndex = 7;
            this.rtbLog.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 129);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "开始分词";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rtbSourceText
            // 
            this.rtbSourceText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSourceText.Location = new System.Drawing.Point(12, 12);
            this.rtbSourceText.Name = "rtbSourceText";
            this.rtbSourceText.Size = new System.Drawing.Size(825, 110);
            this.rtbSourceText.TabIndex = 8;
            this.rtbSourceText.Text = "";
            // 
            // rtbResultText
            // 
            this.rtbResultText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbResultText.Location = new System.Drawing.Point(12, 158);
            this.rtbResultText.Name = "rtbResultText";
            this.rtbResultText.Size = new System.Drawing.Size(825, 134);
            this.rtbResultText.TabIndex = 9;
            this.rtbResultText.Text = "";
            // 
            // frmSegment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 415);
            this.Controls.Add(this.rtbResultText);
            this.Controls.Add(this.rtbSourceText);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnStart);
            this.Name = "frmSegment";
            this.Text = "分词";
            this.Load += new System.EventHandler(this.frmSegment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtbSourceText;
        private System.Windows.Forms.RichTextBox rtbResultText;
    }
}