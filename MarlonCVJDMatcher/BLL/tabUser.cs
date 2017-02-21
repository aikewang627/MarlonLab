using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Maticsoft.Model;
namespace Maticsoft.BLL {
	 	//用户表
		public partial class tabUser
	{
   		     
		private readonly Maticsoft.DAL.tabUser dal=new Maticsoft.DAL.tabUser();
		public tabUser()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string UserName,string Pwd,string SFZNo,string Mobile,string Email,string WeiXinOpenID,string QQID,string UserType,string Industry,int XueLi,int id,int ParentID,string CreateDate,int CreateUser)
		{
			return dal.Exists(UserName,Pwd,SFZNo,Mobile,Email,WeiXinOpenID,QQID,UserType,Industry,XueLi,id,ParentID,CreateDate,CreateUser);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.tabUser model)
		{
						return dal.Add(model);
						
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.tabUser model)
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
		public Maticsoft.Model.tabUser GetModel(int id)
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
		public List<Maticsoft.Model.tabUser> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.tabUser> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.tabUser> modelList = new List<Maticsoft.Model.tabUser>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.tabUser model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Maticsoft.Model.tabUser();					
																	model.UserName= dt.Rows[n]["UserName"].ToString();
																																model.NickName= dt.Rows[n]["NickName"].ToString();
																																model.Pwd= dt.Rows[n]["Pwd"].ToString();
																																model.Sex= dt.Rows[n]["Sex"].ToString();
																																model.Birthday= dt.Rows[n]["Birthday"].ToString();
																												if(dt.Rows[n]["HeadImgURLID"].ToString()!="")
				{
					model.HeadImgURLID=int.Parse(dt.Rows[n]["HeadImgURLID"].ToString());
				}
																																				model.RealName= dt.Rows[n]["RealName"].ToString();
																																model.SFZNo= dt.Rows[n]["SFZNo"].ToString();
																												if(dt.Rows[n]["IDCardPerson"].ToString()!="")
				{
					model.IDCardPerson=int.Parse(dt.Rows[n]["IDCardPerson"].ToString());
				}
																																				model.Mobile= dt.Rows[n]["Mobile"].ToString();
																																model.Email= dt.Rows[n]["Email"].ToString();
																																model.Marriage= dt.Rows[n]["Marriage"].ToString();
																																model.BeginJobYear= dt.Rows[n]["BeginJobYear"].ToString();
																																model.WeiXinOpenID= dt.Rows[n]["WeiXinOpenID"].ToString();
																																model.WXNickName= dt.Rows[n]["WXNickName"].ToString();
																																model.WxCode= dt.Rows[n]["WxCode"].ToString();
																																model.QQID= dt.Rows[n]["QQID"].ToString();
																																model.QQNickName= dt.Rows[n]["QQNickName"].ToString();
																																model.QQNo= dt.Rows[n]["QQNo"].ToString();
																																model.SinaID= dt.Rows[n]["SinaID"].ToString();
																																model.Ali= dt.Rows[n]["Ali"].ToString();
																																model.OtherID= dt.Rows[n]["OtherID"].ToString();
																																model.Country= dt.Rows[n]["Country"].ToString();
																																model.State= dt.Rows[n]["State"].ToString();
																																model.City= dt.Rows[n]["City"].ToString();
																																model.District= dt.Rows[n]["District"].ToString();
																																model.Community= dt.Rows[n]["Community"].ToString();
																																model.Address= dt.Rows[n]["Address"].ToString();
																																model.AddressFull= dt.Rows[n]["AddressFull"].ToString();
																																model.SafeQuestion= dt.Rows[n]["SafeQuestion"].ToString();
																																model.SafeAnswer= dt.Rows[n]["SafeAnswer"].ToString();
																																model.UserType= dt.Rows[n]["UserType"].ToString();
																																												if(dt.Rows[n]["IsLogin"].ToString()!="")
				{
					if((dt.Rows[n]["IsLogin"].ToString()=="1")||(dt.Rows[n]["IsLogin"].ToString().ToLower()=="true"))
					{
					model.IsLogin= true;
					}
					else
					{
					model.IsLogin= false;
					}
				}
																				model.LastLoginTime= dt.Rows[n]["LastLoginTime"].ToString();
																												if(dt.Rows[n]["RoleID"].ToString()!="")
				{
					model.RoleID=int.Parse(dt.Rows[n]["RoleID"].ToString());
				}
																																if(dt.Rows[n]["GroupID"].ToString()!="")
				{
					model.GroupID=int.Parse(dt.Rows[n]["GroupID"].ToString());
				}
																																				model.RegIP= dt.Rows[n]["RegIP"].ToString();
																																model.RegDate= dt.Rows[n]["RegDate"].ToString();
																																model.Industry= dt.Rows[n]["Industry"].ToString();
																												if(dt.Rows[n]["MinZu"].ToString()!="")
				{
					model.MinZu=int.Parse(dt.Rows[n]["MinZu"].ToString());
				}
																																if(dt.Rows[n]["MianMao"].ToString()!="")
				{
					model.MianMao=int.Parse(dt.Rows[n]["MianMao"].ToString());
				}
																																if(dt.Rows[n]["XueLi"].ToString()!="")
				{
					model.XueLi=int.Parse(dt.Rows[n]["XueLi"].ToString());
				}
																																if(dt.Rows[n]["ZhiWu"].ToString()!="")
				{
					model.ZhiWu=int.Parse(dt.Rows[n]["ZhiWu"].ToString());
				}
																																				model.OrgID= dt.Rows[n]["OrgID"].ToString();
																																model.BankCardNo= dt.Rows[n]["BankCardNo"].ToString();
																																												if(dt.Rows[n]["OrderQuality"].ToString()!="")
				{
					if((dt.Rows[n]["OrderQuality"].ToString()=="1")||(dt.Rows[n]["OrderQuality"].ToString().ToLower()=="true"))
					{
					model.OrderQuality= true;
					}
					else
					{
					model.OrderQuality= false;
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