
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
#region  Model 实体类- tabUser
namespace Tclywork.Model{
	[Serializable]
	/// <summary>
	/// 用户表
    /// </summary> 	
	public partial class tabUserModel
	{   		     
      								/// <summary>
			/// 用户名
	        /// </summary>
	        
	        public string UserName
	        {
	            get{ return _UserName; }
	            set{ _UserName = value;}
	        }private string _UserName;
				        
							/// <summary>
			/// 昵称
	        /// </summary>
	        
	        public string NickName
	        {
	            get{ return _NickName; }
	            set{ _NickName = value;}
	        }private string _NickName;
				        
							/// <summary>
			/// 密码
	        /// </summary>
	        
	        public string Pwd
	        {
	            get{ return _Pwd; }
	            set{ _Pwd = value;}
	        }private string _Pwd;
				        
							/// <summary>
			/// 性别
	        /// </summary>
	        
	        public string Sex
	        {
	            get{ return _Sex; }
	            set{ _Sex = value;}
	        }private string _Sex;
				        
							/// <summary>
			/// 生日
	        /// </summary>
	        
	        public string Birthday
	        {
	            get{ return _Birthday; }
	            set{ _Birthday = value;}
	        }private string _Birthday;
				        
							/// <summary>
			/// 头像
	        /// </summary>
	        
	        public int HeadImgURLID
	        {
	            get{ return _HeadImgURLID; }
	            set{ _HeadImgURLID = value;}
	        }private int _HeadImgURLID;
				        
							/// <summary>
			/// 真实姓名
	        /// </summary>
	        
	        public string RealName
	        {
	            get{ return _RealName; }
	            set{ _RealName = value;}
	        }private string _RealName;
				        
							/// <summary>
			/// 身份证
	        /// </summary>
	        
	        public string SFZNo
	        {
	            get{ return _SFZNo; }
	            set{ _SFZNo = value;}
	        }private string _SFZNo;
				        
							/// <summary>
			/// 手持身份证照片资源ID
	        /// </summary>
	        
	        public int IDCardPerson
	        {
	            get{ return _IDCardPerson; }
	            set{ _IDCardPerson = value;}
	        }private int _IDCardPerson;
				        
							/// <summary>
			/// 手机
	        /// </summary>
	        
	        public string Mobile
	        {
	            get{ return _Mobile; }
	            set{ _Mobile = value;}
	        }private string _Mobile;
				        
							/// <summary>
			/// 邮箱
	        /// </summary>
	        
	        public string Email
	        {
	            get{ return _Email; }
	            set{ _Email = value;}
	        }private string _Email;
				        
							/// <summary>
			/// 婚否
	        /// </summary>
	        
	        public string Marriage
	        {
	            get{ return _Marriage; }
	            set{ _Marriage = value;}
	        }private string _Marriage;
				        
							/// <summary>
			/// 开始工作年份，如2012
	        /// </summary>
	        
	        public string BeginJobYear
	        {
	            get{ return _BeginJobYear; }
	            set{ _BeginJobYear = value;}
	        }private string _BeginJobYear;
				        
							/// <summary>
			/// 微信账号
	        /// </summary>
	        
	        public string WeiXinOpenID
	        {
	            get{ return _WeiXinOpenID; }
	            set{ _WeiXinOpenID = value;}
	        }private string _WeiXinOpenID;
				        
							/// <summary>
			/// WXNickName
	        /// </summary>
	        
	        public string WXNickName
	        {
	            get{ return _WXNickName; }
	            set{ _WXNickName = value;}
	        }private string _WXNickName;
				        
							/// <summary>
			/// WxCode
	        /// </summary>
	        
	        public string WxCode
	        {
	            get{ return _WxCode; }
	            set{ _WxCode = value;}
	        }private string _WxCode;
				        
							/// <summary>
			/// QQ账号
	        /// </summary>
	        
	        public string QQID
	        {
	            get{ return _QQID; }
	            set{ _QQID = value;}
	        }private string _QQID;
				        
							/// <summary>
			/// QQNickName
	        /// </summary>
	        
	        public string QQNickName
	        {
	            get{ return _QQNickName; }
	            set{ _QQNickName = value;}
	        }private string _QQNickName;
				        
							/// <summary>
			/// QQNo
	        /// </summary>
	        
	        public string QQNo
	        {
	            get{ return _QQNo; }
	            set{ _QQNo = value;}
	        }private string _QQNo;
				        
							/// <summary>
			/// 新浪微博账号
	        /// </summary>
	        
	        public string SinaID
	        {
	            get{ return _SinaID; }
	            set{ _SinaID = value;}
	        }private string _SinaID;
				        
