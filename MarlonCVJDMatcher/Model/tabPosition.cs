
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
#region  Model 实体类- tabPosition
namespace Tclywork.Model{
	[Serializable]
	/// <summary>
	/// tabPosition
    /// </summary> 	
	public partial class tabPositionModel
	{   		     
      								/// <summary>
			/// 职位名称
	        /// </summary>
	        
	        public string PositionName
	        {
	            get{ return _PositionName; }
	            set{ _PositionName = value;}
	        }private string _PositionName;
				        
							/// <summary>
			/// 职位描述
	        /// </summary>
	        
	        public string PositionDesc
	        {
	            get{ return _PositionDesc; }
	            set{ _PositionDesc = value;}
	        }private string _PositionDesc;
				        
							/// <summary>
			/// 工作地点
	        /// </summary>
	        
	        public string WordAddress
	        {
	            get{ return _WordAddress; }
	            set{ _WordAddress = value;}
	        }private string _WordAddress;
				        
							/// <summary>
			/// 招聘人数
	        /// </summary>
	        
	        public int NeedNum
	        {
	            get{ return _NeedNum; }
	            set{ _NeedNum = value;}
	        }private int _NeedNum;
				        
							/// <summary>
			/// 职位所属部门编号，可通过逆向查询公司名称
	        /// </summary>
	        
	        public string DeptID
	        {
	            get{ return _DeptID; }
	            set{ _DeptID = value;}
	        }private string _DeptID;
				        
							/// <summary>
			/// 操作职位发布的公司ID，企业自己或猎头公司
	        /// </summary>
	        
	        public int PubOrgID
	        {
	            get{ return _PubOrgID; }
	            set{ _PubOrgID = value;}
	        }private int _PubOrgID;
				        
							/// <summary>
			/// 汇报对象
	        /// </summary>
	        
	        public string ReportObj
	        {
	            get{ return _ReportObj; }
	            set{ _ReportObj = value;}
	        }private string _ReportObj;
				        
							/// <summary>
			/// 下属人数
	        /// </summary>
	        
	        public int OrgNum
	        {
	            get{ return _OrgNum; }
	            set{ _OrgNum = value;}
	        }private int _OrgNum;
				        
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
			/// 职位亮点
	        /// </summary>
	        
	        public string PositionEdge
	        {
	            get{ return _PositionEdge; }
	            set{ _PositionEdge = value;}
	        }private string _PositionEdge;
				        
							/// <summary>
			/// 职位开放原因
	        /// </summary>
	        
	        public string PostionReason
	        {
	            get{ return _PostionReason; }
	            set{ _PostionReason = value;}
	        }private string _PostionReason;
				        
							/// <summary>
			/// 佣金政策类型：0：0元招聘；1：行规价；2：自定义价
	        /// </summary>
	        
	        public int CommissionType
	        {
	            get{ return _CommissionType; }
	            set{ _CommissionType = value;}
	        }private int _CommissionType;
				        
							/// <summary>
			/// 佣金总额，单位：分
	        /// </summary>
	        
	        public int PriceCommission
	        {
	            get{ return _PriceCommission; }
	            set{ _PriceCommission = value;}
	        }private int _PriceCommission;
				        
							/// <summary>
			/// 佣金预付款，单位：分
	        /// </summary>
	        
	        public int PricePre
	        {
	            get{ return _PricePre; }
	            set{ _PricePre = value;}
	        }private int _PricePre;
				        
							/// <summary>
			/// 面试后款，单位：分
	        /// </summary>
	        
	        public int PriceInterview
	        {
	            get{ return _PriceInterview; }
	            set{ _PriceInterview = value;}
	        }private int _PriceInterview;
				        
							/// <summary>
			/// 入职后款，单位：分
	        /// </summary>
	        
	        public int PriceJoinWork
	        {
	            get{ return _PriceJoinWork; }
	            set{ _PriceJoinWork = value;}
	        }private int _PriceJoinWork;
				        
							/// <summary>
			/// 转正后款，单位：分
	        /// </summary>
	        
