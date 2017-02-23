
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

#region  Model 实体类 - tabOrgEx
namespace Tclywork.Model
{
    /// <summary>
    /// tabOrg
    /// tabOrg
    /// </summary>

    public partial class tabOrgModel
    { }
    }
#endregion

#region	SQLDAL
namespace Tclywork.DAL
{
    /// <summary>
    /// tabOrg
    /// </summary>
    public partial class tabOrgSQLDAL
    {
        public DataTable GetOgrPhotoDetailListBySql(int OrgID, int UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(" select * ");
            strSql.AppendFormat(" From tabAsset ");
            strSql.AppendFormat("where  ParentID = {0} and AssetType = 'OrgPhoto' ", OrgID);

            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.IsNull() || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            { return null; }
            else
            { return ds.Tables[0]; }

        }
        public int AddWin(tabOrgModel model)
        {
            model.Version = model.Version.IsNotNullOrEmpty() ? model.Version : "1";
            model.RandomNo = model.RandomNo.IsNotNullOrEmpty() ? model.RandomNo : Guid.NewGuid().ToString("N");
            model.Status = model.Status.IsNotNullOrEmpty() ? model.Status : "1";
            model.OrderNo = model.OrderNo > 0 ? model.OrderNo : 1;
            model.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            model.ModifyDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tabOrg(");
            strSql.Append("OrgName,OrgDesc,OrgNickName,OrgZZ,OrgCode,OrgType,OrgClass,OrgLevel,OrgEdge,OrgPro,OrgCard,PlanNum,Leader,LeaderMobile,Logo,WebSite,Phone,ZZNo,ZZImg,Natrue,PY,Country,State,City,District,Community,Address,AreaFull,ZipCode,QQOpenID,WeiXinOpenID,Fax,Email,SaleType,Scale,Source,SaleStatus,BankName,BankAccount,CreateUnitDate,BeginDate,EndDate,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
            strSql.Append(") values (");
            strSql.Append("@OrgName,@OrgDesc,@OrgNickName,@OrgZZ,@OrgCode,@OrgType,@OrgClass,@OrgLevel,@OrgEdge,@OrgPro,@OrgCard,@PlanNum,@Leader,@LeaderMobile,@Logo,@WebSite,@Phone,@ZZNo,@ZZImg,@Natrue,@PY,@Country,@State,@City,@District,@Community,@Address,@AreaFull,@ZipCode,@QQOpenID,@WeiXinOpenID,@Fax,@Email,@SaleType,@Scale,@Source,@SaleStatus,@BankName,@BankAccount,@CreateUnitDate,@BeginDate,@EndDate,@AppID,@Version,@RandomNo,@ParentID,@Remark,@LableText,@ExJson,@Status,@OrderNo,@CreateDate,@ModifyDate,@CreateUser,@ModifyUser");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                        new SqlParameter("@OrgName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@OrgDesc", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@OrgNickName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@OrgZZ", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@OrgCode", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@OrgType", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@OrgClass", SqlDbType.Int,4) ,
                        new SqlParameter("@OrgLevel", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@OrgEdge", SqlDbType.NVarChar,500) ,
                        new SqlParameter("@OrgPro", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@OrgCard", SqlDbType.Int,4) ,
                        new SqlParameter("@PlanNum", SqlDbType.Int,4) ,
                        new SqlParameter("@Leader", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@LeaderMobile", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Logo", SqlDbType.Int,4) ,
                        new SqlParameter("@WebSite", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Phone", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ZZNo", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ZZImg", SqlDbType.Int,4) ,
                        new SqlParameter("@Natrue", SqlDbType.Int,4) ,
                        new SqlParameter("@PY", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Country", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@State", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@City", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@District", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Community", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Address", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@AreaFull", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@ZipCode", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@QQOpenID", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@WeiXinOpenID", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Fax", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Email", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@SaleType", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Scale", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Source", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@SaleStatus", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@BankName", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@BankAccount", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@CreateUnitDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@BeginDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@EndDate", SqlDbType.NVarChar,50) ,
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

            parameters[0].Value = model.OrgName;
            parameters[1].Value = model.OrgDesc;
            parameters[2].Value = model.OrgNickName;
            parameters[3].Value = model.OrgZZ;
            parameters[4].Value = model.OrgCode;
            parameters[5].Value = model.OrgType;
            parameters[6].Value = model.OrgClass;
            parameters[7].Value = model.OrgLevel;
            parameters[8].Value = model.OrgEdge;
            parameters[9].Value = model.OrgPro;
            parameters[10].Value = model.OrgCard;
            parameters[11].Value = model.PlanNum;
            parameters[12].Value = model.Leader;
            parameters[13].Value = model.LeaderMobile;
            parameters[14].Value = model.Logo;
            parameters[15].Value = model.WebSite;
            parameters[16].Value = model.Phone;
            parameters[17].Value = model.ZZNo;
            parameters[18].Value = model.ZZImg;
            parameters[19].Value = model.Natrue;
            parameters[20].Value = model.PY;
            parameters[21].Value = model.Country;
            parameters[22].Value = model.State;
            parameters[23].Value = model.City;
            parameters[24].Value = model.District;
            parameters[25].Value = model.Community;
            parameters[26].Value = model.Address;
            parameters[27].Value = model.AreaFull;
            parameters[28].Value = model.ZipCode;
            parameters[29].Value = model.QQOpenID;
            parameters[30].Value = model.WeiXinOpenID;
            parameters[31].Value = model.Fax;
            parameters[32].Value = model.Email;
            parameters[33].Value = model.SaleType;
            parameters[34].Value = model.Scale;
            parameters[35].Value = model.Source;
            parameters[36].Value = model.SaleStatus;
            parameters[37].Value = model.BankName;
            parameters[38].Value = model.BankAccount;
            parameters[39].Value = model.CreateUnitDate;
            parameters[40].Value = model.BeginDate;
            parameters[41].Value = model.EndDate;
            parameters[42].Value = model.AppID;
            parameters[43].Value = model.Version;
            parameters[44].Value = model.RandomNo;
            parameters[45].Value = model.ParentID;
            parameters[46].Value = model.Remark;
            parameters[47].Value = model.LableText;
            parameters[48].Value = model.ExJson;
            parameters[49].Value = model.Status;
            parameters[50].Value = model.OrderNo;
            parameters[51].Value = model.CreateDate;
            parameters[52].Value = model.ModifyDate;
            parameters[53].Value = model.CreateUser;
            parameters[54].Value = model.ModifyUser;

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
        public DataSet GetModelListByOrgID(int OrgID, string QueryType = "down")
        {
            IDataParameter[] iDataPara = new SqlParameter[2];
            iDataPara[0] = new SqlParameter("@ID", OrgID);
            iDataPara[1] = new SqlParameter("@QueryType", QueryType);
            return DbHelperSQL.RunProcedure("GetOrgTreeByID", iDataPara, "tabOrg");
        }
        public bool GetModelExistOrgName(string OrgName)
        {
            bool bRes = false;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("  from tabOrg ");
            strSql.Append(" where OrgName=@OrgName");
            SqlParameter[] parameters = {
                    new SqlParameter("@OrgName", SqlDbType.NVarChar)
            };
            parameters[0].Value = OrgName;
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
                bRes = true;
            else
                bRes = false;
            return bRes;
        }
        public tabOrgModel GetModelExistOrgEmail(string Email)
        {
            bool bRes = false;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("  from tabOrg ");
            strSql.Append(" where Email=@Email");
            SqlParameter[] parameters = {
                    new SqlParameter("@Email", SqlDbType.NVarChar)
            };
            parameters[0].Value = Email;
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabOrgModel>.FillModel(ds.Tables[0].Rows[0]);
            else
                return null;
        }
        public tabOrgModel GetModelExistOrgEmail(string Email, int OrgID)
        {
            bool bRes = false;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("  from tabOrg ");
            strSql.Append(" where Email=@Email and id<>@OrgID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Email", SqlDbType.NVarChar),
                     new SqlParameter("@OrgID", SqlDbType.Int)
            };
            parameters[0].Value = Email;
            parameters[1].Value = OrgID;
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabOrgModel>.FillModel(ds.Tables[0].Rows[0]);
            else
                return null;
        }
        public DataSet GetListWin(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM tabOrg ");
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
    /// tabOrg
    /// </summary>
    public partial class tabOrgBLL
    {
        public DataTable GetOgrPhotoDetailListBySql(int OrgID, int UserID)
        {
            return dal.GetOgrPhotoDetailListBySql(OrgID, UserID);
        }
        public int AddWin(tabOrgModel model)
        {
            return dal.AddWin(model);

        }
        /// <summary>
        /// 根据id,获取组织架构
        /// </summary>
        public List<tabOrgModel> GetModelListByOrgID(int OrgID, string QueryType = "down")
        {
            DataSet ds = dal.GetModelListByOrgID(OrgID, QueryType);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabOrgModel>.FillModel(ds.Tables[0]);
            else
                return null;
        }
        public bool GetModelExistOrgName(string OrgName)
        {
            return dal.GetModelExistOrgName(OrgName);
        }
        public tabOrgModel GetModelExistOrgEmail(string Email)
        {
            return dal.GetModelExistOrgEmail(Email);
        }
        public tabOrgModel GetModelExistOrgEmail(string Email, int OrgID)
        {
            return dal.GetModelExistOrgEmail(Email, OrgID);
        }

        public DataSet GetModelListWin(string strWhere)
        {
            DataSet ds = dal.GetListWin(strWhere);
            if (ds.Tables[0].Rows.Count > 0)
                return ds;
            else
                return null;
        }
    }

}
#endregion