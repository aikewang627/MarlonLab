
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
#region  Model 实体类- tabResumeOutline
namespace Tclywork.Model{
	[Serializable]
	/// <summary>
	/// tabResumeOutline
    /// </summary> 	
	public partial class tabResumeOutlineModel
	{   		     
      								/// <summary>
			/// id
	        /// </summary>
	        
	        public int id
	        {
	            get{ return _id; }
	            set{ _id = value;}
	        }private int _id;
				        
							/// <summary>
			/// ResumeID
	        /// </summary>
	        
	        public int ResumeID
	        {
	            get{ return _ResumeID; }
	            set{ _ResumeID = value;}
	        }private int _ResumeID;
				        
							/// <summary>
			/// ResumeNo
	        /// </summary>
	        
	        public string ResumeNo
	        {
	            get{ return _ResumeNo; }
	            set{ _ResumeNo = value;}
	        }private string _ResumeNo;
				        
							/// <summary>
			/// 特殊标识（简历名称）
	        /// </summary>
	        
	        public string ResumeName
	        {
	            get{ return _ResumeName; }
	            set{ _ResumeName = value;}
	        }private string _ResumeName;
				        
							/// <summary>
			/// 状态
	        /// </summary>
	        
	        public string Status
	        {
	            get{ return _Status; }
	            set{ _Status = value;}
	        }private string _Status;
				        
							/// <summary>
			/// 创建用户
	        /// </summary>
	        
	        public int CreateUser
	        {
	            get{ return _CreateUser; }
	            set{ _CreateUser = value;}
	        }private int _CreateUser;
				        
							/// <summary>
			/// 创建时间
	        /// </summary>
	        
	        public string CreateDate
	        {
	            get{ return _CreateDate; }
	            set{ _CreateDate = value;}
	        }private string _CreateDate;
				        
							/// <summary>
			/// 上级编号
	        /// </summary>
	        
	        public int ParentID
	        {
	            get{ return _ParentID; }
	            set{ _ParentID = value;}
	        }private int _ParentID;
				        
							/// <summary>
			/// 真实姓名
	        /// </summary>
	        
	        public string RealName
	        {
	            get{ return _RealName; }
	            set{ _RealName = value;}
	        }private string _RealName;
				        
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
			/// 学历
	        /// </summary>
	        
	        public string XueLi
	        {
	            get{ return _XueLi; }
	            set{ _XueLi = value;}
	        }private string _XueLi;
				        
							/// <summary>
			/// 学习过的学校
	        /// </summary>
	        
	        public string School
	        {
	            get{ return _School; }
	            set{ _School = value;}
	        }private string _School;
				        
							/// <summary>
			/// 大学专业
	        /// </summary>
	        
	        public string Major
	        {
	            get{ return _Major; }
	            set{ _Major = value;}
	        }private string _Major;
				        
							/// <summary>
			/// 工作过的公司
	        /// </summary>
	        
	        public string Company
	        {
	            get{ return _Company; }
	            set{ _Company = value;}
	        }private string _Company;
				        
							/// <summary>
			/// Skill
	        /// </summary>
	        
	        public string Skill
	        {
	            get{ return _Skill; }
	            set{ _Skill = value;}
	        }private string _Skill;
				        
							/// <summary>
			/// CoreSkill
	        /// </summary>
	        
	        public string CoreSkill
	        {
	            get{ return _CoreSkill; }
	            set{ _CoreSkill = value;}
	        }private string _CoreSkill;
				        
							/// <summary>
			/// 期望工作地址
	        /// </summary>
	        
	        public string HopeAddress
	        {
	            get{ return _HopeAddress; }
	            set{ _HopeAddress = value;}
	        }private string _HopeAddress;
				        
							/// <summary>
			/// 期望职位
	        /// </summary>
	        
	        public string HopePosition
	        {
	            get{ return _HopePosition; }
	            set{ _HopePosition = value;}
	        }private string _HopePosition;
				        
							/// <summary>
			/// 期望行业
	        /// </summary>
	        
	        public string HopeIndustry
	        {
	            get{ return _HopeIndustry; }
	            set{ _HopeIndustry = value;}
	        }private string _HopeIndustry;
				        
							/// <summary>
			/// HopeSalary
	        /// </summary>
	        
