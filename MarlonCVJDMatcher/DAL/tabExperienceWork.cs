using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Maticsoft.DBUtility;
namespace Maticsoft.DAL
{
    //工作经历表
    public partial class tabExperienceWork
    {

        public bool Exists(string PositionName, string PositionAddress, string PositionBeginDate, int id, int ParentID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tabExperienceWork");
            strSql.Append(" where ");
            strSql.Append(" PositionName = @PositionName and  ");
            strSql.Append(" PositionAddress = @PositionAddress and  ");
            strSql.Append(" PositionBeginDate = @PositionBeginDate and  ");
            strSql.Append(" id = @id and  ");
            strSql.Append(" ParentID = @ParentID  ");
            SqlParameter[] parameters = {
                    new SqlParameter("@PositionName", SqlDbType.NVarChar,50),
                    new SqlParameter("@PositionAddress", SqlDbType.NVarChar,200),
                    new SqlParameter("@PositionBeginDate", SqlDbType.NVarChar,50),
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@ParentID", SqlDbType.Int,4)          };
            parameters[0].Value = PositionName;
            parameters[1].Value = PositionAddress;
            parameters[2].Value = PositionBeginDate;
            parameters[3].Value = id;
            parameters[4].Value = ParentID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.tabExperienceWork model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tabExperienceWork(");
            strSql.Append("OrgID,OrgBeginDate,OrgEndDate,PositionName,PositionAddress,PositionBeginDate,PositionEndDate,DeptNum,PositionDuties,ReportObj,DeptName,WorkPerformance,IsVal,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
            strSql.Append(") values (");
            strSql.Append("@OrgID,@OrgBeginDate,@OrgEndDate,@PositionName,@PositionAddress,@PositionBeginDate,@PositionEndDate,@DeptNum,@PositionDuties,@ReportObj,@DeptName,@WorkPerformance,@IsVal,@AppID,@Version,@RandomNo,@ParentID,@Remark,@LableText,@ExJson,@Status,@OrderNo,@CreateDate,@ModifyDate,@CreateUser,@ModifyUser");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                        new SqlParameter("@OrgID", SqlDbType.Int,4) ,
                        new SqlParameter("@OrgBeginDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@OrgEndDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@PositionName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@PositionAddress", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@PositionBeginDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@PositionEndDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@DeptNum", SqlDbType.Int,4) ,
                        new SqlParameter("@PositionDuties", SqlDbType.NVarChar,1000) ,
                        new SqlParameter("@ReportObj", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@DeptName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@WorkPerformance", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@IsVal", SqlDbType.Bit,1) ,
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
            parameters[1].Value = model.OrgBeginDate;
            parameters[2].Value = model.OrgEndDate;
            parameters[3].Value = model.PositionName;
            parameters[4].Value = model.PositionAddress;
            parameters[5].Value = model.PositionBeginDate;
            parameters[6].Value = model.PositionEndDate;
            parameters[7].Value = model.DeptNum;
            parameters[8].Value = model.PositionDuties;
            parameters[9].Value = model.ReportObj;
            parameters[10].Value = model.DeptName;
            parameters[11].Value = model.WorkPerformance;
            parameters[12].Value = model.IsVal;
            parameters[13].Value = model.AppID;
            parameters[14].Value = model.Version;
            parameters[15].Value = model.RandomNo;
            parameters[16].Value = model.ParentID;
            parameters[17].Value = model.Remark;
            parameters[18].Value = model.LableText;
            parameters[19].Value = model.ExJson;
            parameters[20].Value = model.Status;
            parameters[21].Value = model.OrderNo;
            parameters[22].Value = model.CreateDate;
            parameters[23].Value = model.ModifyDate;
            parameters[24].Value = model.CreateUser;
            parameters[25].Value = model.ModifyUser;

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
        public bool Update(Maticsoft.Model.tabExperienceWork model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tabExperienceWork set ");

            strSql.Append(" OrgID = @OrgID , ");
            strSql.Append(" OrgBeginDate = @OrgBeginDate , ");
            strSql.Append(" OrgEndDate = @OrgEndDate , ");
            strSql.Append(" PositionName = @PositionName , ");
            strSql.Append(" PositionAddress = @PositionAddress , ");
            strSql.Append(" PositionBeginDate = @PositionBeginDate , ");
            strSql.Append(" PositionEndDate = @PositionEndDate , ");
            strSql.Append(" DeptNum = @DeptNum , ");
            strSql.Append(" PositionDuties = @PositionDuties , ");
            strSql.Append(" ReportObj = @ReportObj , ");
            strSql.Append(" DeptName = @DeptName , ");
            strSql.Append(" WorkPerformance = @WorkPerformance , ");
            strSql.Append(" IsVal = @IsVal , ");
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
                        new SqlParameter("@OrgBeginDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@OrgEndDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@PositionName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@PositionAddress", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@PositionBeginDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@PositionEndDate", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@DeptNum", SqlDbType.Int,4) ,
                        new SqlParameter("@PositionDuties", SqlDbType.NVarChar,1000) ,
                        new SqlParameter("@ReportObj", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@DeptName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@WorkPerformance", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@IsVal", SqlDbType.Bit,1) ,
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
            parameters[1].Value = model.OrgBeginDate;
            parameters[2].Value = model.OrgEndDate;
            parameters[3].Value = model.PositionName;
            parameters[4].Value = model.PositionAddress;
            parameters[5].Value = model.PositionBeginDate;
            parameters[6].Value = model.PositionEndDate;
            parameters[7].Value = model.DeptNum;
            parameters[8].Value = model.PositionDuties;
            parameters[9].Value = model.ReportObj;
            parameters[10].Value = model.DeptName;
            parameters[11].Value = model.WorkPerformance;
            parameters[12].Value = model.IsVal;
            parameters[13].Value = model.id;
            parameters[14].Value = model.AppID;
            parameters[15].Value = model.Version;
            parameters[16].Value = model.RandomNo;
            parameters[17].Value = model.ParentID;
            parameters[18].Value = model.Remark;
            parameters[19].Value = model.LableText;
            parameters[20].Value = model.ExJson;
            parameters[21].Value = model.Status;
            parameters[22].Value = model.OrderNo;
            parameters[23].Value = model.CreateDate;
            parameters[24].Value = model.ModifyDate;
            parameters[25].Value = model.CreateUser;
            parameters[26].Value = model.ModifyUser;
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
            strSql.Append("delete from tabExperienceWork ");
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
            strSql.Append("delete from tabExperienceWork ");
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
        public Maticsoft.Model.tabExperienceWork GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select OrgID, OrgBeginDate, OrgEndDate, PositionName, PositionAddress, PositionBeginDate, PositionEndDate, DeptNum, PositionDuties, ReportObj, DeptName, WorkPerformance, IsVal, id, AppID, Version, RandomNo, ParentID, Remark, LableText, ExJson, Status, OrderNo, CreateDate, ModifyDate, CreateUser, ModifyUser  ");
            strSql.Append("  from tabExperienceWork ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;


            Maticsoft.Model.tabExperienceWork model = new Maticsoft.Model.tabExperienceWork();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["OrgID"].ToString() != "")
                {
                    model.OrgID = int.Parse(ds.Tables[0].Rows[0]["OrgID"].ToString());
                }
                model.OrgBeginDate = ds.Tables[0].Rows[0]["OrgBeginDate"].ToString();
                model.OrgEndDate = ds.Tables[0].Rows[0]["OrgEndDate"].ToString();
                model.PositionName = ds.Tables[0].Rows[0]["PositionName"].ToString();
                model.PositionAddress = ds.Tables[0].Rows[0]["PositionAddress"].ToString();
                model.PositionBeginDate = ds.Tables[0].Rows[0]["PositionBeginDate"].ToString();
                model.PositionEndDate = ds.Tables[0].Rows[0]["PositionEndDate"].ToString();
                if (ds.Tables[0].Rows[0]["DeptNum"].ToString() != "")
                {
                    model.DeptNum = int.Parse(ds.Tables[0].Rows[0]["DeptNum"].ToString());
                }
                model.PositionDuties = ds.Tables[0].Rows[0]["PositionDuties"].ToString();
                model.ReportObj = ds.Tables[0].Rows[0]["ReportObj"].ToString();
                model.DeptName = ds.Tables[0].Rows[0]["DeptName"].ToString();
                model.WorkPerformance = ds.Tables[0].Rows[0]["WorkPerformance"].ToString();
                if (ds.Tables[0].Rows[0]["IsVal"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsVal"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsVal"].ToString().ToLower() == "true"))
                    {
                        model.IsVal = true;
                    }
                    else
                    {
                        model.IsVal = false;
                    }
                }
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
            strSql.Append(" FROM tabExperienceWork ");
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
            strSql.Append(" FROM tabExperienceWork ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

