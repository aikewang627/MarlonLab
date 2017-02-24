
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
#region  Model 实体类 - tabCVJDMatchEx
namespace Tclywork.Model
{
	/// <summary>
	/// tabCVJDMatch
	/// tabCVJDMatch
    /// </summary> 	
	public partial class tabCVJDMatchModel
	{      
	
	}
}
#endregion

#region	SQLDAL
namespace Tclywork.DAL
{
	/// <summary>
	/// tabCVJDMatch
    /// </summary> 	
	public partial class tabCVJDMatchSQLDAL
	{
        public List<int> GetResumeIDListForJD(int pageSize, int pageNo, string where, string orderby, out int count)
        {   
            //求count         
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select count(*) ");
            strSql.Append(" from tabResumeOutline  ");
            if (where.IsNotNullOrEmpty()) { strSql.Append(" " + where + ""); }
            if (orderby.IsNotNullOrEmpty()) { strSql.Append(" "+orderby+" "); }
            count = (int)DbHelperSQL.GetSingle(strSql.ToString());

            //获得ListID
            strSql = new StringBuilder();
            strSql.Append(" select ResumeID from ( ");
            strSql.AppendFormat(" select ResumeID, ROW_NUMBER() OVER(ORDER BY {0}) AS RowNo", orderby.IsNullOrEmpty() ? "id" : orderby); 
            strSql.Append(" from tabResumeOutline  ");
            if (where.IsNotNullOrEmpty()) { strSql.Append(" " + where + ""); }
            strSql.Append(" ) as ret ");
            strSql.Append(" where RowNo between "+ pageSize * (pageNo-1 )+ " and "+pageSize*pageNo);


            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.IsNull() )
            {     return null; }
            else
            {
                List<int> lsInt = new List<int>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lsInt.Add(dr["ResumeID"].ToString().ToInt(0));
                }
                return lsInt;
            }


        }

        public bool Delete(string where)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tabCVJDMatch ");
            strSql.Append(" where "+where);

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString() );
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}	
#endregion
#region BLL类    
namespace Tclywork.BLL{
    /// <summary>
    /// tabCVJDMatch
    /// </summary> 	
    public partial class tabCVJDMatchBLL
    {
        public List<int> GetResumeIDListForJD(int pageSize, int pageNo, string where, string orderby, out int count)
        {
            return dal.GetResumeIDListForJD(pageSize, pageNo, where, orderby, out count);
        }
        public bool Delete(string where)
        {
            return dal.Delete(where);
        }

    }	
}
#endregion