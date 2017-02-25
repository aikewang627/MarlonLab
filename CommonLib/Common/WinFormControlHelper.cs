using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//

namespace MarlonLab.CommonLib.Common
{
  public  class WinFormControlHelper
    {
        //往richTextBox控件中添加日志，并滚动到底部
        public static void AddLog(RichTextBox rtbLog,string strTitle="", string strLog="")
        {
            if (rtbLog.TextLength > 10000) { rtbLog.Text = ""; }
            rtbLog.Text += string.Format("{0} {1} ==>>> {2}\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"),strTitle, strLog);
            rtbLog.SelectionStart = rtbLog.TextLength;
            rtbLog.ScrollToCaret();
        }
    }
}
