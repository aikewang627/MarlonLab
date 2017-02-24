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
    public partial class frmCVJDMatch : Form
    {
        int iResumeID = 0;
        int iPositionID = 0;


        public frmCVJDMatch()
        {
            InitializeComponent();

            tbResumeNo.Text = "19973";
            tbPositionNo.Text = "9";




        }
        #region
        private void btnCVStart_Click(object sender, EventArgs e)
        {
            try
            {
                iResumeID = int.Parse(tbResumeNo.Text);

            }
            catch (Exception ex)
            { WinFormControlHelper.AddLog(rtbLog, "", ex.Message); }

            MatchForCV(iResumeID);

        }
        void MatchForCV(int ResumeID)
        {

            try
            {
                #region 
                tabResumeOutlineModel modelRmOtln = tabResumeOutlineBLL.GetInstance().GetModel(ResumeID);

                #endregion
            }
            catch (Exception ex)
            {
                WinFormControlHelper.AddLog(rtbLog, "MatchForCV", ex.Message);
            }

        }

        #endregion

        #region


        private void btnJDStart_Click(object sender, EventArgs e)
        {
            try
            {
                iPositionID = int.Parse(tbPositionNo.Text);

            }
            catch (Exception ex)
            { WinFormControlHelper.AddLog(rtbLog, "", ex.Message); }

            MatchForJD(iPositionID);
        }
        void MatchForJD(int PositionID)
        {

            try
            {
                #region 
                //
                List<tabCVJDMatchModel> slsCVJDMatch = new List< tabCVJDMatchModel>();//用于存放匹配结果，最大数量为100
                slsCVJDMatch.Capacity = 5;
                //
                #region 获取JD简要模型
                tabPositionOutlineModel modelPosOtln = tabPositionOutlineBLL.GetInstance().GetModel(" PositionID="+PositionID+" ",0);
                if (modelPosOtln.IsNull())
                {
                    WinFormControlHelper.AddLog(rtbLog, "MatchForJD", "需要先进行要提取");
                }
                //Skill
                string[] aryJDSkill = modelPosOtln.RequireSkill.Split(new char[] { ' ', ',' });
                HashSet<string> hsJDSkill = new HashSet<string>();
                foreach (string str in aryJDSkill)
                {
                    hsJDSkill.Add(str);
                }
                hsJDSkill.Remove("");
                WinFormControlHelper.AddLog(rtbLog, "职位 " + modelPosOtln.PositionName + " 技能关键字", modelPosOtln.RequireSkill); ;

                #endregion

                //粗选适合的简历
                string _where = "";
                if (modelPosOtln.RequireSchool.IsNotNull()) { _where += " "; }

                string _orderby = "";
                int count = 0;
                int pageSize = 1000;
                int pageNo = 1;
                do
                {
                    #region
                    List<int> lsResumeID = tabCVJDMatchBLL.GetInstance().GetResumeIDListForJD(pageSize, pageNo, _where.ToString(), _orderby, out count);

                    //逐个计算
                    foreach (int ResumeID in lsResumeID)
                    {

                        #region 获取CV简历模型
                        tabResumeOutlineModel modelRmOtln = tabResumeOutlineBLL.GetInstance().GetModel(" ResumeID=" + ResumeID + " ",0);
                        //Skill
                        string[] aryCVSkill = modelRmOtln.Skill.Split(new char[] { ' ', ',' });
                        HashSet<string> hsCVSkill = new HashSet<string>();
                        foreach (string str in aryCVSkill)
                        {
                            hsCVSkill.Add(str);
                        }
                        hsJDSkill.Remove("");
                        WinFormControlHelper.AddLog(rtbLog, "简历"+modelRmOtln.ResumeNo+"技能关键字", modelRmOtln.Skill); ;
                        #endregion

                        #region  评价
                        tabCVJDMatchModel modelMch = new tabCVJDMatchModel();
                        modelMch.PositionID = modelPosOtln.PositionID;
                        modelMch.ResumeID = modelRmOtln.ResumeID;
                        modelMch.ResumeNo = modelRmOtln.ResumeNo;
                        modelMch.BaseOn = "Position";

                        hsCVSkill.IntersectWith(hsJDSkill);
                        modelMch.Skill = (hsCVSkill.Count * 100) / hsJDSkill.Count;
                        modelMch.MatchDegree = modelMch.Skill;
                        WinFormControlHelper.AddLog(rtbLog, "简历" + modelRmOtln.ResumeNo + "综合评价", modelMch.MatchDegree.ToString()); 
                        #endregion

                        #region 保存到内存列表中（只保存前100条记录）
                        //是否要删除
                        if (slsCVJDMatch.Count == slsCVJDMatch.Capacity )
                        {
                            tabCVJDMatchModel modelMin = slsCVJDMatch[0];
                            foreach(tabCVJDMatchModel model in slsCVJDMatch)
                            {
                                if(model.MatchDegree<modelMin.MatchDegree)
                                { modelMin = model; }
                            }
                            slsCVJDMatch.Remove(modelMin);
                        }
                        //是否添加
                        if (slsCVJDMatch.Count < slsCVJDMatch.Capacity)
                        {
                            slsCVJDMatch.Add( modelMch);
                        }                   


                        #endregion

                    }
                    #endregion
                    pageNo++;//
                }
                while (pageNo * pageSize < count);
                #region  保存至数据库
                //删除原来的
                tabCVJDMatchBLL.GetInstance().Delete(" PositionID="+PositionID+" and BaseOn='Position' ");
                //添加新的
                WinFormControlHelper.AddLog(rtbLog, "匹配结果", ""); 
                foreach (tabCVJDMatchModel model in slsCVJDMatch)
                {
                    tabCVJDMatchBLL.GetInstance().Add(model);
                    WinFormControlHelper.AddLog(rtbLog, model.ResumeID.ToString() + " " + model.ResumeNo, model.MatchDegree.ToString());
                }
                #endregion

                #endregion
            }
            catch (Exception ex)
            {
                WinFormControlHelper.AddLog(rtbLog, "MatchForJD", ex.Message);
            }


        }
        #endregion






    }
}
