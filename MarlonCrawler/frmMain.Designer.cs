namespace MarlonCrawler
{
    partial class frmMain
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
            this.btnJianLib = new System.Windows.Forms.Button();
            this.btnLiepinHeadhunter = new System.Windows.Forms.Button();
            this.btnLiepinHr = new System.Windows.Forms.Button();
            this.btnLiepinJobhunter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJianLib
            // 
            this.btnJianLib.Location = new System.Drawing.Point(12, 12);
            this.btnJianLib.Name = "btnJianLib";
            this.btnJianLib.Size = new System.Drawing.Size(75, 23);
            this.btnJianLib.TabIndex = 0;
            this.btnJianLib.Text = "简库爬虫";
            this.btnJianLib.UseVisualStyleBackColor = true;
            this.btnJianLib.Click += new System.EventHandler(this.btnJianLib_Click);
            // 
            // btnLiepinHeadhunter
            // 
            this.btnLiepinHeadhunter.Location = new System.Drawing.Point(12, 41);
            this.btnLiepinHeadhunter.Name = "btnLiepinHeadhunter";
            this.btnLiepinHeadhunter.Size = new System.Drawing.Size(75, 23);
            this.btnLiepinHeadhunter.TabIndex = 1;
            this.btnLiepinHeadhunter.Text = "猎聘-猎头";
            this.btnLiepinHeadhunter.UseVisualStyleBackColor = true;
            this.btnLiepinHeadhunter.Click += new System.EventHandler(this.btnLiepinHeadhunter_Click);
            // 
            // btnLiepinHr
            // 
            this.btnLiepinHr.Location = new System.Drawing.Point(203, 41);
            this.btnLiepinHr.Name = "btnLiepinHr";
            this.btnLiepinHr.Size = new System.Drawing.Size(75, 23);
            this.btnLiepinHr.TabIndex = 2;
            this.btnLiepinHr.Text = "猎聘-HR";
            this.btnLiepinHr.UseVisualStyleBackColor = true;
            this.btnLiepinHr.Click += new System.EventHandler(this.btnLiepinHr_Click);
            // 
            // btnLiepinJobhunter
            // 
            this.btnLiepinJobhunter.Location = new System.Drawing.Point(93, 41);
            this.btnLiepinJobhunter.Name = "btnLiepinJobhunter";
            this.btnLiepinJobhunter.Size = new System.Drawing.Size(104, 23);
            this.btnLiepinJobhunter.TabIndex = 3;
            this.btnLiepinJobhunter.Text = "猎聘-求职者";
            this.btnLiepinJobhunter.UseVisualStyleBackColor = true;
            this.btnLiepinJobhunter.Click += new System.EventHandler(this.btnLiepinJobhunter_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 381);
            this.Controls.Add(this.btnLiepinJobhunter);
            this.Controls.Add(this.btnLiepinHr);
            this.Controls.Add(this.btnLiepinHeadhunter);
            this.Controls.Add(this.btnJianLib);
            this.Name = "frmMain";
            this.Text = "梦龙爬虫";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJianLib;
        private System.Windows.Forms.Button btnLiepinHeadhunter;
        private System.Windows.Forms.Button btnLiepinHr;
        private System.Windows.Forms.Button btnLiepinJobhunter;
    }
}