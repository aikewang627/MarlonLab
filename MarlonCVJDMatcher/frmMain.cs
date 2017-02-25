using System;
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
            List<string> strList = PanGuSegmentHelper.SegmentToStringList(rtbSourseText.Text);
            foreach (string str in strList)
            {
                rtbResultText.Text += str + "    ";
            }          
        }


        #region
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




        #endregion

        private void 集运算ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WinForm.frmHashSetOperater frm = new WinForm.frmHashSetOperater();
            frm.Show();
        }
    }
}
