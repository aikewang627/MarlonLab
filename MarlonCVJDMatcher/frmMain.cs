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
                AddLog(rtbLog, "请先输入文本");
                return;
            }

            List<string> strList = PanGuSegmentHelper.SegmentReturnStringList(rtbSourseText.Text);
            foreach (string str in strList)
            {
                rtbResultText.Text += str + "    ";
            }
            SegmentJDKeyword();
            SegmentCVKeyword();
            Matcher();
        }

        void SegmentJDKeyword()
        {
            //读取文件
            string path = Path.Combine(Application.StartupPath,
                MarlonLab.CommonLib.Common.AppConfigHelper.GetConfigString("JDKeywordFilePath"));
            FileStream fs = new FileStream(path, FileMode.Open);
            byte[] btFileContent = new byte[fs.Length];
            fs.Read(btFileContent, 0, (int)fs.Length);
            fs.Close();
            string strFileContent = Encoding.Default.GetString(btFileContent);


            //分词
            List<string> lsFile = PanGuSegmentHelper.SegmentReturnStringList(strFileContent);


            //存放于Redis
            DoRedisSet redisSet = new DoRedisSet();
            redisSet.Add("JDKeyword",lsFile);

            
        }
        void SegmentCVKeyword()
        {
            //读取文件
            string path = Path.Combine(Application.StartupPath,
    MarlonLab.CommonLib.Common.AppConfigHelper.GetConfigString("CVKeywordFilePath"));
            FileStream fs = new FileStream(path, FileMode.Open);
            byte[] btFileContent = new byte[fs.Length];
            fs.Read(btFileContent, 0, (int)fs.Length);
            fs.Close();
            string strFileContent = Encoding.Default.GetString(btFileContent);

            //分词
            List<string> lsFile = PanGuSegmentHelper.SegmentReturnStringList(strFileContent);


            //存放于Redis
            DoRedisSet redisSet = new DoRedisSet();
            redisSet.Add("JDKeyword", lsFile);


        }
        void Matcher()
        {


        }
        public void AddLog(RichTextBox rtbLog,string strLog)
        {
            rtbLog.Text += string.Format("{0} {1}\r\n",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"),strLog);
            rtbLog.SelectionStart = rtbLog.TextLength;
            rtbLog.ScrollToCaret();

        }
    }
}
