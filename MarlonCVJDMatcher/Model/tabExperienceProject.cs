
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
#region  Model 实体类- tabExperienceProject
namespace Tclywork.Model{
	[Serializable]
	/// <summary>
	/// 项目经验表
    /// </summary> 	
	public partial class tabExperienceProjectModel
	{   		     
      								/// <summary>
			/// 单位编号
	        /// </summary>
	        
	        public int OrgID
	        {
	            get{ return _OrgID; }
	            set{ _OrgID = value;}
	        }private int _OrgID;
				        
							/// <summary>
			/// 项目名
	        /// </summary>
	        
	        public string ProjectName
	        {
	            get{ return _ProjectName; }
	            set{ _ProjectName = value;}
	        }private string _ProjectName;
				        
							/// <summary>
			/// 开始时间
	        /// </summary>
	        
	        public string ProjectBeginDate
	        {
	            get{ return _ProjectBeginDate; }
	            set{ _ProjectBeginDate = value;}
	        }private string _ProjectBeginDate;
				        
							/// <summary>
			/// 结束时间
	        /// </summary>
	        
	        public string ProjectEndDate
	        {
	            get{ return _ProjectEndDate; }
	            set{ _ProjectEndDate = value;}
	        }private string _ProjectEndDate;
				        
							/// <summary>
			/// 项目说明
	        /// </summary>
	        
	        public string ProjectDesc
	        {
	            get{ return _ProjectDesc; }
	            set{ _ProjectDesc = value;}
	        }private string _ProjectDesc;
				        
							/// <summary>
			/// 担任职位
	        /// </summary>
	        
	        public string ProjectPosition
	        {
	            get{ return _ProjectPosition; }
	            set{ _ProjectPosition = value;}
	        }private string _ProjectPosition;
				        
							/// <summary>
			/// 工作业绩
	        /// </summary>
	        
