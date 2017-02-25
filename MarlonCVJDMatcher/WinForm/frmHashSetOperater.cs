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

namespace MarlonCVJDMatcher.WinForm
{
    public partial class frmHashSetOperater : Form
    {



        HashSet<string> hsSetA = new HashSet<string>();
        HashSet<string> hsSetB = new HashSet<string>();
        HashSet<string> hsSetC = new HashSet<string>();

        public frmHashSetOperater()
        {
            InitializeComponent();
            
        }

        private void btnSelectFileA_Click(object sender, EventArgs e)
        {
            SelectFileFullName(tbFileFUllNameA);
        }

        private void btnSelectFileB_Click(object sender, EventArgs e)
        {
            SelectFileFullName(tbFileFUllNameB);
        }

        private void btnSelectFileC_Click(object sender, EventArgs e)
        {
            SelectFileFullName(tbFileFUllNameC);
        }
        void SelectFileFullName(TextBox tb)
        {
            dlgOpenFile.FileName = Application.StartupPath;
            dlgOpenFile.ShowDialog();
            tb.Text = dlgOpenFile.FileName;
        }
        bool CheckCondition()
        {
            if (tbFileFUllNameA.Text.IsNullOrEmpty())
            {
                WinFormControlHelper.AddLog(rtbLog,"","文件路径不可为空");
                return false;
            }
            if (tbFileFUllNameB.Text.IsNullOrEmpty())
            {
                WinFormControlHelper.AddLog(rtbLog, "", "文件路径不可为空");
                return false;
            }
            if (tbFileFUllNameC.Text.IsNullOrEmpty())
            {
                WinFormControlHelper.AddLog(rtbLog, "", "文件路径不可为空");
                return false;
            }
            return true;
        }





        private void btnReSaveA_Click(object sender, EventArgs e)
        {
            if (tbFileFUllNameA.Text.IsNullOrEmpty())
            {
                WinFormControlHelper.AddLog(rtbLog, "", "文件路径不可为空");
            }
            else
            {
                hsSetA = ReadFromFile(tbFileFUllNameA.Text);
                WinFormControlHelper.AddLog(rtbLog, "A集数量", hsSetA.Count.ToString());
                SaveToFile(tbFileFUllNameA.Text, hsSetA);
            }
        }

        private void btnReSaveB_Click(object sender, EventArgs e)
        {
            if (tbFileFUllNameB.Text.IsNullOrEmpty())
            {
                WinFormControlHelper.AddLog(rtbLog, "", "文件路径不可为空");
            }
            else
            {
                hsSetB = ReadFromFile(tbFileFUllNameB.Text);
                WinFormControlHelper.AddLog(rtbLog, "B集数量", hsSetB.Count.ToString());
                SaveToFile(tbFileFUllNameB.Text, hsSetB);
            }
        }

        private void btnReSaveC_Click(object sender, EventArgs e)
        {
            if (tbFileFUllNameC.Text.IsNullOrEmpty())
            {
                WinFormControlHelper.AddLog(rtbLog, "", "文件路径不可为空");
            }
            else
            {
                hsSetC = ReadFromFile(tbFileFUllNameC.Text);
                WinFormControlHelper.AddLog(rtbLog, "C集数量", hsSetC.Count.ToString());
                SaveToFile(tbFileFUllNameC.Text, hsSetC);
            }
        }

        private void btnAExceptB_Click(object sender, EventArgs e)
        {
            if (tbFileFUllNameA.Text.IsNullOrEmpty() || tbFileFUllNameB.Text.IsNullOrEmpty())
            {
                WinFormControlHelper.AddLog(rtbLog, "", "文件路径不可为空");
            }
            else
            {
                hsSetA = ReadFromFile(tbFileFUllNameA.Text);
                WinFormControlHelper.AddLog(rtbLog, "A集数量", hsSetA.Count.ToString());
                hsSetB = ReadFromFile(tbFileFUllNameB.Text);
                WinFormControlHelper.AddLog(rtbLog, "B集数量", hsSetB.Count.ToString());
                hsSetA.ExceptWith(hsSetB);
                WinFormControlHelper.AddLog(rtbLog, "运算后数量", hsSetA.Count.ToString());

                SaveToFile(tbFileFUllNameA.Text, hsSetA);
            }
        }

        private void btnBExceptA_Click(object sender, EventArgs e)
        {
            if (tbFileFUllNameA.Text.IsNullOrEmpty() || tbFileFUllNameB.Text.IsNullOrEmpty())
            {
                WinFormControlHelper.AddLog(rtbLog, "", "文件路径不可为空");
            }
            else
            {
                hsSetA = ReadFromFile(tbFileFUllNameA.Text);
                WinFormControlHelper.AddLog(rtbLog, "A集数量", hsSetA.Count.ToString());
                hsSetB = ReadFromFile(tbFileFUllNameB.Text);
                WinFormControlHelper.AddLog(rtbLog, "B集数量", hsSetB.Count.ToString());
                hsSetB.ExceptWith(hsSetA);
                WinFormControlHelper.AddLog(rtbLog, "运算后数量", hsSetB.Count.ToString());
                SaveToFile(tbFileFUllNameB.Text, hsSetB);
            }
        }


