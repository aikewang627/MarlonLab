using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarlonLab.CommonLib;

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
                AddLog(rtbLog, "请先输入文本");
                return;
            }

            List<string> strList = PanGuSegmentHelper.SegmentReturnStringList(rtbSourseText.Text);
            foreach (string str in strList)
            {
                rtbResultText.Text += str + "    ";
            }
        }
        public void AddLog(RichTextBox rtbLog,string strLog)
        {
            rtbLog.Text += string.Format("{0} {1}\r\n",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"),strLog);
            rtbLog.SelectionStart = rtbLog.TextLength;
            rtbLog.ScrollToCaret();

        }
    }
}
