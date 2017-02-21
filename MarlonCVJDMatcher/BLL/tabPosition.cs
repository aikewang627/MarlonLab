using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.Model;
namespace Maticsoft.BLL {
	 	//tabPosition
		public partial class tabPosition
	{
   		     
		private readonly Maticsoft.DAL.tabPosition dal=new Maticsoft.DAL.tabPosition();
		public tabPosition()
		{}
		
		#region  Method
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
		public int  Add(Maticsoft.Model.tabPosition model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.tabPosition model)
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
		public Maticsoft.Model.tabPosition GetModel(int id)
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
		public List<Maticsoft.Model.tabPosition> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.tabPosition> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.tabPosition> modelList = new List<Maticsoft.Model.tabPosition>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.tabPosition model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.tabPosition();					
																	model.PositionName= dt.Rows[n]["PositionName"].ToString();
																																model.PositionDesc= dt.Rows[n]["PositionDesc"].ToString();
																																model.WordAddress= dt.Rows[n]["WordAddress"].ToString();
																												if(dt.Rows[n]["NeedNum"].ToString()!="")
				{
					model.NeedNum=int.Parse(dt.Rows[n]["NeedNum"].ToString());
				}
																																				model.DeptID= dt.Rows[n]["DeptID"].ToString();
																												if(dt.Rows[n]["PubOrgID"].ToString()!="")
				{
					model.PubOrgID=int.Parse(dt.Rows[n]["PubOrgID"].ToString());
				}
																																				model.ReportObj= dt.Rows[n]["ReportObj"].ToString();
																												if(dt.Rows[n]["OrgNum"].ToString()!="")
				{
					model.OrgNum=int.Parse(dt.Rows[n]["OrgNum"].ToString());
				}
																																if(dt.Rows[n]["SalaryBein"].ToString()!="")
				{
					model.SalaryBein=int.Parse(dt.Rows[n]["SalaryBein"].ToString());
				}
																																if(dt.Rows[n]["SalaryEnd"].ToString()!="")
				{
					model.SalaryEnd=int.Parse(dt.Rows[n]["SalaryEnd"].ToString());
				}
																																				model.PositionEdge= dt.Rows[n]["PositionEdge"].ToString();
																																model.PostionReason= dt.Rows[n]["PostionReason"].ToString();
																												if(dt.Rows[n]["CommissionType"].ToString()!="")
				{
					model.CommissionType=int.Parse(dt.Rows[n]["CommissionType"].ToString());
				}
																																if(dt.Rows[n]["PriceCommission"].ToString()!="")
				{
					model.PriceCommission=int.Parse(dt.Rows[n]["PriceCommission"].ToString());
				}
																																if(dt.Rows[n]["PricePre"].ToString()!="")
				{
					model.PricePre=int.Parse(dt.Rows[n]["PricePre"].ToString());
				}
																																if(dt.Rows[n]["PriceInterview"].ToString()!="")
				{
					model.PriceInterview=int.Parse(dt.Rows[n]["PriceInterview"].ToString());
				}
																																if(dt.Rows[n]["PriceJoinWork"].ToString()!="")
				{
					model.PriceJoinWork=int.Parse(dt.Rows[n]["PriceJoinWork"].ToString());
				}
																																if(dt.Rows[n]["PriceGetWork"].ToString()!="")
				{
					model.PriceGetWork=int.Parse(dt.Rows[n]["PriceGetWork"].ToString());
				}
																																if(dt.Rows[n]["SafeDay"].ToString()!="")
				{
					model.SafeDay=int.Parse(dt.Rows[n]["SafeDay"].ToString());
				}
																																				model.RequireContent= dt.Rows[n]["RequireContent"].ToString();
																																model.RequireEdu= dt.Rows[n]["RequireEdu"].ToString();
																																model.RequireAbility= dt.Rows[n]["RequireAbility"].ToString();
																																model.RequireExperience= dt.Rows[n]["RequireExperience"].ToString();
																																model.RequireYear= dt.Rows[n]["RequireYear"].ToString();
																																model.RequireProject= dt.Rows[n]["RequireProject"].ToString();
																																model.AdditionInfo= dt.Rows[n]["AdditionInfo"].ToString();
																												if(dt.Rows[n]["PositionInitFile"].ToString()!="")
				{
					model.PositionInitFile=int.Parse(dt.Rows[n]["PositionInitFile"].ToString());
				}
																																if(dt.Rows[n]["PositionPdfFile"].ToString()!="")
				{
					model.PositionPdfFile=int.Parse(dt.Rows[n]["PositionPdfFile"].ToString());
				}
																																				model.PositionSourceUrl= dt.Rows[n]["PositionSourceUrl"].ToString();
																																model.PositionSourceText= dt.Rows[n]["PositionSourceText"].ToString();
																																model.PubDate= dt.Rows[n]["PubDate"].ToString();
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