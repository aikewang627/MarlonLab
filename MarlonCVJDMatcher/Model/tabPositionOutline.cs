
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
#region  Model 实体类- tabPositionOutline
namespace Tclywork.Model{
	[Serializable]
	/// <summary>
	/// tabPositionOutline
    /// </summary> 	
	public partial class tabPositionOutlineModel
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
			/// PositionID
	        /// </summary>
	        
	        public int PositionID
	        {
	            get{ return _PositionID; }
	            set{ _PositionID = value;}
	        }private int _PositionID;
				        
							/// <summary>
			/// PositionName
	        /// </summary>
	        
	        public string PositionName
	        {
	            get{ return _PositionName; }
	            set{ _PositionName = value;}
	        }private string _PositionName;
				        
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
			/// 职位所属公司
	        /// </summary>
	        
	        public int ParentID
	        {
	            get{ return _ParentID; }
	            set{ _ParentID = value;}
	        }private int _ParentID;
				        
							/// <summary>
			/// 结构名称
	        /// </summary>
	        
	        public string OrgName
	        {
	            get{ return _OrgName; }
	            set{ _OrgName = value;}
	        }private string _OrgName;
				        
							/// <summary>
			/// 专业领域
	        /// </summary>
	        
	        public string OrgPro
	        {
	            get{ return _OrgPro; }
	            set{ _OrgPro = value;}
	        }private string _OrgPro;
				        
							/// <summary>
			/// 规模
	        /// </summary>
	        
	        public string OrgScale
	        {
	            get{ return _OrgScale; }
	            set{ _OrgScale = value;}
	        }private string _OrgScale;
				        
							/// <summary>
			/// 工作地点
	        /// </summary>
	        
	        public string WordAddress
	        {
	            get{ return _WordAddress; }
	            set{ _WordAddress = value;}
	        }private string _WordAddress;
				        
							/// <summary>
			/// 年薪下限，单位：分
	        /// </summary>
	        
	        public int SalaryBein
	        {
	            get{ return _SalaryBein; }
	            set{ _SalaryBein = value;}
	        }private int _SalaryBein;
				        
							/// <summary>
			/// 年薪上限，单位：分
	        /// </summary>
	        
	        public int SalaryEnd
	        {
	            get{ return _SalaryEnd; }
	            set{ _SalaryEnd = value;}
	        }private int _SalaryEnd;
				        
							/// <summary>
			/// AgeBein
	        /// </summary>
	        
	        public string AgeBein
	        {
	            get{ return _AgeBein; }
	            set{ _AgeBein = value;}
	        }private string _AgeBein;
				        
							/// <summary>
			/// 工作年限；下拉框：应届生；0-1年；1-3年；3-5年；5-10年；10年以上
	        /// </summary>
	        
	        public string AgeEnd
	        {
	            get{ return _AgeEnd; }
	            set{ _AgeEnd = value;}
	        }private string _AgeEnd;
				        
							/// <summary>
			/// 工作年限；下拉框：应届生；0-1年；1-3年；3-5年；5-10年；10年以上
	        /// </summary>
	        
	        public string RequireWorkYear
	        {
	            get{ return _RequireWorkYear; }
	            set{ _RequireWorkYear = value;}
	        }private string _RequireWorkYear;
				        
							/// <summary>
			/// 岗位要求
	        /// </summary>
	        
	        public string RequireSchool
	        {
	            get{ return _RequireSchool; }
	            set{ _RequireSchool = value;}
	        }private string _RequireSchool;
				        
							/// <summary>
			/// 资质证书要求
	        /// </summary>
	        
	        public string RequireMajor
	        {
	            get{ return _RequireMajor; }
	            set{ _RequireMajor = value;}
	        }private string _RequireMajor;
				        
							/// <summary>
			/// 学历要求
	        /// </summary>
	        
	        public string RequireXueLi
	        {
	            get{ return _RequireXueLi; }
	            set{ _RequireXueLi = value;}
	        }private string _RequireXueLi;
				        
							/// <summary>
			/// 资质证书要求
	        /// </summary>
	        
	        public string RequireSkill
	        {
	            get{ return _RequireSkill; }
	            set{ _RequireSkill = value;}
	        }private string _RequireSkill;
				        
							/// <summary>
			/// 资质证书要求
	        /// </summary>
	        
