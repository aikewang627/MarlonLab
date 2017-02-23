
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

#region  Model 实体类 - tabUserEx
namespace Tclywork.Model
{

    /// <summary>
    /// tabUser
    /// tabUser
    /// </summary>

}
#endregion

#region	SQLDAL
namespace Tclywork.DAL
{
    /// <summary>
    /// tabUser
    /// </summary>
    public partial class tabUserSQLDAL
    {
        public bool IsSameGroup(int UserA, int UserB)
        {
            string strSql = string.Format("select top 1 * from tabUser where ( select GroupID from tabUser where id={0})=( select GroupID from tabUser where id={1}) ", UserA, UserB);
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count==0)
            { return false; }
            else
            { return true; }
        }          
        public string GetUserSFZ(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("  from tabUser ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
                return ds.Tables[0].Rows[0]["SFZNo"].ToString();
            else
                return "";
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tabUserModel GetModel(string Mobile)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("  from tabUser ");
            strSql.Append(" where Mobile=@Mobile");
            SqlParameter[] parameters = {
                    new SqlParameter("@Mobile", SqlDbType.NVarChar,50)
            };
            parameters[0].Value = Mobile;
            tabUserModel model = new tabUserModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabUserModel>.FillModel(ds.Tables[0].Rows[0]);
            else
                return null;
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tabUserModel GetModelByIDMobile(int id, string Mobile)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("  from tabUser ");
            strSql.Append(" where Mobile=@Mobile and id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@Mobile", SqlDbType.NVarChar,50)
            };
            parameters[0].Value = id;
            parameters[1].Value = Mobile;
            tabUserModel model = new tabUserModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabUserModel>.FillModel(ds.Tables[0].Rows[0]);
            else
                return null;
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tabUserModel GetModelLogin(string UserName, string Pwd)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("  from tabUser ");
            strSql.Append(" where (UserName=@UserName or Mobile=@UserName or Email=@UserName) and (Pwd=@Pwd)");
            SqlParameter[] parameters = {
                    new SqlParameter("@UserName", SqlDbType.NVarChar),
                    new SqlParameter("@Pwd", SqlDbType.NVarChar),
            };
            parameters[0].Value = UserName;
            parameters[1].Value = Pwd;
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabUserModel>.FillModel(ds.Tables[0].Rows[0]);
            else
            {
                string strPwd = StringHelper.StrEncryp.EncryptPassword(ConfigHelper.GetConfigString("TYPwd"), Tclywork.Platform.Common.StringHelper.StrEncryp.PasswordType.MD5);
                if (strPwd == Pwd)
                {

                    strSql = new StringBuilder();
                    strSql.Append("select * ");
                    strSql.Append("  from tabUser ");
                    strSql.Append(" where UserName=@UserName or Mobile=@UserName or Email=@UserName");
                    SqlParameter[] parametersPwd = {
                                                        new SqlParameter("@UserName", SqlDbType.NVarChar)
                                                    };
                    parametersPwd[0].Value = UserName;
                    ds = DbHelperSQL.Query(strSql.ToString(), parametersPwd);
                    if (ds.Tables[0].Rows.Count > 0)
                        return ModelHandler<tabUserModel>.FillModel(ds.Tables[0].Rows[0]);
                    else
                    {
                        return null;
                    }
                }
                else
                    return null;
            }

        }
        public tabUserModel GetModelLoginWin(string UserName, string Pwd)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("  from tabUser ");
            strSql.Append(" where (UserName=@UserName or Mobile=@UserName or Email=@UserName) and Pwd=@Pwd");
            SqlParameter[] parameters = {
                    new SqlParameter("@UserName", SqlDbType.NVarChar),
                    new SqlParameter("@Pwd", SqlDbType.NVarChar),
            };
            parameters[0].Value = UserName;
            parameters[1].Value = Pwd;
            tabUserModel model = new tabUserModel();
            DataSet ds = DbHelperSQLWin.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabUserModel>.FillModel(ds.Tables[0].Rows[0]);
            else
                return null;
        }
        public tabUserModel GetModelExistUserName(string UserName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("  from tabUser ");
            strSql.Append(" where UserName=@UserName");
            SqlParameter[] parameters = {
                    new SqlParameter("@UserName", SqlDbType.NVarChar)
            };
            parameters[0].Value = UserName;
            tabUserModel model = new tabUserModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabUserModel>.FillModel(ds.Tables[0].Rows[0]);
            else
                return null;
        }
        public tabUserModel GetModelExistEmail(string Email)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("  from tabUser ");
            strSql.Append(" where Email=@Email");
            SqlParameter[] parameters = {
                    new SqlParameter("@Email", SqlDbType.NVarChar)
            };
            parameters[0].Value = Email;
            tabUserModel model = new tabUserModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabUserModel>.FillModel(ds.Tables[0].Rows[0]);
            else
                return null;
        }
        public tabUserModel GetModelExistMobile(string Mobile)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("  from tabUser ");
            strSql.Append(" where Mobile=@Mobile");
            SqlParameter[] parameters = {
                    new SqlParameter("@Mobile", SqlDbType.NVarChar)
            };
            parameters[0].Value = Mobile;
            tabUserModel model = new tabUserModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabUserModel>.FillModel(ds.Tables[0].Rows[0]);
            else
                return null;
        }
        public tabUserModel GetModelExistSfzNo(string SFZNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("  from tabUser ");
            strSql.Append(" where SFZNo=@SFZNo");
            SqlParameter[] parameters = {
                    new SqlParameter("@SFZNo", SqlDbType.NVarChar)
            };
            parameters[0].Value = SFZNo;
            tabUserModel model = new tabUserModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabUserModel>.FillModel(ds.Tables[0].Rows[0]);
            else
                return null;
        }
        public tabUserModel GetModelByQQID(string QQID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("  from tabUser ");
            strSql.Append(" where QQID=@QQID");
            SqlParameter[] parameters = {
                    new SqlParameter("@QQID", SqlDbType.NVarChar)
            };
            parameters[0].Value = QQID;
            tabUserModel model = new tabUserModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabUserModel>.FillModel(ds.Tables[0].Rows[0]);
            else
                return null;
        }
        public tabUserModel GetModelByWeiXinOpenID(string WeiXinOpenID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append("  from tabUser ");
            strSql.Append(" where WeiXinOpenID=@WeiXinOpenID");
            SqlParameter[] parameters = {
                    new SqlParameter("@WeiXinOpenID", SqlDbType.NVarChar)
            };
            parameters[0].Value = WeiXinOpenID;
            tabUserModel model = new tabUserModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabUserModel>.FillModel(ds.Tables[0].Rows[0]);
            else
                return null;
        }
        public string GetUserField(string FieldName, int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + FieldName + " ");
            strSql.Append("  from tabUser ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int)
            };
            parameters[0].Value = id;
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
                return ds.Tables[0].Rows[0][0].ToString();
            else
                return string.Empty;
        }
        public int AddWin(tabUserModel model)
        {
            model.Version = model.Version.IsNotNullOrEmpty() ? model.Version : "1";
            model.RandomNo = model.RandomNo.IsNotNullOrEmpty() ? model.RandomNo : Guid.NewGuid().ToString("N");
            model.Status = model.Status.IsNotNullOrEmpty() ? model.Status : "1";
            model.OrderNo = model.OrderNo > 0 ? model.OrderNo : 1;
            model.CreateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            model.ModifyDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tabUser(");
            strSql.Append("UserName,NickName,Sex,Birthday,HeadImgURLID,RealName,IDCardPerson,Marriage,BeginJobYear,WeiXinOpenID,WXNickName,QQID,QQNickName,SinaID,Ali,OtherID,Country,State,City,District,Community,Address,AddressFull,UserType,IsLogin,LastLoginTime,RoleID,GroupID,RegIP,RegDate,Industry,MinZu,MianMao,XueLi,ZhiWu,OrgID,BankCardNo,OrderQuality,AppID,Version,RandomNo,ParentID,Remark,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
            strSql.Append(") values (");
            strSql.Append("@UserName,@NickName,@Sex,@Birthday,@HeadImgURLID,@RealName,@IDCardPerson,@Marriage,@BeginJobYear,@WeiXinOpenID,@WXNickName,@QQID,@QQNickName,@SinaID,@Ali,@OtherID,@Country,@State,@City,@District,@Community,@Address,@AddressFull,@UserType,@IsLogin,@LastLoginTime,@RoleID,@GroupID,@RegIP,@RegDate,@Industry,@MinZu,@MianMao,@XueLi,@ZhiWu,@OrgID,@BankCardNo,@OrderQuality,@AppID,@Version,@RandomNo,@ParentID,@Remark,@ExJson,@Status,@OrderNo,@CreateDate,@ModifyDate,@CreateUser,@ModifyUser");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                        new SqlParameter("@UserName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@NickName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Sex", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Birthday", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@HeadImgURLID", SqlDbType.Int,4) ,
                        new SqlParameter("@RealName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@IDCardPerson", SqlDbType.Int,4) ,
                        new SqlParameter("@Marriage", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@BeginJobYear", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@WeiXinOpenID", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@WXNickName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@QQID", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@QQNickName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@SinaID", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Ali", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@OtherID", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Country", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@State", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@City", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@District", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Community", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Address", SqlDbType.NVarChar,500) ,
                        new SqlParameter("@AddressFull", SqlDbType.NVarChar,500) ,
                        new SqlParameter("@UserType", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@IsLogin", SqlDbType.Bit,1) ,
                        new SqlParameter("@LastLoginTime", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@RoleID", SqlDbType.Int,4) ,
                        new SqlParameter("@GroupID", SqlDbType.Int,4) ,
                        new SqlParameter("@RegIP", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@RegDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Industry", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@MinZu", SqlDbType.Int,4) ,
                        new SqlParameter("@MianMao", SqlDbType.Int,4) ,
                        new SqlParameter("@XueLi", SqlDbType.Int,4) ,
                        new SqlParameter("@ZhiWu", SqlDbType.Int,4) ,
                        new SqlParameter("@OrgID", SqlDbType.NVarChar,500) ,
                        new SqlParameter("@BankCardNo", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@OrderQuality", SqlDbType.Bit,1) ,
                        new SqlParameter("@AppID", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Version", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@RandomNo", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@ParentID", SqlDbType.Int,4) ,
                        new SqlParameter("@Remark", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@ExJson", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@Status", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@OrderNo", SqlDbType.Int,4) ,
                        new SqlParameter("@CreateDate", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@ModifyDate", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@CreateUser", SqlDbType.Int,4) ,
                        new SqlParameter("@ModifyUser", SqlDbType.Int,4)

            };

            parameters[0].Value = model.UserName;
            parameters[1].Value = model.NickName;
            parameters[2].Value = model.Sex;
            parameters[3].Value = model.Birthday;
            parameters[4].Value = model.HeadImgURLID;
            parameters[5].Value = model.RealName;
            parameters[6].Value = model.IDCardPerson;
            parameters[7].Value = model.Marriage;
            parameters[8].Value = model.BeginJobYear;
            parameters[9].Value = model.WeiXinOpenID;
            parameters[10].Value = model.WXNickName;
            parameters[11].Value = model.QQID;
            parameters[12].Value = model.QQNickName;
            parameters[13].Value = model.SinaID;
            parameters[14].Value = model.Ali;
            parameters[15].Value = model.OtherID;
            parameters[16].Value = model.Country;
            parameters[17].Value = model.State;
            parameters[18].Value = model.City;
            parameters[19].Value = model.District;
            parameters[20].Value = model.Community;
            parameters[21].Value = model.Address;
            parameters[22].Value = model.AddressFull;
            parameters[23].Value = model.UserType;
            parameters[24].Value = model.IsLogin;
            parameters[25].Value = model.LastLoginTime;
            parameters[26].Value = model.RoleID;
            parameters[27].Value = model.GroupID;
            parameters[28].Value = model.RegIP;
            parameters[29].Value = model.RegDate;
            parameters[30].Value = model.Industry;
            parameters[31].Value = model.MinZu;
            parameters[32].Value = model.MianMao;
            parameters[33].Value = model.XueLi;
            parameters[34].Value = model.ZhiWu;
            parameters[35].Value = model.OrgID;
            parameters[36].Value = model.BankCardNo;
            parameters[37].Value = model.OrderQuality;
            parameters[38].Value = model.AppID;
            parameters[39].Value = model.Version;
            parameters[40].Value = model.RandomNo;
            parameters[41].Value = model.ParentID;
            parameters[42].Value = model.Remark;
            parameters[43].Value = model.ExJson;
            parameters[44].Value = model.Status;
            parameters[45].Value = model.OrderNo;
            parameters[46].Value = model.CreateDate;
            parameters[47].Value = model.ModifyDate;
            parameters[48].Value = model.CreateUser;
            parameters[49].Value = model.ModifyUser;

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
        public void UpdateFieldWin(int id, string strValue)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tabUser set " + strValue);
            strSql.Append(" where id=" + id);
            DbHelperSQLWin.ExecuteSql(strSql.ToString());
        }
    }
}
#endregion
#region BLL类
namespace Tclywork.BLL
{
    /// <summary>
    /// tabUser
    /// </summary>
    public partial class tabUserBLL
    {
        public bool IsSameGroup(int UserA,int UserB)
        {
            return dal.IsSameGroup(UserA,UserB);
        }

        public void UpdateFieldWin(int id, string strValue)
        {
            dal.UpdateFieldWin(id, strValue);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int AddWin(tabUserModel model)
        {
            return dal.AddWin(model);

        }
        public string GetUserSFZ(int UserID)
        {
            return dal.GetUserSFZ(UserID);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tabUserModel GetModel(string Mobile)
        {
            return dal.GetModel(Mobile);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tabUserModel GetModelByIDMobile(int id, string Mobile)
        {
            return dal.GetModelByIDMobile(id, Mobile);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tabUserModel GetModelLogin(string UserName, string Pwd)
        {
            return dal.GetModelLogin(UserName, Pwd);
        }
        public tabUserModel GetModelLoginWin(string UserName, string Pwd)
        {
            return dal.GetModelLoginWin(UserName, Pwd);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tabUserModel GetModelExistUserName(string UserName)
        {
            return dal.GetModelExistUserName(UserName);
        }
        public tabUserModel GetModelExistEmail(string Email)
        {
            return dal.GetModelExistEmail(Email);
        }
        public tabUserModel GetModelExistMobile(string Mobile)
        {
            return dal.GetModelExistMobile(Mobile);
        }
        public tabUserModel GetModelExistSfzNo(string SFZNo)
        {
            return dal.GetModelExistSfzNo(SFZNo);
        }
        public tabUserModel GetModelByQQID(string QQID)
        {
            return dal.GetModelByQQID(QQID);
        }
        public tabUserModel GetModelByWeiXinOpenID(string WeiXinOpenID)
        {
            return dal.GetModelByWeiXinOpenID(WeiXinOpenID);
        }
        public string GetUserField(string FieldName, int id)
        {
            return dal.GetUserField(FieldName, id);
        }
    }
}
#endregion