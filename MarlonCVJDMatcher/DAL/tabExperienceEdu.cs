using System; 
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.DBUtility;
namespace Maticsoft.DAL  
{
	 	//教育经历表
		public partial class tabExperienceEdu
	{
   		     
		public bool Exists(string SchoolName,string ProfessionalName,int GetEdu,int id,int ParentID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tabExperienceEdu");
			strSql.Append(" where ");
			                                       strSql.Append(" SchoolName = SQL2012SchoolName and  ");
                                                                   strSql.Append(" ProfessionalName = SQL2012ProfessionalName and  ");
                                                                   strSql.Append(" GetEdu = SQL2012GetEdu and  ");
                                                                   strSql.Append(" id = SQL2012id and  ");
                                                                   strSql.Append(" ParentID = SQL2012ParentID  ");
                            			SqlParameter[] parameters = {
					new SqlParameter("SQL2012SchoolName", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012ProfessionalName", SqlDbType.NVarChar,50),
					new SqlParameter("SQL2012GetEdu", SqlDbType.Int,4),
					new SqlParameter("SQL2012id", SqlDbType.Int,4),
					new SqlParameter("SQL2012ParentID", SqlDbType.Int,4)			};
			parameters[0].Value = SchoolName;
			parameters[1].Value = ProfessionalName;
			parameters[2].Value = GetEdu;
			parameters[3].Value = id;
			parameters[4].Value = ParentID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.tabExperienceEdu model)
		{
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
		public bool Update(Maticsoft.Model.tabExperienceEdu model)
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
		public Maticsoft.Model.tabExperienceEdu GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SchoolName, ProfessionalName, EduBeginDate, EduEndDate, GetEdu, IsTZ, Is211, IsVal, AddonInfo, id, AppID, Version, RandomNo, ParentID, Remark, LableText, ExJson, Status, OrderNo, CreateDate, ModifyDate, CreateUser, ModifyUser  ");			
			strSql.Append("  from tabExperienceEdu ");
			strSql.Append(" where id=SQL2012id");
						SqlParameter[] parameters = {
					new SqlParameter("SQL2012id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			
			Maticsoft.Model.tabExperienceEdu model=new Maticsoft.Model.tabExperienceEdu();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			
			if(ds.Tables[0].Rows.Count>0)
			{
																model.SchoolName= ds.Tables[0].Rows[0]["SchoolName"].ToString();
																																model.ProfessionalName= ds.Tables[0].Rows[0]["ProfessionalName"].ToString();
																																model.EduBeginDate= ds.Tables[0].Rows[0]["EduBeginDate"].ToString();
																																model.EduEndDate= ds.Tables[0].Rows[0]["EduEndDate"].ToString();
																												if(ds.Tables[0].Rows[0]["GetEdu"].ToString()!="")
				{
					model.GetEdu=int.Parse(ds.Tables[0].Rows[0]["GetEdu"].ToString());
				}
																																																if(ds.Tables[0].Rows[0]["IsTZ"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsTZ"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsTZ"].ToString().ToLower()=="true"))
					{
					model.IsTZ= true;
					}
					else
					{
					model.IsTZ= false;
					}
				}
																																if(ds.Tables[0].Rows[0]["Is211"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["Is211"].ToString()=="1")||(ds.Tables[0].Rows[0]["Is211"].ToString().ToLower()=="true"))
					{
					model.Is211= true;
					}
					else
					{
					model.Is211= false;
					}
				}
																																if(ds.Tables[0].Rows[0]["IsVal"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsVal"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsVal"].ToString().ToLower()=="true"))
					{
					model.IsVal= true;
					}
					else
					{
					model.IsVal= false;
					}
				}
																				model.AddonInfo= ds.Tables[0].Rows[0]["AddonInfo"].ToString();
																												if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
																																				model.AppID= ds.Tables[0].Rows[0]["AppID"].ToString();
																																model.Version= ds.Tables[0].Rows[0]["Version"].ToString();
																																model.RandomNo= ds.Tables[0].Rows[0]["RandomNo"].ToString();
																												if(ds.Tables[0].Rows[0]["ParentID"].ToString()!="")
				{
					model.ParentID=int.Parse(ds.Tables[0].Rows[0]["ParentID"].ToString());
				}
																																				model.Remark= ds.Tables[0].Rows[0]["Remark"].ToString();
																																model.LableText= ds.Tables[0].Rows[0]["LableText"].ToString();
																																model.ExJson= ds.Tables[0].Rows[0]["ExJson"].ToString();
																																model.Status= ds.Tables[0].Rows[0]["Status"].ToString();
																												if(ds.Tables[0].Rows[0]["OrderNo"].ToString()!="")
				{
					model.OrderNo=int.Parse(ds.Tables[0].Rows[0]["OrderNo"].ToString());
				}
																																				model.CreateDate= ds.Tables[0].Rows[0]["CreateDate"].ToString();
																																model.ModifyDate= ds.Tables[0].Rows[0]["ModifyDate"].ToString();
																												if(ds.Tables[0].Rows[0]["CreateUser"].ToString()!="")
				{
					model.CreateUser=int.Parse(ds.Tables[0].Rows[0]["CreateUser"].ToString());
				}
																																if(ds.Tables[0].Rows[0]["ModifyUser"].ToString()!="")
				{
					model.ModifyUser=int.Parse(ds.Tables[0].Rows[0]["ModifyUser"].ToString());
				}
																														
				return model;
			}
			else
			{
				return null;
			}
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

   
	}
}

