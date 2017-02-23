
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
#region  Model 实体类- tabExperienceWork
namespace Tclywork.Model{
	[Serializable]
	/// <summary>
	/// 工作经历表
    /// </summary> 	
	public partial class tabExperienceWorkModel
	{   		     
      								/// <summary>
			/// 企业名称编号
	        /// </summary>
	        
	        public int OrgID
	        {
	            get{ return _OrgID; }
	            set{ _OrgID = value;}
	        }private int _OrgID;
				        
							/// <summary>
			/// 入职时间
	        /// </summary>
	        
	        public string OrgBeginDate
	        {
	            get{ return _OrgBeginDate; }
	            set{ _OrgBeginDate = value;}
	        }private string _OrgBeginDate;
				        
							/// <summary>
			/// 离职时间
	        /// </summary>
	        
	        public string OrgEndDate
	        {
	            get{ return _OrgEndDate; }
	            set{ _OrgEndDate = value;}
	        }private string _OrgEndDate;
				        
							/// <summary>
			/// 职位名称
	        /// </summary>
	        
	        public string PositionName
	        {
	            get{ return _PositionName; }
	            set{ _PositionName = value;}
	        }private string _PositionName;
				        
							/// <summary>
			/// 工作地点
	        /// </summary>
	        
	        public string PositionAddress
	        {
	            get{ return _PositionAddress; }
	            set{ _PositionAddress = value;}
	        }private string _PositionAddress;
				        
							/// <summary>
			/// 上任时间
	        /// </summary>
	        
	        public string PositionBeginDate
	        {
	            get{ return _PositionBeginDate; }
	            set{ _PositionBeginDate = value;}
	        }private string _PositionBeginDate;
				        
							/// <summary>
			/// 调任时间
	        /// </summary>
	        
	        public string PositionEndDate
	        {
	            get{ return _PositionEndDate; }
	            set{ _PositionEndDate = value;}
	        }private string _PositionEndDate;
				        
							/// <summary>
			/// 部门人数
	        /// </summary>
	        
	        public int DeptNum
	        {
	            get{ return _DeptNum; }
	            set{ _DeptNum = value;}
	        }private int _DeptNum;
				        
							/// <summary>
			/// 工作职责
	        /// </summary>
	        
	        public string PositionDuties
	        {
	            get{ return _PositionDuties; }
	            set{ _PositionDuties = value;}
	        }private string _PositionDuties;
				        
							/// <summary>
			/// 汇报对象
	        /// </summary>
	        
	        public string ReportObj
	        {
	            get{ return _ReportObj; }
	            set{ _ReportObj = value;}
	        }private string _ReportObj;
				        
							/// <summary>
			/// 所在部门
	        /// </summary>
	        
	        public string DeptName
	        {
	            get{ return _DeptName; }
	            set{ _DeptName = value;}
	        }private string _DeptName;
				        
							/// <summary>
			/// 工作业绩
	        /// </summary>
	        
	        public string WorkPerformance
	        {
	            get{ return _WorkPerformance; }
	            set{ _WorkPerformance = value;}
	        }private string _WorkPerformance;
				        
							/// <summary>
			/// 是否第三方认证
	        /// </summary>
	        
