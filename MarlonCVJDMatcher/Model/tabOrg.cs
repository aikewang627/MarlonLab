
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
#region  Model 实体类- tabOrg
namespace Tclywork.Model{
	[Serializable]
	/// <summary>
	/// 来往单位表（通表）
    /// </summary> 	
	public partial class tabOrgModel
	{   		     
      								/// <summary>
			/// 结构名称
	        /// </summary>
	        
	        public string OrgName
	        {
	            get{ return _OrgName; }
	            set{ _OrgName = value;}
	        }private string _OrgName;
				        
							/// <summary>
			/// 描述
	        /// </summary>
	        
	        public string OrgDesc
	        {
	            get{ return _OrgDesc; }
	            set{ _OrgDesc = value;}
	        }private string _OrgDesc;
				        
							/// <summary>
			/// 简称
	        /// </summary>
	        
	        public string OrgNickName
	        {
	            get{ return _OrgNickName; }
	            set{ _OrgNickName = value;}
	        }private string _OrgNickName;
				        
							/// <summary>
			/// 职责
	        /// </summary>
	        
	        public string OrgZZ
	        {
	            get{ return _OrgZZ; }
	            set{ _OrgZZ = value;}
	        }private string _OrgZZ;
				        
							/// <summary>
			/// 组织代码
	        /// </summary>
	        
	        public string OrgCode
	        {
	            get{ return _OrgCode; }
	            set{ _OrgCode = value;}
	        }private string _OrgCode;
				        
							/// <summary>
			/// 机构类型，公司：Company；工会组织：Union；工会：部门：Dept
	        /// </summary>
	        
	        public string OrgType
	        {
	            get{ return _OrgType; }
	            set{ _OrgType = value;}
	        }private string _OrgType;
				        
							/// <summary>
			/// 自定义分类，客户类型：合作客户，潜在客户，意向客户，优质合作客户，集体所有，国有，外资，民营
	        /// </summary>
	        
	        public int OrgClass
	        {
	            get{ return _OrgClass; }
	            set{ _OrgClass = value;}
	        }private int _OrgClass;
				        
							/// <summary>
			/// 发展阶段
	        /// </summary>
	        
	        public string OrgLevel
	        {
	            get{ return _OrgLevel; }
	            set{ _OrgLevel = value;}
	        }private string _OrgLevel;
				        
							/// <summary>
			/// 单位亮点
	        /// </summary>
	        
	        public string OrgEdge
	        {
	            get{ return _OrgEdge; }
	            set{ _OrgEdge = value;}
	        }private string _OrgEdge;
				        
							/// <summary>
			/// 专业领域
	        /// </summary>
	        
	        public string OrgPro
	        {
	            get{ return _OrgPro; }
	            set{ _OrgPro = value;}
	        }private string _OrgPro;
				        
							/// <summary>
			/// 公司名片
	        /// </summary>
	        
	        public int OrgCard
	        {
	            get{ return _OrgCard; }
	            set{ _OrgCard = value;}
	        }private int _OrgCard;
				        
							/// <summary>
			/// 编制
	        /// </summary>
	        
	        public int PlanNum
	        {
	            get{ return _PlanNum; }
	            set{ _PlanNum = value;}
	        }private int _PlanNum;
				        
							/// <summary>
			/// 联系人
	        /// </summary>
	        
	        public string Leader
	        {
	            get{ return _Leader; }
	            set{ _Leader = value;}
	        }private string _Leader;
				        
							/// <summary>
			/// 领导手机
	        /// </summary>
	        
	        public string LeaderMobile
	        {
	            get{ return _LeaderMobile; }
	            set{ _LeaderMobile = value;}
	        }private string _LeaderMobile;
				        
							/// <summary>
			/// Logo
	        /// </summary>
	        
	        public int Logo
	        {
	            get{ return _Logo; }
	            set{ _Logo = value;}
	        }private int _Logo;
				        
							/// <summary>
			/// 网站
	        /// </summary>
	        
	        public string WebSite
	        {
	            get{ return _WebSite; }
	            set{ _WebSite = value;}
	        }private string _WebSite;
				        
							/// <summary>
			/// 座机
	        /// </summary>
	        
