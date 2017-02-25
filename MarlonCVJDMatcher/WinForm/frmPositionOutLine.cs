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
using Tclywork.Model;
using Tclywork.BLL;
using System.IO;

namespace MarlonCVJDMatcher.WinForm
{
    public partial class frmPositionOutLine : Form
    {

        int iStNo = 0;
        int iEndNo = 0;
        int iCurNo = 0;

        HashSet<string> hsCVJDKeyWord = new HashSet<string>();
        HashSet<string> hsJDSkill = new HashSet<string>();
        HashSet<string> hsCVJDSkillFull = new HashSet<string>();

        public frmPositionOutLine()
        {
            InitializeComponent();

            tbStNo.Text = "9";
            tbEndNo.Text = "50";
            string path = Path.Combine(Application.StartupPath, Config.CVJDKeywordFilePath);
            string strCVJDKeyWord = FileHelper.ReadFromFile(path);//读文件
            List<string> lsCVJDKeyWord = PanGuSegmentHelper.SegmentToStringList(strCVJDKeyWord);//盘古分词
            foreach (string key in lsCVJDKeyWord)//加入集合
            {
                hsCVJDKeyWord.Add(key);
            }

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                iStNo = int.Parse(tbStNo.Text);
                iEndNo = int.Parse(tbEndNo.Text);
            }
            catch (Exception ex)
            { WinFormControlHelper.AddLog(rtbLog, "", ex.Message); }

            for (iCurNo = iStNo; iCurNo <= iEndNo; iCurNo++)
            {
                funPositionOutLine(iCurNo);
            }

        }

        private void btnSaveSkillKeywordNew_Click(object sender, EventArgs e)
        {
            try
            {
                #region 
                string strKeywordNew = "";
                foreach (string str in hsCVJDSkillFull)
                { strKeywordNew += str + "\r\n"; }
                FileHelper.SaveToFile(string.Format(@"{0}\CVJDKeywordNew{1}.txt", Application.StartupPath, DateTime.Now.ToString("yyyyMMddHHmmss")), strKeywordNew);
                #endregion
            }
            catch (Exception ex)
            {
                WinFormControlHelper.AddLog(rtbLog, "btnStop_Click", ex.Message);
            }
        }
        void funPositionOutLine(int PositionID)
        {
            try
            {
                #region 


                WinFormControlHelper.AddLog(rtbLog, "开始插入/更新tabPositionOutlineModel " + PositionID, "");
                int count = 0;
                string _where = "";
                string _order = " id desc";
                //获取详情
                tabPositionModel modelPos = tabPositionBLL.GetInstance().GetModel(PositionID);
                _where = string.Format(" id={0} ", modelPos.ParentID);
                tabOrgModel modelOrg = tabOrgBLL.GetInstance().GetModel(_where, 0);
                if (modelOrg.IsNull()) { modelOrg = new tabOrgModel(); }

                //组合成新的模型
                bool IsExist = false;
                _where = string.Format(" PositionID={0} ", modelPos.id);
                tabPositionOutlineModel modelPosOtln = tabPositionOutlineBLL.GetInstance().GetModel(_where, 0);
                IsExist = modelPosOtln.IsNotNull();
                if (!IsExist) { modelPosOtln = new tabPositionOutlineModel(); }
                #region
                modelPosOtln.PositionID = modelPos.id;
                modelPosOtln.PositionName = modelPos.PositionName;
                modelPosOtln.RequireWorkYear = modelPos.RequireYear;
                modelPosOtln.RequireXueLi = modelPos.RequireEdu;
                modelPosOtln.SalaryBein = modelPos.SalaryBein;
                modelPosOtln.SalaryEnd = modelPos.SalaryEnd;
                modelPosOtln.WordAddress = modelPos.WordAddress;

                modelPosOtln.OrgName = modelOrg.OrgName;
                modelPosOtln.OrgPro = modelOrg.OrgPro;
                modelPosOtln.OrgScale = modelOrg.Scale;

                string strSkill = " ";
                strSkill += modelPos.PositionDesc+ " ";
                strSkill += modelPos.RequireContent + " ";
                strSkill += modelPos.RequireAbility + " ";
                strSkill += modelPos.RequireExperience + " ";
                strSkill += modelPos.AdditionInfo + " ";
                #region  Skill
                //
                List<string> lsSkill = PanGuSegmentHelper.SegmentToStringList(strSkill); //分词
                hsJDSkill = new HashSet<string>();
                foreach (string key in lsSkill)//加入集合
                {
                    hsJDSkill.Add(key);
                    hsCVJDSkillFull.Add(key);
                }
                //获得交集
                hsJDSkill.IntersectWith(hsCVJDKeyWord);
                //转化成字符串
                strSkill = "";
                foreach (string str in hsJDSkill)
                {
                    strSkill += str + " ";
                }
                modelPosOtln.RequireSkill = strSkill;
                #endregion
                #endregion
                //插入或更新
                if (IsExist)
                {
                    tabPositionOutlineBLL.GetInstance().Update(modelPosOtln);
                    WinFormControlHelper.AddLog(rtbLog, "更新tabPositionOutlineModel " + PositionID, "成功");
                }
                else
                {
                    tabPositionOutlineBLL.GetInstance().Add(modelPosOtln);
                    WinFormControlHelper.AddLog(rtbLog, "插入tabPositionOutlineModel " + PositionID, "成功");
                }

                #endregion
            }
            catch (Exception ex)
            {
                WinFormControlHelper.AddLog(rtbLog, "funPositionOutLine", ex.Message);
            }
        }

    }
}
