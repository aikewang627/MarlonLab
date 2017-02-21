using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.Model;
namespace Maticsoft.BLL {
	 	//简历表
		public partial class tabResume
	{
   		     
		private readonly Maticsoft.DAL.tabResume dal=new Maticsoft.DAL.tabResume();
		public tabResume()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ResumeNo,string ResumeName,bool IsMe,string CurPosition,string CurStatus,string HopeAddress,string HopePosition,string HopeIndustry,int id,int ParentID,string CreateDate,string ModifyDate,int CreateUser)
		{
			return dal.Exists(ResumeNo,ResumeName,IsMe,CurPosition,CurStatus,HopeAddress,HopePosition,HopeIndustry,id,ParentID,CreateDate,ModifyDate,CreateUser);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.tabResume model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.tabResume model)
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
		public Maticsoft.Model.tabResume GetModel(int id)
		{
			
			return dal.GetModel(id);
		}



		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
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
		public List<Maticsoft.Model.tabResume> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.tabResume> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.tabResume> modelList = new List<Maticsoft.Model.tabResume>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.tabResume model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.tabResume();					
																	model.ResumeNo= dt.Rows[n]["ResumeNo"].ToString();
																																model.ResumeName= dt.Rows[n]["ResumeName"].ToString();
																												if(dt.Rows[n]["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(dt.Rows[n]["UserID"].ToString());
				}
																																																if(dt.Rows[n]["IsMe"].ToString()!="")
				{
					if((dt.Rows[n]["IsMe"].ToString()=="1")||(dt.Rows[n]["IsMe"].ToString().ToLower()=="true"))
					{
					model.IsMe= true;
					}
					else
					{
					model.IsMe= false;
					}
				}
																																if(dt.Rows[n]["IsDisplayRealName"].ToString()!="")
				{
					if((dt.Rows[n]["IsDisplayRealName"].ToString()=="1")||(dt.Rows[n]["IsDisplayRealName"].ToString().ToLower()=="true"))
					{
					model.IsDisplayRealName= true;
					}
					else
					{
					model.IsDisplayRealName= false;
					}
				}
																				model.CurPosition= dt.Rows[n]["CurPosition"].ToString();
																												if(dt.Rows[n]["CurSalary"].ToString()!="")
				{
					model.CurSalary=decimal.Parse(dt.Rows[n]["CurSalary"].ToString());
				}
																																				model.CurComapny= dt.Rows[n]["CurComapny"].ToString();
																																model.CurIndustry= dt.Rows[n]["CurIndustry"].ToString();
																																model.CurStatus= dt.Rows[n]["CurStatus"].ToString();
																																model.CurAddress= dt.Rows[n]["CurAddress"].ToString();
																																model.HopeAddress= dt.Rows[n]["HopeAddress"].ToString();
																																model.HopePosition= dt.Rows[n]["HopePosition"].ToString();
																																model.HopeIndustry= dt.Rows[n]["HopeIndustry"].ToString();
																												if(dt.Rows[n]["HopeSalary"].ToString()!="")
				{
					model.HopeSalary=decimal.Parse(dt.Rows[n]["HopeSalary"].ToString());
				}
																																				model.HunterComment= dt.Rows[n]["HunterComment"].ToString();
																												if(dt.Rows[n]["ResumeInitFile"].ToString()!="")
				{
					model.ResumeInitFile=int.Parse(dt.Rows[n]["ResumeInitFile"].ToString());
				}
																																if(dt.Rows[n]["ResumePDFFile"].ToString()!="")
				{
					model.ResumePDFFile=int.Parse(dt.Rows[n]["ResumePDFFile"].ToString());
				}
																																				model.Other= dt.Rows[n]["Other"].ToString();
																												if(dt.Rows[n]["Price"].ToString()!="")
				{
					model.Price=int.Parse(dt.Rows[n]["Price"].ToString());
				}
																																				model.SourceUrl= dt.Rows[n]["SourceUrl"].ToString();
																																model.SourceText= dt.Rows[n]["SourceText"].ToString();
																																model.Tags= dt.Rows[n]["Tags"].ToString();
																																model.Lang= dt.Rows[n]["Lang"].ToString();
																												if(dt.Rows[n]["id"].ToString()!="")
				{
					model.id=int.Parse(dt.Rows[n]["id"].ToString());
				}
																																				model.AppID= dt.Rows[n]["AppID"].ToString();
																																model.Version= dt.Rows[n]["Version"].ToString();
																																model.RandomNo= dt.Rows[n]["RandomNo"].ToString();
																												if(dt.Rows[n]["ParentID"].ToString()!="")
				{
					model.ParentID=int.Parse(dt.Rows[n]["ParentID"].ToString());
				}
																																				model.Remark= dt.Rows[n]["Remark"].ToString();
																																model.LableText= dt.Rows[n]["LableText"].ToString();
																																model.ExJson= dt.Rows[n]["ExJson"].ToString();
																																model.Status= dt.Rows[n]["Status"].ToString();
																												if(dt.Rows[n]["OrderNo"].ToString()!="")
				{
					model.OrderNo=int.Parse(dt.Rows[n]["OrderNo"].ToString());
				}
																																				model.CreateDate= dt.Rows[n]["CreateDate"].ToString();
																																model.ModifyDate= dt.Rows[n]["ModifyDate"].ToString();
																												if(dt.Rows[n]["CreateUser"].ToString()!="")
				{
					model.CreateUser=int.Parse(dt.Rows[n]["CreateUser"].ToString());
				}
																																if(dt.Rows[n]["ModifyUser"].ToString()!="")
				{
					model.ModifyUser=int.Parse(dt.Rows[n]["ModifyUser"].ToString());
				}
																										
				
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
#endregion
   
	}
}