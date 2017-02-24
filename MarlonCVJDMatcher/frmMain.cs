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

        private void 加载词库至RedisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> lsJD = ReadFromFile(Config.JDKeywordFilePath);
            List<string> lsCV = ReadFromFile(Config.CVKeywordFilePath);
            List<string> lsCVJD = ReadFromFile(Config.CVJDKeywordFilePath);
            //存放于Redis
            DoRedisSet rs = new DoRedisSet();
            rs.Add("CVKeyword", lsCV);
            rs.Add("JDKeyword", lsJD);
            rs.Add("CVJDKeyword", lsCVJD);
        }

        private void 保存词库从RedisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //存放于Redis
            DoRedisSet rs = new DoRedisSet();

            HashSet<string> hsJD = rs.GetAllItemsFromSet("CVKeyword");
            HashSet<string> hsCV = rs.GetAllItemsFromSet("JDKeyword");
            HashSet<string> hsCVJD = rs.GetAllItemsFromSet("CVJDKeyword");

            SaveToFile(Config.JDKeywordFilePath,hsJD);
            SaveToFile(Config.CVKeywordFilePath, hsCV);
            SaveToFile(Config.CVJDKeywordFilePath, hsCVJD);
        }
        List<string> ReadFromFile(string FileRelativePath)
        {
            //读取文件
            string path = Path.Combine(Application.StartupPath, FileRelativePath);
            FileStream fs = new FileStream(path, FileMode.Open);
            byte[] btFileContent = new byte[fs.Length];
            fs.Read(btFileContent, 0, (int)fs.Length);
            fs.Close();
            string strFileContent = Encoding.Default.GetString(btFileContent);

            //分词
            List<string> lsFile = PanGuSegmentHelper.SegmentToStringList(strFileContent);
            return lsFile;
        }
        void SaveToFile(string FileRelativePath, HashSet<string> hsSet)
        {
            List<string> ls = hsSet.ToList<string>();
            string strFileContent = "";
            foreach (string str in ls)
            {
                strFileContent += str + "  ";
            }

            //读取文件
            string path = Path.Combine(Application.StartupPath, FileRelativePath);
            FileStream fs = new FileStream(path, FileMode.Create);
            byte[] btFileContent = Encoding.Default.GetBytes(strFileContent);            
            fs.Write(btFileContent, 0, btFileContent.Length);
            fs.Flush();
            fs.Close();
        }
        #endregion

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





    }
}
