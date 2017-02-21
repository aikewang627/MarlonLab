using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Maticsoft.DBUtility;
namespace Maticsoft.DAL
{
    //来往单位表（通表）
    public partial class tabOrg
    {

        public bool Exists(string OrgName, int id, int ParentID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tabOrg");
            strSql.Append(" where ");
            strSql.Append(" OrgName = @OrgName and  ");
            strSql.Append(" id = @id and  ");
            strSql.Append(" ParentID = @ParentID  ");
            SqlParameter[] parameters = {
                    new SqlParameter("@OrgName", SqlDbType.NVarChar,50),
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@ParentID", SqlDbType.Int,4)          };
            parameters[0].Value = OrgName;
            parameters[1].Value = id;
            parameters[2].Value = ParentID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.tabOrg model)
        {
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
        public bool Update(Maticsoft.Model.tabOrg model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tabOrg set ");

            strSql.Append(" OrgName = @OrgName , ");
            strSql.Append(" OrgDesc = @OrgDesc , ");
            strSql.Append(" OrgNickName = @OrgNickName , ");
            strSql.Append(" OrgZZ = @OrgZZ , ");
            strSql.Append(" OrgCode = @OrgCode , ");
            strSql.Append(" OrgType = @OrgType , ");
            strSql.Append(" OrgClass = @OrgClass , ");
            strSql.Append(" OrgLevel = @OrgLevel , ");
            strSql.Append(" OrgEdge = @OrgEdge , ");
            strSql.Append(" OrgPro = @OrgPro , ");
            strSql.Append(" OrgCard = @OrgCard , ");
            strSql.Append(" PlanNum = @PlanNum , ");
            strSql.Append(" Leader = @Leader , ");
            strSql.Append(" LeaderMobile = @LeaderMobile , ");
            strSql.Append(" Logo = @Logo , ");
            strSql.Append(" WebSite = @WebSite , ");
            strSql.Append(" Phone = @Phone , ");
            strSql.Append(" ZZNo = @ZZNo , ");
            strSql.Append(" ZZImg = @ZZImg , ");
            strSql.Append(" Natrue = @Natrue , ");
            strSql.Append(" PY = @PY , ");
            strSql.Append(" Country = @Country , ");
            strSql.Append(" State = @State , ");
            strSql.Append(" City = @City , ");
            strSql.Append(" District = @District , ");
            strSql.Append(" Community = @Community , ");
            strSql.Append(" Address = @Address , ");
            strSql.Append(" AreaFull = @AreaFull , ");
            strSql.Append(" ZipCode = @ZipCode , ");
            strSql.Append(" QQOpenID = @QQOpenID , ");
            strSql.Append(" WeiXinOpenID = @WeiXinOpenID , ");
            strSql.Append(" Fax = @Fax , ");
            strSql.Append(" Email = @Email , ");
            strSql.Append(" SaleType = @SaleType , ");
            strSql.Append(" Scale = @Scale , ");
            strSql.Append(" Source = @Source , ");
            strSql.Append(" SaleStatus = @SaleStatus , ");
            strSql.Append(" BankName = @BankName , ");
            strSql.Append(" BankAccount = @BankAccount , ");
            strSql.Append(" CreateUnitDate = @CreateUnitDate , ");
            strSql.Append(" BeginDate = @BeginDate , ");
            strSql.Append(" EndDate = @EndDate , ");
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
            parameters[42].Value = model.id;
            parameters[43].Value = model.AppID;
            parameters[44].Value = model.Version;
            parameters[45].Value = model.RandomNo;
            parameters[46].Value = model.ParentID;
            parameters[47].Value = model.Remark;
            parameters[48].Value = model.LableText;
            parameters[49].Value = model.ExJson;
            parameters[50].Value = model.Status;
            parameters[51].Value = model.OrderNo;
            parameters[52].Value = model.CreateDate;
            parameters[53].Value = model.ModifyDate;
            parameters[54].Value = model.CreateUser;
            parameters[55].Value = model.ModifyUser;
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
            strSql.Append("delete from tabOrg ");
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
            strSql.Append("delete from tabOrg ");
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
        public Maticsoft.Model.tabOrg GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select OrgName, OrgDesc, OrgNickName, OrgZZ, OrgCode, OrgType, OrgClass, OrgLevel, OrgEdge, OrgPro, OrgCard, PlanNum, Leader, LeaderMobile, Logo, WebSite, Phone, ZZNo, ZZImg, Natrue, PY, Country, State, City, District, Community, Address, AreaFull, ZipCode, QQOpenID, WeiXinOpenID, Fax, Email, SaleType, Scale, Source, SaleStatus, BankName, BankAccount, CreateUnitDate, BeginDate, EndDate, id, AppID, Version, RandomNo, ParentID, Remark, LableText, ExJson, Status, OrderNo, CreateDate, ModifyDate, CreateUser, ModifyUser  ");
            strSql.Append("  from tabOrg ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;


            Maticsoft.Model.tabOrg model = new Maticsoft.Model.tabOrg();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                model.OrgName = ds.Tables[0].Rows[0]["OrgName"].ToString();
                model.OrgDesc = ds.Tables[0].Rows[0]["OrgDesc"].ToString();
                model.OrgNickName = ds.Tables[0].Rows[0]["OrgNickName"].ToString();
                model.OrgZZ = ds.Tables[0].Rows[0]["OrgZZ"].ToString();
                model.OrgCode = ds.Tables[0].Rows[0]["OrgCode"].ToString();
                model.OrgType = ds.Tables[0].Rows[0]["OrgType"].ToString();
                if (ds.Tables[0].Rows[0]["OrgClass"].ToString() != "")
                {
                    model.OrgClass = int.Parse(ds.Tables[0].Rows[0]["OrgClass"].ToString());
                }
                model.OrgLevel = ds.Tables[0].Rows[0]["OrgLevel"].ToString();
                model.OrgEdge = ds.Tables[0].Rows[0]["OrgEdge"].ToString();
                model.OrgPro = ds.Tables[0].Rows[0]["OrgPro"].ToString();
                if (ds.Tables[0].Rows[0]["OrgCard"].ToString() != "")
                {
                    model.OrgCard = int.Parse(ds.Tables[0].Rows[0]["OrgCard"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PlanNum"].ToString() != "")
                {
                    model.PlanNum = int.Parse(ds.Tables[0].Rows[0]["PlanNum"].ToString());
                }
                model.Leader = ds.Tables[0].Rows[0]["Leader"].ToString();
                model.LeaderMobile = ds.Tables[0].Rows[0]["LeaderMobile"].ToString();
                if (ds.Tables[0].Rows[0]["Logo"].ToString() != "")
                {
                    model.Logo = int.Parse(ds.Tables[0].Rows[0]["Logo"].ToString());
                }
                model.WebSite = ds.Tables[0].Rows[0]["WebSite"].ToString();
                model.Phone = ds.Tables[0].Rows[0]["Phone"].ToString();
                model.ZZNo = ds.Tables[0].Rows[0]["ZZNo"].ToString();
                if (ds.Tables[0].Rows[0]["ZZImg"].ToString() != "")
                {
                    model.ZZImg = int.Parse(ds.Tables[0].Rows[0]["ZZImg"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Natrue"].ToString() != "")
                {
                    model.Natrue = int.Parse(ds.Tables[0].Rows[0]["Natrue"].ToString());
                }
                model.PY = ds.Tables[0].Rows[0]["PY"].ToString();
                model.Country = ds.Tables[0].Rows[0]["Country"].ToString();
                model.State = ds.Tables[0].Rows[0]["State"].ToString();
                model.City = ds.Tables[0].Rows[0]["City"].ToString();
                model.District = ds.Tables[0].Rows[0]["District"].ToString();
                model.Community = ds.Tables[0].Rows[0]["Community"].ToString();
                model.Address = ds.Tables[0].Rows[0]["Address"].ToString();
                model.AreaFull = ds.Tables[0].Rows[0]["AreaFull"].ToString();
                model.ZipCode = ds.Tables[0].Rows[0]["ZipCode"].ToString();
                model.QQOpenID = ds.Tables[0].Rows[0]["QQOpenID"].ToString();
                model.WeiXinOpenID = ds.Tables[0].Rows[0]["WeiXinOpenID"].ToString();
                model.Fax = ds.Tables[0].Rows[0]["Fax"].ToString();
                model.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                model.SaleType = ds.Tables[0].Rows[0]["SaleType"].ToString();
                model.Scale = ds.Tables[0].Rows[0]["Scale"].ToString();
                model.Source = ds.Tables[0].Rows[0]["Source"].ToString();
                model.SaleStatus = ds.Tables[0].Rows[0]["SaleStatus"].ToString();
                model.BankName = ds.Tables[0].Rows[0]["BankName"].ToString();
                model.BankAccount = ds.Tables[0].Rows[0]["BankAccount"].ToString();
                model.CreateUnitDate = ds.Tables[0].Rows[0]["CreateUnitDate"].ToString();
                model.BeginDate = ds.Tables[0].Rows[0]["BeginDate"].ToString();
                model.EndDate = ds.Tables[0].Rows[0]["EndDate"].ToString();
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
            strSql.Append(" FROM tabOrg ");
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
            strSql.Append(" FROM tabOrg ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