	        public string Phone
	        {
	            get{ return _Phone; }
	            set{ _Phone = value;}
	        }private string _Phone;
				        
							/// <summary>
			/// 执照编号
	        /// </summary>
	        
	        public string ZZNo
	        {
	            get{ return _ZZNo; }
	            set{ _ZZNo = value;}
	        }private string _ZZNo;
				        
							/// <summary>
			/// ZZImg
	        /// </summary>
	        
	        public int ZZImg
	        {
	            get{ return _ZZImg; }
	            set{ _ZZImg = value;}
	        }private int _ZZImg;
				        
							/// <summary>
			/// 性质
	        /// </summary>
	        
	        public int Natrue
	        {
	            get{ return _Natrue; }
	            set{ _Natrue = value;}
	        }private int _Natrue;
				        
							/// <summary>
			/// 拼音
	        /// </summary>
	        
	        public string PY
	        {
	            get{ return _PY; }
	            set{ _PY = value;}
	        }private string _PY;
				        
							/// <summary>
			/// 国家
	        /// </summary>
	        
	        public string Country
	        {
	            get{ return _Country; }
	            set{ _Country = value;}
	        }private string _Country;
				        
							/// <summary>
			/// 省
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
			/// AreaFull
	        /// </summary>
	        
	        public string AreaFull
	        {
	            get{ return _AreaFull; }
	            set{ _AreaFull = value;}
	        }private string _AreaFull;
				        
							/// <summary>
			/// 邮编
	        /// </summary>
	        
	        public string ZipCode
	        {
	            get{ return _ZipCode; }
	            set{ _ZipCode = value;}
	        }private string _ZipCode;
				        
							/// <summary>
			/// QQ号
	        /// </summary>
	        
	        public string QQOpenID
	        {
	            get{ return _QQOpenID; }
	            set{ _QQOpenID = value;}
	        }private string _QQOpenID;
				        
							/// <summary>
			/// 微信号
	        /// </summary>
	        
	        public string WeiXinOpenID
	        {
	            get{ return _WeiXinOpenID; }
	            set{ _WeiXinOpenID = value;}
	        }private string _WeiXinOpenID;
				        
							/// <summary>
			/// 传真
	        /// </summary>
	        
	        public string Fax
	        {
	            get{ return _Fax; }
	            set{ _Fax = value;}
	        }private string _Fax;
				        
							/// <summary>
			/// 邮箱
	        /// </summary>
	        
	        public string Email
	        {
	            get{ return _Email; }
	            set{ _Email = value;}
	        }private string _Email;
				        
							/// <summary>
			/// 销售类型
	        /// </summary>
	        
	        public string SaleType
	        {
	            get{ return _SaleType; }
	            set{ _SaleType = value;}
	        }private string _SaleType;
				        
							/// <summary>
			/// 规模
	        /// </summary>
	        
	        public string Scale
	        {
	            get{ return _Scale; }
	            set{ _Scale = value;}
	        }private string _Scale;
				        
							/// <summary>
			/// 客户来源
	        /// </summary>
	        
	        public string Source
	        {
	            get{ return _Source; }
	            set{ _Source = value;}
	        }private string _Source;
				        
							/// <summary>
			/// 销售状态
	        /// </summary>
	        
	        public string SaleStatus
	        {
	            get{ return _SaleStatus; }
	            set{ _SaleStatus = value;}
	        }private string _SaleStatus;
				        
							/// <summary>
			/// 开户行
	        /// </summary>
	        
	        public string BankName
	        {
	            get{ return _BankName; }
	            set{ _BankName = value;}
	        }private string _BankName;
				        
							/// <summary>
			/// 银行账号
	        /// </summary>
	        
	        public string BankAccount
	        {
	            get{ return _BankAccount; }
	            set{ _BankAccount = value;}
	        }private string _BankAccount;
				        
							/// <summary>
			/// 最早创建时间
	        /// </summary>
	        
	        public string CreateUnitDate
	        {
	            get{ return _CreateUnitDate; }
	            set{ _CreateUnitDate = value;}
	        }private string _CreateUnitDate;
				        
							/// <summary>
			/// 成立时间
	        /// </summary>
	        