	        public decimal HopeSalary
	        {
	            get{ return _HopeSalary; }
	            set{ _HopeSalary = value;}
	        }private decimal _HopeSalary;
				        
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
			/// 排序
	        /// </summary>
	        
	        public int OrderNo
	        {
	            get{ return _OrderNo; }
	            set{ _OrderNo = value;}
	        }private int _OrderNo;
				        
							/// <summary>
			/// 修改时间
	        /// </summary>
	        
	        public string ModifyDate
	        {
	            get{ return _ModifyDate; }
	            set{ _ModifyDate = value;}
	        }private string _ModifyDate;
				        
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
	/// tabResumeOutline
    /// </summary> 	
	public partial class tabResumeOutlineSQLDAL
	{
		#region 实现方法
   		 /// <summary>
		/// 是否存在
		/// </summary>    
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tabResumeOutline");
			strSql.Append(" where ");
			                        strSql.Append(" id = @id  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(tabResumeOutlineModel model)
		{
		 	model.Version = model.Version.IsNotNullOrEmpty()? model.Version: "1";
            model.RandomNo = model.RandomNo.IsNotNullOrEmpty()? model.RandomNo: Guid.NewGuid().ToString("N");
            model.Status = model.Status.IsNotNullOrEmpty()? model.Status: "1";
            model.OrderNo = model.OrderNo>0? model.OrderNo: 1;
			model.CreateDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tabResumeOutline(");			
            strSql.Append("ResumeID,ResumeNo,ResumeName,Status,CreateUser,CreateDate,ParentID,RealName,Sex,Birthday,Marriage,BeginJobYear,Mobile,Email,XueLi,School,Major,Company,Skill,CoreSkill,HopeAddress,HopePosition,HopeIndustry,HopeSalary,AppID,Version,RandomNo,Remark,LableText,ExJson,OrderNo,ModifyDate,ModifyUser");
			strSql.Append(") values (");
            strSql.Append("@ResumeID,@ResumeNo,@ResumeName,@Status,@CreateUser,@CreateDate,@ParentID,@RealName,@Sex,@Birthday,@Marriage,@BeginJobYear,@Mobile,@Email,@XueLi,@School,@Major,@Company,@Skill,@CoreSkill,@HopeAddress,@HopePosition,@HopeIndustry,@HopeSalary,@AppID,@Version,@RandomNo,@Remark,@LableText,@ExJson,@OrderNo,@ModifyDate,@ModifyUser");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@ResumeID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ResumeNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ResumeName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Status", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@CreateUser", SqlDbType.Int,4) ,            
                        new SqlParameter("@CreateDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("@RealName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Sex", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Birthday", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Marriage", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@BeginJobYear", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Mobile", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Email", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@XueLi", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@School", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@Major", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@Company", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@Skill", SqlDbType.NText) ,            
                        new SqlParameter("@CoreSkill", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@HopeAddress", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@HopePosition", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@HopeIndustry", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@HopeSalary", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@AppID", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@Version", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@RandomNo", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@Remark", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@LableText", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@ExJson", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@OrderNo", SqlDbType.Int,4) ,            
                        new SqlParameter("@ModifyDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ModifyUser", SqlDbType.Int,4)             
              
            };
			            
            parameters[0].Value = model.ResumeID;                        
            parameters[1].Value = model.ResumeNo;                        
            parameters[2].Value = model.ResumeName;                        
            parameters[3].Value = model.Status;                        
            parameters[4].Value = model.CreateUser;                        
            parameters[5].Value = model.CreateDate;                        
            parameters[6].Value = model.ParentID;                        
            parameters[7].Value = model.RealName;                        
            parameters[8].Value = model.Sex;                        
            parameters[9].Value = model.Birthday;                        
            parameters[10].Value = model.Marriage;                        
            parameters[11].Value = model.BeginJobYear;                        
            parameters[12].Value = model.Mobile;                        
            parameters[13].Value = model.Email;                        
            parameters[14].Value = model.XueLi;                        
            parameters[15].Value = model.School;                        
            parameters[16].Value = model.Major;                        
            parameters[17].Value = model.Company;                        
            parameters[18].Value = model.Skill;                        
            parameters[19].Value = model.CoreSkill;                        
            parameters[20].Value = model.HopeAddress;                        
            parameters[21].Value = model.HopePosition;                        
            parameters[22].Value = model.HopeIndustry;                        
            parameters[23].Value = model.HopeSalary;                        
            parameters[24].Value = model.AppID;                        
            parameters[25].Value = model.Version;                        
            parameters[26].Value = model.RandomNo;                        
            parameters[27].Value = model.Remark;                        
            parameters[28].Value = model.LableText;                        
            parameters[29].Value = model.ExJson;                        
            parameters[30].Value = model.OrderNo;                        
            parameters[31].Value = model.ModifyDate;                        
            parameters[32].Value = model.ModifyUser;                        
			   
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
		public bool Update(tabResumeOutlineModel model)
		{
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabResumeOutline set ");
			                                                
            strSql.Append(" ResumeID = @ResumeID , ");                                    
            strSql.Append(" ResumeNo = @ResumeNo , ");                                    
            strSql.Append(" ResumeName = @ResumeName , ");                                    
            strSql.Append(" Status = @Status , ");                                    
            strSql.Append(" CreateUser = @CreateUser , ");                                    
            strSql.Append(" CreateDate = @CreateDate , ");                                    
            strSql.Append(" ParentID = @ParentID , ");                                    
            strSql.Append(" RealName = @RealName , ");                                    
            strSql.Append(" Sex = @Sex , ");                                    
            strSql.Append(" Birthday = @Birthday , ");                                    
            strSql.Append(" Marriage = @Marriage , ");                                    
            strSql.Append(" BeginJobYear = @BeginJobYear , ");                                    
            strSql.Append(" Mobile = @Mobile , ");                                    
            strSql.Append(" Email = @Email , ");                                    
            strSql.Append(" XueLi = @XueLi , ");                                    
            strSql.Append(" School = @School , ");                                    
            strSql.Append(" Major = @Major , ");                                    
            strSql.Append(" Company = @Company , ");                                    
            strSql.Append(" Skill = @Skill , ");                                    
            strSql.Append(" CoreSkill = @CoreSkill , ");                                    
            strSql.Append(" HopeAddress = @HopeAddress , ");                                    
            strSql.Append(" HopePosition = @HopePosition , ");                                    
            strSql.Append(" HopeIndustry = @HopeIndustry , ");                                    
            strSql.Append(" HopeSalary = @HopeSalary , ");                                    
            strSql.Append(" AppID = @AppID , ");                                    
            strSql.Append(" Version = @Version , ");                                    
            strSql.Append(" RandomNo = @RandomNo , ");                                    
            strSql.Append(" Remark = @Remark , ");                                    
            strSql.Append(" LableText = @LableText , ");                                    
            strSql.Append(" ExJson = @ExJson , ");                                    
            strSql.Append(" OrderNo = @OrderNo , ");                                    
            strSql.Append(" ModifyDate = @ModifyDate , ");                                    
            strSql.Append(" ModifyUser = @ModifyUser  ");            			
			strSql.Append(" where id=@id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@id", SqlDbType.Int,4) ,            
                        new SqlParameter("@ResumeID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ResumeNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ResumeName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Status", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@CreateUser", SqlDbType.Int,4) ,            
                        new SqlParameter("@CreateDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("@RealName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Sex", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Birthday", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Marriage", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@BeginJobYear", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Mobile", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Email", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@XueLi", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@School", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@Major", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@Company", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@Skill", SqlDbType.NText) ,            
                        new SqlParameter("@CoreSkill", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@HopeAddress", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@HopePosition", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@HopeIndustry", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@HopeSalary", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@AppID", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@Version", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@RandomNo", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@Remark", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@LableText", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@ExJson", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@OrderNo", SqlDbType.Int,4) ,            
                        new SqlParameter("@ModifyDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ModifyUser", SqlDbType.Int,4)             
              
            };
						            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.ResumeID;                        
            parameters[2].Value = model.ResumeNo;                        
            parameters[3].Value = model.ResumeName;                        
            parameters[4].Value = model.Status;                        
            parameters[5].Value = model.CreateUser;                        
            parameters[6].Value = model.CreateDate;                        
            parameters[7].Value = model.ParentID;                        
            parameters[8].Value = model.RealName;                        
            parameters[9].Value = model.Sex;                        
            parameters[10].Value = model.Birthday;                        
            parameters[11].Value = model.Marriage;                        
            parameters[12].Value = model.BeginJobYear;                        
            parameters[13].Value = model.Mobile;                        
            parameters[14].Value = model.Email;                        
            parameters[15].Value = model.XueLi;                        
            parameters[16].Value = model.School;                        
            parameters[17].Value = model.Major;                        
            parameters[18].Value = model.Company;                        
            parameters[19].Value = model.Skill;                        
            parameters[20].Value = model.CoreSkill;                        
            parameters[21].Value = model.HopeAddress;                        
            parameters[22].Value = model.HopePosition;                        
            parameters[23].Value = model.HopeIndustry;                        
            parameters[24].Value = model.HopeSalary;                        
            parameters[25].Value = model.AppID;                        
            parameters[26].Value = model.Version;                        
            parameters[27].Value = model.RandomNo;                        
            parameters[28].Value = model.Remark;                        
            parameters[29].Value = model.LableText;                        
            parameters[30].Value = model.ExJson;                        
            parameters[31].Value = model.OrderNo;                        
            parameters[32].Value = model.ModifyDate;                        
            parameters[33].Value = model.ModifyUser;                        
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
			strSql.Append("update tabResumeOutline set " + strValue);           
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(tabResumeOutlineModel model, List<string> ChangedFields)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabResumeOutline set ");
			                                                
            strSql.Append(" ResumeID = @ResumeID , ");                                    
            strSql.Append(" ResumeNo = @ResumeNo , ");                                    
            strSql.Append(" ResumeName = @ResumeName , ");                                    
            strSql.Append(" Status = @Status , ");                                    
            strSql.Append(" CreateUser = @CreateUser , ");                                    
            strSql.Append(" CreateDate = @CreateDate , ");                                    
            strSql.Append(" ParentID = @ParentID , ");                                    
            strSql.Append(" RealName = @RealName , ");                                    
            strSql.Append(" Sex = @Sex , ");                                    
            strSql.Append(" Birthday = @Birthday , ");                                    
            strSql.Append(" Marriage = @Marriage , ");                                    
            strSql.Append(" BeginJobYear = @BeginJobYear , ");                                    
            strSql.Append(" Mobile = @Mobile , ");                                    
            strSql.Append(" Email = @Email , ");                                    
            strSql.Append(" XueLi = @XueLi , ");                                    
            strSql.Append(" School = @School , ");                                    
            strSql.Append(" Major = @Major , ");                                    
            strSql.Append(" Company = @Company , ");                                    
            strSql.Append(" Skill = @Skill , ");                                    
            strSql.Append(" CoreSkill = @CoreSkill , ");                                    
            strSql.Append(" HopeAddress = @HopeAddress , ");                                    
            strSql.Append(" HopePosition = @HopePosition , ");                                    
            strSql.Append(" HopeIndustry = @HopeIndustry , ");                                    
            strSql.Append(" HopeSalary = @HopeSalary , ");                                    
            strSql.Append(" AppID = @AppID , ");                                    
            strSql.Append(" Version = @Version , ");                                    
            strSql.Append(" RandomNo = @RandomNo , ");                                    
            strSql.Append(" Remark = @Remark , ");                                    
            strSql.Append(" LableText = @LableText , ");                                    
            strSql.Append(" ExJson = @ExJson , ");                                    
            strSql.Append(" OrderNo = @OrderNo , ");                                    
            strSql.Append(" ModifyDate = @ModifyDate , ");                                    
            strSql.Append(" ModifyUser = @ModifyUser  ");            			
			strSql.Append(" where id=@id ");						
SqlParameter[] parameters = {
			            new SqlParameter("@id", SqlDbType.Int,4) ,            
                        new SqlParameter("@ResumeID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ResumeNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ResumeName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Status", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@CreateUser", SqlDbType.Int,4) ,            
                        new SqlParameter("@CreateDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("@RealName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Sex", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Birthday", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Marriage", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@BeginJobYear", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Mobile", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Email", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@XueLi", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@School", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@Major", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@Company", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@Skill", SqlDbType.NText) ,            
                        new SqlParameter("@CoreSkill", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@HopeAddress", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@HopePosition", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@HopeIndustry", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@HopeSalary", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@AppID", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@Version", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@RandomNo", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@Remark", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@LableText", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@ExJson", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@OrderNo", SqlDbType.Int,4) ,            
                        new SqlParameter("@ModifyDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ModifyUser", SqlDbType.Int,4)             
              
            };
						            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.ResumeID;                        
            parameters[2].Value = model.ResumeNo;                        
            parameters[3].Value = model.ResumeName;                        
            parameters[4].Value = model.Status;                        
            parameters[5].Value = model.CreateUser;                        
            parameters[6].Value = model.CreateDate;                        
            parameters[7].Value = model.ParentID;                        
            parameters[8].Value = model.RealName;                        
            parameters[9].Value = model.Sex;                        
            parameters[10].Value = model.Birthday;                        
            parameters[11].Value = model.Marriage;                        
            parameters[12].Value = model.BeginJobYear;                        
            parameters[13].Value = model.Mobile;                        
            parameters[14].Value = model.Email;                        
            parameters[15].Value = model.XueLi;                        
            parameters[16].Value = model.School;                        
            parameters[17].Value = model.Major;                        
            parameters[18].Value = model.Company;                        
            parameters[19].Value = model.Skill;                        
            parameters[20].Value = model.CoreSkill;                        
            parameters[21].Value = model.HopeAddress;                        
            parameters[22].Value = model.HopePosition;                        
            parameters[23].Value = model.HopeIndustry;                        
            parameters[24].Value = model.HopeSalary;                        
            parameters[25].Value = model.AppID;                        
            parameters[26].Value = model.Version;                        
            parameters[27].Value = model.RandomNo;                        
            parameters[28].Value = model.Remark;                        
            parameters[29].Value = model.LableText;                        
            parameters[30].Value = model.ExJson;                        
            parameters[31].Value = model.OrderNo;                        
            parameters[32].Value = model.ModifyDate;                        
            parameters[33].Value = model.ModifyUser;                        
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
			strSql.Append("delete from tabResumeOutline ");
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
			strSql.Append("delete from tabResumeOutline ");
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
		public tabResumeOutlineModel GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");			
			strSql.Append("  from tabResumeOutline ");
			strSql.Append(" where id=@id");
						SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			
			tabResumeOutlineModel model=new tabResumeOutlineModel();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabResumeOutlineModel>.FillModel(ds.Tables[0].Rows[0]);
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
			strSql.Append(" FROM tabResumeOutline ");
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
			strSql.Append(" FROM tabResumeOutline ");
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
			strSql.Append(" FROM tabResumeOutline ");
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
			strSql.Append(" FROM tabResumeOutline as a  where  version=(select max(b.version)  from tabResumeOutline  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabResumeOutline as a  where  version=(select max(b.version)  from tabResumeOutline  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabResumeOutline as a  where  version=(select max(b.version)  from tabResumeOutline  as b  where a.RandomNo =  b.RandomNo)");
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
	/// tabResumeOutline
    /// </summary> 	
	public partial class tabResumeOutlineBLL
	{
        private readonly tabResumeOutlineSQLDAL dal=new tabResumeOutlineSQLDAL();
		public void tabResumeOutline()
		{
		}
		public static tabResumeOutlineBLL Instance
        {
            get
            {
                return _Instance;
            }
            set { _Instance = value; }
        }private static tabResumeOutlineBLL _Instance;
        public static tabResumeOutlineBLL GetInstance()
        {
            if (Instance == null)
            {
                Instance = new tabResumeOutlineBLL();
            }
            return Instance;
        }
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(tabResumeOutlineModel model)
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
		public bool Update(tabResumeOutlineModel model)
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
		public tabResumeOutlineModel GetModel(int id)
		{
			
			return dal.GetModel(id);
		}	
		/// <summary>
		/// 得到对象列表中第一个对象实体
		/// </summary>
		public tabResumeOutlineModel GetModel(string _where,int Index)
		{
			List<tabResumeOutlineModel> lsmodel = GetModelList(_where);
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
        public List<tabResumeOutlineModel> GetModelList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            DataSet ds = dal.GetList(pageSize, pageIndex, strWhere, filedOrder, out recordCount);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabResumeOutlineModel>.FillModel(ds.Tables[0]);
            else
                return new List<tabResumeOutlineModel>();
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
		public List<tabResumeOutlineModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabResumeOutlineModel>.FillModel(ds.Tables[0]);
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
		public List<tabResumeOutlineModel> GetModelListVersion(string strWhere)
		{
			DataSet ds = dal.GetListVersion(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabResumeOutlineModel>.FillModel(ds.Tables[0]);
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