	        public int PriceGetWork
	        {
	            get{ return _PriceGetWork; }
	            set{ _PriceGetWork = value;}
	        }private int _PriceGetWork;
				        
							/// <summary>
			/// 安全天数
	        /// </summary>
	        
	        public int SafeDay
	        {
	            get{ return _SafeDay; }
	            set{ _SafeDay = value;}
	        }private int _SafeDay;
				        
							/// <summary>
			/// 岗位要求
	        /// </summary>
	        
	        public string RequireContent
	        {
	            get{ return _RequireContent; }
	            set{ _RequireContent = value;}
	        }private string _RequireContent;
				        
							/// <summary>
			/// 学历要求
	        /// </summary>
	        
	        public string RequireEdu
	        {
	            get{ return _RequireEdu; }
	            set{ _RequireEdu = value;}
	        }private string _RequireEdu;
				        
							/// <summary>
			/// 资质证书要求
	        /// </summary>
	        
	        public string RequireAbility
	        {
	            get{ return _RequireAbility; }
	            set{ _RequireAbility = value;}
	        }private string _RequireAbility;
				        
							/// <summary>
			/// 特殊工作经历要求
	        /// </summary>
	        
	        public string RequireExperience
	        {
	            get{ return _RequireExperience; }
	            set{ _RequireExperience = value;}
	        }private string _RequireExperience;
				        
							/// <summary>
			/// 工作年限；下拉框：应届生；0-1年；1-3年；3-5年；5-10年；10年以上
	        /// </summary>
	        
	        public string RequireYear
	        {
	            get{ return _RequireYear; }
	            set{ _RequireYear = value;}
	        }private string _RequireYear;
				        
							/// <summary>
			/// 项目要求
	        /// </summary>
	        
	        public string RequireProject
	        {
	            get{ return _RequireProject; }
	            set{ _RequireProject = value;}
	        }private string _RequireProject;
				        
							/// <summary>
			/// 补充信息，使用json格式对其进行区分
	        /// </summary>
	        
	        public string AdditionInfo
	        {
	            get{ return _AdditionInfo; }
	            set{ _AdditionInfo = value;}
	        }private string _AdditionInfo;
				        
							/// <summary>
			/// 原始文件id（tabAsset.ID，没有原始文件则默认为0
	        /// </summary>
	        
	        public int PositionInitFile
	        {
	            get{ return _PositionInitFile; }
	            set{ _PositionInitFile = value;}
	        }private int _PositionInitFile;
				        
							/// <summary>
			/// PDF版本文件编号(tabAssets.id)
	        /// </summary>
	        
	        public int PositionPdfFile
	        {
	            get{ return _PositionPdfFile; }
	            set{ _PositionPdfFile = value;}
	        }private int _PositionPdfFile;
				        
							/// <summary>
			/// 职位来源URL，如国际机器人大会URL
	        /// </summary>
	        
	        public string PositionSourceUrl
	        {
	            get{ return _PositionSourceUrl; }
	            set{ _PositionSourceUrl = value;}
	        }private string _PositionSourceUrl;
				        
							/// <summary>
			/// 职位来源文本，如国际机器人大会
	        /// </summary>
	        
	        public string PositionSourceText
	        {
	            get{ return _PositionSourceText; }
	            set{ _PositionSourceText = value;}
	        }private string _PositionSourceText;
				        
							/// <summary>
			/// 发布/暂停/停止时间，状态根据Status来判定
	        /// </summary>
	        
	        public string PubDate
	        {
	            get{ return _PubDate; }
	            set{ _PubDate = value;}
	        }private string _PubDate;
				        
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
			/// 职位所属公司
	        /// </summary>
	        
	        public int ParentID
	        {
	            get{ return _ParentID; }
	            set{ _ParentID = value;}
	        }private int _ParentID;
				        
