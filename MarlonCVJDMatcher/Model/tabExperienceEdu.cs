
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
#region  Model 实体类- tabExperienceEdu
namespace Tclywork.Model{
	[Serializable]
	/// <summary>
	/// 教育经历表
    /// </summary> 	
	public partial class tabExperienceEduModel
	{   		     
      								/// <summary>
			/// 学校名称
	        /// </summary>
	        
	        public string SchoolName
	        {
	            get{ return _SchoolName; }
	            set{ _SchoolName = value;}
	        }private string _SchoolName;
				        
							/// <summary>
			/// 专业名称
	        /// </summary>
	        
	        public string ProfessionalName
	        {
	            get{ return _ProfessionalName; }
	            set{ _ProfessionalName = value;}
	        }private string _ProfessionalName;
				        
							/// <summary>
			/// EduBeginDate
	        /// </summary>
	        
	        public string EduBeginDate
	        {
	            get{ return _EduBeginDate; }
	            set{ _EduBeginDate = value;}
	        }private string _EduBeginDate;
				        
							/// <summary>
			/// EduEndDate
	        /// </summary>
	        
	        public string EduEndDate
	        {
	            get{ return _EduEndDate; }
	            set{ _EduEndDate = value;}
	        }private string _EduEndDate;
				        
							/// <summary>
			/// 学历
	        /// </summary>
	        
	        public int GetEdu
	        {
	            get{ return _GetEdu; }
	            set{ _GetEdu = value;}
	        }private int _GetEdu;
				        
							/// <summary>
			/// 是否统招
	        /// </summary>
	        
	        public bool IsTZ
	        {
	            get{ return _IsTZ; }
	            set{ _IsTZ = value;}
	        }private bool _IsTZ;
				        
							/// <summary>
			/// Is211
	        /// </summary>
	        
	        public bool Is211
	        {
	            get{ return _Is211; }
	            set{ _Is211 = value;}
	        }private bool _Is211;
				        
							/// <summary>
			/// 是否第三方认证
	        /// </summary>
	        
	        public bool IsVal
	        {
	            get{ return _IsVal; }
	            set{ _IsVal = value;}
	        }private bool _IsVal;
				        
							/// <summary>
			/// 更多信息
	        /// </summary>
	        
