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
            this.SuspendLayout();
            // 
            // btnJianLib
            // 
            this.btnJianLib.Location = new System.Drawing.Point(58, 47);
            this.btnJianLib.Name = "btnJianLib";
            this.btnJianLib.Size = new System.Drawing.Size(75, 23);
            this.btnJianLib.TabIndex = 0;
            this.btnJianLib.Text = "简库爬虫";
            this.btnJianLib.UseVisualStyleBackColor = true;
            this.btnJianLib.Click += new System.EventHandler(this.btnJianLib_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 381);
            this.Controls.Add(this.btnJianLib);
            this.Name = "frmMain";
            this.Text = "梦龙爬虫";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJianLib;
    }
}