							/// <summary>
			/// 淘宝账号
	        /// </summary>
	        
	        public string Ali
	        {
	            get{ return _Ali; }
	            set{ _Ali = value;}
	        }private string _Ali;
				        
							/// <summary>
			/// 第三方账号
	        /// </summary>
	        
	        public string OtherID
	        {
	            get{ return _OtherID; }
	            set{ _OtherID = value;}
	        }private string _OtherID;
				        
							/// <summary>
			/// 国家
	        /// </summary>
	        
	        public string Country
	        {
	            get{ return _Country; }
	            set{ _Country = value;}
	        }private string _Country;
				        
							/// <summary>
			/// 省份
	        /// </summary>
	        
	        public string State
	        {
	            get{ return _State; }
	            set{ _State = value;}
	        }private string _State;
				        
							/// <summary>
			/// 市
	        /// </summary>
	        
	        public string City
	        {
	            get{ return _City; }
	            set{ _City = value;}
	        }private string _City;
				        
							/// <summary>
			/// 县/区
	        /// </summary>
	        
	        public string District
	        {
	            get{ return _District; }
	            set{ _District = value;}
	        }private string _District;
				        
							/// <summary>
			/// 社区
	        /// </summary>
	        
	        public string Community
	        {
	            get{ return _Community; }
	            set{ _Community = value;}
	        }private string _Community;
				        
							/// <summary>
			/// 详细地址
	        /// </summary>
	        
	        public string Address
	        {
	            get{ return _Address; }
	            set{ _Address = value;}
	        }private string _Address;
				        
							/// <summary>
			/// 完整地址
	        /// </summary>
	        
	        public string AddressFull
	        {
	            get{ return _AddressFull; }
	            set{ _AddressFull = value;}
	        }private string _AddressFull;
				        
							/// <summary>
			/// 安全问题
	        /// </summary>
	        
	        public string SafeQuestion
	        {
	            get{ return _SafeQuestion; }
	            set{ _SafeQuestion = value;}
	        }private string _SafeQuestion;
				        
							/// <summary>
			/// 安全问题答案
	        /// </summary>
	        
	        public string SafeAnswer
	        {
	            get{ return _SafeAnswer; }
	            set{ _SafeAnswer = value;}
	        }private string _SafeAnswer;
				        
							/// <summary>
			/// 用户类型，采用AppName.UserType标识，如DDZC.CompanyUser
	        /// </summary>
	        
	        public string UserType
	        {
	            get{ return _UserType; }
	            set{ _UserType = value;}
	        }private string _UserType;
				        
							/// <summary>
			/// 是否允许登录
	        /// </summary>
	        
	        public bool IsLogin
	        {
	            get{ return _IsLogin; }
	            set{ _IsLogin = value;}
	        }private bool _IsLogin;
				        
							/// <summary>
			/// 最后登录时间
	        /// </summary>
	        
	        public string LastLoginTime
	        {
	            get{ return _LastLoginTime; }
	            set{ _LastLoginTime = value;}
	        }private string _LastLoginTime;
				        
							/// <summary>
			/// 角色
	        /// </summary>
	        
	        public int RoleID
	        {
	            get{ return _RoleID; }
	            set{ _RoleID = value;}
	        }private int _RoleID;
				        
							/// <summary>
			/// 用户组
	        /// </summary>
	        
	        public int GroupID
	        {
	            get{ return _GroupID; }
	            set{ _GroupID = value;}
	        }private int _GroupID;
				        
							/// <summary>
			/// 注册IP
	        /// </summary>
	        
	        public string RegIP
	        {
	            get{ return _RegIP; }
	            set{ _RegIP = value;}
	        }private string _RegIP;
				        
							/// <summary>
			/// 注册时间
	        /// </summary>
	        
	        public string RegDate
	        {
	            get{ return _RegDate; }
	            set{ _RegDate = value;}
	        }private string _RegDate;
				        
							/// <summary>
			/// 行业
	        /// </summary>
	        
	        public string Industry
	        {
	            get{ return _Industry; }
	            set{ _Industry = value;}
	        }private string _Industry;
				        
							/// <summary>
			/// 民族
	        /// </summary>
	        
	        public int MinZu
	        {
	            get{ return _MinZu; }
	            set{ _MinZu = value;}
	        }private int _MinZu;
				        
							/// <summary>
			/// 面貌
	        /// </summary>
	        
	        public int MianMao
	        {
	            get{ return _MianMao; }
	            set{ _MianMao = value;}
	        }private int _MianMao;
				        
