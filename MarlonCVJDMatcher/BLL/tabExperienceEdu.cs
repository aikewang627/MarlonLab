using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.Model;
namespace Maticsoft.BLL {
	 	//教育经历表
		public partial class tabExperienceEdu
	{
   		     
		private readonly Maticsoft.DAL.tabExperienceEdu dal=new Maticsoft.DAL.tabExperienceEdu();
		public tabExperienceEdu()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string SchoolName,string ProfessionalName,int GetEdu,int id,int ParentID)
		{
			return dal.Exists(SchoolName,ProfessionalName,GetEdu,id,ParentID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.tabExperienceEdu model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.tabExperienceEdu model)
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
		public Maticsoft.Model.tabExperienceEdu GetModel(int id)
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
		public List<Maticsoft.Model.tabExperienceEdu> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.tabExperienceEdu> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.tabExperienceEdu> modelList = new List<Maticsoft.Model.tabExperienceEdu>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.tabExperienceEdu model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.tabExperienceEdu();					
																	model.SchoolName= dt.Rows[n]["SchoolName"].ToString();
																																model.ProfessionalName= dt.Rows[n]["ProfessionalName"].ToString();
																																model.EduBeginDate= dt.Rows[n]["EduBeginDate"].ToString();
																																model.EduEndDate= dt.Rows[n]["EduEndDate"].ToString();
																												if(dt.Rows[n]["GetEdu"].ToString()!="")
				{
					model.GetEdu=int.Parse(dt.Rows[n]["GetEdu"].ToString());
				}
																																																if(dt.Rows[n]["IsTZ"].ToString()!="")
				{
					if((dt.Rows[n]["IsTZ"].ToString()=="1")||(dt.Rows[n]["IsTZ"].ToString().ToLower()=="true"))
					{
					model.IsTZ= true;
					}
					else
					{
					model.IsTZ= false;
					}
				}
																																if(dt.Rows[n]["Is211"].ToString()!="")
				{
					if((dt.Rows[n]["Is211"].ToString()=="1")||(dt.Rows[n]["Is211"].ToString().ToLower()=="true"))
					{
					model.Is211= true;
					}
					else
					{
					model.Is211= false;
					}
				}
																																if(dt.Rows[n]["IsVal"].ToString()!="")
				{
					if((dt.Rows[n]["IsVal"].ToString()=="1")||(dt.Rows[n]["IsVal"].ToString().ToLower()=="true"))
					{
					model.IsVal= true;
					}
					else
					{
					model.IsVal= false;
					}
				}
																				model.AddonInfo= dt.Rows[n]["AddonInfo"].ToString();
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