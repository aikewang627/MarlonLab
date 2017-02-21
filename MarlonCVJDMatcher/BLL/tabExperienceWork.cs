using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.Model;
namespace Maticsoft.BLL {
	 	//工作经历表
		public partial class tabExperienceWork
	{
   		     
		private readonly Maticsoft.DAL.tabExperienceWork dal=new Maticsoft.DAL.tabExperienceWork();
		public tabExperienceWork()
		{}
		
		#region  Method
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
		public int  Add(Maticsoft.Model.tabExperienceWork model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.tabExperienceWork model)
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
		public Maticsoft.Model.tabExperienceWork GetModel(int id)
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
		public List<Maticsoft.Model.tabExperienceWork> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.tabExperienceWork> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.tabExperienceWork> modelList = new List<Maticsoft.Model.tabExperienceWork>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.tabExperienceWork model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.tabExperienceWork();					
													if(dt.Rows[n]["OrgID"].ToString()!="")
				{
					model.OrgID=int.Parse(dt.Rows[n]["OrgID"].ToString());
				}
																																				model.OrgBeginDate= dt.Rows[n]["OrgBeginDate"].ToString();
																																model.OrgEndDate= dt.Rows[n]["OrgEndDate"].ToString();
																																model.PositionName= dt.Rows[n]["PositionName"].ToString();
																																model.PositionAddress= dt.Rows[n]["PositionAddress"].ToString();
																																model.PositionBeginDate= dt.Rows[n]["PositionBeginDate"].ToString();
																																model.PositionEndDate= dt.Rows[n]["PositionEndDate"].ToString();
																												if(dt.Rows[n]["DeptNum"].ToString()!="")
				{
					model.DeptNum=int.Parse(dt.Rows[n]["DeptNum"].ToString());
				}
																																				model.PositionDuties= dt.Rows[n]["PositionDuties"].ToString();
																																model.ReportObj= dt.Rows[n]["ReportObj"].ToString();
																																model.DeptName= dt.Rows[n]["DeptName"].ToString();
																																model.WorkPerformance= dt.Rows[n]["WorkPerformance"].ToString();
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