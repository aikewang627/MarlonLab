using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Maticsoft.DBUtility;
namespace Maticsoft.DAL
{
    //用户表
    public partial class tabUser
    {

        public bool Exists(string UserName, string Pwd, string SFZNo, string Mobile, string Email, string WeiXinOpenID, string QQID, string UserType, string Industry, int XueLi, int id, int ParentID, string CreateDate, int CreateUser)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tabUser");
            strSql.Append(" where ");
            strSql.Append(" UserName = @UserName and  ");
            strSql.Append(" Pwd = @Pwd and  ");
            strSql.Append(" SFZNo = @SFZNo and  ");
            strSql.Append(" Mobile = @Mobile and  ");
            strSql.Append(" Email = @Email and  ");
            strSql.Append(" WeiXinOpenID = @WeiXinOpenID and  ");
            strSql.Append(" QQID = @QQID and  ");
            strSql.Append(" UserType = @UserType and  ");
            strSql.Append(" Industry = @Industry and  ");
            strSql.Append(" XueLi = @XueLi and  ");
            strSql.Append(" id = @id and  ");
            strSql.Append(" ParentID = @ParentID and  ");
            strSql.Append(" CreateDate = @CreateDate and  ");
            strSql.Append(" CreateUser = @CreateUser  ");
            SqlParameter[] parameters = {
                    new SqlParameter("@UserName", SqlDbType.NVarChar,50),
                    new SqlParameter("@Pwd", SqlDbType.NVarChar,200),
                    new SqlParameter("@SFZNo", SqlDbType.NVarChar,50),
                    new SqlParameter("@Mobile", SqlDbType.NVarChar,50),
                    new SqlParameter("@Email", SqlDbType.NVarChar,500),
                    new SqlParameter("@WeiXinOpenID", SqlDbType.NVarChar,50),
                    new SqlParameter("@QQID", SqlDbType.NVarChar,50),
                    new SqlParameter("@UserType", SqlDbType.NVarChar,50),
                    new SqlParameter("@Industry", SqlDbType.NVarChar,50),
                    new SqlParameter("@XueLi", SqlDbType.Int,4),
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@ParentID", SqlDbType.Int,4),
                    new SqlParameter("@CreateDate", SqlDbType.NVarChar,200),
                    new SqlParameter("@CreateUser", SqlDbType.Int,4)          };
            parameters[0].Value = UserName;
            parameters[1].Value = Pwd;
            parameters[2].Value = SFZNo;
            parameters[3].Value = Mobile;
            parameters[4].Value = Email;
            parameters[5].Value = WeiXinOpenID;
            parameters[6].Value = QQID;
            parameters[7].Value = UserType;
            parameters[8].Value = Industry;
            parameters[9].Value = XueLi;
            parameters[10].Value = id;
            parameters[11].Value = ParentID;
            parameters[12].Value = CreateDate;
            parameters[13].Value = CreateUser;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.tabUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tabUser(");
            strSql.Append("UserName,NickName,Pwd,Sex,Birthday,HeadImgURLID,RealName,SFZNo,IDCardPerson,Mobile,Email,Marriage,BeginJobYear,WeiXinOpenID,WXNickName,WxCode,QQID,QQNickName,QQNo,SinaID,Ali,OtherID,Country,State,City,District,Community,Address,AddressFull,SafeQuestion,SafeAnswer,UserType,IsLogin,LastLoginTime,RoleID,GroupID,RegIP,RegDate,Industry,MinZu,MianMao,XueLi,ZhiWu,OrgID,BankCardNo,OrderQuality,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
            strSql.Append(") values (");
            strSql.Append("@UserName,@NickName,@Pwd,@Sex,@Birthday,@HeadImgURLID,@RealName,@SFZNo,@IDCardPerson,@Mobile,@Email,@Marriage,@BeginJobYear,@WeiXinOpenID,@WXNickName,@WxCode,@QQID,@QQNickName,@QQNo,@SinaID,@Ali,@OtherID,@Country,@State,@City,@District,@Community,@Address,@AddressFull,@SafeQuestion,@SafeAnswer,@UserType,@IsLogin,@LastLoginTime,@RoleID,@GroupID,@RegIP,@RegDate,@Industry,@MinZu,@MianMao,@XueLi,@ZhiWu,@OrgID,@BankCardNo,@OrderQuality,@AppID,@Version,@RandomNo,@ParentID,@Remark,@LableText,@ExJson,@Status,@OrderNo,@CreateDate,@ModifyDate,@CreateUser,@ModifyUser");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                        new SqlParameter("@UserName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@NickName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Pwd", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@Sex", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Birthday", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@HeadImgURLID", SqlDbType.Int,4) ,
                        new SqlParameter("@RealName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@SFZNo", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@IDCardPerson", SqlDbType.Int,4) ,
                        new SqlParameter("@Mobile", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Email", SqlDbType.NVarChar,500) ,
                        new SqlParameter("@Marriage", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@BeginJobYear", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@WeiXinOpenID", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@WXNickName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@WxCode", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@QQID", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@QQNickName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@QQNo", SqlDbType.NVarChar,50) ,
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
                        new SqlParameter("@SafeQuestion", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@SafeAnswer", SqlDbType.NVarChar,-1) ,
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
                        new SqlParameter("@LableText", SqlDbType.NVarChar,-1) ,
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
            parameters[2].Value = model.Pwd;
            parameters[3].Value = model.Sex;
            parameters[4].Value = model.Birthday;
            parameters[5].Value = model.HeadImgURLID;
            parameters[6].Value = model.RealName;
            parameters[7].Value = model.SFZNo;
            parameters[8].Value = model.IDCardPerson;
            parameters[9].Value = model.Mobile;
            parameters[10].Value = model.Email;
            parameters[11].Value = model.Marriage;
            parameters[12].Value = model.BeginJobYear;
            parameters[13].Value = model.WeiXinOpenID;
            parameters[14].Value = model.WXNickName;
            parameters[15].Value = model.WxCode;
            parameters[16].Value = model.QQID;
            parameters[17].Value = model.QQNickName;
            parameters[18].Value = model.QQNo;
            parameters[19].Value = model.SinaID;
            parameters[20].Value = model.Ali;
            parameters[21].Value = model.OtherID;
            parameters[22].Value = model.Country;
            parameters[23].Value = model.State;
            parameters[24].Value = model.City;
            parameters[25].Value = model.District;
            parameters[26].Value = model.Community;
            parameters[27].Value = model.Address;
            parameters[28].Value = model.AddressFull;
            parameters[29].Value = model.SafeQuestion;
            parameters[30].Value = model.SafeAnswer;
            parameters[31].Value = model.UserType;
            parameters[32].Value = model.IsLogin;
            parameters[33].Value = model.LastLoginTime;
            parameters[34].Value = model.RoleID;
            parameters[35].Value = model.GroupID;
            parameters[36].Value = model.RegIP;
            parameters[37].Value = model.RegDate;
            parameters[38].Value = model.Industry;
            parameters[39].Value = model.MinZu;
            parameters[40].Value = model.MianMao;
            parameters[41].Value = model.XueLi;
            parameters[42].Value = model.ZhiWu;
            parameters[43].Value = model.OrgID;
            parameters[44].Value = model.BankCardNo;
            parameters[45].Value = model.OrderQuality;
            parameters[46].Value = model.AppID;
            parameters[47].Value = model.Version;
            parameters[48].Value = model.RandomNo;
            parameters[49].Value = model.ParentID;
            parameters[50].Value = model.Remark;
            parameters[51].Value = model.LableText;
            parameters[52].Value = model.ExJson;
            parameters[53].Value = model.Status;
            parameters[54].Value = model.OrderNo;
            parameters[55].Value = model.CreateDate;
            parameters[56].Value = model.ModifyDate;
            parameters[57].Value = model.CreateUser;
            parameters[58].Value = model.ModifyUser;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {

                return Convert.ToInt32(obj);

            }

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.tabUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tabUser set ");

            strSql.Append(" UserName = @UserName , ");
            strSql.Append(" NickName = @NickName , ");
            strSql.Append(" Pwd = @Pwd , ");
            strSql.Append(" Sex = @Sex , ");
            strSql.Append(" Birthday = @Birthday , ");
            strSql.Append(" HeadImgURLID = @HeadImgURLID , ");
            strSql.Append(" RealName = @RealName , ");
            strSql.Append(" SFZNo = @SFZNo , ");
            strSql.Append(" IDCardPerson = @IDCardPerson , ");
            strSql.Append(" Mobile = @Mobile , ");
            strSql.Append(" Email = @Email , ");
            strSql.Append(" Marriage = @Marriage , ");
            strSql.Append(" BeginJobYear = @BeginJobYear , ");
            strSql.Append(" WeiXinOpenID = @WeiXinOpenID , ");
            strSql.Append(" WXNickName = @WXNickName , ");
            strSql.Append(" WxCode = @WxCode , ");
            strSql.Append(" QQID = @QQID , ");
            strSql.Append(" QQNickName = @QQNickName , ");
            strSql.Append(" QQNo = @QQNo , ");
            strSql.Append(" SinaID = @SinaID , ");
            strSql.Append(" Ali = @Ali , ");
            strSql.Append(" OtherID = @OtherID , ");
            strSql.Append(" Country = @Country , ");
            strSql.Append(" State = @State , ");
            strSql.Append(" City = @City , ");
            strSql.Append(" District = @District , ");
            strSql.Append(" Community = @Community , ");
            strSql.Append(" Address = @Address , ");
            strSql.Append(" AddressFull = @AddressFull , ");
            strSql.Append(" SafeQuestion = @SafeQuestion , ");
            strSql.Append(" SafeAnswer = @SafeAnswer , ");
            strSql.Append(" UserType = @UserType , ");
            strSql.Append(" IsLogin = @IsLogin , ");
            strSql.Append(" LastLoginTime = @LastLoginTime , ");
            strSql.Append(" RoleID = @RoleID , ");
            strSql.Append(" GroupID = @GroupID , ");
            strSql.Append(" RegIP = @RegIP , ");
            strSql.Append(" RegDate = @RegDate , ");
            strSql.Append(" Industry = @Industry , ");
            strSql.Append(" MinZu = @MinZu , ");
            strSql.Append(" MianMao = @MianMao , ");
            strSql.Append(" XueLi = @XueLi , ");
            strSql.Append(" ZhiWu = @ZhiWu , ");
            strSql.Append(" OrgID = @OrgID , ");
            strSql.Append(" BankCardNo = @BankCardNo , ");
            strSql.Append(" OrderQuality = @OrderQuality , ");
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
                        new SqlParameter("@UserName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@NickName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Pwd", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@Sex", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Birthday", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@HeadImgURLID", SqlDbType.Int,4) ,
                        new SqlParameter("@RealName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@SFZNo", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@IDCardPerson", SqlDbType.Int,4) ,
                        new SqlParameter("@Mobile", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@Email", SqlDbType.NVarChar,500) ,
                        new SqlParameter("@Marriage", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@BeginJobYear", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@WeiXinOpenID", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@WXNickName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@WxCode", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@QQID", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@QQNickName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@QQNo", SqlDbType.NVarChar,50) ,
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
                        new SqlParameter("@SafeQuestion", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@SafeAnswer", SqlDbType.NVarChar,-1) ,
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

            parameters[0].Value = model.UserName;
            parameters[1].Value = model.NickName;
            parameters[2].Value = model.Pwd;
            parameters[3].Value = model.Sex;
            parameters[4].Value = model.Birthday;
            parameters[5].Value = model.HeadImgURLID;
            parameters[6].Value = model.RealName;
            parameters[7].Value = model.SFZNo;
            parameters[8].Value = model.IDCardPerson;
            parameters[9].Value = model.Mobile;
            parameters[10].Value = model.Email;
            parameters[11].Value = model.Marriage;
            parameters[12].Value = model.BeginJobYear;
            parameters[13].Value = model.WeiXinOpenID;
            parameters[14].Value = model.WXNickName;
            parameters[15].Value = model.WxCode;
            parameters[16].Value = model.QQID;
            parameters[17].Value = model.QQNickName;
            parameters[18].Value = model.QQNo;
            parameters[19].Value = model.SinaID;
            parameters[20].Value = model.Ali;
            parameters[21].Value = model.OtherID;
            parameters[22].Value = model.Country;
            parameters[23].Value = model.State;
            parameters[24].Value = model.City;
            parameters[25].Value = model.District;
            parameters[26].Value = model.Community;
            parameters[27].Value = model.Address;
            parameters[28].Value = model.AddressFull;
            parameters[29].Value = model.SafeQuestion;
            parameters[30].Value = model.SafeAnswer;
            parameters[31].Value = model.UserType;
            parameters[32].Value = model.IsLogin;
            parameters[33].Value = model.LastLoginTime;
            parameters[34].Value = model.RoleID;
            parameters[35].Value = model.GroupID;
            parameters[36].Value = model.RegIP;
            parameters[37].Value = model.RegDate;
            parameters[38].Value = model.Industry;
            parameters[39].Value = model.MinZu;
            parameters[40].Value = model.MianMao;
            parameters[41].Value = model.XueLi;
            parameters[42].Value = model.ZhiWu;
            parameters[43].Value = model.OrgID;
            parameters[44].Value = model.BankCardNo;
            parameters[45].Value = model.OrderQuality;
            parameters[46].Value = model.id;
            parameters[47].Value = model.AppID;
            parameters[48].Value = model.Version;
            parameters[49].Value = model.RandomNo;
            parameters[50].Value = model.ParentID;
            parameters[51].Value = model.Remark;
            parameters[52].Value = model.LableText;
            parameters[53].Value = model.ExJson;
            parameters[54].Value = model.Status;
            parameters[55].Value = model.OrderNo;
            parameters[56].Value = model.CreateDate;
            parameters[57].Value = model.ModifyDate;
            parameters[58].Value = model.CreateUser;
            parameters[59].Value = model.ModifyUser;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tabUser ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;


            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tabUser ");
            strSql.Append(" where ID in (" + idlist + ")  ");
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


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.tabUser GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserName, NickName, Pwd, Sex, Birthday, HeadImgURLID, RealName, SFZNo, IDCardPerson, Mobile, Email, Marriage, BeginJobYear, WeiXinOpenID, WXNickName, WxCode, QQID, QQNickName, QQNo, SinaID, Ali, OtherID, Country, State, City, District, Community, Address, AddressFull, SafeQuestion, SafeAnswer, UserType, IsLogin, LastLoginTime, RoleID, GroupID, RegIP, RegDate, Industry, MinZu, MianMao, XueLi, ZhiWu, OrgID, BankCardNo, OrderQuality, id, AppID, Version, RandomNo, ParentID, Remark, LableText, ExJson, Status, OrderNo, CreateDate, ModifyDate, CreateUser, ModifyUser  ");
            strSql.Append("  from tabUser ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;


            Maticsoft.Model.tabUser model = new Maticsoft.Model.tabUser();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                model.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                model.NickName = ds.Tables[0].Rows[0]["NickName"].ToString();
                model.Pwd = ds.Tables[0].Rows[0]["Pwd"].ToString();
                model.Sex = ds.Tables[0].Rows[0]["Sex"].ToString();
                model.Birthday = ds.Tables[0].Rows[0]["Birthday"].ToString();
                if (ds.Tables[0].Rows[0]["HeadImgURLID"].ToString() != "")
                {
                    model.HeadImgURLID = int.Parse(ds.Tables[0].Rows[0]["HeadImgURLID"].ToString());
                }
                model.RealName = ds.Tables[0].Rows[0]["RealName"].ToString();
                model.SFZNo = ds.Tables[0].Rows[0]["SFZNo"].ToString();
                if (ds.Tables[0].Rows[0]["IDCardPerson"].ToString() != "")
                {
                    model.IDCardPerson = int.Parse(ds.Tables[0].Rows[0]["IDCardPerson"].ToString());
                }
                model.Mobile = ds.Tables[0].Rows[0]["Mobile"].ToString();
                model.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                model.Marriage = ds.Tables[0].Rows[0]["Marriage"].ToString();
                model.BeginJobYear = ds.Tables[0].Rows[0]["BeginJobYear"].ToString();
                model.WeiXinOpenID = ds.Tables[0].Rows[0]["WeiXinOpenID"].ToString();
                model.WXNickName = ds.Tables[0].Rows[0]["WXNickName"].ToString();
                model.WxCode = ds.Tables[0].Rows[0]["WxCode"].ToString();
                model.QQID = ds.Tables[0].Rows[0]["QQID"].ToString();
                model.QQNickName = ds.Tables[0].Rows[0]["QQNickName"].ToString();
                model.QQNo = ds.Tables[0].Rows[0]["QQNo"].ToString();
                model.SinaID = ds.Tables[0].Rows[0]["SinaID"].ToString();
                model.Ali = ds.Tables[0].Rows[0]["Ali"].ToString();
                model.OtherID = ds.Tables[0].Rows[0]["OtherID"].ToString();
                model.Country = ds.Tables[0].Rows[0]["Country"].ToString();
                model.State = ds.Tables[0].Rows[0]["State"].ToString();
                model.City = ds.Tables[0].Rows[0]["City"].ToString();
                model.District = ds.Tables[0].Rows[0]["District"].ToString();
                model.Community = ds.Tables[0].Rows[0]["Community"].ToString();
                model.Address = ds.Tables[0].Rows[0]["Address"].ToString();
                model.AddressFull = ds.Tables[0].Rows[0]["AddressFull"].ToString();
                model.SafeQuestion = ds.Tables[0].Rows[0]["SafeQuestion"].ToString();
                model.SafeAnswer = ds.Tables[0].Rows[0]["SafeAnswer"].ToString();
                model.UserType = ds.Tables[0].Rows[0]["UserType"].ToString();
                if (ds.Tables[0].Rows[0]["IsLogin"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsLogin"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsLogin"].ToString().ToLower() == "true"))
                    {
                        model.IsLogin = true;
                    }
                    else
                    {
                        model.IsLogin = false;
                    }
                }
                model.LastLoginTime = ds.Tables[0].Rows[0]["LastLoginTime"].ToString();
                if (ds.Tables[0].Rows[0]["RoleID"].ToString() != "")
                {
                    model.RoleID = int.Parse(ds.Tables[0].Rows[0]["RoleID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["GroupID"].ToString() != "")
                {
                    model.GroupID = int.Parse(ds.Tables[0].Rows[0]["GroupID"].ToString());
                }
                model.RegIP = ds.Tables[0].Rows[0]["RegIP"].ToString();
                model.RegDate = ds.Tables[0].Rows[0]["RegDate"].ToString();
                model.Industry = ds.Tables[0].Rows[0]["Industry"].ToString();
                if (ds.Tables[0].Rows[0]["MinZu"].ToString() != "")
                {
                    model.MinZu = int.Parse(ds.Tables[0].Rows[0]["MinZu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MianMao"].ToString() != "")
                {
                    model.MianMao = int.Parse(ds.Tables[0].Rows[0]["MianMao"].ToString());
                }
                if (ds.Tables[0].Rows[0]["XueLi"].ToString() != "")
                {
                    model.XueLi = int.Parse(ds.Tables[0].Rows[0]["XueLi"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ZhiWu"].ToString() != "")
                {
                    model.ZhiWu = int.Parse(ds.Tables[0].Rows[0]["ZhiWu"].ToString());
                }
                model.OrgID = ds.Tables[0].Rows[0]["OrgID"].ToString();
                model.BankCardNo = ds.Tables[0].Rows[0]["BankCardNo"].ToString();
                if (ds.Tables[0].Rows[0]["OrderQuality"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["OrderQuality"].ToString() == "1") || (ds.Tables[0].Rows[0]["OrderQuality"].ToString().ToLower() == "true"))
                    {
                        model.OrderQuality = true;
                    }
                    else
                    {
                        model.OrderQuality = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.AppID = ds.Tables[0].Rows[0]["AppID"].ToString();
                model.Version = ds.Tables[0].Rows[0]["Version"].ToString();
                model.RandomNo = ds.Tables[0].Rows[0]["RandomNo"].ToString();
                if (ds.Tables[0].Rows[0]["ParentID"].ToString() != "")
                {
                    model.ParentID = int.Parse(ds.Tables[0].Rows[0]["ParentID"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                model.LableText = ds.Tables[0].Rows[0]["LableText"].ToString();
                model.ExJson = ds.Tables[0].Rows[0]["ExJson"].ToString();
                model.Status = ds.Tables[0].Rows[0]["Status"].ToString();
                if (ds.Tables[0].Rows[0]["OrderNo"].ToString() != "")
                {
                    model.OrderNo = int.Parse(ds.Tables[0].Rows[0]["OrderNo"].ToString());
                }
                model.CreateDate = ds.Tables[0].Rows[0]["CreateDate"].ToString();
                model.ModifyDate = ds.Tables[0].Rows[0]["ModifyDate"].ToString();
                if (ds.Tables[0].Rows[0]["CreateUser"].ToString() != "")
                {
                    model.CreateUser = int.Parse(ds.Tables[0].Rows[0]["CreateUser"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ModifyUser"].ToString() != "")
                {
                    model.ModifyUser = int.Parse(ds.Tables[0].Rows[0]["ModifyUser"].ToString());
                }

                return model;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM tabUser ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM tabUser ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

