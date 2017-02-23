
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

#region  Model 实体类 - tabResumeEx
namespace Tclywork.Model
{
    /// <summary>
    /// 简历表
    /// tabResume
    /// </summary> 	
  

}
#endregion

#region	SQLDAL
namespace Tclywork.DAL
{

    /// <summary>
    /// 简历表
    /// </summary> 	
    public partial class tabResumeSQLDAL
    {
        public bool UpdateWin(tabResumeModel model)
        {
            model.ModifyDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tabResume set ");

            strSql.Append(" ResumeNo = @ResumeNo , ");
            strSql.Append(" ResumeName = @ResumeName , ");
            strSql.Append(" UserID = @UserID , ");
            strSql.Append(" IsMe = @IsMe , ");
            strSql.Append(" IsDisplayRealName = @IsDisplayRealName , ");
            strSql.Append(" CurPosition = @CurPosition , ");
            strSql.Append(" CurSalary = @CurSalary , ");
            strSql.Append(" CurComapny = @CurComapny , ");
            strSql.Append(" CurIndustry = @CurIndustry , ");
            strSql.Append(" CurStatus = @CurStatus , ");
            strSql.Append(" CurAddress = @CurAddress , ");
            strSql.Append(" HopeAddress = @HopeAddress , ");
            strSql.Append(" HopePosition = @HopePosition , ");
            strSql.Append(" HopeIndustry = @HopeIndustry , ");
            strSql.Append(" HunterComment = @HunterComment , ");
            strSql.Append(" ResumeInitFile = @ResumeInitFile , ");
            strSql.Append(" ResumePDFFile = @ResumePDFFile , ");
            strSql.Append(" Other = @Other , ");
            strSql.Append(" Price = @Price , ");
            strSql.Append(" SourceUrl = @SourceUrl , ");
            strSql.Append(" SourceText = @SourceText , ");
            strSql.Append(" Tags = @Tags , ");
            strSql.Append(" Lang = @Lang , ");
            strSql.Append(" AppID = @AppID , ");
            strSql.Append(" Version = @Version , ");
            strSql.Append(" RandomNo = @RandomNo , ");
            strSql.Append(" ParentID = @ParentID , ");
            strSql.Append(" Remark = @Remark , ");
            strSql.Append(" LableText = @LableText , ");
            strSql.Append(" ExJson = @ExJson , ");
            strSql.Append(" Status = @Status , ");
            strSql.Append(" OrderNo = @OrderNo , ");
            strSql.Append(" CreateDate = @CreateDate , ");
            strSql.Append(" ModifyDate = @ModifyDate , ");
            strSql.Append(" CreateUser = @CreateUser , ");
            strSql.Append(" ModifyUser = @ModifyUser  ");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
                        new SqlParameter("@ResumeNo", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ResumeName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@UserID", SqlDbType.Int,4) ,
                        new SqlParameter("@IsMe", SqlDbType.Bit,1) ,
                        new SqlParameter("@IsDisplayRealName", SqlDbType.Bit,1) ,
                        new SqlParameter("@CurPosition", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@CurSalary", SqlDbType.Int,4) ,
                        new SqlParameter("@CurComapny", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@CurIndustry", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@CurStatus", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@CurAddress", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@HopeAddress", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@HopePosition", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@HopeIndustry", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@HunterComment", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@ResumeInitFile", SqlDbType.Int,4) ,
                        new SqlParameter("@ResumePDFFile", SqlDbType.Int,4) ,
                        new SqlParameter("@Other", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@Price", SqlDbType.Int,4) ,
                        new SqlParameter("@SourceUrl", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@SourceText", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Tags", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Lang", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@id", SqlDbType.Int,4) ,
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

            parameters[0].Value = model.ResumeNo;
            parameters[1].Value = model.ResumeName;
            parameters[2].Value = model.UserID;
            parameters[3].Value = model.IsMe;
            parameters[4].Value = model.IsDisplayRealName;
            parameters[5].Value = model.CurPosition;
            parameters[6].Value = model.CurSalary;
            parameters[7].Value = model.CurComapny;
            parameters[8].Value = model.CurIndustry;
            parameters[9].Value = model.CurStatus;
            parameters[10].Value = model.CurAddress;
            parameters[11].Value = model.HopeAddress;
            parameters[12].Value = model.HopePosition;
            parameters[13].Value = model.HopeIndustry;
            parameters[14].Value = model.HunterComment;
            parameters[15].Value = model.ResumeInitFile;
            parameters[16].Value = model.ResumePDFFile;
            parameters[17].Value = model.Other;
            parameters[18].Value = model.Price;
            parameters[19].Value = model.SourceUrl;
            parameters[20].Value = model.SourceText;
            parameters[21].Value = model.Tags;
            parameters[22].Value = model.Lang;
            parameters[23].Value = model.id;
            parameters[24].Value = model.AppID;
            parameters[25].Value = model.Version;
            parameters[26].Value = model.RandomNo;
            parameters[27].Value = model.ParentID;
            parameters[28].Value = model.Remark;
            parameters[29].Value = model.LableText;
            parameters[30].Value = model.ExJson;
            parameters[31].Value = model.Status;
            parameters[32].Value = model.OrderNo;
            parameters[33].Value = model.CreateDate;
            parameters[34].Value = model.ModifyDate;
            parameters[35].Value = model.CreateUser;
            parameters[36].Value = model.ModifyUser;
            int rows = DbHelperSQLWin.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int AddWin(tabResumeModel model)
        {
            model.Version = model.Version.IsNotNullOrEmpty() ? model.Version : "1";
            model.RandomNo = model.RandomNo.IsNotNullOrEmpty() ? model.RandomNo : Guid.NewGuid().ToString("N");
            model.Status = model.Status.IsNotNullOrEmpty() ? model.Status : "1";
            model.OrderNo = model.OrderNo > 0 ? model.OrderNo : 1;
            model.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            model.ModifyDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tabResume(");
            strSql.Append("ResumeNo,ResumeName,UserID,IsMe,IsDisplayRealName,CurPosition,CurSalary,CurComapny,CurIndustry,CurStatus,CurAddress,HopeAddress,HopePosition,HopeIndustry,HunterComment,ResumeInitFile,ResumePDFFile,Other,Price,SourceUrl,SourceText,Tags,Lang,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
            strSql.Append(") values (");
            strSql.Append("@ResumeNo,@ResumeName,@UserID,@IsMe,@IsDisplayRealName,@CurPosition,@CurSalary,@CurComapny,@CurIndustry,@CurStatus,@CurAddress,@HopeAddress,@HopePosition,@HopeIndustry,@HunterComment,@ResumeInitFile,@ResumePDFFile,@Other,@Price,@SourceUrl,@SourceText,@Tags,@Lang,@AppID,@Version,@RandomNo,@ParentID,@Remark,@LableText,@ExJson,@Status,@OrderNo,@CreateDate,@ModifyDate,@CreateUser,@ModifyUser");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                        new SqlParameter("@ResumeNo", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ResumeName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@UserID", SqlDbType.Int,4) ,
                        new SqlParameter("@IsMe", SqlDbType.Bit,1) ,
                        new SqlParameter("@IsDisplayRealName", SqlDbType.Bit,1) ,
                        new SqlParameter("@CurPosition", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@CurSalary", SqlDbType.Int,4) ,
                        new SqlParameter("@CurComapny", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@CurIndustry", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@CurStatus", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@CurAddress", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@HopeAddress", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@HopePosition", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@HopeIndustry", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@HunterComment", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@ResumeInitFile", SqlDbType.Int,4) ,
                        new SqlParameter("@ResumePDFFile", SqlDbType.Int,4) ,
                        new SqlParameter("@Other", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@Price", SqlDbType.Int,4) ,
                        new SqlParameter("@SourceUrl", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@SourceText", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Tags", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Lang", SqlDbType.NVarChar,50) ,
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

            parameters[0].Value = model.ResumeNo;
            parameters[1].Value = model.ResumeName;
            parameters[2].Value = model.UserID;
            parameters[3].Value = model.IsMe;
            parameters[4].Value = model.IsDisplayRealName;
            parameters[5].Value = model.CurPosition;
            parameters[6].Value = model.CurSalary;
            parameters[7].Value = model.CurComapny;
            parameters[8].Value = model.CurIndustry;
            parameters[9].Value = model.CurStatus;
            parameters[10].Value = model.CurAddress;
            parameters[11].Value = model.HopeAddress;
            parameters[12].Value = model.HopePosition;
            parameters[13].Value = model.HopeIndustry;
            parameters[14].Value = model.HunterComment;
            parameters[15].Value = model.ResumeInitFile;
            parameters[16].Value = model.ResumePDFFile;
            parameters[17].Value = model.Other;
            parameters[18].Value = model.Price;
            parameters[19].Value = model.SourceUrl;
            parameters[20].Value = model.SourceText;
            parameters[21].Value = model.Tags;
            parameters[22].Value = model.Lang;
            parameters[23].Value = model.AppID;
            parameters[24].Value = model.Version;
            parameters[25].Value = model.RandomNo;
            parameters[26].Value = model.ParentID;
            parameters[27].Value = model.Remark;
            parameters[28].Value = model.LableText;
            parameters[29].Value = model.ExJson;
            parameters[30].Value = model.Status;
            parameters[31].Value = model.OrderNo;
            parameters[32].Value = model.CreateDate;
            parameters[33].Value = model.ModifyDate;
            parameters[34].Value = model.CreateUser;
            parameters[35].Value = model.ModifyUser;

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
        public DataSet GetModelListByIDName(string strWhere)
        {
            DataSet ds = new DataSet();//临时用，防报错
            return ds;
        }
        public List<tabResumeModel> GetModelListPiLiang()
        {
            return new List<tabResumeModel>();//临时用，防报错
        }
        //取代ResumeModel，采用SQL语句获得相关信息
        public DataTable GetDetailBySql(int UserID, string ResumeNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT Rm.*, ");
            strSql.Append(" UsrPar.RealName as  RealName, ");
            strSql.Append(" UsrPar.NickName as  NickName, ");
            strSql.Append(" UsrPar.Status as  UserStatus, ");
            strSql.Append(" UsrPar.Sex as  Sex, ");
            strSql.Append(" UsrPar.Birthday as  Birthday, ");
            strSql.Append(" Age=case when UsrPar.Birthday is not null then  DateDiff(YEAR,UsrPar.Birthday,GetDate()) else 0 end , ");
            strSql.Append(" UsrPar.HeadImgURLID, ");
            strSql.Append(" HeadImgURL=(select top 1 AssetUrl from tabAsset where id=UsrPar.HeadImgURLID), ");
            strSql.Append(" UsrPar.XueLi as XueLi, ");
            strSql.Append(" UsrPar.Marriage as Marriage, ");            
            strSql.Append(" IsRealNameAu =case when PATINDEX('%RealNameAu\":true % ',UsrPar.Status)>0 then 1 else 0 end, ");
            strSql.Append(" QZZ =case when PATINDEX('%RealNameAu\":true%', UsrPar.Status)> 0 then 1 else 0 end, ");
            strSql.Append(" HrAu =case when PATINDEX('%HrAu\":true%', UsrPar.Status)> 0 then 1 else 0 end, ");
            strSql.Append(" HunterCorAu =case when PATINDEX('%HunterCorAu\":true%', UsrPar.Status)> 0 then 1 else 0 end, ");
            strSql.Append(" UsrCre.RealName as RealNameCreate, ");
            strSql.Append(" UsrCre.OrgID, ");
            strSql.Append(" OrgUsrCre.OrgName as OrgNameCreate, ");
            strSql.Append(" AuStatusTextCreate =case when PATINDEX('%RealNameAu\":true%', UsrCre.Status)> 0 then '实名认证' ");
            strSql.Append(" when PATINDEX('%HrAu\":true%', UsrCre.Status)> 0 then '企业认证' ");
            strSql.Append(" when PATINDEX('%HunterCorAu\":true%', UsrCre.Status)> 0 then '猎企认证'  else '未认证' end, ");
            strSql.Append(" IsMy =case when UsrCre.GroupID = UsrCur.GroupID then 1 else 0 end, ");
            strSql.Append(" IsCollected = Case when Fav.id is not null then 1 else 0 end, ");
            strSql.Append(" Vis.CreateDate as VisitDate ");
            strSql.Append("  FROM  tabResume Rm ");
            strSql.Append(" left join tabUser UsrCre on UsrCre.id = Rm.CreateUser ");
            strSql.Append(" left join tabOrg OrgUsrCre on OrgUsrCre.id = LTRIM(RTRIM(REPLACE(UsrCre.OrgID, ',', ' '))) ");
            strSql.Append(" left join tabUser UsrPar on UsrPar.id = Rm.ParentID ");
            strSql.AppendFormat(" left join tabUser UsrCur on UsrCur.id = {0} ",UserID);
            strSql.AppendFormat(" outer apply(select top 1 * From tabFavorite where  FavoriteType = 'Resume' and Status = '1' and ParentID = Rm.id and CreateUser ={0} ) Fav ",UserID);
            strSql.AppendFormat(" outer apply(select top 1 * From tabVisitHistory where  VisitHistoryType = 'Resume' and Status = '1' and ParentID = Rm.id and CreateUser = {0}) Vis ",UserID);
            strSql.Append("  ");
            strSql.AppendFormat(" where Rm.ResumeNo='{0}'",ResumeNo);

            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.IsNull() || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            { return null; }
            else
            { return ds.Tables[0]; }
        }

    }
}
#endregion
#region BLL类    
namespace Tclywork.BLL
{

    /// <summary>
    /// 简历表
    /// </summary> 	
    public partial class tabResumeBLL
    {
   
        public DataTable GetDetailBySql(int UserID, string ResumeNo)
        {
            return dal.GetDetailBySql(UserID, ResumeNo);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
     
    }
}
#endregion