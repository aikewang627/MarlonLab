namespace MarlonCVJDMatcher
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbSourseText = new System.Windows.Forms.RichTextBox();
            this.btnSegment = new System.Windows.Forms.Button();
            this.rtbResultText = new System.Windows.Forms.RichTextBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbSourseText
            // 
            this.rtbSourseText.Location = new System.Drawing.Point(12, 12);
            this.rtbSourseText.Name = "rtbSourseText";
            this.rtbSourseText.Size = new System.Drawing.Size(356, 103);
            this.rtbSourseText.TabIndex = 0;
            this.rtbSourseText.Text = "";
            // 
            // btnSegment
            // 
            this.btnSegment.Location = new System.Drawing.Point(385, 106);
            this.btnSegment.Name = "btnSegment";
            this.btnSegment.Size = new System.Drawing.Size(75, 23);
            this.btnSegment.TabIndex = 1;
            this.btnSegment.Text = "分词";
            this.btnSegment.UseVisualStyleBackColor = true;
            this.btnSegment.Click += new System.EventHandler(this.btnSegment_Click);
            // 
            // rtbResultText
            // 
            this.rtbResultText.Location = new System.Drawing.Point(12, 121);
            this.rtbResultText.Name = "rtbResultText";
            this.rtbResultText.Size = new System.Drawing.Size(356, 103);
            this.rtbResultText.TabIndex = 2;
            this.rtbResultText.Text = "";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(12, 261);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(356, 103);
            this.rtbLog.TabIndex = 3;
            this.rtbLog.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 376);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.rtbResultText);
            this.Controls.Add(this.btnSegment);
            this.Controls.Add(this.rtbSourseText);
            this.Name = "frmMain";
            this.Text = "职位简历匹配";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSourseText;
        private System.Windows.Forms.Button btnSegment;
        private System.Windows.Forms.RichTextBox rtbResultText;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}

