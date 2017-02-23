
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
#region  Model 实体类 - tabPositionEx
namespace Tclywork.Model
{
    /// <summary>
    /// tabPosition
    /// tabPosition
    /// </summary> 	

}
#endregion

#region	SQLDAL
namespace Tclywork.DAL
{
    /// <summary>
    /// tabPosition
    /// </summary> 	
    public partial class tabPositionSQLDAL
    {

        public DataTable GetDetailBySql(int id, int UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select Pos.* , ");
            strSql.Append(" LogoURL = (select AssetURL From tabAsset where id = Org.Logo), ");
            strSql.Append(" Org.OrgEdge,Org.OrgName,Org.Address ,Org.OrgPro, ");
            strSql.Append(" Org.Scale,Org.OrgClass,Org.WebSite,Org.OrgLevel,Org.OrgDesc, ");
            strSql.Append(" SalaryRang = (cast(Pos.SalaryBein / 1000000 as nvarchar(10)) + '-' + cast(Pos.SalaryEnd / 1000000 as nvarchar(10))), ");
            strSql.Append(" RecruitType = (case when Pos.PubOrgID = Pos.ParentID then '企业直聘' when Prov.id is not null then '猎头代聘' else '未验证' end ), ");
            strSql.Append(" UsrCur.RealName as RealNameCreate, ");
            strSql.Append(" i.*,");
            strSql.Append(" IsCollected = Case when Fav.id is not null then 1 else 0 end,  ");
            strSql.Append(" Vis.CreateDate as VisitDate  ");
            strSql.Append(" from tabPosition Pos ");
            strSql.Append(" left join tabOrg Org on Org.id = Pos.ParentID ");
            strSql.AppendFormat(" left join tabUser UsrCur on UsrCur.id = {0} ",UserID);
            strSql.Append (" outer Apply(select top 1 id from tabPositionProve where PubOrgID = Pos.PubOrgID and ParentID = Pos.ParentID and Status != -99) Prov  ");
            strSql.AppendFormat(" outer apply(select top 1 * From tabFavorite where  FavoriteType = 'Position' and Status = '1' and ParentID = Pos.id and CreateUser = {0}) Fav  ",UserID);
            strSql.AppendFormat("  outer apply(select top 1 * From tabVisitHistory where  VisitHistoryType = 'Position' and Status = '1' and ParentID = Pos.id and CreateUser = {0}) Vis ",UserID);
            strSql.Append("  outer apply (select count(*) as TuiJianNum, count(case when status='1' then status else Null end ) as JuJueNum , count(case when status in(2,3,4) then status else Null end ) as MianShiNum , count(case when status in(3,4) then status else Null end ) as RuZhiNum , count(case when status ='4' then status else Null end ) as ZhuanZhengNum  from  tabPositionOrder where   ParentID=Pos.id and OrderType='TuiJian' ) i ");
            strSql.AppendFormat(" where Pos.id = {0} ",id );

            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.IsNull() || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            { return null; }
            else
            { return ds.Tables[0]; }
        }
   
    }
}
#endregion
#region BLL类
namespace Tclywork.BLL
{
    /// <summary>
    /// tabPosition
    /// </summary> 	
    public partial class tabPositionBLL
    {
        public DataTable GetDetailBySql(int id,  int UserID)
        {
            return dal.GetDetailBySql(id, UserID);        
        }

    }
}
#endregion