							/// <summary>
			/// 学历
	        /// </summary>
	        
	        public int XueLi
	        {
	            get{ return _XueLi; }
	            set{ _XueLi = value;}
	        }private int _XueLi;
				        
							/// <summary>
			/// 职务
	        /// </summary>
	        
	        public int ZhiWu
	        {
	            get{ return _ZhiWu; }
	            set{ _ZhiWu = value;}
	        }private int _ZhiWu;
				        
							/// <summary>
			/// 所属单位
	        /// </summary>
	        
	        public string OrgID
	        {
	            get{ return _OrgID; }
	            set{ _OrgID = value;}
	        }private string _OrgID;
				        
							/// <summary>
			/// 银行卡号
	        /// </summary>
	        
	        public string BankCardNo
	        {
	            get{ return _BankCardNo; }
	            set{ _BankCardNo = value;}
	        }private string _BankCardNo;
				        
							/// <summary>
			/// 高佣金订单的 做单资质
	        /// </summary>
	        
	        public bool OrderQuality
	        {
	            get{ return _OrderQuality; }
	            set{ _OrderQuality = value;}
	        }private bool _OrderQuality;
				        
							/// <summary>
			/// 编号
	        /// </summary>
	        
	        public int id
	        {
	            get{ return _id; }
	            set{ _id = value;}
	        }private int _id;
				        
							/// <summary>
			/// AppID
	        /// </summary>
	        
	        public string AppID
	        {
	            get{ return _AppID; }
	            set{ _AppID = value;}
	        }private string _AppID;
				        
							/// <summary>
			/// Version
	        /// </summary>
	        
	        public string Version
	        {
	            get{ return _Version; }
	            set{ _Version = value;}
	        }private string _Version;
				        
							/// <summary>
			/// 随机码
	        /// </summary>
	        
	        public string RandomNo
	        {
	            get{ return _RandomNo; }
	            set{ _RandomNo = value;}
	        }private string _RandomNo;
				        
							/// <summary>
			/// 上级编号
	        /// </summary>
	        
	        public int ParentID
	        {
	            get{ return _ParentID; }
	            set{ _ParentID = value;}
	        }private int _ParentID;
				        
							/// <summary>
			/// 备注
	        /// </summary>
	        
	        public string Remark
	        {
	            get{ return _Remark; }
	            set{ _Remark = value;}
	        }private string _Remark;
				        
							/// <summary>
			/// 标签
	        /// </summary>
	        
	        public string LableText
	        {
	            get{ return _LableText; }
	            set{ _LableText = value;}
	        }private string _LableText;
				        
							/// <summary>
			/// 扩展Json
	        /// </summary>
	        
	        public string ExJson
	        {
	            get{ return _ExJson; }
	            set{ _ExJson = value;}
	        }private string _ExJson;
				        
							/// <summary>
			/// 状态
	        /// </summary>
	        
	        public string Status
	        {
	            get{ return _Status; }
	            set{ _Status = value;}
	        }private string _Status;
				        
							/// <summary>
			/// 排序
	        /// </summary>
	        
	        public int OrderNo
	        {
	            get{ return _OrderNo; }
	            set{ _OrderNo = value;}
	        }private int _OrderNo;
				        
							/// <summary>
			/// 创建时间
	        /// </summary>
	        
	        public string CreateDate
	        {
	            get{ return _CreateDate; }
	            set{ _CreateDate = value;}
	        }private string _CreateDate;
				        
							/// <summary>
			/// 修改时间
	        /// </summary>
	        
	        public string ModifyDate
	        {
	            get{ return _ModifyDate; }
	            set{ _ModifyDate = value;}
	        }private string _ModifyDate;
				        
							/// <summary>
			/// 创建用户
	        /// </summary>
	        
	        public int CreateUser
	        {
	            get{ return _CreateUser; }
	            set{ _CreateUser = value;}
	        }private int _CreateUser;
				        
							/// <summary>
			/// 修改用户
	        /// </summary>
	        
	        public int ModifyUser
	        {
	            get{ return _ModifyUser; }
	            set{ _ModifyUser = value;}
	        }private int _ModifyUser;
				        
 	}
	
	}
#endregion

