
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
#region  Model 实体类- tabCVJDMatch
namespace Tclywork.Model{
	[Serializable]
	/// <summary>
	/// tabCVJDMatch
    /// </summary> 	
	public partial class tabCVJDMatchModel
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
			/// 匹配基准：Resume；Position
	        /// </summary>
	        
	        public string BaseOn
	        {
	            get{ return _BaseOn; }
	            set{ _BaseOn = value;}
	        }private string _BaseOn;
				        
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
	        
	        public int ResumeNo
	        {
	            get{ return _ResumeNo; }
	            set{ _ResumeNo = value;}
	        }private int _ResumeNo;
				        
							/// <summary>
			/// PositionID
	        /// </summary>
	        
	        public int PositionID
	        {
	            get{ return _PositionID; }
	            set{ _PositionID = value;}
	        }private int _PositionID;
				        
							/// <summary>
			/// 创建时间
	        /// </summary>
	        
	        public string CreateDate
	        {
	            get{ return _CreateDate; }
	            set{ _CreateDate = value;}
	        }private string _CreateDate;
				        
							/// <summary>
			/// 匹配分值：0-100
	        /// </summary>
	        
	        public int WordAddress
	        {
	            get{ return _WordAddress; }
	            set{ _WordAddress = value;}
	        }private int _WordAddress;
				        
							/// <summary>
			/// 匹配分值：0-100
	        /// </summary>
	        
	        public int Age
	        {
	            get{ return _Age; }
	            set{ _Age = value;}
	        }private int _Age;
				        
							/// <summary>
			/// 匹配分值：0-100
	        /// </summary>
	        
	        public int WorkYear
	        {
	            get{ return _WorkYear; }
	            set{ _WorkYear = value;}
	        }private int _WorkYear;
				        
							/// <summary>
			/// 匹配分值：0-100
	        /// </summary>
	        
	        public int Salary
	        {
	            get{ return _Salary; }
	            set{ _Salary = value;}
	        }private int _Salary;
				        
							/// <summary>
			/// 匹配分值：0-100
	        /// </summary>
	        
	        public int XueLi
	        {
	            get{ return _XueLi; }
	            set{ _XueLi = value;}
	        }private int _XueLi;
				        
							/// <summary>
			/// 匹配分值：0-100
	        /// </summary>
	        
	        public int Skill
	        {
	            get{ return _Skill; }
	            set{ _Skill = value;}
	        }private int _Skill;
				        
							/// <summary>
			/// 匹配分值：0-100
	        /// </summary>
	        
	        public int CoreSkill
	        {
	            get{ return _CoreSkill; }
	            set{ _CoreSkill = value;}
	        }private int _CoreSkill;
				        
							/// <summary>
			/// 匹配分值：0-100
	        /// </summary>
	        
	        public int Major
	        {
	            get{ return _Major; }
	            set{ _Major = value;}
	        }private int _Major;
				        
							/// <summary>
			/// 匹配分值：0-100
	        /// </summary>
	        
	        public int OrgScale
	        {
	            get{ return _OrgScale; }
	            set{ _OrgScale = value;}
	        }private int _OrgScale;
				        
							/// <summary>
			/// 综合匹配分值：0-
	        /// </summary>
	        