	        public string ProjectPerformance
	        {
	            get{ return _ProjectPerformance; }
	            set{ _ProjectPerformance = value;}
	        }private string _ProjectPerformance;
				        
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
	/// 项目经验表
    /// </summary> 	
	public partial class tabExperienceProjectSQLDAL
	{
		#region 实现方法
   		 /// <summary>
		/// 是否存在
		/// </summary>    
		public bool Exists(int OrgID,string ProjectBeginDate,string ProjectPosition,int id,int ParentID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tabExperienceProject");
			strSql.Append(" where ");
			                        strSql.Append(" OrgID = SQL2012OrgID and  ");
                                                    strSql.Append(" ProjectBeginDate = SQL2012ProjectBeginDate and  ");
                                                    strSql.Append(" ProjectPosition = SQL2012ProjectPosition and  ");
                                                    strSql.Append(" id = SQL2012id and  ");
                                                    strSql.Append(" ParentID = SQL2012ParentID  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("SQL2012OrgID", SqlDbType.Int,4),
					new SqlParameter("SQL2012ProjectBeginDate", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012ProjectPosition", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012id", SqlDbType.Int,4),
					new SqlParameter("SQL2012ParentID", SqlDbType.Int,4)			};
			parameters[0].Value = OrgID;
			parameters[1].Value = ProjectBeginDate;
			parameters[2].Value = ProjectPosition;
			parameters[3].Value = id;
			parameters[4].Value = ParentID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(tabExperienceProjectModel model)
		{
		 	model.Version = model.Version.IsNotNullOrEmpty()? model.Version: "1";
            model.RandomNo = model.RandomNo.IsNotNullOrEmpty()? model.RandomNo: Guid.NewGuid().ToString("N");
            model.Status = model.Status.IsNotNullOrEmpty()? model.Status: "1";
            model.OrderNo = model.OrderNo>0? model.OrderNo: 1;
			model.CreateDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tabExperienceProject(");			
            strSql.Append("OrgID,ProjectName,ProjectBeginDate,ProjectEndDate,ProjectDesc,ProjectPosition,ProjectPerformance,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
			strSql.Append(") values (");
            strSql.Append("SQL2012OrgID,SQL2012ProjectName,SQL2012ProjectBeginDate,SQL2012ProjectEndDate,SQL2012ProjectDesc,SQL2012ProjectPosition,SQL2012ProjectPerformance,SQL2012AppID,SQL2012Version,SQL2012RandomNo,SQL2012ParentID,SQL2012Remark,SQL2012LableText,SQL2012ExJson,SQL2012Status,SQL2012OrderNo,SQL2012CreateDate,SQL2012ModifyDate,SQL2012CreateUser,SQL2012ModifyUser");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("SQL2012OrgID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012ProjectName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012ProjectBeginDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012ProjectEndDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012ProjectDesc", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012ProjectPosition", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012ProjectPerformance", SqlDbType.NVarChar,-1) ,            
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
			            
            parameters[0].Value = model.OrgID;                        
            parameters[1].Value = model.ProjectName;                        
            parameters[2].Value = model.ProjectBeginDate;                        
            parameters[3].Value = model.ProjectEndDate;                        
            parameters[4].Value = model.ProjectDesc;                        
            parameters[5].Value = model.ProjectPosition;                        
            parameters[6].Value = model.ProjectPerformance;                        
            parameters[7].Value = model.AppID;                        
            parameters[8].Value = model.Version;                        
            parameters[9].Value = model.RandomNo;                        
            parameters[10].Value = model.ParentID;                        
            parameters[11].Value = model.Remark;                        
            parameters[12].Value = model.LableText;                        
            parameters[13].Value = model.ExJson;                        
            parameters[14].Value = model.Status;                        
            parameters[15].Value = model.OrderNo;                        
            parameters[16].Value = model.CreateDate;                        
            parameters[17].Value = model.ModifyDate;                        
            parameters[18].Value = model.CreateUser;                        
            parameters[19].Value = model.ModifyUser;                        
			   
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
		public bool Update(tabExperienceProjectModel model)
		{
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabExperienceProject set ");
			                        
            strSql.Append(" OrgID = SQL2012OrgID , ");                                    
            strSql.Append(" ProjectName = SQL2012ProjectName , ");                                    
            strSql.Append(" ProjectBeginDate = SQL2012ProjectBeginDate , ");                                    
            strSql.Append(" ProjectEndDate = SQL2012ProjectEndDate , ");                                    
            strSql.Append(" ProjectDesc = SQL2012ProjectDesc , ");                                    
            strSql.Append(" ProjectPosition = SQL2012ProjectPosition , ");                                    
            strSql.Append(" ProjectPerformance = SQL2012ProjectPerformance , ");                                                            
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
			            new SqlParameter("SQL2012OrgID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012ProjectName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012ProjectBeginDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012ProjectEndDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012ProjectDesc", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012ProjectPosition", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012ProjectPerformance", SqlDbType.NVarChar,-1) ,            
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
						            
            parameters[0].Value = model.OrgID;                        
            parameters[1].Value = model.ProjectName;                        
            parameters[2].Value = model.ProjectBeginDate;                        
            parameters[3].Value = model.ProjectEndDate;                        
            parameters[4].Value = model.ProjectDesc;                        
            parameters[5].Value = model.ProjectPosition;                        
            parameters[6].Value = model.ProjectPerformance;                        
            parameters[7].Value = model.id;                        
            parameters[8].Value = model.AppID;                        
            parameters[9].Value = model.Version;                        
            parameters[10].Value = model.RandomNo;                        
            parameters[11].Value = model.ParentID;                        
            parameters[12].Value = model.Remark;                        
            parameters[13].Value = model.LableText;                        
            parameters[14].Value = model.ExJson;                        
            parameters[15].Value = model.Status;                        
            parameters[16].Value = model.OrderNo;                        
            parameters[17].Value = model.CreateDate;                        
            parameters[18].Value = model.ModifyDate;                        
            parameters[19].Value = model.CreateUser;                        
            parameters[20].Value = model.ModifyUser;                        
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
			strSql.Append("update tabExperienceProject set " + strValue);           
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(tabExperienceProjectModel model, List<string> ChangedFields)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabExperienceProject set ");
			                        
            strSql.Append(" OrgID = SQL2012OrgID , ");                                    
            strSql.Append(" ProjectName = SQL2012ProjectName , ");                                    
            strSql.Append(" ProjectBeginDate = SQL2012ProjectBeginDate , ");                                    
            strSql.Append(" ProjectEndDate = SQL2012ProjectEndDate , ");                                    
            strSql.Append(" ProjectDesc = SQL2012ProjectDesc , ");                                    
            strSql.Append(" ProjectPosition = SQL2012ProjectPosition , ");                                    
            strSql.Append(" ProjectPerformance = SQL2012ProjectPerformance , ");                                                            
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
			            new SqlParameter("SQL2012OrgID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012ProjectName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012ProjectBeginDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012ProjectEndDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012ProjectDesc", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012ProjectPosition", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012ProjectPerformance", SqlDbType.NVarChar,-1) ,            
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
						            
            parameters[0].Value = model.OrgID;                        
            parameters[1].Value = model.ProjectName;                        
            parameters[2].Value = model.ProjectBeginDate;                        
            parameters[3].Value = model.ProjectEndDate;                        
            parameters[4].Value = model.ProjectDesc;                        
            parameters[5].Value = model.ProjectPosition;                        
            parameters[6].Value = model.ProjectPerformance;                        
            parameters[7].Value = model.id;                        
            parameters[8].Value = model.AppID;                        
            parameters[9].Value = model.Version;                        
            parameters[10].Value = model.RandomNo;                        
            parameters[11].Value = model.ParentID;                        
            parameters[12].Value = model.Remark;                        
            parameters[13].Value = model.LableText;                        
            parameters[14].Value = model.ExJson;                        
            parameters[15].Value = model.Status;                        
            parameters[16].Value = model.OrderNo;                        
            parameters[17].Value = model.CreateDate;                        
            parameters[18].Value = model.ModifyDate;                        
            parameters[19].Value = model.CreateUser;                        
            parameters[20].Value = model.ModifyUser;                        
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
			strSql.Append("delete from tabExperienceProject ");
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
			strSql.Append("delete from tabExperienceProject ");
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
		public tabExperienceProjectModel GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");			
			strSql.Append("  from tabExperienceProject ");
			strSql.Append(" where id=SQL2012id");
						SqlParameter[] parameters = {
					new SqlParameter("SQL2012id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			
			tabExperienceProjectModel model=new tabExperienceProjectModel();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabExperienceProjectModel>.FillModel(ds.Tables[0].Rows[0]);
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
			strSql.Append(" FROM tabExperienceProject ");
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
			strSql.Append(" FROM tabExperienceProject ");
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
			strSql.Append(" FROM tabExperienceProject ");
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
			strSql.Append(" FROM tabExperienceProject as a  where  version=(select max(b.version)  from tabExperienceProject  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabExperienceProject as a  where  version=(select max(b.version)  from tabExperienceProject  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabExperienceProject as a  where  version=(select max(b.version)  from tabExperienceProject  as b  where a.RandomNo =  b.RandomNo)");
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
	/// 项目经验表
    /// </summary> 	
	public partial class tabExperienceProjectBLL
	{
        private readonly tabExperienceProjectSQLDAL dal=new tabExperienceProjectSQLDAL();
		public void tabExperienceProject()
		{
		}
		public static tabExperienceProjectBLL Instance
        {
            get
            {
                return _Instance;
            }
            set { _Instance = value; }
        }private static tabExperienceProjectBLL _Instance;
        public static tabExperienceProjectBLL GetInstance()
        {
            if (Instance == null)
            {
                Instance = new tabExperienceProjectBLL();
            }
            return Instance;
        }
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OrgID,string ProjectBeginDate,string ProjectPosition,int id,int ParentID)
		{
			return dal.Exists(OrgID,ProjectBeginDate,ProjectPosition,id,ParentID);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(tabExperienceProjectModel model)
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
		public bool Update(tabExperienceProjectModel model)
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
		public tabExperienceProjectModel GetModel(int id)
		{
			
			return dal.GetModel(id);
		}	
		/// <summary>
		/// 得到对象列表中第一个对象实体
		/// </summary>
		public tabExperienceProjectModel GetModel(string _where,int Index)
		{
			List<tabExperienceProjectModel> lsmodel = GetModelList(_where);
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
        public List<tabExperienceProjectModel> GetModelList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            DataSet ds = dal.GetList(pageSize, pageIndex, strWhere, filedOrder, out recordCount);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabExperienceProjectModel>.FillModel(ds.Tables[0]);
            else
                return new List<tabExperienceProjectModel>();
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
		public List<tabExperienceProjectModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabExperienceProjectModel>.FillModel(ds.Tables[0]);
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
		public List<tabExperienceProjectModel> GetModelListVersion(string strWhere)
		{
			DataSet ds = dal.GetListVersion(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabExperienceProjectModel>.FillModel(ds.Tables[0]);
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