	        public string RequireCoreSkill
	        {
	            get{ return _RequireCoreSkill; }
	            set{ _RequireCoreSkill = value;}
	        }private string _RequireCoreSkill;
				        
 	}
	
	}
#endregion

#region	SQLDAL
namespace Tclywork.DAL{
	/// <summary>
	/// tabPositionOutline
    /// </summary> 	
	public partial class tabPositionOutlineSQLDAL
	{
		#region 实现方法
   		 /// <summary>
		/// 是否存在
		/// </summary>    
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tabPositionOutline");
			strSql.Append(" where ");
			                        strSql.Append(" id = SQL2012id  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("SQL2012id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(tabPositionOutlineModel model)
		{
		 	model.Version = model.Version.IsNotNullOrEmpty()? model.Version: "1";
            model.RandomNo = model.RandomNo.IsNotNullOrEmpty()? model.RandomNo: Guid.NewGuid().ToString("N");
            model.Status = model.Status.IsNotNullOrEmpty()? model.Status: "1";
            model.OrderNo = model.OrderNo>0? model.OrderNo: 1;
			model.CreateDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tabPositionOutline(");			
            strSql.Append("PositionID,PositionName,CreateUser,CreateDate,ParentID,OrgName,OrgPro,OrgScale,WordAddress,SalaryBein,SalaryEnd,AgeBein,AgeEnd,RequireWorkYear,RequireSchool,RequireMajor,RequireXueLi,RequireSkill,RequireCoreSkill");
			strSql.Append(") values (");
            strSql.Append("SQL2012PositionID,SQL2012PositionName,SQL2012CreateUser,SQL2012CreateDate,SQL2012ParentID,SQL2012OrgName,SQL2012OrgPro,SQL2012OrgScale,SQL2012WordAddress,SQL2012SalaryBein,SQL2012SalaryEnd,SQL2012AgeBein,SQL2012AgeEnd,SQL2012RequireWorkYear,SQL2012RequireSchool,SQL2012RequireMajor,SQL2012RequireXueLi,SQL2012RequireSkill,SQL2012RequireCoreSkill");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("SQL2012PositionID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012CreateUser", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012CreateDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012OrgName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OrgPro", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OrgScale", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012WordAddress", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012SalaryBein", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012SalaryEnd", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012AgeBein", SqlDbType.NChar,10) ,            
                        new SqlParameter("SQL2012AgeEnd", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012RequireWorkYear", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012RequireSchool", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012RequireMajor", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012RequireXueLi", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012RequireSkill", SqlDbType.NText) ,            
                        new SqlParameter("SQL2012RequireCoreSkill", SqlDbType.NVarChar,500)             
              
            };
			            
            parameters[0].Value = model.PositionID;                        
            parameters[1].Value = model.PositionName;                        
            parameters[2].Value = model.CreateUser;                        
            parameters[3].Value = model.CreateDate;                        
            parameters[4].Value = model.ParentID;                        
            parameters[5].Value = model.OrgName;                        
            parameters[6].Value = model.OrgPro;                        
            parameters[7].Value = model.OrgScale;                        
            parameters[8].Value = model.WordAddress;                        
            parameters[9].Value = model.SalaryBein;                        
            parameters[10].Value = model.SalaryEnd;                        
            parameters[11].Value = model.AgeBein;                        
            parameters[12].Value = model.AgeEnd;                        
            parameters[13].Value = model.RequireWorkYear;                        
            parameters[14].Value = model.RequireSchool;                        
            parameters[15].Value = model.RequireMajor;                        
            parameters[16].Value = model.RequireXueLi;                        
            parameters[17].Value = model.RequireSkill;                        
            parameters[18].Value = model.RequireCoreSkill;                        
			   
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
		public bool Update(tabPositionOutlineModel model)
		{
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabPositionOutline set ");
			                                                
            strSql.Append(" PositionID = SQL2012PositionID , ");                                    
            strSql.Append(" PositionName = SQL2012PositionName , ");                                    
            strSql.Append(" CreateUser = SQL2012CreateUser , ");                                    
            strSql.Append(" CreateDate = SQL2012CreateDate , ");                                    
            strSql.Append(" ParentID = SQL2012ParentID , ");                                    
            strSql.Append(" OrgName = SQL2012OrgName , ");                                    
            strSql.Append(" OrgPro = SQL2012OrgPro , ");                                    
            strSql.Append(" OrgScale = SQL2012OrgScale , ");                                    
            strSql.Append(" WordAddress = SQL2012WordAddress , ");                                    
            strSql.Append(" SalaryBein = SQL2012SalaryBein , ");                                    
            strSql.Append(" SalaryEnd = SQL2012SalaryEnd , ");                                    
            strSql.Append(" AgeBein = SQL2012AgeBein , ");                                    
            strSql.Append(" AgeEnd = SQL2012AgeEnd , ");                                    
            strSql.Append(" RequireWorkYear = SQL2012RequireWorkYear , ");                                    
            strSql.Append(" RequireSchool = SQL2012RequireSchool , ");                                    
            strSql.Append(" RequireMajor = SQL2012RequireMajor , ");                                    
            strSql.Append(" RequireXueLi = SQL2012RequireXueLi , ");                                    
            strSql.Append(" RequireSkill = SQL2012RequireSkill , ");                                    
            strSql.Append(" RequireCoreSkill = SQL2012RequireCoreSkill  ");            			
			strSql.Append(" where id=SQL2012id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("SQL2012id", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012CreateUser", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012CreateDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012OrgName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OrgPro", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OrgScale", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012WordAddress", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012SalaryBein", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012SalaryEnd", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012AgeBein", SqlDbType.NChar,10) ,            
                        new SqlParameter("SQL2012AgeEnd", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012RequireWorkYear", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012RequireSchool", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012RequireMajor", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012RequireXueLi", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012RequireSkill", SqlDbType.NText) ,            
                        new SqlParameter("SQL2012RequireCoreSkill", SqlDbType.NVarChar,500)             
              
            };
						            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.PositionID;                        
            parameters[2].Value = model.PositionName;                        
            parameters[3].Value = model.CreateUser;                        
            parameters[4].Value = model.CreateDate;                        
            parameters[5].Value = model.ParentID;                        
            parameters[6].Value = model.OrgName;                        
            parameters[7].Value = model.OrgPro;                        
            parameters[8].Value = model.OrgScale;                        
            parameters[9].Value = model.WordAddress;                        
            parameters[10].Value = model.SalaryBein;                        
            parameters[11].Value = model.SalaryEnd;                        
            parameters[12].Value = model.AgeBein;                        
            parameters[13].Value = model.AgeEnd;                        
            parameters[14].Value = model.RequireWorkYear;                        
            parameters[15].Value = model.RequireSchool;                        
            parameters[16].Value = model.RequireMajor;                        
            parameters[17].Value = model.RequireXueLi;                        
            parameters[18].Value = model.RequireSkill;                        
            parameters[19].Value = model.RequireCoreSkill;                        
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
			strSql.Append("update tabPositionOutline set " + strValue);           
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(tabPositionOutlineModel model, List<string> ChangedFields)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabPositionOutline set ");
			                                                
            strSql.Append(" PositionID = SQL2012PositionID , ");                                    
            strSql.Append(" PositionName = SQL2012PositionName , ");                                    
            strSql.Append(" CreateUser = SQL2012CreateUser , ");                                    
            strSql.Append(" CreateDate = SQL2012CreateDate , ");                                    
            strSql.Append(" ParentID = SQL2012ParentID , ");                                    
            strSql.Append(" OrgName = SQL2012OrgName , ");                                    
            strSql.Append(" OrgPro = SQL2012OrgPro , ");                                    
            strSql.Append(" OrgScale = SQL2012OrgScale , ");                                    
            strSql.Append(" WordAddress = SQL2012WordAddress , ");                                    
            strSql.Append(" SalaryBein = SQL2012SalaryBein , ");                                    
            strSql.Append(" SalaryEnd = SQL2012SalaryEnd , ");                                    
            strSql.Append(" AgeBein = SQL2012AgeBein , ");                                    
            strSql.Append(" AgeEnd = SQL2012AgeEnd , ");                                    
            strSql.Append(" RequireWorkYear = SQL2012RequireWorkYear , ");                                    
            strSql.Append(" RequireSchool = SQL2012RequireSchool , ");                                    
            strSql.Append(" RequireMajor = SQL2012RequireMajor , ");                                    
            strSql.Append(" RequireXueLi = SQL2012RequireXueLi , ");                                    
            strSql.Append(" RequireSkill = SQL2012RequireSkill , ");                                    
            strSql.Append(" RequireCoreSkill = SQL2012RequireCoreSkill  ");            			
			strSql.Append(" where id=SQL2012id ");						
SqlParameter[] parameters = {
			            new SqlParameter("SQL2012id", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012CreateUser", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012CreateDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012OrgName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OrgPro", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OrgScale", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012WordAddress", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012SalaryBein", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012SalaryEnd", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012AgeBein", SqlDbType.NChar,10) ,            
                        new SqlParameter("SQL2012AgeEnd", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012RequireWorkYear", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012RequireSchool", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012RequireMajor", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012RequireXueLi", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012RequireSkill", SqlDbType.NText) ,            
                        new SqlParameter("SQL2012RequireCoreSkill", SqlDbType.NVarChar,500)             
              
            };
						            
            parameters[0].Value = model.id;                        
            parameters[1].Value = model.PositionID;                        
            parameters[2].Value = model.PositionName;                        
            parameters[3].Value = model.CreateUser;                        
            parameters[4].Value = model.CreateDate;                        
            parameters[5].Value = model.ParentID;                        
            parameters[6].Value = model.OrgName;                        
            parameters[7].Value = model.OrgPro;                        
            parameters[8].Value = model.OrgScale;                        
            parameters[9].Value = model.WordAddress;                        
            parameters[10].Value = model.SalaryBein;                        
            parameters[11].Value = model.SalaryEnd;                        
            parameters[12].Value = model.AgeBein;                        
            parameters[13].Value = model.AgeEnd;                        
            parameters[14].Value = model.RequireWorkYear;                        
            parameters[15].Value = model.RequireSchool;                        
            parameters[16].Value = model.RequireMajor;                        
            parameters[17].Value = model.RequireXueLi;                        
            parameters[18].Value = model.RequireSkill;                        
            parameters[19].Value = model.RequireCoreSkill;                        
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
			strSql.Append("delete from tabPositionOutline ");
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
			strSql.Append("delete from tabPositionOutline ");
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
		public tabPositionOutlineModel GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");			
			strSql.Append("  from tabPositionOutline ");
			strSql.Append(" where id=SQL2012id");
						SqlParameter[] parameters = {
					new SqlParameter("SQL2012id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			
			tabPositionOutlineModel model=new tabPositionOutlineModel();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabPositionOutlineModel>.FillModel(ds.Tables[0].Rows[0]);
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
			strSql.Append(" FROM tabPositionOutline ");
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
			strSql.Append(" FROM tabPositionOutline ");
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
			strSql.Append(" FROM tabPositionOutline ");
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
			strSql.Append(" FROM tabPositionOutline as a  where  version=(select max(b.version)  from tabPositionOutline  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabPositionOutline as a  where  version=(select max(b.version)  from tabPositionOutline  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabPositionOutline as a  where  version=(select max(b.version)  from tabPositionOutline  as b  where a.RandomNo =  b.RandomNo)");
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
	/// tabPositionOutline
    /// </summary> 	
	public partial class tabPositionOutlineBLL
	{
        private readonly tabPositionOutlineSQLDAL dal=new tabPositionOutlineSQLDAL();
		public void tabPositionOutline()
		{
		}
		public static tabPositionOutlineBLL Instance
        {
            get
            {
                return _Instance;
            }
            set { _Instance = value; }
        }private static tabPositionOutlineBLL _Instance;
        public static tabPositionOutlineBLL GetInstance()
        {
            if (Instance == null)
            {
                Instance = new tabPositionOutlineBLL();
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
		public int  Add(tabPositionOutlineModel model)
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
		public bool Update(tabPositionOutlineModel model)
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
		public tabPositionOutlineModel GetModel(int id)
		{
			
			return dal.GetModel(id);
		}	
		/// <summary>
		/// 得到对象列表中第一个对象实体
		/// </summary>
		public tabPositionOutlineModel GetModel(string _where,int Index)
		{
			List<tabPositionOutlineModel> lsmodel = GetModelList(_where);
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
        public List<tabPositionOutlineModel> GetModelList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            DataSet ds = dal.GetList(pageSize, pageIndex, strWhere, filedOrder, out recordCount);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabPositionOutlineModel>.FillModel(ds.Tables[0]);
            else
                return new List<tabPositionOutlineModel>();
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
		public List<tabPositionOutlineModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabPositionOutlineModel>.FillModel(ds.Tables[0]);
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
		public List<tabPositionOutlineModel> GetModelListVersion(string strWhere)
		{
			DataSet ds = dal.GetListVersion(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabPositionOutlineModel>.FillModel(ds.Tables[0]);
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
