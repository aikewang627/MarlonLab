﻿
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
#region  Model 实体类- tabResume
namespace Tclywork.Model{
	[Serializable]
	/// <summary>
	/// 简历表
    /// </summary> 	
	public partial class tabResumeModel
	{   		     
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
			/// 用户编号
	        /// </summary>
	        
	        public int UserID
	        {
	            get{ return _UserID; }
	            set{ _UserID = value;}
	        }private int _UserID;
				        
							/// <summary>
			/// 是否自己的简历，在创建简历的时候自动作出判断
	        /// </summary>
	        
	        public bool IsMe
	        {
	            get{ return _IsMe; }
	            set{ _IsMe = value;}
	        }private bool _IsMe;
				        
							/// <summary>
			/// 是否公开联系方式
	        /// </summary>
	        
	        public bool IsDisplayRealName
	        {
	            get{ return _IsDisplayRealName; }
	            set{ _IsDisplayRealName = value;}
	        }private bool _IsDisplayRealName;
				        
							/// <summary>
			/// 最近职位
	        /// </summary>
	        
	        public string CurPosition
	        {
	            get{ return _CurPosition; }
	            set{ _CurPosition = value;}
	        }private string _CurPosition;
				        
							/// <summary>
			/// 目前年薪
	        /// </summary>
	        
	        public decimal CurSalary
	        {
	            get{ return _CurSalary; }
	            set{ _CurSalary = value;}
	        }private decimal _CurSalary;
				        
							/// <summary>
			/// 当前公司名称
	        /// </summary>
	        
	        public string CurComapny
	        {
	            get{ return _CurComapny; }
	            set{ _CurComapny = value;}
	        }private string _CurComapny;
				        
							/// <summary>
			/// 当前行业职能
	        /// </summary>
	        
	        public string CurIndustry
	        {
	            get{ return _CurIndustry; }
	            set{ _CurIndustry = value;}
	        }private string _CurIndustry;
				        
							/// <summary>
			/// 求职状态
	        /// </summary>
	        
	        public string CurStatus
	        {
	            get{ return _CurStatus; }
	            set{ _CurStatus = value;}
	        }private string _CurStatus;
				        
							/// <summary>
			/// 目前居住地
	        /// </summary>
	        
	        public string CurAddress
	        {
	            get{ return _CurAddress; }
	            set{ _CurAddress = value;}
	        }private string _CurAddress;
				        
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
			/// 猎手评价
	        /// </summary>
	        
	        public string HunterComment
	        {
	            get{ return _HunterComment; }
	            set{ _HunterComment = value;}
	        }private string _HunterComment;
				        
							/// <summary>
			/// 简历原始文档
	        /// </summary>
	        
	        public int ResumeInitFile
	        {
	            get{ return _ResumeInitFile; }
	            set{ _ResumeInitFile = value;}
	        }private int _ResumeInitFile;
				        
							/// <summary>
			/// ResumePDFFile
	        /// </summary>
	        
	        public int ResumePDFFile
	        {
	            get{ return _ResumePDFFile; }
	            set{ _ResumePDFFile = value;}
	        }private int _ResumePDFFile;
				        
							/// <summary>
			/// 其他信息
	        /// </summary>
	        
	        public string Other
	        {
	            get{ return _Other; }
	            set{ _Other = value;}
	        }private string _Other;
				        
							/// <summary>
			/// 建立购买单价，单位：分
	        /// </summary>
	        
	        public int Price
	        {
	            get{ return _Price; }
	            set{ _Price = value;}
	        }private int _Price;
				        
							/// <summary>
			/// 职位来源URL，如国际机器人大会URL
	        /// </summary>
	        
	        public string SourceUrl
	        {
	            get{ return _SourceUrl; }
	            set{ _SourceUrl = value;}
	        }private string _SourceUrl;
				        
							/// <summary>
			/// 职位来源文本，如国际机器人大会
	        /// </summary>
	        
	        public string SourceText
	        {
	            get{ return _SourceText; }
	            set{ _SourceText = value;}
	        }private string _SourceText;
				        
