using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.Model;
namespace Maticsoft.BLL {
	 	//来往单位表（通表）
		public partial class tabOrg
	{
   		     
		private readonly Maticsoft.DAL.tabOrg dal=new Maticsoft.DAL.tabOrg();
		public tabOrg()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string OrgName,int id,int ParentID)
		{
			return dal.Exists(OrgName,id,ParentID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.tabOrg model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.tabOrg model)
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
		public Maticsoft.Model.tabOrg GetModel(int id)
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
		public List<Maticsoft.Model.tabOrg> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.tabOrg> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.tabOrg> modelList = new List<Maticsoft.Model.tabOrg>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.tabOrg model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.tabOrg();					
																	model.OrgName= dt.Rows[n]["OrgName"].ToString();
																																model.OrgDesc= dt.Rows[n]["OrgDesc"].ToString();
																																model.OrgNickName= dt.Rows[n]["OrgNickName"].ToString();
																																model.OrgZZ= dt.Rows[n]["OrgZZ"].ToString();
																																model.OrgCode= dt.Rows[n]["OrgCode"].ToString();
																																model.OrgType= dt.Rows[n]["OrgType"].ToString();
																												if(dt.Rows[n]["OrgClass"].ToString()!="")
				{
					model.OrgClass=int.Parse(dt.Rows[n]["OrgClass"].ToString());
				}
																																				model.OrgLevel= dt.Rows[n]["OrgLevel"].ToString();
																																model.OrgEdge= dt.Rows[n]["OrgEdge"].ToString();
																																model.OrgPro= dt.Rows[n]["OrgPro"].ToString();
																												if(dt.Rows[n]["OrgCard"].ToString()!="")
				{
					model.OrgCard=int.Parse(dt.Rows[n]["OrgCard"].ToString());
				}
																																if(dt.Rows[n]["PlanNum"].ToString()!="")
				{
					model.PlanNum=int.Parse(dt.Rows[n]["PlanNum"].ToString());
				}
																																				model.Leader= dt.Rows[n]["Leader"].ToString();
																																model.LeaderMobile= dt.Rows[n]["LeaderMobile"].ToString();
																												if(dt.Rows[n]["Logo"].ToString()!="")
				{
					model.Logo=int.Parse(dt.Rows[n]["Logo"].ToString());
				}
																																				model.WebSite= dt.Rows[n]["WebSite"].ToString();
																																model.Phone= dt.Rows[n]["Phone"].ToString();
																																model.ZZNo= dt.Rows[n]["ZZNo"].ToString();
																												if(dt.Rows[n]["ZZImg"].ToString()!="")
				{
					model.ZZImg=int.Parse(dt.Rows[n]["ZZImg"].ToString());
				}
																																if(dt.Rows[n]["Natrue"].ToString()!="")
				{
					model.Natrue=int.Parse(dt.Rows[n]["Natrue"].ToString());
				}
																																				model.PY= dt.Rows[n]["PY"].ToString();
																																model.Country= dt.Rows[n]["Country"].ToString();
																																model.State= dt.Rows[n]["State"].ToString();
																																model.City= dt.Rows[n]["City"].ToString();
																																model.District= dt.Rows[n]["District"].ToString();
																																model.Community= dt.Rows[n]["Community"].ToString();
																																model.Address= dt.Rows[n]["Address"].ToString();
																																model.AreaFull= dt.Rows[n]["AreaFull"].ToString();
																																model.ZipCode= dt.Rows[n]["ZipCode"].ToString();
																																model.QQOpenID= dt.Rows[n]["QQOpenID"].ToString();
																																model.WeiXinOpenID= dt.Rows[n]["WeiXinOpenID"].ToString();
																																model.Fax= dt.Rows[n]["Fax"].ToString();
																																model.Email= dt.Rows[n]["Email"].ToString();
																																model.SaleType= dt.Rows[n]["SaleType"].ToString();
																																model.Scale= dt.Rows[n]["Scale"].ToString();
																																model.Source= dt.Rows[n]["Source"].ToString();
																																model.SaleStatus= dt.Rows[n]["SaleStatus"].ToString();
																																model.BankName= dt.Rows[n]["BankName"].ToString();
																																model.BankAccount= dt.Rows[n]["BankAccount"].ToString();
																																model.CreateUnitDate= dt.Rows[n]["CreateUnitDate"].ToString();
																																model.BeginDate= dt.Rows[n]["BeginDate"].ToString();
																																model.EndDate= dt.Rows[n]["EndDate"].ToString();
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