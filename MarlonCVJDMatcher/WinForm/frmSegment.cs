using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarlonLab.CommonLib;//
using MarlonLab.CommonLib.Common;


namespace MarlonCVJDMatcher.WinForm
{
    public partial class frmSegment : Form
    {
        public frmSegment()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rtbSourceText.Text.IsNullOrEmpty())
            { WinFormControlHelper.AddLog(rtbLog, "请输入文本！！！", ""); }

            WinFormControlHelper.AddLog(rtbLog, "开始分词", "");
            List<string> lsStrResult = PanGuSegmentHelper.SegmentToStringList(rtbSourceText.Text);
            if (lsStrResult.IsNull())
            {
                WinFormControlHelper.AddLog(rtbLog, "无分词结果！！！", "");
                return;
            }

            WinFormControlHelper.AddLog(rtbLog, "分词数", lsStrResult.Count.ToString());
            HashSet<string> hsStrResult = new HashSet<string>();
            foreach (string str in lsStrResult)
            {
                hsStrResult.Add(str);
            }

            WinFormControlHelper.AddLog(rtbLog, "不重复数", hsStrResult.Count.ToString());
            string strResult = "";
            foreach (string str in hsStrResult)
            {
                strResult += str + "\r\n";
            }
            rtbResultText.Text = strResult;

        }

        private void frmSegment_Load(object sender, EventArgs e)
        {

        }
    }
}