	        public string AddonInfo
	        {
	            get{ return _AddonInfo; }
	            set{ _AddonInfo = value;}
	        }private string _AddonInfo;
				        
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
			/// 简历编号
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
	/// 教育经历表
    /// </summary> 	
	public partial class tabExperienceEduSQLDAL
	{
		#region 实现方法
   		 /// <summary>
		/// 是否存在
		/// </summary>    
		public bool Exists(string SchoolName,string ProfessionalName,string EduBeginDate,int GetEdu,int id,int ParentID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tabExperienceEdu");
			strSql.Append(" where ");
			                        strSql.Append(" SchoolName = SQL2012SchoolName and  ");
                                                    strSql.Append(" ProfessionalName = SQL2012ProfessionalName and  ");
                                                    strSql.Append(" EduBeginDate = SQL2012EduBeginDate and  ");
                                                    strSql.Append(" GetEdu = SQL2012GetEdu and  ");
                                                    strSql.Append(" id = SQL2012id and  ");
                                                    strSql.Append(" ParentID = SQL2012ParentID  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("SQL2012SchoolName", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012ProfessionalName", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012EduBeginDate", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012GetEdu", SqlDbType.Int,4),
					new SqlParameter("SQL2012id", SqlDbType.Int,4),
					new SqlParameter("SQL2012ParentID", SqlDbType.Int,4)			};
			parameters[0].Value = SchoolName;
			parameters[1].Value = ProfessionalName;
			parameters[2].Value = EduBeginDate;
			parameters[3].Value = GetEdu;
			parameters[4].Value = id;
			parameters[5].Value = ParentID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(tabExperienceEduModel model)
		{
		 	model.Version = model.Version.IsNotNullOrEmpty()? model.Version: "1";
            model.RandomNo = model.RandomNo.IsNotNullOrEmpty()? model.RandomNo: Guid.NewGuid().ToString("N");
            model.Status = model.Status.IsNotNullOrEmpty()? model.Status: "1";
            model.OrderNo = model.OrderNo>0? model.OrderNo: 1;
			model.CreateDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tabExperienceEdu(");			
            strSql.Append("SchoolName,ProfessionalName,EduBeginDate,EduEndDate,GetEdu,IsTZ,Is211,IsVal,AddonInfo,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
			strSql.Append(") values (");
            strSql.Append("SQL2012SchoolName,SQL2012ProfessionalName,SQL2012EduBeginDate,SQL2012EduEndDate,SQL2012GetEdu,SQL2012IsTZ,SQL2012Is211,SQL2012IsVal,SQL2012AddonInfo,SQL2012AppID,SQL2012Version,SQL2012RandomNo,SQL2012ParentID,SQL2012Remark,SQL2012LableText,SQL2012ExJson,SQL2012Status,SQL2012OrderNo,SQL2012CreateDate,SQL2012ModifyDate,SQL2012CreateUser,SQL2012ModifyUser");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("SQL2012SchoolName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012ProfessionalName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012EduBeginDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012EduEndDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012GetEdu", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012IsTZ", SqlDbType.Bit,1) ,            
                        new SqlParameter("SQL2012Is211", SqlDbType.Bit,1) ,            
                        new SqlParameter("SQL2012IsVal", SqlDbType.Bit,1) ,            
                        new SqlParameter("SQL2012AddonInfo", SqlDbType.NVarChar,-1) ,            
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
		public bool Update(tabExperienceEduModel model)
		{
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabExperienceEdu set ");
			                        
            strSql.Append(" SchoolName = SQL2012SchoolName , ");                                    
            strSql.Append(" ProfessionalName = SQL2012ProfessionalName , ");                                    
            strSql.Append(" EduBeginDate = SQL2012EduBeginDate , ");                                    
            strSql.Append(" EduEndDate = SQL2012EduEndDate , ");                                    
            strSql.Append(" GetEdu = SQL2012GetEdu , ");                                    
            strSql.Append(" IsTZ = SQL2012IsTZ , ");                                    
            strSql.Append(" Is211 = SQL2012Is211 , ");                                    
            strSql.Append(" IsVal = SQL2012IsVal , ");                                    
            strSql.Append(" AddonInfo = SQL2012AddonInfo , ");                                                            
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
			            new SqlParameter("SQL2012SchoolName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012ProfessionalName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012EduBeginDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012EduEndDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012GetEdu", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012IsTZ", SqlDbType.Bit,1) ,            
                        new SqlParameter("SQL2012Is211", SqlDbType.Bit,1) ,            
                        new SqlParameter("SQL2012IsVal", SqlDbType.Bit,1) ,            
                        new SqlParameter("SQL2012AddonInfo", SqlDbType.NVarChar,-1) ,            
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
						            
            parameters[0].Value = model.SchoolName;                        
            parameters[1].Value = model.ProfessionalName;                        
            parameters[2].Value = model.EduBeginDate;                        
            parameters[3].Value = model.EduEndDate;                        
            parameters[4].Value = model.GetEdu;                        
            parameters[5].Value = model.IsTZ;                        
            parameters[6].Value = model.Is211;                        
            parameters[7].Value = model.IsVal;                        
            parameters[8].Value = model.AddonInfo;                        
            parameters[9].Value = model.id;                        
            parameters[10].Value = model.AppID;                        
            parameters[11].Value = model.Version;                        
            parameters[12].Value = model.RandomNo;                        
            parameters[13].Value = model.ParentID;                        
            parameters[14].Value = model.Remark;                        
            parameters[15].Value = model.LableText;                        
            parameters[16].Value = model.ExJson;                        
            parameters[17].Value = model.Status;                        
            parameters[18].Value = model.OrderNo;                        
            parameters[19].Value = model.CreateDate;                        
            parameters[20].Value = model.ModifyDate;                        
            parameters[21].Value = model.CreateUser;                        
            parameters[22].Value = model.ModifyUser;                        
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
			strSql.Append("update tabExperienceEdu set " + strValue);           
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(tabExperienceEduModel model, List<string> ChangedFields)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabExperienceEdu set ");
			                        
            strSql.Append(" SchoolName = SQL2012SchoolName , ");                                    
            strSql.Append(" ProfessionalName = SQL2012ProfessionalName , ");                                    
            strSql.Append(" EduBeginDate = SQL2012EduBeginDate , ");                                    
            strSql.Append(" EduEndDate = SQL2012EduEndDate , ");                                    
            strSql.Append(" GetEdu = SQL2012GetEdu , ");                                    
            strSql.Append(" IsTZ = SQL2012IsTZ , ");                                    
            strSql.Append(" Is211 = SQL2012Is211 , ");                                    
            strSql.Append(" IsVal = SQL2012IsVal , ");                                    
            strSql.Append(" AddonInfo = SQL2012AddonInfo , ");                                                            
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
			            new SqlParameter("SQL2012SchoolName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012ProfessionalName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012EduBeginDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012EduEndDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012GetEdu", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012IsTZ", SqlDbType.Bit,1) ,            
                        new SqlParameter("SQL2012Is211", SqlDbType.Bit,1) ,            
                        new SqlParameter("SQL2012IsVal", SqlDbType.Bit,1) ,            
                        new SqlParameter("SQL2012AddonInfo", SqlDbType.NVarChar,-1) ,            
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
						            
            parameters[0].Value = model.SchoolName;                        
            parameters[1].Value = model.ProfessionalName;                        
            parameters[2].Value = model.EduBeginDate;                        
            parameters[3].Value = model.EduEndDate;                        
            parameters[4].Value = model.GetEdu;                        
            parameters[5].Value = model.IsTZ;                        
            parameters[6].Value = model.Is211;                        
            parameters[7].Value = model.IsVal;                        
            parameters[8].Value = model.AddonInfo;                        
            parameters[9].Value = model.id;                        
            parameters[10].Value = model.AppID;                        
            parameters[11].Value = model.Version;                        
            parameters[12].Value = model.RandomNo;                        
            parameters[13].Value = model.ParentID;                        
            parameters[14].Value = model.Remark;                        
            parameters[15].Value = model.LableText;                        
            parameters[16].Value = model.ExJson;                        
            parameters[17].Value = model.Status;                        
            parameters[18].Value = model.OrderNo;                        
            parameters[19].Value = model.CreateDate;                        
            parameters[20].Value = model.ModifyDate;                        
            parameters[21].Value = model.CreateUser;                        
            parameters[22].Value = model.ModifyUser;                        
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
			strSql.Append("delete from tabExperienceEdu ");
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
			strSql.Append("delete from tabExperienceEdu ");
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
		public tabExperienceEduModel GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");			
			strSql.Append("  from tabExperienceEdu ");
			strSql.Append(" where id=SQL2012id");
						SqlParameter[] parameters = {
					new SqlParameter("SQL2012id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			
			tabExperienceEduModel model=new tabExperienceEduModel();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabExperienceEduModel>.FillModel(ds.Tables[0].Rows[0]);
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
			strSql.Append(" FROM tabExperienceEdu ");
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
			strSql.Append(" FROM tabExperienceEdu ");
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
			strSql.Append(" FROM tabExperienceEdu ");
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
			strSql.Append(" FROM tabExperienceEdu as a  where  version=(select max(b.version)  from tabExperienceEdu  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabExperienceEdu as a  where  version=(select max(b.version)  from tabExperienceEdu  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabExperienceEdu as a  where  version=(select max(b.version)  from tabExperienceEdu  as b  where a.RandomNo =  b.RandomNo)");
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
	/// 教育经历表
    /// </summary> 	
	public partial class tabExperienceEduBLL
	{
        private readonly tabExperienceEduSQLDAL dal=new tabExperienceEduSQLDAL();
		public void tabExperienceEdu()
		{
		}
		public static tabExperienceEduBLL Instance
        {
            get
            {
                return _Instance;
            }
            set { _Instance = value; }
        }private static tabExperienceEduBLL _Instance;
        public static tabExperienceEduBLL GetInstance()
        {
            if (Instance == null)
            {
                Instance = new tabExperienceEduBLL();
            }
            return Instance;
        }
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SchoolName,string ProfessionalName,string EduBeginDate,int GetEdu,int id,int ParentID)
		{
			return dal.Exists(SchoolName,ProfessionalName,EduBeginDate,GetEdu,id,ParentID);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(tabExperienceEduModel model)
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
		public bool Update(tabExperienceEduModel model)
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
		public tabExperienceEduModel GetModel(int id)
		{
			
			return dal.GetModel(id);
		}	
		/// <summary>
		/// 得到对象列表中第一个对象实体
		/// </summary>
		public tabExperienceEduModel GetModel(string _where,int Index)
		{
			List<tabExperienceEduModel> lsmodel = GetModelList(_where);
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
        public List<tabExperienceEduModel> GetModelList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            DataSet ds = dal.GetList(pageSize, pageIndex, strWhere, filedOrder, out recordCount);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabExperienceEduModel>.FillModel(ds.Tables[0]);
            else
                return new List<tabExperienceEduModel>();
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
		public List<tabExperienceEduModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabExperienceEduModel>.FillModel(ds.Tables[0]);
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
		public List<tabExperienceEduModel> GetModelListVersion(string strWhere)
		{
			DataSet ds = dal.GetListVersion(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabExperienceEduModel>.FillModel(ds.Tables[0]);
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