	        public int MatchDegree
	        {
	            get{ return _MatchDegree; }
	            set{ _MatchDegree = value;}
	        }private int _MatchDegree;
				        
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
			/// 消费此积分的消费记录ID,如购买简历的积分，购买保面试的积分。
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
	/// tabCVJDMatch
    /// </summary> 	
	public partial class tabCVJDMatchSQLDAL
	{
		#region 实现方法
   		 /// <summary>
		/// 是否存在
		/// </summary>    
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tabCVJDMatch");
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
		public int Add(tabCVJDMatchModel model)
		{
		 	model.Version = model.Version.IsNotNullOrEmpty()? model.Version: "1";
            model.RandomNo = model.RandomNo.IsNotNullOrEmpty()? model.RandomNo: Guid.NewGuid().ToString("N");
            model.Status = model.Status.IsNotNullOrEmpty()? model.Status: "1";
            model.OrderNo = model.OrderNo>0? model.OrderNo: 1;
			model.CreateDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tabCVJDMatch(");			
            strSql.Append("BaseOn,ResumeID,ResumeNo,PositionID,CreateDate,WordAddress,Age,WorkYear,Salary,XueLi,Skill,CoreSkill,Major,OrgScale,MatchDegree,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,ModifyDate,CreateUser,ModifyUser");
			strSql.Append(") values (");
            strSql.Append("@BaseOn,@ResumeID,@ResumeNo,@PositionID,@CreateDate,@WordAddress,@Age,@WorkYear,@Salary,@XueLi,@Skill,@CoreSkill,@Major,@OrgScale,@MatchDegree,@AppID,@Version,@RandomNo,@ParentID,@Remark,@LableText,@ExJson,@Status,@OrderNo,@ModifyDate,@CreateUser,@ModifyUser");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@BaseOn", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ResumeID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ResumeNo", SqlDbType.Int,4) ,            
                        new SqlParameter("@PositionID", SqlDbType.Int,4) ,            
                        new SqlParameter("@CreateDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@WordAddress", SqlDbType.Int,4) ,            
                        new SqlParameter("@Age", SqlDbType.Int,4) ,            
                        new SqlParameter("@WorkYear", SqlDbType.Int,4) ,            
                        new SqlParameter("@Salary", SqlDbType.Int,4) ,            
                        new SqlParameter("@XueLi", SqlDbType.Int,4) ,            
                        new SqlParameter("@Skill", SqlDbType.Int,4) ,            
                        new SqlParameter("@CoreSkill", SqlDbType.Int,4) ,            
                        new SqlParameter("@Major", SqlDbType.Int,4) ,            
                        new SqlParameter("@OrgScale", SqlDbType.Int,4) ,            
                        new SqlParameter("@MatchDegree", SqlDbType.Int,4) ,            
                        new SqlParameter("@AppID", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@Version", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@RandomNo", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Remark", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@LableText", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@ExJson", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@Status", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@OrderNo", SqlDbType.Int,4) ,            
                        new SqlParameter("@ModifyDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@CreateUser", SqlDbType.Int,4) ,            
                        new SqlParameter("@ModifyUser", SqlDbType.Int,4)             
              
            };
			            
            parameters[0].Value = model.BaseOn;                        
            parameters[1].Value = model.ResumeID;                        
            parameters[2].Value = model.ResumeNo;                        
            parameters[3].Value = model.PositionID;                        
            parameters[4].Value = model.CreateDate;                        
            parameters[5].Value = model.WordAddress;                        
            parameters[6].Value = model.Age;                        
            parameters[7].Value = model.WorkYear;                        
            parameters[8].Value = model.Salary;                        
            parameters[9].Value = model.XueLi;                        
            parameters[10].Value = model.Skill;                        
            parameters[11].Value = model.CoreSkill;                        
            parameters[12].Value = model.Major;                        
            parameters[13].Value = model.OrgScale;                        
            parameters[14].Value = model.MatchDegree;                        
            parameters[15].Value = model.AppID;                        
            parameters[16].Value = model.Version;                        
            parameters[17].Value = model.RandomNo;                        
            parameters[18].Value = model.ParentID;                        
            parameters[19].Value = model.Remark;                        
            parameters[20].Value = model.LableText;                        
            parameters[21].Value = model.ExJson;                        
            parameters[22].Value = model.Status;                        
            parameters[23].Value = model.OrderNo;                        
            parameters[24].Value = model.ModifyDate;                        
            parameters[25].Value = model.CreateUser;                        
            parameters[26].Value = model.ModifyUser;                        
			   
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
		public bool Update(tabCVJDMatchModel model)
		{
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabCVJDMatch set ");
			                                                
            strSql.Append(" BaseOn = @BaseOn , ");                                    
            strSql.Append(" ResumeID = @ResumeID , ");                                    
            strSql.Append(" ResumeNo = @ResumeNo , ");                                    
            strSql.Append(" PositionID = @PositionID , ");                                    
            strSql.Append(" CreateDate = @CreateDate , ");                                    
            strSql.Append(" WordAddress = @WordAddress , ");                                    
            strSql.Append(" Age = @Age , ");                                    
            strSql.Append(" WorkYear = @WorkYear , ");                                    
            strSql.Append(" Salary = @Salary , ");                                    
            strSql.Append(" XueLi = @XueLi , ");                                    
            strSql.Append(" Skill = @Skill , ");                                    
            strSql.Append(" CoreSkill = @CoreSkill , ");                                    
            strSql.Append(" Major = @Major , ");                                    
            strSql.Append(" OrgScale = @OrgScale , ");                                    
            strSql.Append(" MatchDegree = @MatchDegree , ");                                    
            strSql.Append(" AppID = @AppID , ");                                    
            strSql.Append(" Version = @Version , ");                                    
            strSql.Append(" RandomNo = @RandomNo , ");                                    
            strSql.Append(" ParentID = @ParentID , ");                                    
            strSql.Append(" Remark = @Remark , ");                                    
            strSql.Append(" LableText = @LableText , ");                                    
            strSql.Append(" ExJson = @ExJson , ");                                    
            strSql.Append(" Status = @Status , ");                                    
            strSql.Append(" OrderNo = @OrderNo , ");                                    
            strSql.Append(" ModifyDate = @ModifyDate , ");                                    
            strSql.Append(" CreateUser = @CreateUser , ");                                    
            strSql.Append(" ModifyUser = @ModifyUser  ");            			
			strSql.Append(" where id=@id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@id", SqlDbType.Int,4) ,            
                        new SqlParameter("@BaseOn", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ResumeID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ResumeNo", SqlDbType.Int,4) ,            
                        new SqlParameter("@PositionID", SqlDbType.Int,4) ,            
                        new SqlParameter("@CreateDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@WordAddress", SqlDbType.Int,4) ,            
                        new SqlParameter("@Age", SqlDbType.Int,4) ,            
                        new SqlParameter("@WorkYear", SqlDbType.Int,4) ,            
                        new SqlParameter("@Salary", SqlDbType.Int,4) ,            
                        new SqlParameter("@XueLi", SqlDbType.Int,4) ,            
                        new SqlParameter("@Skill", SqlDbType.Int,4) ,            
                        new SqlParameter("@CoreSkill", SqlDbType.Int,4) ,            
                        new SqlParameter("@Major", SqlDbType.Int,4) ,            
                        new SqlParameter("@OrgScale", SqlDbType.Int,4) ,            
                        new SqlParameter("@MatchDegree", SqlDbType.Int,4) ,            
                        new SqlParameter("@AppID", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@Version", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@RandomNo", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Remark", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@LableText", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@ExJson", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@Status", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@OrderNo", SqlDbType.Int,4) ,            
                        new SqlParameter("@ModifyDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@CreateUser", SqlDbType.Int,4) ,            
                        new SqlParameter("@ModifyUser", SqlDbType.Int,4)             
              
            };
						            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.BaseOn;                        
            parameters[2].Value = model.ResumeID;                        
            parameters[3].Value = model.ResumeNo;                        
            parameters[4].Value = model.PositionID;                        
            parameters[5].Value = model.CreateDate;                        
            parameters[6].Value = model.WordAddress;                        
            parameters[7].Value = model.Age;                        
            parameters[8].Value = model.WorkYear;                        
            parameters[9].Value = model.Salary;                        
            parameters[10].Value = model.XueLi;                        
            parameters[11].Value = model.Skill;                        
            parameters[12].Value = model.CoreSkill;                        
            parameters[13].Value = model.Major;                        
            parameters[14].Value = model.OrgScale;                        
            parameters[15].Value = model.MatchDegree;                        
            parameters[16].Value = model.AppID;                        
            parameters[17].Value = model.Version;                        
            parameters[18].Value = model.RandomNo;                        
            parameters[19].Value = model.ParentID;                        
            parameters[20].Value = model.Remark;                        
            parameters[21].Value = model.LableText;                        
            parameters[22].Value = model.ExJson;                        
            parameters[23].Value = model.Status;                        
            parameters[24].Value = model.OrderNo;                        
            parameters[25].Value = model.ModifyDate;                        
            parameters[26].Value = model.CreateUser;                        
            parameters[27].Value = model.ModifyUser;                        
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
			strSql.Append("update tabCVJDMatch set " + strValue);           
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(tabCVJDMatchModel model, List<string> ChangedFields)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabCVJDMatch set ");
			                                                
            strSql.Append(" BaseOn = @BaseOn , ");                                    
            strSql.Append(" ResumeID = @ResumeID , ");                                    
            strSql.Append(" ResumeNo = @ResumeNo , ");                                    
            strSql.Append(" PositionID = @PositionID , ");                                    
            strSql.Append(" CreateDate = @CreateDate , ");                                    
            strSql.Append(" WordAddress = @WordAddress , ");                                    
            strSql.Append(" Age = @Age , ");                                    
            strSql.Append(" WorkYear = @WorkYear , ");                                    
            strSql.Append(" Salary = @Salary , ");                                    
            strSql.Append(" XueLi = @XueLi , ");                                    
            strSql.Append(" Skill = @Skill , ");                                    
            strSql.Append(" CoreSkill = @CoreSkill , ");                                    
            strSql.Append(" Major = @Major , ");                                    
            strSql.Append(" OrgScale = @OrgScale , ");                                    
            strSql.Append(" MatchDegree = @MatchDegree , ");                                    
            strSql.Append(" AppID = @AppID , ");                                    
            strSql.Append(" Version = @Version , ");                                    
            strSql.Append(" RandomNo = @RandomNo , ");                                    
            strSql.Append(" ParentID = @ParentID , ");                                    
            strSql.Append(" Remark = @Remark , ");                                    
            strSql.Append(" LableText = @LableText , ");                                    
            strSql.Append(" ExJson = @ExJson , ");                                    
            strSql.Append(" Status = @Status , ");                                    
            strSql.Append(" OrderNo = @OrderNo , ");                                    
            strSql.Append(" ModifyDate = @ModifyDate , ");                                    
            strSql.Append(" CreateUser = @CreateUser , ");                                    
            strSql.Append(" ModifyUser = @ModifyUser  ");            			
			strSql.Append(" where id=@id ");						
SqlParameter[] parameters = {
			            new SqlParameter("@id", SqlDbType.Int,4) ,            
                        new SqlParameter("@BaseOn", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ResumeID", SqlDbType.Int,4) ,            
                        new SqlParameter("@ResumeNo", SqlDbType.Int,4) ,            
                        new SqlParameter("@PositionID", SqlDbType.Int,4) ,            
                        new SqlParameter("@CreateDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@WordAddress", SqlDbType.Int,4) ,            
                        new SqlParameter("@Age", SqlDbType.Int,4) ,            
                        new SqlParameter("@WorkYear", SqlDbType.Int,4) ,            
                        new SqlParameter("@Salary", SqlDbType.Int,4) ,            
                        new SqlParameter("@XueLi", SqlDbType.Int,4) ,            
                        new SqlParameter("@Skill", SqlDbType.Int,4) ,            
                        new SqlParameter("@CoreSkill", SqlDbType.Int,4) ,            
                        new SqlParameter("@Major", SqlDbType.Int,4) ,            
                        new SqlParameter("@OrgScale", SqlDbType.Int,4) ,            
                        new SqlParameter("@MatchDegree", SqlDbType.Int,4) ,            
                        new SqlParameter("@AppID", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@Version", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@RandomNo", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("@Remark", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@LableText", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@ExJson", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@Status", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@OrderNo", SqlDbType.Int,4) ,            
                        new SqlParameter("@ModifyDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@CreateUser", SqlDbType.Int,4) ,            
                        new SqlParameter("@ModifyUser", SqlDbType.Int,4)             
              
            };
						            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.BaseOn;                        
            parameters[2].Value = model.ResumeID;                        
            parameters[3].Value = model.ResumeNo;                        
            parameters[4].Value = model.PositionID;                        
            parameters[5].Value = model.CreateDate;                        
            parameters[6].Value = model.WordAddress;                        
            parameters[7].Value = model.Age;                        
            parameters[8].Value = model.WorkYear;                        
            parameters[9].Value = model.Salary;                        
            parameters[10].Value = model.XueLi;                        
            parameters[11].Value = model.Skill;                        
            parameters[12].Value = model.CoreSkill;                        
            parameters[13].Value = model.Major;                        
            parameters[14].Value = model.OrgScale;                        
            parameters[15].Value = model.MatchDegree;                        
            parameters[16].Value = model.AppID;                        
            parameters[17].Value = model.Version;                        
            parameters[18].Value = model.RandomNo;                        
            parameters[19].Value = model.ParentID;                        
            parameters[20].Value = model.Remark;                        
            parameters[21].Value = model.LableText;                        
            parameters[22].Value = model.ExJson;                        
            parameters[23].Value = model.Status;                        
            parameters[24].Value = model.OrderNo;                        
            parameters[25].Value = model.ModifyDate;                        
            parameters[26].Value = model.CreateUser;                        
            parameters[27].Value = model.ModifyUser;                        
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
			strSql.Append("delete from tabCVJDMatch ");
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
			strSql.Append("delete from tabCVJDMatch ");
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
		public tabCVJDMatchModel GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");			
			strSql.Append("  from tabCVJDMatch ");
			strSql.Append(" where id=@id");
						SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			
			tabCVJDMatchModel model=new tabCVJDMatchModel();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabCVJDMatchModel>.FillModel(ds.Tables[0].Rows[0]);
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
			strSql.Append(" FROM tabCVJDMatch ");
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
			strSql.Append(" FROM tabCVJDMatch ");
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
			strSql.Append(" FROM tabCVJDMatch ");
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
			strSql.Append(" FROM tabCVJDMatch as a  where  version=(select max(b.version)  from tabCVJDMatch  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabCVJDMatch as a  where  version=(select max(b.version)  from tabCVJDMatch  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabCVJDMatch as a  where  version=(select max(b.version)  from tabCVJDMatch  as b  where a.RandomNo =  b.RandomNo)");
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
	/// tabCVJDMatch
    /// </summary> 	
	public partial class tabCVJDMatchBLL
	{
        private readonly tabCVJDMatchSQLDAL dal=new tabCVJDMatchSQLDAL();
		public void tabCVJDMatch()
		{
		}
		public static tabCVJDMatchBLL Instance
        {
            get
            {
                return _Instance;
            }
            set { _Instance = value; }
        }private static tabCVJDMatchBLL _Instance;
        public static tabCVJDMatchBLL GetInstance()
        {
            if (Instance == null)
            {
                Instance = new tabCVJDMatchBLL();
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
		public int  Add(tabCVJDMatchModel model)
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
		public bool Update(tabCVJDMatchModel model)
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
		public tabCVJDMatchModel GetModel(int id)
		{
			
			return dal.GetModel(id);
		}	
		/// <summary>
		/// 得到对象列表中第一个对象实体
		/// </summary>
		public tabCVJDMatchModel GetModel(string _where,int Index)
		{
			List<tabCVJDMatchModel> lsmodel = GetModelList(_where);
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
        public List<tabCVJDMatchModel> GetModelList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            DataSet ds = dal.GetList(pageSize, pageIndex, strWhere, filedOrder, out recordCount);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabCVJDMatchModel>.FillModel(ds.Tables[0]);
            else
                return new List<tabCVJDMatchModel>();
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
		public List<tabCVJDMatchModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabCVJDMatchModel>.FillModel(ds.Tables[0]);
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
		public List<tabCVJDMatchModel> GetModelListVersion(string strWhere)
		{
			DataSet ds = dal.GetListVersion(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabCVJDMatchModel>.FillModel(ds.Tables[0]);
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
