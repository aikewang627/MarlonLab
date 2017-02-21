using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Maticsoft.DBUtility;
namespace Maticsoft.DAL
{
    //项目经验表
    public partial class tabExperienceProject
    {

        public bool Exists(int OrgID, string ProjectPosition, int id, int ParentID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tabExperienceProject");
            strSql.Append(" where ");
            strSql.Append(" OrgID = @OrgID and  ");
            strSql.Append(" ProjectPosition = @ProjectPosition and  ");
            strSql.Append(" id = @id and  ");
            strSql.Append(" ParentID = @ParentID  ");
            SqlParameter[] parameters = {
                    new SqlParameter("@OrgID", SqlDbType.Int,4),
                    new SqlParameter("@ProjectPosition", SqlDbType.NVarChar,50),
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@ParentID", SqlDbType.Int,4)          };
            parameters[0].Value = OrgID;
            parameters[1].Value = ProjectPosition;
            parameters[2].Value = id;
            parameters[3].Value = ParentID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.tabExperienceProject model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tabExperienceProject(");
            strSql.Append("OrgID,ProjectName,ProjectBeginDate,ProjectEndDate,ProjectDesc,ProjectPosition,ProjectPerformance,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
            strSql.Append(") values (");
            strSql.Append("@OrgID,@ProjectName,@ProjectBeginDate,@ProjectEndDate,@ProjectDesc,@ProjectPosition,@ProjectPerformance,@AppID,@Version,@RandomNo,@ParentID,@Remark,@LableText,@ExJson,@Status,@OrderNo,@CreateDate,@ModifyDate,@CreateUser,@ModifyUser");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                        new SqlParameter("@OrgID", SqlDbType.Int,4) ,
                        new SqlParameter("@ProjectName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ProjectBeginDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ProjectEndDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ProjectDesc", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@ProjectPosition", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ProjectPerformance", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@AppID", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Version", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@RandomNo", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@ParentID", SqlDbType.Int,4) ,
                        new SqlParameter("@Remark", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@LableText", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@ExJson", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@Status", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@OrderNo", SqlDbType.Int,4) ,
                        new SqlParameter("@CreateDate", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@ModifyDate", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@CreateUser", SqlDbType.Int,4) ,
                        new SqlParameter("@ModifyUser", SqlDbType.Int,4)

            };

            parameters[0].Value = model.OrgID;
            parameters[1].Value = model.ProjectName;
            parameters[2].Value = model.ProjectBeginDate;
            parameters[3].Value = model.ProjectEndDate;
            parameters[4].Value = model.ProjectDesc;
            parameters[5].Value = model.ProjectPosition;
            parameters[6].Value = model.ProjectPerformance;
            parameters[7].Value = model.AppID;
            parameters[8].Value = model.Version;
            parameters[9].Value = model.RandomNo;
            parameters[10].Value = model.ParentID;
            parameters[11].Value = model.Remark;
            parameters[12].Value = model.LableText;
            parameters[13].Value = model.ExJson;
            parameters[14].Value = model.Status;
            parameters[15].Value = model.OrderNo;
            parameters[16].Value = model.CreateDate;
            parameters[17].Value = model.ModifyDate;
            parameters[18].Value = model.CreateUser;
            parameters[19].Value = model.ModifyUser;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(Maticsoft.Model.tabExperienceProject model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tabExperienceProject set ");

            strSql.Append(" OrgID = @OrgID , ");
            strSql.Append(" ProjectName = @ProjectName , ");
            strSql.Append(" ProjectBeginDate = @ProjectBeginDate , ");
            strSql.Append(" ProjectEndDate = @ProjectEndDate , ");
            strSql.Append(" ProjectDesc = @ProjectDesc , ");
            strSql.Append(" ProjectPosition = @ProjectPosition , ");
            strSql.Append(" ProjectPerformance = @ProjectPerformance , ");
            strSql.Append(" AppID = @AppID , ");
            strSql.Append(" Version = @Version , ");
            strSql.Append(" RandomNo = @RandomNo , ");
            strSql.Append(" ParentID = @ParentID , ");
            strSql.Append(" Remark = @Remark , ");
            strSql.Append(" LableText = @LableText , ");
            strSql.Append(" ExJson = @ExJson , ");
            strSql.Append(" Status = @Status , ");
            strSql.Append(" OrderNo = @OrderNo , ");
            strSql.Append(" CreateDate = @CreateDate , ");
            strSql.Append(" ModifyDate = @ModifyDate , ");
            strSql.Append(" CreateUser = @CreateUser , ");
            strSql.Append(" ModifyUser = @ModifyUser  ");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
                        new SqlParameter("@OrgID", SqlDbType.Int,4) ,
                        new SqlParameter("@ProjectName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ProjectBeginDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ProjectEndDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ProjectDesc", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@ProjectPosition", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@ProjectPerformance", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@id", SqlDbType.Int,4) ,
                        new SqlParameter("@AppID", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@Version", SqlDbType.NVarChar,100) ,
                        new SqlParameter("@RandomNo", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@ParentID", SqlDbType.Int,4) ,
                        new SqlParameter("@Remark", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@LableText", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@ExJson", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@Status", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@OrderNo", SqlDbType.Int,4) ,
                        new SqlParameter("@CreateDate", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@ModifyDate", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@CreateUser", SqlDbType.Int,4) ,
                        new SqlParameter("@ModifyUser", SqlDbType.Int,4)

            };

            parameters[0].Value = model.OrgID;
            parameters[1].Value = model.ProjectName;
            parameters[2].Value = model.ProjectBeginDate;
            parameters[3].Value = model.ProjectEndDate;
            parameters[4].Value = model.ProjectDesc;
            parameters[5].Value = model.ProjectPosition;
            parameters[6].Value = model.ProjectPerformance;
            parameters[7].Value = model.id;
            parameters[8].Value = model.AppID;
            parameters[9].Value = model.Version;
            parameters[10].Value = model.RandomNo;
            parameters[11].Value = model.ParentID;
            parameters[12].Value = model.Remark;
            parameters[13].Value = model.LableText;
            parameters[14].Value = model.ExJson;
            parameters[15].Value = model.Status;
            parameters[16].Value = model.OrderNo;
            parameters[17].Value = model.CreateDate;
            parameters[18].Value = model.ModifyDate;
            parameters[19].Value = model.CreateUser;
            parameters[20].Value = model.ModifyUser;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tabExperienceProject ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;


            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tabExperienceProject ");
            strSql.Append(" where ID in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public Maticsoft.Model.tabExperienceProject GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select OrgID, ProjectName, ProjectBeginDate, ProjectEndDate, ProjectDesc, ProjectPosition, ProjectPerformance, id, AppID, Version, RandomNo, ParentID, Remark, LableText, ExJson, Status, OrderNo, CreateDate, ModifyDate, CreateUser, ModifyUser  ");
            strSql.Append("  from tabExperienceProject ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;


            Maticsoft.Model.tabExperienceProject model = new Maticsoft.Model.tabExperienceProject();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["OrgID"].ToString() != "")
                {
                    model.OrgID = int.Parse(ds.Tables[0].Rows[0]["OrgID"].ToString());
                }
                model.ProjectName = ds.Tables[0].Rows[0]["ProjectName"].ToString();
                model.ProjectBeginDate = ds.Tables[0].Rows[0]["ProjectBeginDate"].ToString();
                model.ProjectEndDate = ds.Tables[0].Rows[0]["ProjectEndDate"].ToString();
                model.ProjectDesc = ds.Tables[0].Rows[0]["ProjectDesc"].ToString();
                model.ProjectPosition = ds.Tables[0].Rows[0]["ProjectPosition"].ToString();
                model.ProjectPerformance = ds.Tables[0].Rows[0]["ProjectPerformance"].ToString();
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.AppID = ds.Tables[0].Rows[0]["AppID"].ToString();
                model.Version = ds.Tables[0].Rows[0]["Version"].ToString();
                model.RandomNo = ds.Tables[0].Rows[0]["RandomNo"].ToString();
                if (ds.Tables[0].Rows[0]["ParentID"].ToString() != "")
                {
                    model.ParentID = int.Parse(ds.Tables[0].Rows[0]["ParentID"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                model.LableText = ds.Tables[0].Rows[0]["LableText"].ToString();
                model.ExJson = ds.Tables[0].Rows[0]["ExJson"].ToString();
                model.Status = ds.Tables[0].Rows[0]["Status"].ToString();
                if (ds.Tables[0].Rows[0]["OrderNo"].ToString() != "")
                {
                    model.OrderNo = int.Parse(ds.Tables[0].Rows[0]["OrderNo"].ToString());
                }
                model.CreateDate = ds.Tables[0].Rows[0]["CreateDate"].ToString();
                model.ModifyDate = ds.Tables[0].Rows[0]["ModifyDate"].ToString();
                if (ds.Tables[0].Rows[0]["CreateUser"].ToString() != "")
                {
                    model.CreateUser = int.Parse(ds.Tables[0].Rows[0]["CreateUser"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ModifyUser"].ToString() != "")
                {
                    model.ModifyUser = int.Parse(ds.Tables[0].Rows[0]["ModifyUser"].ToString());
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM tabExperienceProject ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM tabExperienceProject ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

