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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.匹配词库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载词库至RedisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存词库从RedisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cVJDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简历精要提取ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.职位精要提取ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匹配ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbSourseText
            // 
            this.rtbSourseText.Location = new System.Drawing.Point(12, 28);
            this.rtbSourseText.Name = "rtbSourseText";
            this.rtbSourseText.Size = new System.Drawing.Size(356, 103);
            this.rtbSourseText.TabIndex = 0;
            this.rtbSourseText.Text = "";
            // 
            // btnSegment
            // 
            this.btnSegment.Location = new System.Drawing.Point(374, 64);
            this.btnSegment.Name = "btnSegment";
            this.btnSegment.Size = new System.Drawing.Size(80, 23);
            this.btnSegment.TabIndex = 1;
            this.btnSegment.Text = "分词";
            this.btnSegment.UseVisualStyleBackColor = true;
            this.btnSegment.Click += new System.EventHandler(this.btnSegment_Click);
            // 
            // rtbResultText
            // 
            this.rtbResultText.Location = new System.Drawing.Point(460, 28);
            this.rtbResultText.Name = "rtbResultText";
            this.rtbResultText.Size = new System.Drawing.Size(356, 103);
            this.rtbResultText.TabIndex = 2;
            this.rtbResultText.Text = "";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(12, 137);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(804, 324);
            this.rtbLog.TabIndex = 3;
            this.rtbLog.Text = "";
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.匹配词库ToolStripMenuItem,
            this.cVJDToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(828, 25);
            this.msMain.TabIndex = 5;
            this.msMain.Text = "menuStrip1";
            // 
            // 匹配词库ToolStripMenuItem
            // 
            this.匹配词库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载词库至RedisToolStripMenuItem,
            this.保存词库从RedisToolStripMenuItem});
            this.匹配词库ToolStripMenuItem.Name = "匹配词库ToolStripMenuItem";
            this.匹配词库ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.匹配词库ToolStripMenuItem.Text = "匹配词库";
            // 
            // 加载词库至RedisToolStripMenuItem
            // 
            this.加载词库至RedisToolStripMenuItem.Name = "加载词库至RedisToolStripMenuItem";
            this.加载词库至RedisToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.加载词库至RedisToolStripMenuItem.Text = "加载词库至Redis";
            this.加载词库至RedisToolStripMenuItem.Click += new System.EventHandler(this.加载词库至RedisToolStripMenuItem_Click);
            // 
            // 保存词库从RedisToolStripMenuItem
            // 
            this.保存词库从RedisToolStripMenuItem.Name = "保存词库从RedisToolStripMenuItem";
            this.保存词库从RedisToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.保存词库从RedisToolStripMenuItem.Text = "保存词库从Redis";
            this.保存词库从RedisToolStripMenuItem.Click += new System.EventHandler(this.保存词库从RedisToolStripMenuItem_Click);
            // 
            // cVJDToolStripMenuItem
            // 
            this.cVJDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.简历精要提取ToolStripMenuItem,
            this.职位精要提取ToolStripMenuItem,
            this.匹配ToolStripMenuItem});
            this.cVJDToolStripMenuItem.Name = "cVJDToolStripMenuItem";
            this.cVJDToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.cVJDToolStripMenuItem.Text = "CVJD";
            // 
            // 简历精要提取ToolStripMenuItem
            // 
            this.简历精要提取ToolStripMenuItem.Name = "简历精要提取ToolStripMenuItem";
            this.简历精要提取ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.简历精要提取ToolStripMenuItem.Text = "简历精要提取";
            this.简历精要提取ToolStripMenuItem.Click += new System.EventHandler(this.简历精要提取ToolStripMenuItem_Click);
            // 
            // 职位精要提取ToolStripMenuItem
            // 
            this.职位精要提取ToolStripMenuItem.Name = "职位精要提取ToolStripMenuItem";
            this.职位精要提取ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.职位精要提取ToolStripMenuItem.Text = "职位精要提取";
            this.职位精要提取ToolStripMenuItem.Click += new System.EventHandler(this.职位精要提取ToolStripMenuItem_Click);
            // 
            // 匹配ToolStripMenuItem
            // 
            this.匹配ToolStripMenuItem.Name = "匹配ToolStripMenuItem";
            this.匹配ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.匹配ToolStripMenuItem.Text = "匹配";
            this.匹配ToolStripMenuItem.Click += new System.EventHandler(this.匹配ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 473);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.rtbResultText);
            this.Controls.Add(this.btnSegment);
            this.Controls.Add(this.rtbSourseText);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.Text = "职位简历匹配";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSourseText;
        private System.Windows.Forms.Button btnSegment;
        private System.Windows.Forms.RichTextBox rtbResultText;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem cVJDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 简历精要提取ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 职位精要提取ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匹配ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 匹配词库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载词库至RedisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存词库从RedisToolStripMenuItem;
    }
}