							/// <summary>
			/// 备注 ，当Status为1时，可为审核中，审核成功后为空字符
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
			/// 状态：-1：草拟；0:关闭职位；1：开放职位；2：暂停职位
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
	/// tabPosition
    /// </summary> 	
	public partial class tabPositionSQLDAL
	{
		#region 实现方法
   		 /// <summary>
		/// 是否存在
		/// </summary>    
		public bool Exists(int id,int ParentID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tabPosition");
			strSql.Append(" where ");
			                        strSql.Append(" id = SQL2012id and  ");
                                                    strSql.Append(" ParentID = SQL2012ParentID  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("SQL2012id", SqlDbType.Int,4),
					new SqlParameter("SQL2012ParentID", SqlDbType.Int,4)			};
			parameters[0].Value = id;
			parameters[1].Value = ParentID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(tabPositionModel model)
		{
		 	model.Version = model.Version.IsNotNullOrEmpty()? model.Version: "1";
            model.RandomNo = model.RandomNo.IsNotNullOrEmpty()? model.RandomNo: Guid.NewGuid().ToString("N");
            model.Status = model.Status.IsNotNullOrEmpty()? model.Status: "1";
            model.OrderNo = model.OrderNo>0? model.OrderNo: 1;
			model.CreateDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tabPosition(");			
            strSql.Append("PositionName,PositionDesc,WordAddress,NeedNum,DeptID,PubOrgID,ReportObj,OrgNum,SalaryBein,SalaryEnd,PositionEdge,PostionReason,CommissionType,PriceCommission,PricePre,PriceInterview,PriceJoinWork,PriceGetWork,SafeDay,RequireContent,RequireEdu,RequireAbility,RequireExperience,RequireYear,RequireProject,AdditionInfo,PositionInitFile,PositionPdfFile,PositionSourceUrl,PositionSourceText,PubDate,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
			strSql.Append(") values (");
            strSql.Append("SQL2012PositionName,SQL2012PositionDesc,SQL2012WordAddress,SQL2012NeedNum,SQL2012DeptID,SQL2012PubOrgID,SQL2012ReportObj,SQL2012OrgNum,SQL2012SalaryBein,SQL2012SalaryEnd,SQL2012PositionEdge,SQL2012PostionReason,SQL2012CommissionType,SQL2012PriceCommission,SQL2012PricePre,SQL2012PriceInterview,SQL2012PriceJoinWork,SQL2012PriceGetWork,SQL2012SafeDay,SQL2012RequireContent,SQL2012RequireEdu,SQL2012RequireAbility,SQL2012RequireExperience,SQL2012RequireYear,SQL2012RequireProject,SQL2012AdditionInfo,SQL2012PositionInitFile,SQL2012PositionPdfFile,SQL2012PositionSourceUrl,SQL2012PositionSourceText,SQL2012PubDate,SQL2012AppID,SQL2012Version,SQL2012RandomNo,SQL2012ParentID,SQL2012Remark,SQL2012LableText,SQL2012ExJson,SQL2012Status,SQL2012OrderNo,SQL2012CreateDate,SQL2012ModifyDate,SQL2012CreateUser,SQL2012ModifyUser");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("SQL2012PositionName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012PositionDesc", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012WordAddress", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012NeedNum", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012DeptID", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012PubOrgID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012ReportObj", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OrgNum", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012SalaryBein", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012SalaryEnd", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionEdge", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012PostionReason", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012CommissionType", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PriceCommission", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PricePre", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PriceInterview", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PriceJoinWork", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PriceGetWork", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012SafeDay", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012RequireContent", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012RequireEdu", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012RequireAbility", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012RequireExperience", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012RequireYear", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012RequireProject", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012AdditionInfo", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012PositionInitFile", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionPdfFile", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionSourceUrl", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012PositionSourceText", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012PubDate", SqlDbType.NVarChar,50) ,            
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
			            
            parameters[0].Value = model.PositionName;                        
            parameters[1].Value = model.PositionDesc;                        
            parameters[2].Value = model.WordAddress;                        
            parameters[3].Value = model.NeedNum;                        
            parameters[4].Value = model.DeptID;                        
            parameters[5].Value = model.PubOrgID;                        
            parameters[6].Value = model.ReportObj;                        
            parameters[7].Value = model.OrgNum;                        
            parameters[8].Value = model.SalaryBein;                        
            parameters[9].Value = model.SalaryEnd;                        
            parameters[10].Value = model.PositionEdge;                        
            parameters[11].Value = model.PostionReason;                        
            parameters[12].Value = model.CommissionType;                        
            parameters[13].Value = model.PriceCommission;                        
            parameters[14].Value = model.PricePre;                        
            parameters[15].Value = model.PriceInterview;                        
            parameters[16].Value = model.PriceJoinWork;                        
            parameters[17].Value = model.PriceGetWork;                        
            parameters[18].Value = model.SafeDay;                        
            parameters[19].Value = model.RequireContent;                        
            parameters[20].Value = model.RequireEdu;                        
            parameters[21].Value = model.RequireAbility;                        
            parameters[22].Value = model.RequireExperience;                        
            parameters[23].Value = model.RequireYear;                        
            parameters[24].Value = model.RequireProject;                        
            parameters[25].Value = model.AdditionInfo;                        
            parameters[26].Value = model.PositionInitFile;                        
            parameters[27].Value = model.PositionPdfFile;                        
            parameters[28].Value = model.PositionSourceUrl;                        
            parameters[29].Value = model.PositionSourceText;                        
            parameters[30].Value = model.PubDate;                        
            parameters[31].Value = model.AppID;                        
            parameters[32].Value = model.Version;                        
            parameters[33].Value = model.RandomNo;                        
            parameters[34].Value = model.ParentID;                        
            parameters[35].Value = model.Remark;                        
            parameters[36].Value = model.LableText;                        
            parameters[37].Value = model.ExJson;                        
            parameters[38].Value = model.Status;                        
            parameters[39].Value = model.OrderNo;                        
            parameters[40].Value = model.CreateDate;                        
            parameters[41].Value = model.ModifyDate;                        
            parameters[42].Value = model.CreateUser;                        
            parameters[43].Value = model.ModifyUser;                        
			   
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
		public bool Update(tabPositionModel model)
		{
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabPosition set ");
			                        
            strSql.Append(" PositionName = SQL2012PositionName , ");                                    
            strSql.Append(" PositionDesc = SQL2012PositionDesc , ");                                    
            strSql.Append(" WordAddress = SQL2012WordAddress , ");                                    
            strSql.Append(" NeedNum = SQL2012NeedNum , ");                                    
            strSql.Append(" DeptID = SQL2012DeptID , ");                                    
            strSql.Append(" PubOrgID = SQL2012PubOrgID , ");                                    
            strSql.Append(" ReportObj = SQL2012ReportObj , ");                                    
            strSql.Append(" OrgNum = SQL2012OrgNum , ");                                    
            strSql.Append(" SalaryBein = SQL2012SalaryBein , ");                                    
            strSql.Append(" SalaryEnd = SQL2012SalaryEnd , ");                                    
            strSql.Append(" PositionEdge = SQL2012PositionEdge , ");                                    
            strSql.Append(" PostionReason = SQL2012PostionReason , ");                                    
            strSql.Append(" CommissionType = SQL2012CommissionType , ");                                    
            strSql.Append(" PriceCommission = SQL2012PriceCommission , ");                                    
            strSql.Append(" PricePre = SQL2012PricePre , ");                                    
            strSql.Append(" PriceInterview = SQL2012PriceInterview , ");                                    
            strSql.Append(" PriceJoinWork = SQL2012PriceJoinWork , ");                                    
            strSql.Append(" PriceGetWork = SQL2012PriceGetWork , ");                                    
            strSql.Append(" SafeDay = SQL2012SafeDay , ");                                    
            strSql.Append(" RequireContent = SQL2012RequireContent , ");                                    
            strSql.Append(" RequireEdu = SQL2012RequireEdu , ");                                    
            strSql.Append(" RequireAbility = SQL2012RequireAbility , ");                                    
            strSql.Append(" RequireExperience = SQL2012RequireExperience , ");                                    
            strSql.Append(" RequireYear = SQL2012RequireYear , ");                                    
            strSql.Append(" RequireProject = SQL2012RequireProject , ");                                    
            strSql.Append(" AdditionInfo = SQL2012AdditionInfo , ");                                    
            strSql.Append(" PositionInitFile = SQL2012PositionInitFile , ");                                    
            strSql.Append(" PositionPdfFile = SQL2012PositionPdfFile , ");                                    
            strSql.Append(" PositionSourceUrl = SQL2012PositionSourceUrl , ");                                    
            strSql.Append(" PositionSourceText = SQL2012PositionSourceText , ");                                    
            strSql.Append(" PubDate = SQL2012PubDate , ");                                                            
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
			            new SqlParameter("SQL2012PositionName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012PositionDesc", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012WordAddress", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012NeedNum", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012DeptID", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012PubOrgID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012ReportObj", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OrgNum", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012SalaryBein", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012SalaryEnd", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionEdge", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012PostionReason", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012CommissionType", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PriceCommission", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PricePre", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PriceInterview", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PriceJoinWork", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PriceGetWork", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012SafeDay", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012RequireContent", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012RequireEdu", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012RequireAbility", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012RequireExperience", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012RequireYear", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012RequireProject", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012AdditionInfo", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012PositionInitFile", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionPdfFile", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionSourceUrl", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012PositionSourceText", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012PubDate", SqlDbType.NVarChar,50) ,            
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
						            
            parameters[0].Value = model.PositionName;                        
            parameters[1].Value = model.PositionDesc;                        
            parameters[2].Value = model.WordAddress;                        
            parameters[3].Value = model.NeedNum;                        
            parameters[4].Value = model.DeptID;                        
            parameters[5].Value = model.PubOrgID;                        
            parameters[6].Value = model.ReportObj;                        
            parameters[7].Value = model.OrgNum;                        
            parameters[8].Value = model.SalaryBein;                        
            parameters[9].Value = model.SalaryEnd;                        
            parameters[10].Value = model.PositionEdge;                        
            parameters[11].Value = model.PostionReason;                        
            parameters[12].Value = model.CommissionType;                        
            parameters[13].Value = model.PriceCommission;                        
            parameters[14].Value = model.PricePre;                        
            parameters[15].Value = model.PriceInterview;                        
            parameters[16].Value = model.PriceJoinWork;                        
            parameters[17].Value = model.PriceGetWork;                        
            parameters[18].Value = model.SafeDay;                        
            parameters[19].Value = model.RequireContent;                        
            parameters[20].Value = model.RequireEdu;                        
            parameters[21].Value = model.RequireAbility;                        
            parameters[22].Value = model.RequireExperience;                        
            parameters[23].Value = model.RequireYear;                        
            parameters[24].Value = model.RequireProject;                        
            parameters[25].Value = model.AdditionInfo;                        
            parameters[26].Value = model.PositionInitFile;                        
            parameters[27].Value = model.PositionPdfFile;                        
            parameters[28].Value = model.PositionSourceUrl;                        
            parameters[29].Value = model.PositionSourceText;                        
            parameters[30].Value = model.PubDate;                        
            parameters[31].Value = model.id;                        
            parameters[32].Value = model.AppID;                        
            parameters[33].Value = model.Version;                        
            parameters[34].Value = model.RandomNo;                        
            parameters[35].Value = model.ParentID;                        
            parameters[36].Value = model.Remark;                        
            parameters[37].Value = model.LableText;                        
            parameters[38].Value = model.ExJson;                        
            parameters[39].Value = model.Status;                        
            parameters[40].Value = model.OrderNo;                        
            parameters[41].Value = model.CreateDate;                        
            parameters[42].Value = model.ModifyDate;                        
            parameters[43].Value = model.CreateUser;                        
            parameters[44].Value = model.ModifyUser;                        
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
			strSql.Append("update tabPosition set " + strValue);           
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(tabPositionModel model, List<string> ChangedFields)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabPosition set ");
			                        
            strSql.Append(" PositionName = SQL2012PositionName , ");                                    
            strSql.Append(" PositionDesc = SQL2012PositionDesc , ");                                    
            strSql.Append(" WordAddress = SQL2012WordAddress , ");                                    
            strSql.Append(" NeedNum = SQL2012NeedNum , ");                                    
            strSql.Append(" DeptID = SQL2012DeptID , ");                                    
            strSql.Append(" PubOrgID = SQL2012PubOrgID , ");                                    
            strSql.Append(" ReportObj = SQL2012ReportObj , ");                                    
            strSql.Append(" OrgNum = SQL2012OrgNum , ");                                    
            strSql.Append(" SalaryBein = SQL2012SalaryBein , ");                                    
            strSql.Append(" SalaryEnd = SQL2012SalaryEnd , ");                                    
            strSql.Append(" PositionEdge = SQL2012PositionEdge , ");                                    
            strSql.Append(" PostionReason = SQL2012PostionReason , ");                                    
            strSql.Append(" CommissionType = SQL2012CommissionType , ");                                    
            strSql.Append(" PriceCommission = SQL2012PriceCommission , ");                                    
            strSql.Append(" PricePre = SQL2012PricePre , ");                                    
            strSql.Append(" PriceInterview = SQL2012PriceInterview , ");                                    
            strSql.Append(" PriceJoinWork = SQL2012PriceJoinWork , ");                                    
            strSql.Append(" PriceGetWork = SQL2012PriceGetWork , ");                                    
            strSql.Append(" SafeDay = SQL2012SafeDay , ");                                    
            strSql.Append(" RequireContent = SQL2012RequireContent , ");                                    
            strSql.Append(" RequireEdu = SQL2012RequireEdu , ");                                    
            strSql.Append(" RequireAbility = SQL2012RequireAbility , ");                                    
            strSql.Append(" RequireExperience = SQL2012RequireExperience , ");                                    
            strSql.Append(" RequireYear = SQL2012RequireYear , ");                                    
            strSql.Append(" RequireProject = SQL2012RequireProject , ");                                    
            strSql.Append(" AdditionInfo = SQL2012AdditionInfo , ");                                    
            strSql.Append(" PositionInitFile = SQL2012PositionInitFile , ");                                    
            strSql.Append(" PositionPdfFile = SQL2012PositionPdfFile , ");                                    
            strSql.Append(" PositionSourceUrl = SQL2012PositionSourceUrl , ");                                    
            strSql.Append(" PositionSourceText = SQL2012PositionSourceText , ");                                    
            strSql.Append(" PubDate = SQL2012PubDate , ");                                                            
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
			            new SqlParameter("SQL2012PositionName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012PositionDesc", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012WordAddress", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012NeedNum", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012DeptID", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012PubOrgID", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012ReportObj", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012OrgNum", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012SalaryBein", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012SalaryEnd", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionEdge", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012PostionReason", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("SQL2012CommissionType", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PriceCommission", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PricePre", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PriceInterview", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PriceJoinWork", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PriceGetWork", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012SafeDay", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012RequireContent", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012RequireEdu", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012RequireAbility", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012RequireExperience", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012RequireYear", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012RequireProject", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012AdditionInfo", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("SQL2012PositionInitFile", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionPdfFile", SqlDbType.Int,4) ,            
                        new SqlParameter("SQL2012PositionSourceUrl", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("SQL2012PositionSourceText", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("SQL2012PubDate", SqlDbType.NVarChar,50) ,            
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
						            
            parameters[0].Value = model.PositionName;                        
            parameters[1].Value = model.PositionDesc;                        
            parameters[2].Value = model.WordAddress;                        
            parameters[3].Value = model.NeedNum;                        
            parameters[4].Value = model.DeptID;                        
            parameters[5].Value = model.PubOrgID;                        
            parameters[6].Value = model.ReportObj;                        
            parameters[7].Value = model.OrgNum;                        
            parameters[8].Value = model.SalaryBein;                        
            parameters[9].Value = model.SalaryEnd;                        
            parameters[10].Value = model.PositionEdge;                        
            parameters[11].Value = model.PostionReason;                        
            parameters[12].Value = model.CommissionType;                        
            parameters[13].Value = model.PriceCommission;                        
            parameters[14].Value = model.PricePre;                        
            parameters[15].Value = model.PriceInterview;                        
            parameters[16].Value = model.PriceJoinWork;                        
            parameters[17].Value = model.PriceGetWork;                        
            parameters[18].Value = model.SafeDay;                        
            parameters[19].Value = model.RequireContent;                        
            parameters[20].Value = model.RequireEdu;                        
            parameters[21].Value = model.RequireAbility;                        
            parameters[22].Value = model.RequireExperience;                        
            parameters[23].Value = model.RequireYear;                        
            parameters[24].Value = model.RequireProject;                        
            parameters[25].Value = model.AdditionInfo;                        
            parameters[26].Value = model.PositionInitFile;                        
            parameters[27].Value = model.PositionPdfFile;                        
            parameters[28].Value = model.PositionSourceUrl;                        
            parameters[29].Value = model.PositionSourceText;                        
            parameters[30].Value = model.PubDate;                        
            parameters[31].Value = model.id;                        
            parameters[32].Value = model.AppID;                        
            parameters[33].Value = model.Version;                        
            parameters[34].Value = model.RandomNo;                        
            parameters[35].Value = model.ParentID;                        
            parameters[36].Value = model.Remark;                        
            parameters[37].Value = model.LableText;                        
            parameters[38].Value = model.ExJson;                        
            parameters[39].Value = model.Status;                        
            parameters[40].Value = model.OrderNo;                        
            parameters[41].Value = model.CreateDate;                        
            parameters[42].Value = model.ModifyDate;                        
            parameters[43].Value = model.CreateUser;                        
            parameters[44].Value = model.ModifyUser;                        
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
			strSql.Append("delete from tabPosition ");
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
			strSql.Append("delete from tabPosition ");
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
		public tabPositionModel GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");			
			strSql.Append("  from tabPosition ");
			strSql.Append(" where id=SQL2012id");
						SqlParameter[] parameters = {
					new SqlParameter("SQL2012id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			
			tabPositionModel model=new tabPositionModel();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabPositionModel>.FillModel(ds.Tables[0].Rows[0]);
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
			strSql.Append(" FROM tabPosition ");
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
			strSql.Append(" FROM tabPosition ");
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
			strSql.Append(" FROM tabPosition ");
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
			strSql.Append(" FROM tabPosition as a  where  version=(select max(b.version)  from tabPosition  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabPosition as a  where  version=(select max(b.version)  from tabPosition  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabPosition as a  where  version=(select max(b.version)  from tabPosition  as b  where a.RandomNo =  b.RandomNo)");
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
	/// tabPosition
    /// </summary> 	
	public partial class tabPositionBLL
	{
        private readonly tabPositionSQLDAL dal=new tabPositionSQLDAL();
		public void tabPosition()
		{
		}
		public static tabPositionBLL Instance
        {
            get
            {
                return _Instance;
            }
            set { _Instance = value; }
        }private static tabPositionBLL _Instance;
        public static tabPositionBLL GetInstance()
        {
            if (Instance == null)
            {
                Instance = new tabPositionBLL();
            }
            return Instance;
        }
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id,int ParentID)
		{
			return dal.Exists(id,ParentID);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(tabPositionModel model)
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
		public bool Update(tabPositionModel model)
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
		public tabPositionModel GetModel(int id)
		{
			
			return dal.GetModel(id);
		}	
		/// <summary>
		/// 得到对象列表中第一个对象实体
		/// </summary>
		public tabPositionModel GetModel(string _where,int Index)
		{
			List<tabPositionModel> lsmodel = GetModelList(_where);
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
        public List<tabPositionModel> GetModelList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            DataSet ds = dal.GetList(pageSize, pageIndex, strWhere, filedOrder, out recordCount);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabPositionModel>.FillModel(ds.Tables[0]);
            else
                return new List<tabPositionModel>();
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
		public List<tabPositionModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabPositionModel>.FillModel(ds.Tables[0]);
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
		public List<tabPositionModel> GetModelListVersion(string strWhere)
		{
			DataSet ds = dal.GetListVersion(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabPositionModel>.FillModel(ds.Tables[0]);
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
