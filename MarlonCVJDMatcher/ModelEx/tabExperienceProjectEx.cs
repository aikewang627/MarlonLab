
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Tclywork.Platform.Common;
using Tclywork.DBUtility;
using Tclywork.Model;
using Tclywork.BLL;
using Tclywork.DAL;
#region  Model 实体类 - tabExperienceProjectEx
namespace Tclywork.Model
{
    /// <summary>
    /// 项目经验表
    /// tabExperienceProject
    /// </summary> 	
    public partial class tabExperienceProjectModel
    {
        /// <summary>
        /// 单位名称
        /// </summary>
        public string OrgName
        {
            get
            {
                tabOrgModel model = tabOrgBLL.GetInstance().GetModel(OrgID);
                if (model.IsNotNull())
                { return model.OrgName; }
                else { return ""; }
            }
            set { _OrgName = value; }
        }
        private string _OrgName;
    }
}
#endregion

#region	SQLDAL
namespace Tclywork.DAL
{
    /// <summary>
    /// 项目经验表
    /// </summary> 	
    public partial class tabExperienceProjectSQLDAL
    {
        //通过SQL语句获得详情
        public DataTable GetDetailListBySql(int ResumeId, int UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select proj.* , ");
            strSql.Append(" org.OrgName ");
            strSql.Append(" from tabExperienceProject proj ");
            strSql.Append(" left join tabOrg org on proj.OrgID = org.id ");
            strSql.AppendFormat(" where proj.ParentID={0} ",ResumeId);
            strSql.Append(" order by proj.ProjectBeginDate desc ");

            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.IsNull() || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            { return null; }
            else
            { return ds.Tables[0]; }
        }
        public bool DeleteList(int ResumeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tabExperienceWork ");
            strSql.Append(" where ParentID=" + ResumeID);
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int AddWin(tabExperienceProjectModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tabExperienceProject(");
            strSql.Append("OrgID,ProjectName,ProjectBeginDate,ProjectEndDate,ProjectDesc,ProjectPosition,ProjectPerformance,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
            strSql.Append(") values (");
            strSql.Append("@OrgID,@ProjectName,@ProjectBeginDate,@ProjectEndDate,@ProjectDesc,@ProjectPosition,@ProjectPerformance,@AppID,@Version,@RandomNo,@ParentID,@Remark,@LableText,@ExJson,@Status,@OrderNo,@CreateDate,@ModifyDate,@CreateUser,@ModifyUser");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                        new SqlParameter("@OrgID", SqlDbType.Int,4) ,
                        new SqlParameter("@ProjectName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ProjectBeginDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ProjectEndDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ProjectDesc", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@ProjectPosition", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ProjectPerformance", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@AppID", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Version", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@RandomNo", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@ParentID", SqlDbType.Int,4) ,
                        new SqlParameter("@Remark", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@LableText", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@ExJson", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@Status", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@OrderNo", SqlDbType.Int,4) ,
                        new SqlParameter("@CreateDate", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@ModifyDate", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@CreateUser", SqlDbType.Int,4) ,
                        new SqlParameter("@ModifyUser", SqlDbType.Int,4)

            };

            parameters[0].Value = model.OrgID;
            parameters[1].Value = model.ProjectName;
            parameters[2].Value = model.ProjectBeginDate;
            parameters[3].Value = model.ProjectEndDate;
            parameters[4].Value = model.ProjectDesc;
            parameters[5].Value = model.ProjectPosition;
            parameters[6].Value = model.ProjectPerformance;
            parameters[7].Value = model.AppID;
            parameters[8].Value = model.Version;
            parameters[9].Value = model.RandomNo;
            parameters[10].Value = model.ParentID;
            parameters[11].Value = model.Remark;
            parameters[12].Value = model.LableText;
            parameters[13].Value = model.ExJson;
            parameters[14].Value = model.Status;
            parameters[15].Value = model.OrderNo;
            parameters[16].Value = model.CreateDate;
            parameters[17].Value = model.ModifyDate;
            parameters[18].Value = model.CreateUser;
            parameters[19].Value = model.ModifyUser;

            object obj = DbHelperSQLWin.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {

                return Convert.ToInt32(obj);

            }

        }
    }
}
#endregion
#region BLL类    
namespace Tclywork.BLL
{
    /// <summary>
    /// 项目经验表
    /// </summary> 	
    public partial class tabExperienceProjectBLL
    {
        public DataTable GetDetailListBySql(int ResumeId, int UserID)
        {
            return dal.GetDetailListBySql(ResumeId, UserID);
        }
        public bool DeleteList(int ResumeID)
        {
            return dal.DeleteList(ResumeID);
        }
        public int AddWin(tabExperienceProjectModel model)
        {
            return dal.AddWin(model);

        }
    }
}
#endregion