							/// <summary>
			/// 简历标签
	        /// </summary>
	        
	        public string Tags
	        {
	            get{ return _Tags; }
	            set{ _Tags = value;}
	        }private string _Tags;
				        
							/// <summary>
			/// 语言能力
	        /// </summary>
	        
	        public string Lang
	        {
	            get{ return _Lang; }
	            set{ _Lang = value;}
	        }private string _Lang;
				        
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
			/// 简历标签
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
	/// 简历表
    /// </summary> 	
	public partial class tabResumeSQLDAL
	{
		#region 实现方法
   		 /// <summary>
		/// 是否存在
		/// </summary>    
		public bool Exists(string ResumeNo,string ResumeName,bool IsMe,string CurPosition,string CurStatus,string HopeAddress,string HopePosition,string HopeIndustry,int id,int ParentID,int CreateUser)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tabResume");
			strSql.Append(" where ");
			                        strSql.Append(" ResumeNo = @ResumeNo and  ");
                                                    strSql.Append(" ResumeName = @ResumeName and  ");
                                                    strSql.Append(" IsMe = @IsMe and  ");
                                                    strSql.Append(" CurPosition = @CurPosition and  ");
                                                    strSql.Append(" CurStatus = @CurStatus and  ");
                                                    strSql.Append(" HopeAddress = @HopeAddress and  ");
                                                    strSql.Append(" HopePosition = @HopePosition and  ");
                                                    strSql.Append(" HopeIndustry = @HopeIndustry and  ");
                                                    strSql.Append(" id = @id and  ");
                                                    strSql.Append(" ParentID = @ParentID and  ");
                                                    strSql.Append(" CreateUser = @CreateUser  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("@ResumeNo", SqlDbType.NVarChar,50),
					new SqlParameter("@ResumeName", SqlDbType.NVarChar,50),
					new SqlParameter("@IsMe", SqlDbType.Bit,1),
					new SqlParameter("@CurPosition", SqlDbType.NVarChar,50),
					new SqlParameter("@CurStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@HopeAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@HopePosition", SqlDbType.NVarChar,50),
					new SqlParameter("@HopeIndustry", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@CreateUser", SqlDbType.Int,4)			};
			parameters[0].Value = ResumeNo;
			parameters[1].Value = ResumeName;
			parameters[2].Value = IsMe;
			parameters[3].Value = CurPosition;
			parameters[4].Value = CurStatus;
			parameters[5].Value = HopeAddress;
			parameters[6].Value = HopePosition;
			parameters[7].Value = HopeIndustry;
			parameters[8].Value = id;
			parameters[9].Value = ParentID;
			parameters[10].Value = CreateUser;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(tabResumeModel model)
		{
		 	model.Version = model.Version.IsNotNullOrEmpty()? model.Version: "1";
            model.RandomNo = model.RandomNo.IsNotNullOrEmpty()? model.RandomNo: Guid.NewGuid().ToString("N");
            model.Status = model.Status.IsNotNullOrEmpty()? model.Status: "1";
            model.OrderNo = model.OrderNo>0? model.OrderNo: 1;
			model.CreateDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tabResume(");			
            strSql.Append("ResumeNo,ResumeName,UserID,IsMe,IsDisplayRealName,CurPosition,CurSalary,CurComapny,CurIndustry,CurStatus,CurAddress,HopeAddress,HopePosition,HopeIndustry,HopeSalary,HunterComment,ResumeInitFile,ResumePDFFile,Other,Price,SourceUrl,SourceText,Tags,Lang,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
			strSql.Append(") values (");
            strSql.Append("@ResumeNo,@ResumeName,@UserID,@IsMe,@IsDisplayRealName,@CurPosition,@CurSalary,@CurComapny,@CurIndustry,@CurStatus,@CurAddress,@HopeAddress,@HopePosition,@HopeIndustry,@HopeSalary,@HunterComment,@ResumeInitFile,@ResumePDFFile,@Other,@Price,@SourceUrl,@SourceText,@Tags,@Lang,@AppID,@Version,@RandomNo,@ParentID,@Remark,@LableText,@ExJson,@Status,@OrderNo,@CreateDate,@ModifyDate,@CreateUser,@ModifyUser");            
            strSql.Append(") ");            
            strSql.Append(";select @@IDENTITY");		
			SqlParameter[] parameters = {
			            new SqlParameter("@ResumeNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ResumeName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@UserID", SqlDbType.Int,4) ,            
                        new SqlParameter("@IsMe", SqlDbType.Bit,1) ,            
                        new SqlParameter("@IsDisplayRealName", SqlDbType.Bit,1) ,            
                        new SqlParameter("@CurPosition", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@CurSalary", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@CurComapny", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@CurIndustry", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@CurStatus", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@CurAddress", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@HopeAddress", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@HopePosition", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@HopeIndustry", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@HopeSalary", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@HunterComment", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@ResumeInitFile", SqlDbType.Int,4) ,            
                        new SqlParameter("@ResumePDFFile", SqlDbType.Int,4) ,            
                        new SqlParameter("@Other", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@Price", SqlDbType.Int,4) ,            
                        new SqlParameter("@SourceUrl", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@SourceText", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Tags", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Lang", SqlDbType.NVarChar,50) ,            
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
			            
            parameters[0].Value = model.ResumeNo;                        
            parameters[1].Value = model.ResumeName;                        
            parameters[2].Value = model.UserID;                        
            parameters[3].Value = model.IsMe;                        
            parameters[4].Value = model.IsDisplayRealName;                        
            parameters[5].Value = model.CurPosition;                        
            parameters[6].Value = model.CurSalary;                        
            parameters[7].Value = model.CurComapny;                        
            parameters[8].Value = model.CurIndustry;                        
            parameters[9].Value = model.CurStatus;                        
            parameters[10].Value = model.CurAddress;                        
            parameters[11].Value = model.HopeAddress;                        
            parameters[12].Value = model.HopePosition;                        
            parameters[13].Value = model.HopeIndustry;                        
            parameters[14].Value = model.HopeSalary;                        
            parameters[15].Value = model.HunterComment;                        
            parameters[16].Value = model.ResumeInitFile;                        
            parameters[17].Value = model.ResumePDFFile;                        
            parameters[18].Value = model.Other;                        
            parameters[19].Value = model.Price;                        
            parameters[20].Value = model.SourceUrl;                        
            parameters[21].Value = model.SourceText;                        
            parameters[22].Value = model.Tags;                        
            parameters[23].Value = model.Lang;                        
            parameters[24].Value = model.AppID;                        
            parameters[25].Value = model.Version;                        
            parameters[26].Value = model.RandomNo;                        
            parameters[27].Value = model.ParentID;                        
            parameters[28].Value = model.Remark;                        
            parameters[29].Value = model.LableText;                        
            parameters[30].Value = model.ExJson;                        
            parameters[31].Value = model.Status;                        
            parameters[32].Value = model.OrderNo;                        
            parameters[33].Value = model.CreateDate;                        
            parameters[34].Value = model.ModifyDate;                        
            parameters[35].Value = model.CreateUser;                        
            parameters[36].Value = model.ModifyUser;                        
			   
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
		public bool Update(tabResumeModel model)
		{
			model.ModifyDate=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabResume set ");
			                        
            strSql.Append(" ResumeNo = @ResumeNo , ");                                    
            strSql.Append(" ResumeName = @ResumeName , ");                                    
            strSql.Append(" UserID = @UserID , ");                                    
            strSql.Append(" IsMe = @IsMe , ");                                    
            strSql.Append(" IsDisplayRealName = @IsDisplayRealName , ");                                    
            strSql.Append(" CurPosition = @CurPosition , ");                                    
            strSql.Append(" CurSalary = @CurSalary , ");                                    
            strSql.Append(" CurComapny = @CurComapny , ");                                    
            strSql.Append(" CurIndustry = @CurIndustry , ");                                    
            strSql.Append(" CurStatus = @CurStatus , ");                                    
            strSql.Append(" CurAddress = @CurAddress , ");                                    
            strSql.Append(" HopeAddress = @HopeAddress , ");                                    
            strSql.Append(" HopePosition = @HopePosition , ");                                    
            strSql.Append(" HopeIndustry = @HopeIndustry , ");                                    
            strSql.Append(" HopeSalary = @HopeSalary , ");                                    
            strSql.Append(" HunterComment = @HunterComment , ");                                    
            strSql.Append(" ResumeInitFile = @ResumeInitFile , ");                                    
            strSql.Append(" ResumePDFFile = @ResumePDFFile , ");                                    
            strSql.Append(" Other = @Other , ");                                    
            strSql.Append(" Price = @Price , ");                                    
            strSql.Append(" SourceUrl = @SourceUrl , ");                                    
            strSql.Append(" SourceText = @SourceText , ");                                    
            strSql.Append(" Tags = @Tags , ");                                    
            strSql.Append(" Lang = @Lang , ");                                                            
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
			            new SqlParameter("@ResumeNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ResumeName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@UserID", SqlDbType.Int,4) ,            
                        new SqlParameter("@IsMe", SqlDbType.Bit,1) ,            
                        new SqlParameter("@IsDisplayRealName", SqlDbType.Bit,1) ,            
                        new SqlParameter("@CurPosition", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@CurSalary", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@CurComapny", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@CurIndustry", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@CurStatus", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@CurAddress", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@HopeAddress", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@HopePosition", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@HopeIndustry", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@HopeSalary", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@HunterComment", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@ResumeInitFile", SqlDbType.Int,4) ,            
                        new SqlParameter("@ResumePDFFile", SqlDbType.Int,4) ,            
                        new SqlParameter("@Other", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@Price", SqlDbType.Int,4) ,            
                        new SqlParameter("@SourceUrl", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@SourceText", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Tags", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Lang", SqlDbType.NVarChar,50) ,            
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
						            
            parameters[0].Value = model.ResumeNo;                        
            parameters[1].Value = model.ResumeName;                        
            parameters[2].Value = model.UserID;                        
            parameters[3].Value = model.IsMe;                        
            parameters[4].Value = model.IsDisplayRealName;                        
            parameters[5].Value = model.CurPosition;                        
            parameters[6].Value = model.CurSalary;                        
            parameters[7].Value = model.CurComapny;                        
            parameters[8].Value = model.CurIndustry;                        
            parameters[9].Value = model.CurStatus;                        
            parameters[10].Value = model.CurAddress;                        
            parameters[11].Value = model.HopeAddress;                        
            parameters[12].Value = model.HopePosition;                        
            parameters[13].Value = model.HopeIndustry;                        
            parameters[14].Value = model.HopeSalary;                        
            parameters[15].Value = model.HunterComment;                        
            parameters[16].Value = model.ResumeInitFile;                        
            parameters[17].Value = model.ResumePDFFile;                        
            parameters[18].Value = model.Other;                        
            parameters[19].Value = model.Price;                        
            parameters[20].Value = model.SourceUrl;                        
            parameters[21].Value = model.SourceText;                        
            parameters[22].Value = model.Tags;                        
            parameters[23].Value = model.Lang;                        
            parameters[24].Value = model.id;                        
            parameters[25].Value = model.AppID;                        
            parameters[26].Value = model.Version;                        
            parameters[27].Value = model.RandomNo;                        
            parameters[28].Value = model.ParentID;                        
            parameters[29].Value = model.Remark;                        
            parameters[30].Value = model.LableText;                        
            parameters[31].Value = model.ExJson;                        
            parameters[32].Value = model.Status;                        
            parameters[33].Value = model.OrderNo;                        
            parameters[34].Value = model.CreateDate;                        
            parameters[35].Value = model.ModifyDate;                        
            parameters[36].Value = model.CreateUser;                        
            parameters[37].Value = model.ModifyUser;                        
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
			strSql.Append("update tabResume set " + strValue);           
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(tabResumeModel model, List<string> ChangedFields)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tabResume set ");
			                        
            strSql.Append(" ResumeNo = @ResumeNo , ");                                    
            strSql.Append(" ResumeName = @ResumeName , ");                                    
            strSql.Append(" UserID = @UserID , ");                                    
            strSql.Append(" IsMe = @IsMe , ");                                    
            strSql.Append(" IsDisplayRealName = @IsDisplayRealName , ");                                    
            strSql.Append(" CurPosition = @CurPosition , ");                                    
            strSql.Append(" CurSalary = @CurSalary , ");                                    
            strSql.Append(" CurComapny = @CurComapny , ");                                    
            strSql.Append(" CurIndustry = @CurIndustry , ");                                    
            strSql.Append(" CurStatus = @CurStatus , ");                                    
            strSql.Append(" CurAddress = @CurAddress , ");                                    
            strSql.Append(" HopeAddress = @HopeAddress , ");                                    
            strSql.Append(" HopePosition = @HopePosition , ");                                    
            strSql.Append(" HopeIndustry = @HopeIndustry , ");                                    
            strSql.Append(" HopeSalary = @HopeSalary , ");                                    
            strSql.Append(" HunterComment = @HunterComment , ");                                    
            strSql.Append(" ResumeInitFile = @ResumeInitFile , ");                                    
            strSql.Append(" ResumePDFFile = @ResumePDFFile , ");                                    
            strSql.Append(" Other = @Other , ");                                    
            strSql.Append(" Price = @Price , ");                                    
            strSql.Append(" SourceUrl = @SourceUrl , ");                                    
            strSql.Append(" SourceText = @SourceText , ");                                    
            strSql.Append(" Tags = @Tags , ");                                    
            strSql.Append(" Lang = @Lang , ");                                                            
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
			            new SqlParameter("@ResumeNo", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@ResumeName", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@UserID", SqlDbType.Int,4) ,            
                        new SqlParameter("@IsMe", SqlDbType.Bit,1) ,            
                        new SqlParameter("@IsDisplayRealName", SqlDbType.Bit,1) ,            
                        new SqlParameter("@CurPosition", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@CurSalary", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@CurComapny", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@CurIndustry", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@CurStatus", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@CurAddress", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@HopeAddress", SqlDbType.NVarChar,100) ,            
                        new SqlParameter("@HopePosition", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@HopeIndustry", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@HopeSalary", SqlDbType.Decimal,9) ,            
                        new SqlParameter("@HunterComment", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@ResumeInitFile", SqlDbType.Int,4) ,            
                        new SqlParameter("@ResumePDFFile", SqlDbType.Int,4) ,            
                        new SqlParameter("@Other", SqlDbType.NVarChar,-1) ,            
                        new SqlParameter("@Price", SqlDbType.Int,4) ,            
                        new SqlParameter("@SourceUrl", SqlDbType.NVarChar,200) ,            
                        new SqlParameter("@SourceText", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Tags", SqlDbType.NVarChar,50) ,            
                        new SqlParameter("@Lang", SqlDbType.NVarChar,50) ,            
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
						            
            parameters[0].Value = model.ResumeNo;                        
            parameters[1].Value = model.ResumeName;                        
            parameters[2].Value = model.UserID;                        
            parameters[3].Value = model.IsMe;                        
            parameters[4].Value = model.IsDisplayRealName;                        
            parameters[5].Value = model.CurPosition;                        
            parameters[6].Value = model.CurSalary;                        
            parameters[7].Value = model.CurComapny;                        
            parameters[8].Value = model.CurIndustry;                        
            parameters[9].Value = model.CurStatus;                        
            parameters[10].Value = model.CurAddress;                        
            parameters[11].Value = model.HopeAddress;                        
            parameters[12].Value = model.HopePosition;                        
            parameters[13].Value = model.HopeIndustry;                        
            parameters[14].Value = model.HopeSalary;                        
            parameters[15].Value = model.HunterComment;                        
            parameters[16].Value = model.ResumeInitFile;                        
            parameters[17].Value = model.ResumePDFFile;                        
            parameters[18].Value = model.Other;                        
            parameters[19].Value = model.Price;                        
            parameters[20].Value = model.SourceUrl;                        
            parameters[21].Value = model.SourceText;                        
            parameters[22].Value = model.Tags;                        
            parameters[23].Value = model.Lang;                        
            parameters[24].Value = model.id;                        
            parameters[25].Value = model.AppID;                        
            parameters[26].Value = model.Version;                        
            parameters[27].Value = model.RandomNo;                        
            parameters[28].Value = model.ParentID;                        
            parameters[29].Value = model.Remark;                        
            parameters[30].Value = model.LableText;                        
            parameters[31].Value = model.ExJson;                        
            parameters[32].Value = model.Status;                        
            parameters[33].Value = model.OrderNo;                        
            parameters[34].Value = model.CreateDate;                        
            parameters[35].Value = model.ModifyDate;                        
            parameters[36].Value = model.CreateUser;                        
            parameters[37].Value = model.ModifyUser;                        
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
			strSql.Append("delete from tabResume ");
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
			strSql.Append("delete from tabResume ");
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
		public tabResumeModel GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");			
			strSql.Append("  from tabResume ");
			strSql.Append(" where id=@id");
						SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			
			tabResumeModel model=new tabResumeModel();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabResumeModel>.FillModel(ds.Tables[0].Rows[0]);
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
			strSql.Append(" FROM tabResume ");
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
			strSql.Append(" FROM tabResume ");
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
			strSql.Append(" FROM tabResume ");
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
			strSql.Append(" FROM tabResume as a  where  version=(select max(b.version)  from tabResume  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabResume as a  where  version=(select max(b.version)  from tabResume  as b  where a.RandomNo =  b.RandomNo) ");
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
			strSql.Append(" FROM tabResume as a  where  version=(select max(b.version)  from tabResume  as b  where a.RandomNo =  b.RandomNo)");
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
	/// 简历表
    /// </summary> 	
	public partial class tabResumeBLL
	{
        private readonly tabResumeSQLDAL dal=new tabResumeSQLDAL();
		public void tabResume()
		{
		}
		public static tabResumeBLL Instance
        {
            get
            {
                return _Instance;
            }
            set { _Instance = value; }
        }private static tabResumeBLL _Instance;
        public static tabResumeBLL GetInstance()
        {
            if (Instance == null)
            {
                Instance = new tabResumeBLL();
            }
            return Instance;
        }
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ResumeNo,string ResumeName,bool IsMe,string CurPosition,string CurStatus,string HopeAddress,string HopePosition,string HopeIndustry,int id,int ParentID,int CreateUser)
		{
			return dal.Exists(ResumeNo,ResumeName,IsMe,CurPosition,CurStatus,HopeAddress,HopePosition,HopeIndustry,id,ParentID,CreateUser);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(tabResumeModel model)
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
		public bool Update(tabResumeModel model)
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
		public tabResumeModel GetModel(int id)
		{
			
			return dal.GetModel(id);
		}	
		/// <summary>
		/// 得到对象列表中第一个对象实体
		/// </summary>
		public tabResumeModel GetModel(string _where,int Index)
		{
			List<tabResumeModel> lsmodel = GetModelList(_where);
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
        public List<tabResumeModel> GetModelList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            DataSet ds = dal.GetList(pageSize, pageIndex, strWhere, filedOrder, out recordCount);
            if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabResumeModel>.FillModel(ds.Tables[0]);
            else
                return new List<tabResumeModel>();
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
		public List<tabResumeModel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabResumeModel>.FillModel(ds.Tables[0]);
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
		public List<tabResumeModel> GetModelListVersion(string strWhere)
		{
			DataSet ds = dal.GetListVersion(strWhere);
			if (ds.Tables[0].Rows.Count > 0)
                return ModelHandler<tabResumeModel>.FillModel(ds.Tables[0]);
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
