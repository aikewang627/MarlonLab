
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
#region  Model 实体类 - tabExperienceWorkEx
namespace Tclywork.Model
{
    /// <summary>
    /// 工作经历表
    /// tabExperienceWork
    /// </summary> 	
    public partial class tabExperienceWorkModel
    {


    }
}
#endregion

#region	SQLDAL
namespace Tclywork.DAL
{
    /// <summary>
    /// 工作经历表
    /// </summary> 	
    public partial class tabExperienceWorkSQLDAL
    {
        //通过SQL语句获得详情
        public DataTable GetDetailListBySql(int ResumeId, int UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select work.* , ");
            strSql.Append(" org.OrgName ");
            strSql.Append(" from tabExperienceWork work ");
            strSql.Append(" left join tabOrg org on work.OrgID = org.id ");
            strSql.AppendFormat(" where work.ParentID={0} ", ResumeId);
            strSql.Append(" order by work.PositionBeginDate desc ");

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
        public int AddWin(tabExperienceWorkModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tabExperienceWork(");
            strSql.Append("OrgID,OrgBeginDate,OrgEndDate,PositionName,PositionAddress,PositionBeginDate,PositionEndDate,DeptNum,PositionDuties,ReportObj,DeptName,WorkPerformance,IsVal,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
            strSql.Append(") values (");
            strSql.Append("@OrgID,@OrgBeginDate,@OrgEndDate,@PositionName,@PositionAddress,@PositionBeginDate,@PositionEndDate,@DeptNum,@PositionDuties,@ReportObj,@DeptName,@WorkPerformance,@IsVal,@AppID,@Version,@RandomNo,@ParentID,@Remark,@LableText,@ExJson,@Status,@OrderNo,@CreateDate,@ModifyDate,@CreateUser,@ModifyUser");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                        new SqlParameter("@OrgID", SqlDbType.Int,4) ,
                        new SqlParameter("@OrgBeginDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@OrgEndDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@PositionName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@PositionAddress", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@PositionBeginDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@PositionEndDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@DeptNum", SqlDbType.Int,4) ,
                        new SqlParameter("@PositionDuties", SqlDbType.NVarChar,1000) ,
                        new SqlParameter("@ReportObj", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@DeptName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@WorkPerformance", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@IsVal", SqlDbType.Bit,1) ,
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
            parameters[1].Value = model.OrgBeginDate;
            parameters[2].Value = model.OrgEndDate;
            parameters[3].Value = model.PositionName;
            parameters[4].Value = model.PositionAddress;
            parameters[5].Value = model.PositionBeginDate;
            parameters[6].Value = model.PositionEndDate;
            parameters[7].Value = model.DeptNum;
            parameters[8].Value = model.PositionDuties;
            parameters[9].Value = model.ReportObj;
            parameters[10].Value = model.DeptName;
            parameters[11].Value = model.WorkPerformance;
            parameters[12].Value = model.IsVal;
            parameters[13].Value = model.AppID;
            parameters[14].Value = model.Version;
            parameters[15].Value = model.RandomNo;
            parameters[16].Value = model.ParentID;
            parameters[17].Value = model.Remark;
            parameters[18].Value = model.LableText;
            parameters[19].Value = model.ExJson;
            parameters[20].Value = model.Status;
            parameters[21].Value = model.OrderNo;
            parameters[22].Value = model.CreateDate;
            parameters[23].Value = model.ModifyDate;
            parameters[24].Value = model.CreateUser;
            parameters[25].Value = model.ModifyUser;

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
        public DataSet GetListWin(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM tabExperienceWork ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQLWin.Query(strSql.ToString());
        }
    }
}
#endregion
#region BLL类    
namespace Tclywork.BLL
{
    /// <summary>
    /// 工作经历表
    /// </summary> 	
    public partial class tabExperienceWorkBLL
    {
        public DataTable GetDetailListBySql(int ResumeId, int UserID)
        {
            return dal.GetDetailListBySql(ResumeId, UserID);
        }
        public bool DeleteList(int ResumeID)
        {
            return dal.DeleteList(ResumeID);
        }
        public int AddWin(tabExperienceWorkModel model)
        {
            return dal.AddWin(model);

        }
        public tabExperienceWorkModel GetModelWin(string _where, int Index)
        {
            List<tabExperienceWorkModel> lsmodel = GetModelListWin(_where);
            if (lsmodel != null && lsmodel.Count > 0)
            {
                return lsmodel[Index];
            }
            else
            {
                return null;
            }
        }
        public List<tabExperienceWorkModel> GetModelListWin(string strWhere)
        {
            DataSet ds = dal.GetListWin(strWhere);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabExperienceWorkModel>.FillModel(ds.Tables[0]);
            else
                return null;
        }
    }
}
#endregion