	        public string BeginDate
	        {
	            get{ return _BeginDate; }
	            set{ _BeginDate = value;}
	        }private string _BeginDate;
				        
							/// <summary>
			/// EndDate
	        /// </summary>
	        
	        public string EndDate
	        {
	            get{ return _EndDate; }
	            set{ _EndDate = value;}
	        }private string _EndDate;
				        
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
	/// 来往单位表（通表）
    /// </summary> 	
	public partial class tabOrgSQLDAL
	{
		#region 实现方法
   		 /// <summary>
		/// 是否存在
		/// </summary>    
		public bool Exists(string OrgName,int id,int ParentID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tabOrg");
			strSql.Append(" where ");
			                        strSql.Append(" OrgName = @OrgName and  ");
                                                    strSql.Append(" id = @id and  ");
                                                    strSql.Append(" ParentID = @ParentID  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@OrgName", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4)			};
			parameters[0].Value = OrgName;
			parameters[1].Value = id;
			parameters[2].Value = ParentID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(tabOrgModel model)
		{
		 	model.Version = model.Version.IsNotNullOrEmpty()? model.Version: "1";
            model.RandomNo = model.RandomNo.IsNotNullOrEmpty()? model.RandomNo: Guid.NewGuid().ToString("N");
            model.Status = model.Status.IsNotNullOrEmpty()? model.Status: "1";
            model.OrderNo = model.OrderNo>0? model.OrderNo: 1;
			model.CreateDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
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
		public bool Update(tabOrgModel model)
		{
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
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
			strSql.Append("update tabOrg set " + strValue);           
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(tabOrgModel model, List<string> ChangedFields)
		{
			StringBuilder strSql=new StringBuilder();
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
			strSql.Append("delete from tabOrg ");
			strSql.Append(" where id=@id");
						SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
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
			strSql.Append("delete from tabOrg ");
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
		public tabOrgModel GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");			
			strSql.Append("  from tabOrg ");
			strSql.Append(" where id=@id");
						SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			
			tabOrgModel model=new tabOrgModel();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabOrgModel>.FillModel(ds.Tables[0].Rows[0]);
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
			strSql.Append(" FROM tabOrg ");
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
			strSql.Append(" FROM tabOrg ");
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
			strSql.Append(" FROM tabOrg ");
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
			strSql.Append(" FROM tabOrg as a  where  version=(select max(b.version)  from tabOrg  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabOrg as a  where  version=(select max(b.version)  from tabOrg  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabOrg as a  where  version=(select max(b.version)  from tabOrg  as b  where a.RandomNo =  b.RandomNo)");
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
	/// 来往单位表（通表）
    /// </summary> 	
	public partial class tabOrgBLL
	{
        private readonly tabOrgSQLDAL dal=new tabOrgSQLDAL();
		public void tabOrg()
		{
		}
		public static tabOrgBLL Instance
        {
            get
            {
                return _Instance;
            }
            set { _Instance = value; }
        }private static tabOrgBLL _Instance;
        public static tabOrgBLL GetInstance()
        {
            if (Instance == null)
            {
                Instance = new tabOrgBLL();
            }
            return Instance;
        }
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string OrgName,int id,int ParentID)
		{
			return dal.Exists(OrgName,id,ParentID);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(tabOrgModel model)
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
		public bool Update(tabOrgModel model)
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
		public tabOrgModel GetModel(int id)
		{
			
			return dal.GetModel(id);
		}	
		/// <summary>
		/// 得到对象列表中第一个对象实体
		/// </summary>
		public tabOrgModel GetModel(string _where,int Index)
		{
			List<tabOrgModel> lsmodel = GetModelList(_where);
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
        public List<tabOrgModel> GetModelList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            DataSet ds = dal.GetList(pageSize, pageIndex, strWhere, filedOrder, out recordCount);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabOrgModel>.FillModel(ds.Tables[0]);
            else
                return new List<tabOrgModel>();
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
		public List<tabOrgModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabOrgModel>.FillModel(ds.Tables[0]);
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
		public List<tabOrgModel> GetModelListVersion(string strWhere)
		{
			DataSet ds = dal.GetListVersion(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabOrgModel>.FillModel(ds.Tables[0]);
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
