
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
            strSql.Append("PositionID,PositionName,CreateUser,CreateDate,ParentID,OrgName,OrgPro,OrgScale,WordAddress,SalaryBein,SalaryEnd,AgeBein,AgeEnd,RequireWorkYear,RequireSchool,RequireMajor,RequireXueLi,RequireSkill,RequireCoreSkill,AppID,Version,RandomNo,Remark,LableText,ExJson,Status,OrderNo,ModifyDate,ModifyUser");
			strSql.Append(") values (");
            strSql.Append("@PositionID,@PositionName,@CreateUser,@CreateDate,@ParentID,@OrgName,@OrgPro,@OrgScale,@WordAddress,@SalaryBein,@SalaryEnd,@AgeBein,@AgeEnd,@RequireWorkYear,@RequireSchool,@RequireMajor,@RequireXueLi,@RequireSkill,@RequireCoreSkill,@AppID,@Version,@RandomNo,@Remark,@LableText,@ExJson,@Status,@OrderNo,@ModifyDate,@ModifyUser");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@PositionID", SqlDbType.Int,4) ,            
                        new SqlParameter("@PositionName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@CreateUser", SqlDbType.Int,4) ,            
                        new SqlParameter("@CreateDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("@OrgName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@OrgPro", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@OrgScale", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@WordAddress", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@SalaryBein", SqlDbType.Int,4) ,            
                        new SqlParameter("@SalaryEnd", SqlDbType.Int,4) ,            
                        new SqlParameter("@AgeBein", SqlDbType.NChar,10) ,            
                        new SqlParameter("@AgeEnd", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@RequireWorkYear", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@RequireSchool", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@RequireMajor", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@RequireXueLi", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@RequireSkill", SqlDbType.NText) ,            
                        new SqlParameter("@RequireCoreSkill", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@AppID", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@Version", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@RandomNo", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@Remark", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@LableText", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@ExJson", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@Status", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@OrderNo", SqlDbType.Int,4) ,            
                        new SqlParameter("@ModifyDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ModifyUser", SqlDbType.Int,4)             
              
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
            parameters[19].Value = model.AppID;                        
            parameters[20].Value = model.Version;                        
            parameters[21].Value = model.RandomNo;                        
            parameters[22].Value = model.Remark;                        
            parameters[23].Value = model.LableText;                        
            parameters[24].Value = model.ExJson;                        
            parameters[25].Value = model.Status;                        
            parameters[26].Value = model.OrderNo;                        
            parameters[27].Value = model.ModifyDate;                        
            parameters[28].Value = model.ModifyUser;                        
			   
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
			                                                
            strSql.Append(" PositionID = @PositionID , ");                                    
            strSql.Append(" PositionName = @PositionName , ");                                    
            strSql.Append(" CreateUser = @CreateUser , ");                                    
            strSql.Append(" CreateDate = @CreateDate , ");                                    
            strSql.Append(" ParentID = @ParentID , ");                                    
            strSql.Append(" OrgName = @OrgName , ");                                    
            strSql.Append(" OrgPro = @OrgPro , ");                                    
            strSql.Append(" OrgScale = @OrgScale , ");                                    
            strSql.Append(" WordAddress = @WordAddress , ");                                    
            strSql.Append(" SalaryBein = @SalaryBein , ");                                    
            strSql.Append(" SalaryEnd = @SalaryEnd , ");                                    
            strSql.Append(" AgeBein = @AgeBein , ");                                    
            strSql.Append(" AgeEnd = @AgeEnd , ");                                    
            strSql.Append(" RequireWorkYear = @RequireWorkYear , ");                                    
            strSql.Append(" RequireSchool = @RequireSchool , ");                                    
            strSql.Append(" RequireMajor = @RequireMajor , ");                                    
            strSql.Append(" RequireXueLi = @RequireXueLi , ");                                    
            strSql.Append(" RequireSkill = @RequireSkill , ");                                    
            strSql.Append(" RequireCoreSkill = @RequireCoreSkill , ");                                    
            strSql.Append(" AppID = @AppID , ");                                    
            strSql.Append(" Version = @Version , ");                                    
            strSql.Append(" RandomNo = @RandomNo , ");                                    
            strSql.Append(" Remark = @Remark , ");                                    
            strSql.Append(" LableText = @LableText , ");                                    
            strSql.Append(" ExJson = @ExJson , ");                                    
            strSql.Append(" Status = @Status , ");                                    
            strSql.Append(" OrderNo = @OrderNo , ");                                    
            strSql.Append(" ModifyDate = @ModifyDate , ");                                    
            strSql.Append(" ModifyUser = @ModifyUser  ");            			
			strSql.Append(" where id=@id ");
						
SqlParameter[] parameters = {
			            new SqlParameter("@id", SqlDbType.Int,4) ,            
                        new SqlParameter("@PositionID", SqlDbType.Int,4) ,            
                        new SqlParameter("@PositionName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@CreateUser", SqlDbType.Int,4) ,            
                        new SqlParameter("@CreateDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("@OrgName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@OrgPro", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@OrgScale", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@WordAddress", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@SalaryBein", SqlDbType.Int,4) ,            
                        new SqlParameter("@SalaryEnd", SqlDbType.Int,4) ,            
                        new SqlParameter("@AgeBein", SqlDbType.NChar,10) ,            
                        new SqlParameter("@AgeEnd", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@RequireWorkYear", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@RequireSchool", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@RequireMajor", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@RequireXueLi", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@RequireSkill", SqlDbType.NText) ,            
                        new SqlParameter("@RequireCoreSkill", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@AppID", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@Version", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@RandomNo", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@Remark", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@LableText", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@ExJson", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@Status", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@OrderNo", SqlDbType.Int,4) ,            
                        new SqlParameter("@ModifyDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ModifyUser", SqlDbType.Int,4)             
              
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
            parameters[20].Value = model.AppID;                        
            parameters[21].Value = model.Version;                        
            parameters[22].Value = model.RandomNo;                        
            parameters[23].Value = model.Remark;                        
            parameters[24].Value = model.LableText;                        
            parameters[25].Value = model.ExJson;                        
            parameters[26].Value = model.Status;                        
            parameters[27].Value = model.OrderNo;                        
            parameters[28].Value = model.ModifyDate;                        
            parameters[29].Value = model.ModifyUser;                        
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
			                                                
            strSql.Append(" PositionID = @PositionID , ");                                    
            strSql.Append(" PositionName = @PositionName , ");                                    
            strSql.Append(" CreateUser = @CreateUser , ");                                    
            strSql.Append(" CreateDate = @CreateDate , ");                                    
            strSql.Append(" ParentID = @ParentID , ");                                    
            strSql.Append(" OrgName = @OrgName , ");                                    
            strSql.Append(" OrgPro = @OrgPro , ");                                    
            strSql.Append(" OrgScale = @OrgScale , ");                                    
            strSql.Append(" WordAddress = @WordAddress , ");                                    
            strSql.Append(" SalaryBein = @SalaryBein , ");                                    
            strSql.Append(" SalaryEnd = @SalaryEnd , ");                                    
            strSql.Append(" AgeBein = @AgeBein , ");                                    
            strSql.Append(" AgeEnd = @AgeEnd , ");                                    
            strSql.Append(" RequireWorkYear = @RequireWorkYear , ");                                    
            strSql.Append(" RequireSchool = @RequireSchool , ");                                    
            strSql.Append(" RequireMajor = @RequireMajor , ");                                    
            strSql.Append(" RequireXueLi = @RequireXueLi , ");                                    
            strSql.Append(" RequireSkill = @RequireSkill , ");                                    
            strSql.Append(" RequireCoreSkill = @RequireCoreSkill , ");                                    
            strSql.Append(" AppID = @AppID , ");                                    
            strSql.Append(" Version = @Version , ");                                    
            strSql.Append(" RandomNo = @RandomNo , ");                                    
            strSql.Append(" Remark = @Remark , ");                                    
            strSql.Append(" LableText = @LableText , ");                                    
            strSql.Append(" ExJson = @ExJson , ");                                    
            strSql.Append(" Status = @Status , ");                                    
            strSql.Append(" OrderNo = @OrderNo , ");                                    
            strSql.Append(" ModifyDate = @ModifyDate , ");                                    
            strSql.Append(" ModifyUser = @ModifyUser  ");            			
			strSql.Append(" where id=@id ");						
SqlParameter[] parameters = {
			            new SqlParameter("@id", SqlDbType.Int,4) ,            
                        new SqlParameter("@PositionID", SqlDbType.Int,4) ,            
                        new SqlParameter("@PositionName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@CreateUser", SqlDbType.Int,4) ,            
                        new SqlParameter("@CreateDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ParentID", SqlDbType.Int,4) ,            
                        new SqlParameter("@OrgName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@OrgPro", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@OrgScale", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@WordAddress", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@SalaryBein", SqlDbType.Int,4) ,            
                        new SqlParameter("@SalaryEnd", SqlDbType.Int,4) ,            
                        new SqlParameter("@AgeBein", SqlDbType.NChar,10) ,            
                        new SqlParameter("@AgeEnd", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@RequireWorkYear", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@RequireSchool", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@RequireMajor", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@RequireXueLi", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@RequireSkill", SqlDbType.NText) ,            
                        new SqlParameter("@RequireCoreSkill", SqlDbType.NVarChar,500) ,            
                        new SqlParameter("@AppID", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@Version", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@RandomNo", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@Remark", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@LableText", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@ExJson", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@Status", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@OrderNo", SqlDbType.Int,4) ,            
                        new SqlParameter("@ModifyDate", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@ModifyUser", SqlDbType.Int,4)             
              
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
            parameters[20].Value = model.AppID;                        
            parameters[21].Value = model.Version;                        
            parameters[22].Value = model.RandomNo;                        
            parameters[23].Value = model.Remark;                        
            parameters[24].Value = model.LableText;                        
            parameters[25].Value = model.ExJson;                        
            parameters[26].Value = model.Status;                        
            parameters[27].Value = model.OrderNo;                        
            parameters[28].Value = model.ModifyDate;                        
            parameters[29].Value = model.ModifyUser;                        
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
			strSql.Append(" where id=@id");
						SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
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
