﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarlonLab.CommonLib;
using MarlonLab.CommonLib.Common;
using MarlonLab.CommonLib.RedisHelper;//

namespace MarlonCVJDMatcher
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSegment_Click(object sender, EventArgs e)
        {

            if (rtbSourseText.TextLength == 0)
            {
                WinFormControlHelper.AddLog(rtbLog,"", "请先输入文本");
                return;
            }
            rtbResultText.Text = "";
            List<string> strList = PanGuSegmentHelper.SegmentReturnStringList(rtbSourseText.Text);
            foreach (string str in strList)
            {
                rtbResultText.Text += str + "    ";
            }          
        }

        private void 关键字加载ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<string> lsJD = FileSegment(Config.JDKeywordFilePath);
            List<string> lsCV = FileSegment(Config.CVKeywordFilePath); 
            
            //存放于Redis
            DoRedisSet rs = new DoRedisSet();
            rs.Add("CVKeyword", lsCV);
            rs.Add("JDKeyword", lsJD);
        }
        private void 简历精要提取ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForm.frmResumeOutline frmRmOtli = new WinForm.frmResumeOutline();
            frmRmOtli.Show();
        }

        private void 职位精要提取ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForm.frmPositionOutLine frmPosOtli = new WinForm.frmPositionOutLine();
            frmPosOtli.Show();
        }

        private void 匹配ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinForm.frmCVJDMatch frmMch = new WinForm.frmCVJDMatch();
            frmMch.Show();
        }


        List<string> FileSegment(string FileRelativePath)
        {
            //读取文件
            string path = Path.Combine(Application.StartupPath,FileRelativePath);
            FileStream fs = new FileStream(path, FileMode.Open);
            byte[] btFileContent = new byte[fs.Length];
            fs.Read(btFileContent, 0, (int)fs.Length);
            fs.Close();
            string strFileContent = Encoding.Default.GetString(btFileContent);

            //分词
            List<string> lsFile = PanGuSegmentHelper.SegmentReturnStringList(strFileContent);
            return lsFile;            
        }



    }
}
