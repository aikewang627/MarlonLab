namespace MarlonCrawler.JianLib
{
    partial class frmJianLib
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.wbMain = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnSelectStorePath = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStorePath = new System.Windows.Forms.TextBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.dlgStorePath = new System.Windows.Forms.FolderBrowserDialog();
            this.tmLogin = new System.Windows.Forms.Timer(this.components);
            this.tmAjaxRequest = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.wbMain);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbLog);
            this.splitContainer1.Size = new System.Drawing.Size(900, 561);
            this.splitContainer1.SplitterDistance = 443;
            this.splitContainer1.TabIndex = 0;
            // 
            // wbMain
            // 
            this.wbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbMain.Location = new System.Drawing.Point(3, 111);
            this.wbMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMain.Name = "wbMain";
            this.wbMain.Size = new System.Drawing.Size(433, 443);
            this.wbMain.TabIndex = 0;
            this.wbMain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbMain_DocumentCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.btnSelectStorePath);
            this.groupBox1.Controls.Add(this.btStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbUserName);
            this.groupBox1.Controls.Add(this.tbKeyword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbStorePath);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 102);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(257, 11);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(120, 21);
            this.tbPassword.TabIndex = 3;
            // 
            // btnSelectStorePath
            // 
            this.btnSelectStorePath.Location = new System.Drawing.Point(302, 38);
            this.btnSelectStorePath.Name = "btnSelectStorePath";
            this.btnSelectStorePath.Size = new System.Drawing.Size(32, 23);
            this.btnSelectStorePath.TabIndex = 9;
            this.btnSelectStorePath.Text = "…";
            this.btnSelectStorePath.UseVisualStyleBackColor = true;
            this.btnSelectStorePath.Click += new System.EventHandler(this.btnSelectStorePath_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(302, 69);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(53, 23);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "启动";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "关键字";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(62, 13);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(154, 21);
            this.tbUserName.TabIndex = 1;
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(62, 69);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(234, 21);
            this.tbKeyword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "存放路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "口令";
            // 
            // tbStorePath
            // 
            this.tbStorePath.Location = new System.Drawing.Point(62, 40);
            this.tbStorePath.Name = "tbStorePath";
            this.tbStorePath.Size = new System.Drawing.Size(234, 21);
            this.tbStorePath.TabIndex = 5;
            // 
            // rtbLog
            // 
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(0, 0);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(449, 557);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // tmLogin
            // 
            this.tmLogin.Interval = 1000;
            this.tmLogin.Tick += new System.EventHandler(this.tmLogin_Tick);
            // 
            // tmAjaxRequest
            // 
            this.tmAjaxRequest.Interval = 1000;
            this.tmAjaxRequest.Tick += new System.EventHandler(this.tmAjaxRequest_Tick);
            // 
            // frmJianLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmJianLib";
            this.Text = "简库爬虫";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.WebBrowser wbMain;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStorePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnSelectStorePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.FolderBrowserDialog dlgStorePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer tmLogin;
        private System.Windows.Forms.Timer tmAjaxRequest;
    }
}

