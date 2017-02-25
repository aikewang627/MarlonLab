namespace MarlonCVJDMatcher.WinForm
{
    partial class frmHashSetOperater
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
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.tbFileFUllNameA = new System.Windows.Forms.TextBox();
            this.btnSelectFileA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectFileB = new System.Windows.Forms.Button();
            this.tbFileFUllNameB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectFileC = new System.Windows.Forms.Button();
            this.tbFileFUllNameC = new System.Windows.Forms.TextBox();
            this.btnIntersect = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.btnAExceptB = new System.Windows.Forms.Button();
            this.btnBExceptA = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnReSaveA = new System.Windows.Forms.Button();
            this.btnReSaveB = new System.Windows.Forms.Button();
            this.btnReSaveC = new System.Windows.Forms.Button();
            this.btnBUnionA = new System.Windows.Forms.Button();
            this.btnAUnionB = new System.Windows.Forms.Button();
            this.btnAUnionBExceptC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "openFileDialog1";
            // 
            // tbFileFUllNameA
            // 
            this.tbFileFUllNameA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFileFUllNameA.Location = new System.Drawing.Point(53, 12);
            this.tbFileFUllNameA.Name = "tbFileFUllNameA";
            this.tbFileFUllNameA.Size = new System.Drawing.Size(622, 21);
            this.tbFileFUllNameA.TabIndex = 0;
            // 
            // btnSelectFileA
            // 
            this.btnSelectFileA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFileA.Location = new System.Drawing.Point(681, 10);
            this.btnSelectFileA.Name = "btnSelectFileA";
            this.btnSelectFileA.Size = new System.Drawing.Size(33, 23);
            this.btnSelectFileA.TabIndex = 1;
            this.btnSelectFileA.Text = "…";
            this.btnSelectFileA.UseVisualStyleBackColor = true;
            this.btnSelectFileA.Click += new System.EventHandler(this.btnSelectFileA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "文件B";
            // 
            // btnSelectFileB
            // 
            this.btnSelectFileB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFileB.Location = new System.Drawing.Point(681, 37);
            this.btnSelectFileB.Name = "btnSelectFileB";
            this.btnSelectFileB.Size = new System.Drawing.Size(33, 23);
            this.btnSelectFileB.TabIndex = 4;
            this.btnSelectFileB.Text = "…";
            this.btnSelectFileB.UseVisualStyleBackColor = true;
            this.btnSelectFileB.Click += new System.EventHandler(this.btnSelectFileB_Click);
            // 
            // tbFileFUllNameB
            // 
            this.tbFileFUllNameB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFileFUllNameB.Location = new System.Drawing.Point(53, 39);
            this.tbFileFUllNameB.Name = "tbFileFUllNameB";
            this.tbFileFUllNameB.Size = new System.Drawing.Size(622, 21);
            this.tbFileFUllNameB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "文件C";
            // 
            // btnSelectFileC
            // 
            this.btnSelectFileC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFileC.Location = new System.Drawing.Point(681, 64);
            this.btnSelectFileC.Name = "btnSelectFileC";
            this.btnSelectFileC.Size = new System.Drawing.Size(33, 23);
            this.btnSelectFileC.TabIndex = 7;
            this.btnSelectFileC.Text = "…";
            this.btnSelectFileC.UseVisualStyleBackColor = true;
            this.btnSelectFileC.Click += new System.EventHandler(this.btnSelectFileC_Click);
            // 
            // tbFileFUllNameC
            // 
            this.tbFileFUllNameC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFileFUllNameC.Location = new System.Drawing.Point(53, 66);
            this.tbFileFUllNameC.Name = "tbFileFUllNameC";
            this.tbFileFUllNameC.Size = new System.Drawing.Size(622, 21);
            this.tbFileFUllNameC.TabIndex = 6;
            // 
            // btnIntersect
            // 
            this.btnIntersect.Location = new System.Drawing.Point(53, 180);
            this.btnIntersect.Name = "btnIntersect";
            this.btnIntersect.Size = new System.Drawing.Size(320, 23);
            this.btnIntersect.TabIndex = 10;
            this.btnIntersect.Text = "取A、B交集，保存于C";
            this.btnIntersect.UseVisualStyleBackColor = true;
            this.btnIntersect.Click += new System.EventHandler(this.btnIntersect_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnion.Location = new System.Drawing.Point(379, 180);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(296, 23);
            this.btnUnion.TabIndex = 11;
            this.btnUnion.Text = "取A、B并集，保存于C";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // btnAExceptB
            // 
            this.btnAExceptB.Location = new System.Drawing.Point(53, 122);
            this.btnAExceptB.Name = "btnAExceptB";
            this.btnAExceptB.Size = new System.Drawing.Size(320, 23);
            this.btnAExceptB.TabIndex = 12;
            this.btnAExceptB.Text = "从A集中排除B集";
            this.btnAExceptB.UseVisualStyleBackColor = true;
            this.btnAExceptB.Click += new System.EventHandler(this.btnAExceptB_Click);
            // 
            // btnBExceptA
            // 
            this.btnBExceptA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBExceptA.Location = new System.Drawing.Point(379, 122);
            this.btnBExceptA.Name = "btnBExceptA";
            this.btnBExceptA.Size = new System.Drawing.Size(296, 23);
            this.btnBExceptA.TabIndex = 13;
            this.btnBExceptA.Text = "从B集中排除A集";
            this.btnBExceptA.UseVisualStyleBackColor = true;
            this.btnBExceptA.Click += new System.EventHandler(this.btnBExceptA_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.Location = new System.Drawing.Point(14, 238);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(700, 235);
            this.rtbLog.TabIndex = 14;
            this.rtbLog.Text = "";
            // 
            // btnReSaveA
            // 
            this.btnReSaveA.Location = new System.Drawing.Point(53, 93);
            this.btnReSaveA.Name = "btnReSaveA";
            this.btnReSaveA.Size = new System.Drawing.Size(219, 23);
            this.btnReSaveA.TabIndex = 15;
            this.btnReSaveA.Text = "去除A集重复项";
            this.btnReSaveA.UseVisualStyleBackColor = true;
            this.btnReSaveA.Click += new System.EventHandler(this.btnReSaveA_Click);
            // 
            // btnReSaveB
            // 
            this.btnReSaveB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReSaveB.Location = new System.Drawing.Point(278, 93);
            this.btnReSaveB.Name = "btnReSaveB";
            this.btnReSaveB.Size = new System.Drawing.Size(212, 23);
            this.btnReSaveB.TabIndex = 16;
            this.btnReSaveB.Text = "去除B集重复项";
            this.btnReSaveB.UseVisualStyleBackColor = true;
            this.btnReSaveB.Click += new System.EventHandler(this.btnReSaveB_Click);
            // 
            // btnReSaveC
            // 
            this.btnReSaveC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReSaveC.Location = new System.Drawing.Point(496, 93);
            this.btnReSaveC.Name = "btnReSaveC";
            this.btnReSaveC.Size = new System.Drawing.Size(179, 23);
            this.btnReSaveC.TabIndex = 17;
            this.btnReSaveC.Text = "去除C集重复项";
            this.btnReSaveC.UseVisualStyleBackColor = true;
            this.btnReSaveC.Click += new System.EventHandler(this.btnReSaveC_Click);
            // 
            // btnBUnionA
            // 
            this.btnBUnionA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBUnionA.Location = new System.Drawing.Point(379, 151);
            this.btnBUnionA.Name = "btnBUnionA";
            this.btnBUnionA.Size = new System.Drawing.Size(296, 23);
            this.btnBUnionA.TabIndex = 19;
            this.btnBUnionA.Text = "B集合并A集";
            this.btnBUnionA.UseVisualStyleBackColor = true;
            this.btnBUnionA.Click += new System.EventHandler(this.btnBUnionA_Click);
            // 
            // btnAUnionB
            // 
            this.btnAUnionB.Location = new System.Drawing.Point(53, 151);
            this.btnAUnionB.Name = "btnAUnionB";
            this.btnAUnionB.Size = new System.Drawing.Size(320, 23);
            this.btnAUnionB.TabIndex = 18;
            this.btnAUnionB.Text = "A集合并B集";
            this.btnAUnionB.UseVisualStyleBackColor = true;
            this.btnAUnionB.Click += new System.EventHandler(this.btnAUnionB_Click);
            // 
            // btnAUnionBExceptC
            // 
            this.btnAUnionBExceptC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAUnionBExceptC.Location = new System.Drawing.Point(53, 209);
            this.btnAUnionBExceptC.Name = "btnAUnionBExceptC";
            this.btnAUnionBExceptC.Size = new System.Drawing.Size(622, 23);
            this.btnAUnionBExceptC.TabIndex = 20;
            this.btnAUnionBExceptC.Text = "A集 合并 ( B集 排除 C集 )，保存于A集";
            this.btnAUnionBExceptC.UseVisualStyleBackColor = true;
            this.btnAUnionBExceptC.Click += new System.EventHandler(this.btnAUnionBExceptC_Click);
            // 
            // frmHashSetOperater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 485);
            this.Controls.Add(this.btnAUnionBExceptC);
            this.Controls.Add(this.btnBUnionA);
            this.Controls.Add(this.btnAUnionB);
            this.Controls.Add(this.btnReSaveC);
            this.Controls.Add(this.btnReSaveB);
            this.Controls.Add(this.btnReSaveA);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnBExceptA);
            this.Controls.Add(this.btnAExceptB);
            this.Controls.Add(this.btnUnion);
            this.Controls.Add(this.btnIntersect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectFileC);
            this.Controls.Add(this.tbFileFUllNameC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectFileB);
            this.Controls.Add(this.tbFileFUllNameB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectFileA);
            this.Controls.Add(this.tbFileFUllNameA);
            this.Name = "frmHashSetOperater";
            this.Text = "文件集合运算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.TextBox tbFileFUllNameA;
        private System.Windows.Forms.Button btnSelectFileA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectFileB;
        private System.Windows.Forms.TextBox tbFileFUllNameB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectFileC;
        private System.Windows.Forms.TextBox tbFileFUllNameC;
        private System.Windows.Forms.Button btnIntersect;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Button btnAExceptB;
        private System.Windows.Forms.Button btnBExceptA;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnReSaveA;
        private System.Windows.Forms.Button btnReSaveB;
        private System.Windows.Forms.Button btnReSaveC;
        private System.Windows.Forms.Button btnBUnionA;
        private System.Windows.Forms.Button btnAUnionB;
        private System.Windows.Forms.Button btnAUnionBExceptC;
    }
}