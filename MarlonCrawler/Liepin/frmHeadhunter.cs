using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarlonLab.CommonLib;


namespace MarlonCrawler.Liepin
{
    //此窗体用于获取猎聘网的简历
    public partial class frmHeadhunter : Form
    {

        string strStorePathBasic = @"e:\";
        string strStorePathLog = @"e:\Log\";
        string strWebBrowserUrl = @"https://passport.liepin.com/h/account/#sfrom=click-pc_homepage-front_navigation-hunter_new";
        string strCookie = "";
        public frmHeadhunter()
        {
            InitializeComponent();
            InitializeComponent2();
        }
        void InitializeComponent2()
        {
            tbStorePath.Text = strStorePathBasic;
            tbWebBrowserUrl.Text = strWebBrowserUrl;

        }
        //选择存放路径
        private void btnSelectStorePath_Click(object sender, EventArgs e)
        {
            dlgSelectStorePath.SelectedPath = strStorePathBasic;
            dlgSelectStorePath.ShowDialog();
            strStorePathBasic = tbStorePath.Text = dlgSelectStorePath.SelectedPath;
            strStorePathLog = strStorePathBasic + @"\Log";
            if (!Directory.Exists(strStorePathBasic)) { Directory.CreateDirectory(strStorePathBasic); }
            if (!Directory.Exists(strStorePathLog)) { Directory.CreateDirectory(strStorePathLog); }
        }
        //跳转到指定路径
        private void btnGotoUrl_Click(object sender, EventArgs e)
        {
            strWebBrowserUrl = tbWebBrowserUrl.Text;
            if (!strWebBrowserUrl.IsUrl())
            {
                AddLog("请输入正确的网址！！！");
                return;
            }
            wbMain.Navigate(tbWebBrowserUrl.Text);
        }
        private void wbMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if ((e.Url==wbMain.Url)&&(wbMain.ReadyState == WebBrowserReadyState.Complete))
            {
                strCookie = wbMain.Document.Cookie;
                AddLog(string.Format("浏览器加载完成！Cookie为:{0}",strCookie));

            }
          

        }

        //启动
        private void btnStart_Click(object sender, EventArgs e)
        {

        }
        //添加日志
        void AddLog(string msg)
        {
            if (rtbLog.Text.Length > 100000)
            {
                if (!Directory.Exists(strStorePathLog)) { Directory.CreateDirectory(strStorePathLog); }
                string fileFullName = string.Format(strStorePathLog + @"\{0}-{1}.txt", "Log", DateTime.Now.ToString("yyyyMMddHHmmss"));
                FileStream fs = new FileStream(fileFullName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(rtbLog.Text);
                sw.Flush();
                sw.Close();
                fs.Close();

                rtbLog.Text = "";
            }

            rtbLog.Text += DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss fff") + "  " + msg + "\r\n ";
            rtbLog.SelectionStart = rtbLog.Text.Length;
            rtbLog.ScrollToCaret();
        }


    }
}