	        public bool IsVal
	        {
	            get{ return _IsVal; }
	            set{ _IsVal = value;}
	        }private bool _IsVal;
				        
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
	/// 工作经历表
    /// </summary> 	
	public partial class tabExperienceWorkSQLDAL
	{
		#region 实现方法
   		 /// <summary>
		/// 是否存在
		/// </summary>    
		public bool Exists(string PositionName,string PositionAddress,string PositionBeginDate,int id,int ParentID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tabExperienceWork");
			strSql.Append(" where ");
			                        strSql.Append(" PositionName = SQL2012PositionName and  ");
                                                    strSql.Append(" PositionAddress = SQL2012PositionAddress and  ");
                                                    strSql.Append(" PositionBeginDate = SQL2012PositionBeginDate and  ");
                                                    strSql.Append(" id = SQL2012id and  ");
                                                    strSql.Append(" ParentID = SQL2012ParentID  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("SQL2012PositionName", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012PositionAddress", SqlDbType.NVarChar,200),
					new SqlParameter("SQL2012PositionBeginDate", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012id", SqlDbType.Int,4),
					new SqlParameter("SQL2012ParentID", SqlDbType.Int,4)			};
			parameters[0].Value = PositionName;
			parameters[1].Value = PositionAddress;
			parameters[2].Value = PositionBeginDate;
			parameters[3].Value = id;
			parameters[4].Value = ParentID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(tabExperienceWorkModel model)
		{
		 	model.Version = model.Version.IsNotNullOrEmpty()? model.Version: "1";
            model.RandomNo = model.RandomNo.IsNotNullOrEmpty()? model.RandomNo: Guid.NewGuid().ToString("N");
            model.Status = model.Status.IsNotNullOrEmpty()? model.Status: "1";
            model.OrderNo = model.OrderNo>0? model.OrderNo: 1;
			model.CreateDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tabExperienceWork(");			
            strSql.Append("OrgID,OrgBeginDate,OrgEndDate,PositionName,PositionAddress,PositionBeginDate,PositionEndDate,DeptNum,PositionDuties,ReportObj,DeptName,WorkPerformance,IsVal,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
			strSql.Append(") values (");
            strSql.Append("SQL2012OrgID,SQL2012OrgBeginDate,SQL2012OrgEndDate,SQL2012PositionName,SQL2012PositionAddress,SQL2012PositionBeginDate,SQL2012PositionEndDate,SQL2012DeptNum,SQL2012PositionDuties,SQL2012ReportObj,SQL2012DeptName,SQL2012WorkPerformance,SQL2012IsVal,SQL2012AppID,SQL2012Version,SQL2012RandomNo,SQL2012ParentID,SQL2012Remark,SQL2012LableText,SQL2012ExJson,SQL2012Status,SQL2012OrderNo,SQL2012CreateDate,SQL2012ModifyDate,SQL2012CreateUser,SQL2012ModifyUser");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("SQL2012OrgID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012OrgBeginDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OrgEndDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012PositionName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012PositionAddress", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012PositionBeginDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012PositionEndDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012DeptNum", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionDuties", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("SQL2012ReportObj", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012DeptName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012WorkPerformance", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012IsVal", SqlDbType.Bit,1) ,            
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
            parameters[1].Value = model.OrgBeginDate;                        
            parameters[2].Value = model.OrgEndDate;                        
            parameters[3].Value = model.PositionName;                        
            parameters[4].Value = model.PositionAddress;                        
            parameters[5].Value = model.PositionBeginDate;                        
            parameters[6].Value = model.PositionEndDate;                        
            parameters[7].Value = model.DeptNum;                        
            parameters[8].Value = model.PositionDuties;                        
            parameters[9].Value = model.ReportObj;                        
            parameters[10].Value = model.DeptName;                        
            parameters[11].Value = model.WorkPerformance;                        
            parameters[12].Value = model.IsVal;                        
            parameters[13].Value = model.AppID;                        
            parameters[14].Value = model.Version;                        
            parameters[15].Value = model.RandomNo;                        
            parameters[16].Value = model.ParentID;                        
            parameters[17].Value = model.Remark;                        
            parameters[18].Value = model.LableText;                        
            parameters[19].Value = model.ExJson;                        
            parameters[20].Value = model.Status;                        
            parameters[21].Value = model.OrderNo;                        
            parameters[22].Value = model.CreateDate;                        
            parameters[23].Value = model.ModifyDate;                        
            parameters[24].Value = model.CreateUser;                        
            parameters[25].Value = model.ModifyUser;                        
			   
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
		public bool Update(tabExperienceWorkModel model)
		{
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabExperienceWork set ");
			                        
            strSql.Append(" OrgID = SQL2012OrgID , ");                                    
            strSql.Append(" OrgBeginDate = SQL2012OrgBeginDate , ");                                    
            strSql.Append(" OrgEndDate = SQL2012OrgEndDate , ");                                    
            strSql.Append(" PositionName = SQL2012PositionName , ");                                    
            strSql.Append(" PositionAddress = SQL2012PositionAddress , ");                                    
            strSql.Append(" PositionBeginDate = SQL2012PositionBeginDate , ");                                    
            strSql.Append(" PositionEndDate = SQL2012PositionEndDate , ");                                    
            strSql.Append(" DeptNum = SQL2012DeptNum , ");                                    
            strSql.Append(" PositionDuties = SQL2012PositionDuties , ");                                    
            strSql.Append(" ReportObj = SQL2012ReportObj , ");                                    
            strSql.Append(" DeptName = SQL2012DeptName , ");                                    
            strSql.Append(" WorkPerformance = SQL2012WorkPerformance , ");                                    
            strSql.Append(" IsVal = SQL2012IsVal , ");                                                            
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
                        new SqlParameter("SQL2012OrgBeginDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OrgEndDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012PositionName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012PositionAddress", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012PositionBeginDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012PositionEndDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012DeptNum", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionDuties", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("SQL2012ReportObj", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012DeptName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012WorkPerformance", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012IsVal", SqlDbType.Bit,1) ,            
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
            parameters[1].Value = model.OrgBeginDate;                        
            parameters[2].Value = model.OrgEndDate;                        
            parameters[3].Value = model.PositionName;                        
            parameters[4].Value = model.PositionAddress;                        
            parameters[5].Value = model.PositionBeginDate;                        
            parameters[6].Value = model.PositionEndDate;                        
            parameters[7].Value = model.DeptNum;                        
            parameters[8].Value = model.PositionDuties;                        
            parameters[9].Value = model.ReportObj;                        
            parameters[10].Value = model.DeptName;                        
            parameters[11].Value = model.WorkPerformance;                        
            parameters[12].Value = model.IsVal;                        
            parameters[13].Value = model.id;                        
            parameters[14].Value = model.AppID;                        
            parameters[15].Value = model.Version;                        
            parameters[16].Value = model.RandomNo;                        
            parameters[17].Value = model.ParentID;                        
            parameters[18].Value = model.Remark;                        
            parameters[19].Value = model.LableText;                        
            parameters[20].Value = model.ExJson;                        
            parameters[21].Value = model.Status;                        
            parameters[22].Value = model.OrderNo;                        
            parameters[23].Value = model.CreateDate;                        
            parameters[24].Value = model.ModifyDate;                        
            parameters[25].Value = model.CreateUser;                        
            parameters[26].Value = model.ModifyUser;                        
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
			strSql.Append("update tabExperienceWork set " + strValue);           
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(tabExperienceWorkModel model, List<string> ChangedFields)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabExperienceWork set ");
			                        
            strSql.Append(" OrgID = SQL2012OrgID , ");                                    
            strSql.Append(" OrgBeginDate = SQL2012OrgBeginDate , ");                                    
            strSql.Append(" OrgEndDate = SQL2012OrgEndDate , ");                                    
            strSql.Append(" PositionName = SQL2012PositionName , ");                                    
            strSql.Append(" PositionAddress = SQL2012PositionAddress , ");                                    
            strSql.Append(" PositionBeginDate = SQL2012PositionBeginDate , ");                                    
            strSql.Append(" PositionEndDate = SQL2012PositionEndDate , ");                                    
            strSql.Append(" DeptNum = SQL2012DeptNum , ");                                    
            strSql.Append(" PositionDuties = SQL2012PositionDuties , ");                                    
            strSql.Append(" ReportObj = SQL2012ReportObj , ");                                    
            strSql.Append(" DeptName = SQL2012DeptName , ");                                    
            strSql.Append(" WorkPerformance = SQL2012WorkPerformance , ");                                    
            strSql.Append(" IsVal = SQL2012IsVal , ");                                                            
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
                        new SqlParameter("SQL2012OrgBeginDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OrgEndDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012PositionName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012PositionAddress", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012PositionBeginDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012PositionEndDate", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012DeptNum", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionDuties", SqlDbType.NVarChar,1000) ,            
                        new SqlParameter("SQL2012ReportObj", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012DeptName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012WorkPerformance", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012IsVal", SqlDbType.Bit,1) ,            
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
            parameters[1].Value = model.OrgBeginDate;                        
            parameters[2].Value = model.OrgEndDate;                        
            parameters[3].Value = model.PositionName;                        
            parameters[4].Value = model.PositionAddress;                        
            parameters[5].Value = model.PositionBeginDate;                        
            parameters[6].Value = model.PositionEndDate;                        
            parameters[7].Value = model.DeptNum;                        
            parameters[8].Value = model.PositionDuties;                        
            parameters[9].Value = model.ReportObj;                        
            parameters[10].Value = model.DeptName;                        
            parameters[11].Value = model.WorkPerformance;                        
            parameters[12].Value = model.IsVal;                        
            parameters[13].Value = model.id;                        
            parameters[14].Value = model.AppID;                        
            parameters[15].Value = model.Version;                        
            parameters[16].Value = model.RandomNo;                        
            parameters[17].Value = model.ParentID;                        
            parameters[18].Value = model.Remark;                        
            parameters[19].Value = model.LableText;                        
            parameters[20].Value = model.ExJson;                        
            parameters[21].Value = model.Status;                        
            parameters[22].Value = model.OrderNo;                        
            parameters[23].Value = model.CreateDate;                        
            parameters[24].Value = model.ModifyDate;                        
            parameters[25].Value = model.CreateUser;                        
            parameters[26].Value = model.ModifyUser;                        
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
			strSql.Append("delete from tabExperienceWork ");
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
			strSql.Append("delete from tabExperienceWork ");
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
		public tabExperienceWorkModel GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");			
			strSql.Append("  from tabExperienceWork ");
			strSql.Append(" where id=SQL2012id");
						SqlParameter[] parameters = {
					new SqlParameter("SQL2012id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			
			tabExperienceWorkModel model=new tabExperienceWorkModel();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabExperienceWorkModel>.FillModel(ds.Tables[0].Rows[0]);
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
			strSql.Append(" FROM tabExperienceWork ");
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
			strSql.Append(" FROM tabExperienceWork ");
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
			strSql.Append(" FROM tabExperienceWork ");
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
			strSql.Append(" FROM tabExperienceWork as a  where  version=(select max(b.version)  from tabExperienceWork  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabExperienceWork as a  where  version=(select max(b.version)  from tabExperienceWork  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabExperienceWork as a  where  version=(select max(b.version)  from tabExperienceWork  as b  where a.RandomNo =  b.RandomNo)");
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
	/// 工作经历表
    /// </summary> 	
	public partial class tabExperienceWorkBLL
	{
        private readonly tabExperienceWorkSQLDAL dal=new tabExperienceWorkSQLDAL();
		public void tabExperienceWork()
		{
		}
		public static tabExperienceWorkBLL Instance
        {
            get
            {
                return _Instance;
            }
            set { _Instance = value; }
        }private static tabExperienceWorkBLL _Instance;
        public static tabExperienceWorkBLL GetInstance()
        {
            if (Instance == null)
            {
                Instance = new tabExperienceWorkBLL();
            }
            return Instance;
        }
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string PositionName,string PositionAddress,string PositionBeginDate,int id,int ParentID)
		{
			return dal.Exists(PositionName,PositionAddress,PositionBeginDate,id,ParentID);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(tabExperienceWorkModel model)
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
		public bool Update(tabExperienceWorkModel model)
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
		public tabExperienceWorkModel GetModel(int id)
		{
			
			return dal.GetModel(id);
		}	
		/// <summary>
		/// 得到对象列表中第一个对象实体
		/// </summary>
		public tabExperienceWorkModel GetModel(string _where,int Index)
		{
			List<tabExperienceWorkModel> lsmodel = GetModelList(_where);
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
        public List<tabExperienceWorkModel> GetModelList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            DataSet ds = dal.GetList(pageSize, pageIndex, strWhere, filedOrder, out recordCount);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabExperienceWorkModel>.FillModel(ds.Tables[0]);
            else
                return new List<tabExperienceWorkModel>();
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
		public List<tabExperienceWorkModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabExperienceWorkModel>.FillModel(ds.Tables[0]);
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
		public List<tabExperienceWorkModel> GetModelListVersion(string strWhere)
		{
			DataSet ds = dal.GetListVersion(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabExperienceWorkModel>.FillModel(ds.Tables[0]);
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
