using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.Model;
namespace Maticsoft.BLL {
	 	//项目经验表
		public partial class tabExperienceProject
	{
   		     
		private readonly Maticsoft.DAL.tabExperienceProject dal=new Maticsoft.DAL.tabExperienceProject();
		public tabExperienceProject()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OrgID,string ProjectPosition,int id,int ParentID)
		{
			return dal.Exists(OrgID,ProjectPosition,id,ParentID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.tabExperienceProject model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.tabExperienceProject model)
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
		public Maticsoft.Model.tabExperienceProject GetModel(int id)
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
		public List<Maticsoft.Model.tabExperienceProject> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.tabExperienceProject> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.tabExperienceProject> modelList = new List<Maticsoft.Model.tabExperienceProject>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.tabExperienceProject model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.tabExperienceProject();					
													if(dt.Rows[n]["OrgID"].ToString()!="")
				{
					model.OrgID=int.Parse(dt.Rows[n]["OrgID"].ToString());
				}
																																				model.ProjectName= dt.Rows[n]["ProjectName"].ToString();
																																model.ProjectBeginDate= dt.Rows[n]["ProjectBeginDate"].ToString();
																																model.ProjectEndDate= dt.Rows[n]["ProjectEndDate"].ToString();
																																model.ProjectDesc= dt.Rows[n]["ProjectDesc"].ToString();
																																model.ProjectPosition= dt.Rows[n]["ProjectPosition"].ToString();
																																model.ProjectPerformance= dt.Rows[n]["ProjectPerformance"].ToString();
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