        private void btnAUnionB_Click(object sender, EventArgs e)
        {
            if (tbFileFUllNameA.Text.IsNullOrEmpty() || tbFileFUllNameB.Text.IsNullOrEmpty())
            {
                WinFormControlHelper.AddLog(rtbLog, "", "文件路径不可为空");
            }
            else
            {
                hsSetA = ReadFromFile(tbFileFUllNameA.Text);
                WinFormControlHelper.AddLog(rtbLog, "A集数量", hsSetA.Count.ToString());
                hsSetB = ReadFromFile(tbFileFUllNameB.Text);
                WinFormControlHelper.AddLog(rtbLog, "B集数量", hsSetB.Count.ToString());
                hsSetA.UnionWith(hsSetB);
                WinFormControlHelper.AddLog(rtbLog, "运算后数量", hsSetA.Count.ToString());

                SaveToFile(tbFileFUllNameA.Text, hsSetA);
            }
        }

        private void btnBUnionA_Click(object sender, EventArgs e)
        {
            if (tbFileFUllNameA.Text.IsNullOrEmpty() || tbFileFUllNameB.Text.IsNullOrEmpty())
            {
                WinFormControlHelper.AddLog(rtbLog, "", "文件路径不可为空");
            }
            else
            {
                hsSetA = ReadFromFile(tbFileFUllNameA.Text);
                WinFormControlHelper.AddLog(rtbLog, "A集数量", hsSetA.Count.ToString());
                hsSetB = ReadFromFile(tbFileFUllNameB.Text);
                WinFormControlHelper.AddLog(rtbLog, "B集数量", hsSetB.Count.ToString());
                hsSetB.UnionWith(hsSetA);
                WinFormControlHelper.AddLog(rtbLog, "运算后数量", hsSetB.Count.ToString());
                SaveToFile(tbFileFUllNameB.Text, hsSetB);
            }
        }

        private void btnIntersect_Click(object sender, EventArgs e)
        {
            if (CheckCondition())
            {
                hsSetA = ReadFromFile(tbFileFUllNameA.Text);
                WinFormControlHelper.AddLog(rtbLog, "A集数量", hsSetA.Count.ToString());
                hsSetB = ReadFromFile(tbFileFUllNameB.Text);
                WinFormControlHelper.AddLog(rtbLog, "B集数量", hsSetA.Count.ToString());
                hsSetA.IntersectWith(hsSetB);
                WinFormControlHelper.AddLog(rtbLog, "运算后数量", hsSetA.Count.ToString());
                SaveToFile(tbFileFUllNameC.Text, hsSetA);
            }
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            if (CheckCondition())
            {
                hsSetA = ReadFromFile(tbFileFUllNameA.Text);
                WinFormControlHelper.AddLog(rtbLog, "A集数量", hsSetA.Count.ToString());
                hsSetB = ReadFromFile(tbFileFUllNameB.Text);
                WinFormControlHelper.AddLog(rtbLog, "B集数量", hsSetB.Count.ToString());
                hsSetA.UnionWith(hsSetB);
                WinFormControlHelper.AddLog(rtbLog, "运算后数量", hsSetA.Count.ToString());
                SaveToFile(tbFileFUllNameC.Text, hsSetA);
            }
        }
        private void btnAUnionBExceptC_Click(object sender, EventArgs e)
        {
            if (CheckCondition())
            {
                hsSetA = ReadFromFile(tbFileFUllNameA.Text);
                WinFormControlHelper.AddLog(rtbLog, "A集数量", hsSetA.Count.ToString());
                hsSetB = ReadFromFile(tbFileFUllNameB.Text);
                WinFormControlHelper.AddLog(rtbLog, "B集数量", hsSetB.Count.ToString());
                hsSetC = ReadFromFile(tbFileFUllNameC.Text);
                WinFormControlHelper.AddLog(rtbLog, "C集数量", hsSetC.Count.ToString());
                hsSetB.ExceptWith(hsSetC);
                hsSetA.UnionWith(hsSetB);
                WinFormControlHelper.AddLog(rtbLog, "运算后数量", hsSetA.Count.ToString());
                SaveToFile(tbFileFUllNameC.Text, hsSetA);
            }
        }

        #region


        HashSet<string> ReadFromFile(string fileFullName)
        {
            HashSet<string> hsRet = new HashSet<string>();

            string strFileContent = FileHelper.ReadFromFile(fileFullName);
            String[] aryString = strFileContent.Split(new char[] { ' ','\r','\n' });
            foreach (string str in aryString)
            {
                hsRet.Add(str);
            }
            hsRet.Remove("");
            return hsRet;
        }

        void SaveToFile(string fileFullName, HashSet<string> hsFileContent)
        {
            string strFileContent = "";
            foreach (string str in hsFileContent)
            {
                strFileContent += str + " ";
            }
            FileHelper.SaveToFile(fileFullName, strFileContent);
        }


        #endregion


    }
}
