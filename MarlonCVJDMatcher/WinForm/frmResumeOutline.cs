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

namespace MarlonCVJDMatcher.WinForm
{
    public partial class frmResumeOutline : Form
    {

        int iStNo = 0;
        int iEndNo = 0;
        int iCurNo = 0;



        public frmResumeOutline()
        {
            InitializeComponent();

            tbStNo.Text = "1";
            tbEndNo.Text = "1000";

        }

        private void frmResumeOutline_Load(object sender, EventArgs e)
        {
            try
            {
                #region 


                #endregion
            }
            catch (Exception ex)
            {
                WinFormControlHelper.AddLog(rtbLog, "frmResumeOutline_Load", ex.Message);
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
                funResumeOutLine(iCurNo);
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                #region 


                #endregion
            }
            catch (Exception ex)
            {
                WinFormControlHelper.AddLog(rtbLog, "btnStop_Click", ex.Message);
            }
        }
        void funResumeOutLine(int ResumeID)
        {
            try
            {
                #region 


                WinFormControlHelper.AddLog(rtbLog, "开始插入/更新tabResumeOutlineModel " + ResumeID, "");
                int count = 0;
                string _where = "";
                string _order = " id desc";
                //获取详情
                tabResumeModel modelRm = tabResumeBLL.GetInstance().GetModel(ResumeID);
                _where = string.Format(" id={0} ", modelRm.ParentID);
                tabUserModel modelUsr = tabUserBLL.GetInstance().GetModel(_where, 0);
                if (modelUsr.IsNull()) { modelUsr = new tabUserModel(); }
                _where = string.Format(" ParentID={0} ", modelRm.id);
                List<tabExperienceEduModel> lsmodelEdu = tabExperienceEduBLL.GetInstance().GetModelList(20, 1, _where, _order, out count);
                if (lsmodelEdu.IsNull()) { lsmodelEdu = new List<tabExperienceEduModel>(); }
                List<tabExperienceWorkModel> lsmodelWork = tabExperienceWorkBLL.GetInstance().GetModelList(20, 1, _where, _order, out count);
                if (lsmodelWork.IsNull()) { lsmodelWork = new List<tabExperienceWorkModel>(); }
                List<tabExperienceProjectModel> lsmodelProject = tabExperienceProjectBLL.GetInstance().GetModelList(20, 1, _where, _order, out count);
                if (lsmodelProject.IsNull()) { lsmodelProject = new List<tabExperienceProjectModel>(); }
                //组合成新的模型
                bool IsExist = false;
                _where = string.Format(" ResumeID={0} ", modelRm.id);
                tabResumeOutlineModel modelRmOtln = tabResumeOutlineBLL.GetInstance().GetModel(_where, 0);
                IsExist = modelRmOtln.IsNotNull();
                if (!IsExist) { modelRmOtln = new tabResumeOutlineModel(); }
                #region
                modelRmOtln.ResumeID = modelRm.id;
                modelRmOtln.ResumeNo = modelRm.ResumeNo;
                modelRmOtln.ResumeName = modelRm.ResumeName;
                modelRmOtln.HopeAddress = modelRm.HopeAddress;
                modelRmOtln.HopeIndustry = modelRm.HopeIndustry;
                modelRmOtln.HopePosition = modelRm.HopePosition;
                modelRmOtln.HopeSalary = modelRm.HopeSalary;
                modelRmOtln.RealName = modelUsr.RealName;
                modelRmOtln.Birthday = modelUsr.Birthday;
                modelRmOtln.Mobile = modelUsr.Mobile;
                modelRmOtln.Email = modelUsr.Email;
                modelRmOtln.Sex = modelUsr.Sex;
                #region
                foreach ( tabExperienceEduModel model in lsmodelEdu)
                {

                }
                #endregion
                #region
                foreach (tabExperienceWorkModel model in lsmodelWork)
                {


                }
                #endregion
                #region
                foreach (tabExperienceProjectModel model in lsmodelProject)
                {


                }
                #endregion

                #endregion
                //插入或更新
                if (IsExist)
                {
                    tabResumeOutlineBLL.GetInstance().Update(modelRmOtln);
                    WinFormControlHelper.AddLog(rtbLog, "更新tabResumeOutlineModel " + ResumeID, "成功");
                }
                else
                {
                    tabResumeOutlineBLL.GetInstance().Add(modelRmOtln);
                    WinFormControlHelper.AddLog(rtbLog, "插入tabResumeOutlineModel " + ResumeID, "成功");
                }

                #endregion
            }
            catch (Exception ex)
            {
                WinFormControlHelper.AddLog(rtbLog, "funResumeOutLine", ex.Message);
            }
        }

    }
}