#region	SQLDAL
namespace Tclywork.DAL{
	/// <summary>
	/// 用户表
    /// </summary> 	
	public partial class tabUserSQLDAL
	{
		#region 实现方法
   		 /// <summary>
		/// 是否存在
		/// </summary>    
		public bool Exists(string UserName,string Pwd,string SFZNo,string Mobile,string Email,string WeiXinOpenID,string QQID,string UserType,string Industry,int XueLi,int id,int ParentID,string CreateDate,int CreateUser)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tabUser");
			strSql.Append(" where ");
			                        strSql.Append(" UserName = SQL2012UserName and  ");
                                                    strSql.Append(" Pwd = SQL2012Pwd and  ");
                                                    strSql.Append(" SFZNo = SQL2012SFZNo and  ");
                                                    strSql.Append(" Mobile = SQL2012Mobile and  ");
                                                    strSql.Append(" Email = SQL2012Email and  ");
                                                    strSql.Append(" WeiXinOpenID = SQL2012WeiXinOpenID and  ");
                                                    strSql.Append(" QQID = SQL2012QQID and  ");
                                                    strSql.Append(" UserType = SQL2012UserType and  ");
                                                    strSql.Append(" Industry = SQL2012Industry and  ");
                                                    strSql.Append(" XueLi = SQL2012XueLi and  ");
                                                    strSql.Append(" id = SQL2012id and  ");
                                                    strSql.Append(" ParentID = SQL2012ParentID and  ");
                                                    strSql.Append(" CreateDate = SQL2012CreateDate and  ");
                                                    strSql.Append(" CreateUser = SQL2012CreateUser  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("SQL2012UserName", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012Pwd", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012SFZNo", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012Mobile", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012Email", SqlDbType.NVarChar,500),
					new SqlParameter("SQL2012WeiXinOpenID", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012QQID", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012UserType", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012Industry", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012XueLi", SqlDbType.Int,4),
					new SqlParameter("SQL2012id", SqlDbType.Int,4),
					new SqlParameter("SQL2012ParentID", SqlDbType.Int,4),
					new SqlParameter("SQL2012CreateDate", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012CreateUser", SqlDbType.Int,4)			};
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

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(tabUserModel model)
		{
		 	model.Version = model.Version.IsNotNullOrEmpty()? model.Version: "1";
            model.RandomNo = model.RandomNo.IsNotNullOrEmpty()? model.RandomNo: Guid.NewGuid().ToString("N");
            model.Status = model.Status.IsNotNullOrEmpty()? model.Status: "1";
            model.OrderNo = model.OrderNo>0? model.OrderNo: 1;
			model.CreateDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tabUser(");			
            strSql.Append("UserName,NickName,Pwd,Sex,Birthday,HeadImgURLID,RealName,SFZNo,IDCardPerson,Mobile,Email,Marriage,BeginJobYear,WeiXinOpenID,WXNickName,WxCode,QQID,QQNickName,QQNo,SinaID,Ali,OtherID,Country,State,City,District,Community,Address,AddressFull,SafeQuestion,SafeAnswer,UserType,IsLogin,LastLoginTime,RoleID,GroupID,RegIP,RegDate,Industry,MinZu,MianMao,XueLi,ZhiWu,OrgID,BankCardNo,OrderQuality,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
			strSql.Append(") values (");
            strSql.Append("SQL2012UserName,SQL2012NickName,SQL2012Pwd,SQL2012Sex,SQL2012Birthday,SQL2012HeadImgURLID,SQL2012RealName,SQL2012SFZNo,SQL2012IDCardPerson,SQL2012Mobile,SQL2012Email,SQL2012Marriage,SQL2012BeginJobYear,SQL2012WeiXinOpenID,SQL2012WXNickName,SQL2012WxCode,SQL2012QQID,SQL2012QQNickName,SQL2012QQNo,SQL2012SinaID,SQL2012Ali,SQL2012OtherID,SQL2012Country,SQL2012State,SQL2012City,SQL2012District,SQL2012Community,SQL2012Address,SQL2012AddressFull,SQL2012SafeQuestion,SQL2012SafeAnswer,SQL2012UserType,SQL2012IsLogin,SQL2012LastLoginTime,SQL2012RoleID,SQL2012GroupID,SQL2012RegIP,SQL2012RegDate,SQL2012Industry,SQL2012MinZu,SQL2012MianMao,SQL2012XueLi,SQL2012ZhiWu,SQL2012OrgID,SQL2012BankCardNo,SQL2012OrderQuality,SQL2012AppID,SQL2012Version,SQL2012RandomNo,SQL2012ParentID,SQL2012Remark,SQL2012LableText,SQL2012ExJson,SQL2012Status,SQL2012OrderNo,SQL2012CreateDate,SQL2012ModifyDate,SQL2012CreateUser,SQL2012ModifyUser");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("SQL2012UserName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012NickName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Pwd", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012Sex", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Birthday", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012HeadImgURLID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012RealName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012SFZNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012IDCardPerson", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012Mobile", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Email", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012Marriage", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012BeginJobYear", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012WeiXinOpenID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012WXNickName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012WxCode", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012QQID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012QQNickName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012QQNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012SinaID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Ali", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OtherID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Country", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012State", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012City", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012District", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Community", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Address", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012AddressFull", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012SafeQuestion", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012SafeAnswer", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012UserType", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012IsLogin", SqlDbType.Bit,1) ,            
                        new SqlParameter("SQL2012LastLoginTime", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012RoleID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012GroupID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012RegIP", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012RegDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Industry", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012MinZu", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012MianMao", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012XueLi", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012ZhiWu", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012OrgID", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012BankCardNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OrderQuality", SqlDbType.Bit,1) ,            
                        new SqlParameter("SQL2012AppID", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("SQL2012Version", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("SQL2012RandomNo", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012Remark", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012LableText", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012ExJson", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012Status", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012OrderNo", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012CreateDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012ModifyDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012CreateUser", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012ModifyUser", SqlDbType.Int,4)             
              
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
			   
			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);			
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
		public bool Update(tabUserModel model)
		{
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabUser set ");
			                        
            strSql.Append(" UserName = SQL2012UserName , ");                                    
            strSql.Append(" NickName = SQL2012NickName , ");                                    
            strSql.Append(" Pwd = SQL2012Pwd , ");                                    
            strSql.Append(" Sex = SQL2012Sex , ");                                    
            strSql.Append(" Birthday = SQL2012Birthday , ");                                    
            strSql.Append(" HeadImgURLID = SQL2012HeadImgURLID , ");                                    
            strSql.Append(" RealName = SQL2012RealName , ");                                    
            strSql.Append(" SFZNo = SQL2012SFZNo , ");                                    
            strSql.Append(" IDCardPerson = SQL2012IDCardPerson , ");                                    
            strSql.Append(" Mobile = SQL2012Mobile , ");                                    
            strSql.Append(" Email = SQL2012Email , ");                                    
            strSql.Append(" Marriage = SQL2012Marriage , ");                                    
            strSql.Append(" BeginJobYear = SQL2012BeginJobYear , ");                                    
            strSql.Append(" WeiXinOpenID = SQL2012WeiXinOpenID , ");                                    
            strSql.Append(" WXNickName = SQL2012WXNickName , ");                                    
            strSql.Append(" WxCode = SQL2012WxCode , ");                                    
            strSql.Append(" QQID = SQL2012QQID , ");                                    
            strSql.Append(" QQNickName = SQL2012QQNickName , ");                                    
            strSql.Append(" QQNo = SQL2012QQNo , ");                                    
            strSql.Append(" SinaID = SQL2012SinaID , ");                                    
            strSql.Append(" Ali = SQL2012Ali , ");                                    
            strSql.Append(" OtherID = SQL2012OtherID , ");                                    
            strSql.Append(" Country = SQL2012Country , ");                                    
            strSql.Append(" State = SQL2012State , ");                                    
            strSql.Append(" City = SQL2012City , ");                                    
            strSql.Append(" District = SQL2012District , ");                                    
            strSql.Append(" Community = SQL2012Community , ");                                    
            strSql.Append(" Address = SQL2012Address , ");                                    
            strSql.Append(" AddressFull = SQL2012AddressFull , ");                                    
            strSql.Append(" SafeQuestion = SQL2012SafeQuestion , ");                                    
            strSql.Append(" SafeAnswer = SQL2012SafeAnswer , ");                                    
            strSql.Append(" UserType = SQL2012UserType , ");                                    
            strSql.Append(" IsLogin = SQL2012IsLogin , ");                                    
            strSql.Append(" LastLoginTime = SQL2012LastLoginTime , ");                                    
            strSql.Append(" RoleID = SQL2012RoleID , ");                                    
            strSql.Append(" GroupID = SQL2012GroupID , ");                                    
            strSql.Append(" RegIP = SQL2012RegIP , ");                                    
            strSql.Append(" RegDate = SQL2012RegDate , ");                                    
            strSql.Append(" Industry = SQL2012Industry , ");                                    
            strSql.Append(" MinZu = SQL2012MinZu , ");                                    
            strSql.Append(" MianMao = SQL2012MianMao , ");                                    
            strSql.Append(" XueLi = SQL2012XueLi , ");                                    
            strSql.Append(" ZhiWu = SQL2012ZhiWu , ");                                    
            strSql.Append(" OrgID = SQL2012OrgID , ");                                    
            strSql.Append(" BankCardNo = SQL2012BankCardNo , ");                                    
            strSql.Append(" OrderQuality = SQL2012OrderQuality , ");                                                            
            strSql.Append(" AppID = SQL2012AppID , ");                                    
            strSql.Append(" Version = SQL2012Version , ");                                    
            strSql.Append(" RandomNo = SQL2012RandomNo , ");                                    
            strSql.Append(" ParentID = SQL2012ParentID , ");                                    
            strSql.Append(" Remark = SQL2012Remark , ");                                    
            strSql.Append(" LableText = SQL2012LableText , ");                                    
            strSql.Append(" ExJson = SQL2012ExJson , ");                                    
            strSql.Append(" Status = SQL2012Status , ");                                    
            strSql.Append(" OrderNo = SQL2012OrderNo , ");                                    
            strSql.Append(" CreateDate = SQL2012CreateDate , ");                                    
            strSql.Append(" ModifyDate = SQL2012ModifyDate , ");                                    
            strSql.Append(" CreateUser = SQL2012CreateUser , ");                                    
            strSql.Append(" ModifyUser = SQL2012ModifyUser  ");            			
			strSql.Append(" where id=SQL2012id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("SQL2012UserName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012NickName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Pwd", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012Sex", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Birthday", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012HeadImgURLID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012RealName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012SFZNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012IDCardPerson", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012Mobile", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Email", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012Marriage", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012BeginJobYear", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012WeiXinOpenID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012WXNickName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012WxCode", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012QQID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012QQNickName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012QQNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012SinaID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Ali", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OtherID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Country", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012State", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012City", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012District", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Community", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Address", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012AddressFull", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012SafeQuestion", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012SafeAnswer", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012UserType", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012IsLogin", SqlDbType.Bit,1) ,            
                        new SqlParameter("SQL2012LastLoginTime", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012RoleID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012GroupID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012RegIP", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012RegDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Industry", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012MinZu", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012MianMao", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012XueLi", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012ZhiWu", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012OrgID", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012BankCardNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OrderQuality", SqlDbType.Bit,1) ,            
                        new SqlParameter("SQL2012id", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012AppID", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("SQL2012Version", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("SQL2012RandomNo", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012Remark", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012LableText", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012ExJson", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012Status", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012OrderNo", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012CreateDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012ModifyDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012CreateUser", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012ModifyUser", SqlDbType.Int,4)             
              
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
            int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
        /// 修改一列数据
        /// </summary>
        public void UpdateField(int id, string strValue)
        {
            StringBuilder strSql = new StringBuilder();
			strSql.Append("update tabUser set " + strValue);           
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(tabUserModel model, List<string> ChangedFields)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabUser set ");
			                        
            strSql.Append(" UserName = SQL2012UserName , ");                                    
            strSql.Append(" NickName = SQL2012NickName , ");                                    
            strSql.Append(" Pwd = SQL2012Pwd , ");                                    
            strSql.Append(" Sex = SQL2012Sex , ");                                    
            strSql.Append(" Birthday = SQL2012Birthday , ");                                    
            strSql.Append(" HeadImgURLID = SQL2012HeadImgURLID , ");                                    
            strSql.Append(" RealName = SQL2012RealName , ");                                    
            strSql.Append(" SFZNo = SQL2012SFZNo , ");                                    
            strSql.Append(" IDCardPerson = SQL2012IDCardPerson , ");                                    
            strSql.Append(" Mobile = SQL2012Mobile , ");                                    
            strSql.Append(" Email = SQL2012Email , ");                                    
            strSql.Append(" Marriage = SQL2012Marriage , ");                                    
            strSql.Append(" BeginJobYear = SQL2012BeginJobYear , ");                                    
            strSql.Append(" WeiXinOpenID = SQL2012WeiXinOpenID , ");                                    
            strSql.Append(" WXNickName = SQL2012WXNickName , ");                                    
            strSql.Append(" WxCode = SQL2012WxCode , ");                                    
            strSql.Append(" QQID = SQL2012QQID , ");                                    
            strSql.Append(" QQNickName = SQL2012QQNickName , ");                                    
            strSql.Append(" QQNo = SQL2012QQNo , ");                                    
            strSql.Append(" SinaID = SQL2012SinaID , ");                                    
            strSql.Append(" Ali = SQL2012Ali , ");                                    
            strSql.Append(" OtherID = SQL2012OtherID , ");                                    
            strSql.Append(" Country = SQL2012Country , ");                                    
            strSql.Append(" State = SQL2012State , ");                                    
            strSql.Append(" City = SQL2012City , ");                                    
            strSql.Append(" District = SQL2012District , ");                                    
            strSql.Append(" Community = SQL2012Community , ");                                    
            strSql.Append(" Address = SQL2012Address , ");                                    
            strSql.Append(" AddressFull = SQL2012AddressFull , ");                                    
            strSql.Append(" SafeQuestion = SQL2012SafeQuestion , ");                                    
            strSql.Append(" SafeAnswer = SQL2012SafeAnswer , ");                                    
            strSql.Append(" UserType = SQL2012UserType , ");                                    
            strSql.Append(" IsLogin = SQL2012IsLogin , ");                                    
            strSql.Append(" LastLoginTime = SQL2012LastLoginTime , ");                                    
            strSql.Append(" RoleID = SQL2012RoleID , ");                                    
            strSql.Append(" GroupID = SQL2012GroupID , ");                                    
            strSql.Append(" RegIP = SQL2012RegIP , ");                                    
            strSql.Append(" RegDate = SQL2012RegDate , ");                                    
            strSql.Append(" Industry = SQL2012Industry , ");                                    
            strSql.Append(" MinZu = SQL2012MinZu , ");                                    
            strSql.Append(" MianMao = SQL2012MianMao , ");                                    
            strSql.Append(" XueLi = SQL2012XueLi , ");                                    
            strSql.Append(" ZhiWu = SQL2012ZhiWu , ");                                    
            strSql.Append(" OrgID = SQL2012OrgID , ");                                    
            strSql.Append(" BankCardNo = SQL2012BankCardNo , ");                                    
            strSql.Append(" OrderQuality = SQL2012OrderQuality , ");                                                            
            strSql.Append(" AppID = SQL2012AppID , ");                                    
            strSql.Append(" Version = SQL2012Version , ");                                    
            strSql.Append(" RandomNo = SQL2012RandomNo , ");                                    
            strSql.Append(" ParentID = SQL2012ParentID , ");                                    
            strSql.Append(" Remark = SQL2012Remark , ");                                    
            strSql.Append(" LableText = SQL2012LableText , ");                                    
            strSql.Append(" ExJson = SQL2012ExJson , ");                                    
            strSql.Append(" Status = SQL2012Status , ");                                    
            strSql.Append(" OrderNo = SQL2012OrderNo , ");                                    
            strSql.Append(" CreateDate = SQL2012CreateDate , ");                                    
            strSql.Append(" ModifyDate = SQL2012ModifyDate , ");                                    
            strSql.Append(" CreateUser = SQL2012CreateUser , ");                                    
            strSql.Append(" ModifyUser = SQL2012ModifyUser  ");            			
			strSql.Append(" where id=SQL2012id ");						
SqlParameter[] parameters = {
			            new SqlParameter("SQL2012UserName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012NickName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Pwd", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012Sex", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Birthday", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012HeadImgURLID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012RealName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012SFZNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012IDCardPerson", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012Mobile", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Email", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012Marriage", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012BeginJobYear", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012WeiXinOpenID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012WXNickName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012WxCode", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012QQID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012QQNickName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012QQNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012SinaID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Ali", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OtherID", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Country", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012State", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012City", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012District", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Community", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Address", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012AddressFull", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012SafeQuestion", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012SafeAnswer", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012UserType", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012IsLogin", SqlDbType.Bit,1) ,            
                        new SqlParameter("SQL2012LastLoginTime", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012RoleID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012GroupID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012RegIP", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012RegDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012Industry", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012MinZu", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012MianMao", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012XueLi", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012ZhiWu", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012OrgID", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012BankCardNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OrderQuality", SqlDbType.Bit,1) ,            
                        new SqlParameter("SQL2012id", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012AppID", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("SQL2012Version", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("SQL2012RandomNo", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012Remark", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012LableText", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012ExJson", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012Status", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012OrderNo", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012CreateDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012ModifyDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012CreateUser", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012ModifyUser", SqlDbType.Int,4)             
              
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
            int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tabUser ");
			strSql.Append(" where id=SQL2012id");
						SqlParameter[] parameters = {
					new SqlParameter("SQL2012id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tabUser ");
			strSql.Append(" where ID in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public tabUserModel GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");			
			strSql.Append("  from tabUser ");
			strSql.Append(" where id=SQL2012id");
						SqlParameter[] parameters = {
					new SqlParameter("SQL2012id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			
			tabUserModel model=new tabUserModel();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabUserModel>.FillModel(ds.Tables[0].Rows[0]);
            else
                return null;
		}		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM tabUser ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
			return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM tabUser ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" * ");
			strSql.Append(" FROM tabUser ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
		/// <summary>
		/// 获得数据列表，取最新版本数据
		/// </summary>
		public DataSet GetListVersion(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM tabUser as a  where  version=(select max(b.version)  from tabUser  as b  where a.RandomNo =  b.RandomNo) ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" and "+strWhere);
			}
			recordCount = Convert.ToInt32(DbHelperSQL.GetSingle(PagingHelper.CreateCountingSql(strSql.ToString())));
			return DbHelperSQL.Query(PagingHelper.CreatePagingSql(recordCount, pageSize, pageIndex, strSql.ToString(), filedOrder));			
		}
		/// <summary>
		/// 获得数据列表，取最新版本数据
		/// </summary>
		public DataSet GetListVersion(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM tabUser as a  where  version=(select max(b.version)  from tabUser  as b  where a.RandomNo =  b.RandomNo) ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" and "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}		
		/// <summary>
		/// 获得前几行数据，取最新版本数据
		/// </summary>
		public DataSet GetListVersion(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" * ");
			strSql.Append(" FROM tabUser as a  where  version=(select max(b.version)  from tabUser  as b  where a.RandomNo =  b.RandomNo)");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" and "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
		#endregion
	}
}
#endregion
#region BLL类    
namespace Tclywork.BLL{    
    /// <summary>
	/// 用户表
    /// </summary> 	
	public partial class tabUserBLL
	{
        private readonly tabUserSQLDAL dal=new tabUserSQLDAL();
		public void tabUser()
		{
		}
		public static tabUserBLL Instance
        {
            get
            {
                return _Instance;
            }
            set { _Instance = value; }
        }private static tabUserBLL _Instance;
        public static tabUserBLL GetInstance()
        {
            if (Instance == null)
            {
                Instance = new tabUserBLL();
            }
            return Instance;
        }
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string UserName,string Pwd,string SFZNo,string Mobile,string Email,string WeiXinOpenID,string QQID,string UserType,string Industry,int XueLi,int id,int ParentID,string CreateDate,int CreateUser)
		{
			return dal.Exists(UserName,Pwd,SFZNo,Mobile,Email,WeiXinOpenID,QQID,UserType,Industry,XueLi,id,ParentID,CreateDate,CreateUser);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(tabUserModel model)
		{
			return dal.Add(model);
						
		}
		/// <summary>
		/// 修改一列数据
		/// </summary>
		public void UpdateField(int id, string strValue)
		{
			dal.UpdateField(id, strValue);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(tabUserModel model)
		{
			return dal.Update(model);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{		
			return dal.Delete(id);
		}
				/// <summary>
		/// 批量删除一批数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			return dal.DeleteList(idlist );
		}
			
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public tabUserModel GetModel(int id)
		{
			
			return dal.GetModel(id);
		}	
		/// <summary>
		/// 得到对象列表中第一个对象实体
		/// </summary>
		public tabUserModel GetModel(string _where,int Index)
		{
			List<tabUserModel> lsmodel = GetModelList(_where);
			if(lsmodel != null && lsmodel.Count>0)
            {
                return lsmodel[Index];
            }
            else
            {
                return null;
            }
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
		{
			return dal.GetList(pageSize, pageIndex, strWhere, filedOrder, out recordCount);
		}
		/// <summary>
        /// 获得数据列表
        /// </summary>
        public List<tabUserModel> GetModelList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            DataSet ds = dal.GetList(pageSize, pageIndex, strWhere, filedOrder, out recordCount);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabUserModel>.FillModel(ds.Tables[0]);
            else
                return new List<tabUserModel>();
        }
        
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<tabUserModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabUserModel>.FillModel(ds.Tables[0]);
            else
                return null;
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return dal.GetList("");
		}
		/// <summary>
		/// 获得数据列表，取最新版本数据
		/// </summary>
		public DataSet GetListVersion(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
		{
			return dal.GetListVersion(pageSize, pageIndex, strWhere, filedOrder, out recordCount);
		}
		/// <summary>
		/// 获得前几行数据，取最新版本数据
		/// </summary>
		public DataSet GetListVersion(int Top,string strWhere,string filedOrder)
		{
			return dal.GetListVersion(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表，取最新版本数据
		/// </summary>
		public List<tabUserModel> GetModelListVersion(string strWhere)
		{
			DataSet ds = dal.GetListVersion(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabUserModel>.FillModel(ds.Tables[0]);
            else
                return null;
		}
		/// <summary>
		/// 获得数据列表，取最新版本数据
		/// </summary>
		public DataSet GetAllListVersion()
		{
			return dal.GetListVersion("");
		}
	}
	
}
#endregion
