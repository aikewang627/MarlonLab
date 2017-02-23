
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
#region  Model 实体类 - tabExperienceEduEx
namespace Tclywork.Model
{
    /// <summary>
    /// 教育经历表
    /// tabExperienceEdu
    /// </summary> 	
    public partial class tabExperienceEduModel
    { }
    }
#endregion

#region	SQLDAL
namespace Tclywork.DAL
{

    /// <summary>
    /// 教育经历表
    /// </summary> 	
    public partial class tabExperienceEduSQLDAL
    {
        //通过SQL语句获得详情
        public DataTable GetDetailListBySql(int ResumeId, int UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select edu.* ");
            strSql.Append(" from tabExperienceEdu edu ");
            strSql.AppendFormat(" where edu.ParentID={0} ",ResumeId);
            strSql.Append(" order by edu.EduBeginDate desc ");        

            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.IsNull() || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            { return null; }
            else
            { return ds.Tables[0]; }
        }

        public DataSet GetListWin(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM tabExperienceEdu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQLWin.Query(strSql.ToString());
        }
        public int AddWin(tabExperienceEduModel model)
        {
            model.Version = model.Version.IsNotNullOrEmpty() ? model.Version : "1";
            model.RandomNo = model.RandomNo.IsNotNullOrEmpty() ? model.RandomNo : Guid.NewGuid().ToString("N");
            model.Status = model.Status.IsNotNullOrEmpty() ? model.Status : "1";
            model.OrderNo = model.OrderNo > 0 ? model.OrderNo : 1;
            model.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            model.ModifyDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tabExperienceEdu(");
            strSql.Append("SchoolName,ProfessionalName,EduBeginDate,EduEndDate,GetEdu,IsTZ,Is211,IsVal,AddonInfo,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
            strSql.Append(") values (");
            strSql.Append("@SchoolName,@ProfessionalName,@EduBeginDate,@EduEndDate,@GetEdu,@IsTZ,@Is211,@IsVal,@AddonInfo,@AppID,@Version,@RandomNo,@ParentID,@Remark,@LableText,@ExJson,@Status,@OrderNo,@CreateDate,@ModifyDate,@CreateUser,@ModifyUser");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                        new SqlParameter("@SchoolName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ProfessionalName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@EduBeginDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@EduEndDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@GetEdu", SqlDbType.Int,4) ,
                        new SqlParameter("@IsTZ", SqlDbType.Bit,1) ,
                        new SqlParameter("@Is211", SqlDbType.Bit,1) ,
                        new SqlParameter("@IsVal", SqlDbType.Bit,1) ,
                        new SqlParameter("@AddonInfo", SqlDbType.NVarChar,-1) ,
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

            parameters[0].Value = model.SchoolName;
            parameters[1].Value = model.ProfessionalName;
            parameters[2].Value = model.EduBeginDate;
            parameters[3].Value = model.EduEndDate;
            parameters[4].Value = model.GetEdu;
            parameters[5].Value = model.IsTZ;
            parameters[6].Value = model.Is211;
            parameters[7].Value = model.IsVal;
            parameters[8].Value = model.AddonInfo;
            parameters[9].Value = model.AppID;
            parameters[10].Value = model.Version;
            parameters[11].Value = model.RandomNo;
            parameters[12].Value = model.ParentID;
            parameters[13].Value = model.Remark;
            parameters[14].Value = model.LableText;
            parameters[15].Value = model.ExJson;
            parameters[16].Value = model.Status;
            parameters[17].Value = model.OrderNo;
            parameters[18].Value = model.CreateDate;
            parameters[19].Value = model.ModifyDate;
            parameters[20].Value = model.CreateUser;
            parameters[21].Value = model.ModifyUser;

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
        public bool DeleteList(int ResumeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tabExperienceEdu ");
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
    }
}
#endregion
#region BLL类    
namespace Tclywork.BLL
{
    /// <summary>
    /// 教育经历表
    /// </summary> 	
    public partial class tabExperienceEduBLL
    {
        public DataTable GetDetailListBySql(int ResumeId, int UserID)
        {
            return dal.GetDetailListBySql( ResumeId,  UserID);
        }
        public int AddWin(tabExperienceEduModel model)
        {
            return dal.AddWin(model);

        }
        public bool DeleteList(int ResumeID)
        {
            return dal.DeleteList(ResumeID);
        }
        public tabExperienceEduModel GetModelWin(string _where, int Index)
        {
            List<tabExperienceEduModel> lsmodel = GetModelListWin(_where);
            if (lsmodel != null && lsmodel.Count > 0)
            {
                return lsmodel[Index];
            }
            else
            {
                return null;
            }
        }
        public List<tabExperienceEduModel> GetModelListWin(string strWhere)
        {
            DataSet ds = dal.GetListWin(strWhere);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabExperienceEduModel>.FillModel(ds.Tables[0]);
            else
                return null;
        }
    }
}
#endregion