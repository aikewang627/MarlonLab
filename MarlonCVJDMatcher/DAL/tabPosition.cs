using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Maticsoft.DBUtility;
namespace Maticsoft.DAL
{
    //tabPosition
    public partial class tabPosition
    {

        public bool Exists(int id, int ParentID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tabPosition");
            strSql.Append(" where ");
            strSql.Append(" id = @id and  ");
            strSql.Append(" ParentID = @ParentID  ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@ParentID", SqlDbType.Int,4)            };
            parameters[0].Value = id;
            parameters[1].Value = ParentID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.tabPosition model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tabPosition(");
            strSql.Append("PositionName,PositionDesc,WordAddress,NeedNum,DeptID,PubOrgID,ReportObj,OrgNum,SalaryBein,SalaryEnd,PositionEdge,PostionReason,CommissionType,PriceCommission,PricePre,PriceInterview,PriceJoinWork,PriceGetWork,SafeDay,RequireContent,RequireEdu,RequireAbility,RequireExperience,RequireYear,RequireProject,AdditionInfo,PositionInitFile,PositionPdfFile,PositionSourceUrl,PositionSourceText,PubDate,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
            strSql.Append(") values (");
            strSql.Append("@PositionName,@PositionDesc,@WordAddress,@NeedNum,@DeptID,@PubOrgID,@ReportObj,@OrgNum,@SalaryBein,@SalaryEnd,@PositionEdge,@PostionReason,@CommissionType,@PriceCommission,@PricePre,@PriceInterview,@PriceJoinWork,@PriceGetWork,@SafeDay,@RequireContent,@RequireEdu,@RequireAbility,@RequireExperience,@RequireYear,@RequireProject,@AdditionInfo,@PositionInitFile,@PositionPdfFile,@PositionSourceUrl,@PositionSourceText,@PubDate,@AppID,@Version,@RandomNo,@ParentID,@Remark,@LableText,@ExJson,@Status,@OrderNo,@CreateDate,@ModifyDate,@CreateUser,@ModifyUser");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                        new SqlParameter("@PositionName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@PositionDesc", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@WordAddress", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@NeedNum", SqlDbType.Int,4) ,
                        new SqlParameter("@DeptID", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@PubOrgID", SqlDbType.Int,4) ,
                        new SqlParameter("@ReportObj", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@OrgNum", SqlDbType.Int,4) ,
                        new SqlParameter("@SalaryBein", SqlDbType.Int,4) ,
                        new SqlParameter("@SalaryEnd", SqlDbType.Int,4) ,
                        new SqlParameter("@PositionEdge", SqlDbType.NVarChar,500) ,
                        new SqlParameter("@PostionReason", SqlDbType.NVarChar,500) ,
                        new SqlParameter("@CommissionType", SqlDbType.Int,4) ,
                        new SqlParameter("@PriceCommission", SqlDbType.Int,4) ,
                        new SqlParameter("@PricePre", SqlDbType.Int,4) ,
                        new SqlParameter("@PriceInterview", SqlDbType.Int,4) ,
                        new SqlParameter("@PriceJoinWork", SqlDbType.Int,4) ,
                        new SqlParameter("@PriceGetWork", SqlDbType.Int,4) ,
                        new SqlParameter("@SafeDay", SqlDbType.Int,4) ,
                        new SqlParameter("@RequireContent", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@RequireEdu", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@RequireAbility", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@RequireExperience", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@RequireYear", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@RequireProject", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@AdditionInfo", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@PositionInitFile", SqlDbType.Int,4) ,
                        new SqlParameter("@PositionPdfFile", SqlDbType.Int,4) ,
                        new SqlParameter("@PositionSourceUrl", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@PositionSourceText", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@PubDate", SqlDbType.NVarChar,50) ,
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

            parameters[0].Value = model.PositionName;
            parameters[1].Value = model.PositionDesc;
            parameters[2].Value = model.WordAddress;
            parameters[3].Value = model.NeedNum;
            parameters[4].Value = model.DeptID;
            parameters[5].Value = model.PubOrgID;
            parameters[6].Value = model.ReportObj;
            parameters[7].Value = model.OrgNum;
            parameters[8].Value = model.SalaryBein;
            parameters[9].Value = model.SalaryEnd;
            parameters[10].Value = model.PositionEdge;
            parameters[11].Value = model.PostionReason;
            parameters[12].Value = model.CommissionType;
            parameters[13].Value = model.PriceCommission;
            parameters[14].Value = model.PricePre;
            parameters[15].Value = model.PriceInterview;
            parameters[16].Value = model.PriceJoinWork;
            parameters[17].Value = model.PriceGetWork;
            parameters[18].Value = model.SafeDay;
            parameters[19].Value = model.RequireContent;
            parameters[20].Value = model.RequireEdu;
            parameters[21].Value = model.RequireAbility;
            parameters[22].Value = model.RequireExperience;
            parameters[23].Value = model.RequireYear;
            parameters[24].Value = model.RequireProject;
            parameters[25].Value = model.AdditionInfo;
            parameters[26].Value = model.PositionInitFile;
            parameters[27].Value = model.PositionPdfFile;
            parameters[28].Value = model.PositionSourceUrl;
            parameters[29].Value = model.PositionSourceText;
            parameters[30].Value = model.PubDate;
            parameters[31].Value = model.AppID;
            parameters[32].Value = model.Version;
            parameters[33].Value = model.RandomNo;
            parameters[34].Value = model.ParentID;
            parameters[35].Value = model.Remark;
            parameters[36].Value = model.LableText;
            parameters[37].Value = model.ExJson;
            parameters[38].Value = model.Status;
            parameters[39].Value = model.OrderNo;
            parameters[40].Value = model.CreateDate;
            parameters[41].Value = model.ModifyDate;
            parameters[42].Value = model.CreateUser;
            parameters[43].Value = model.ModifyUser;

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
        public bool Update(Maticsoft.Model.tabPosition model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tabPosition set ");

            strSql.Append(" PositionName = @PositionName , ");
            strSql.Append(" PositionDesc = @PositionDesc , ");
            strSql.Append(" WordAddress = @WordAddress , ");
            strSql.Append(" NeedNum = @NeedNum , ");
            strSql.Append(" DeptID = @DeptID , ");
            strSql.Append(" PubOrgID = @PubOrgID , ");
            strSql.Append(" ReportObj = @ReportObj , ");
            strSql.Append(" OrgNum = @OrgNum , ");
            strSql.Append(" SalaryBein = @SalaryBein , ");
            strSql.Append(" SalaryEnd = @SalaryEnd , ");
            strSql.Append(" PositionEdge = @PositionEdge , ");
            strSql.Append(" PostionReason = @PostionReason , ");
            strSql.Append(" CommissionType = @CommissionType , ");
            strSql.Append(" PriceCommission = @PriceCommission , ");
            strSql.Append(" PricePre = @PricePre , ");
            strSql.Append(" PriceInterview = @PriceInterview , ");
            strSql.Append(" PriceJoinWork = @PriceJoinWork , ");
            strSql.Append(" PriceGetWork = @PriceGetWork , ");
            strSql.Append(" SafeDay = @SafeDay , ");
            strSql.Append(" RequireContent = @RequireContent , ");
            strSql.Append(" RequireEdu = @RequireEdu , ");
            strSql.Append(" RequireAbility = @RequireAbility , ");
            strSql.Append(" RequireExperience = @RequireExperience , ");
            strSql.Append(" RequireYear = @RequireYear , ");
            strSql.Append(" RequireProject = @RequireProject , ");
            strSql.Append(" AdditionInfo = @AdditionInfo , ");
            strSql.Append(" PositionInitFile = @PositionInitFile , ");
            strSql.Append(" PositionPdfFile = @PositionPdfFile , ");
            strSql.Append(" PositionSourceUrl = @PositionSourceUrl , ");
            strSql.Append(" PositionSourceText = @PositionSourceText , ");
            strSql.Append(" PubDate = @PubDate , ");
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
                        new SqlParameter("@PositionName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@PositionDesc", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@WordAddress", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@NeedNum", SqlDbType.Int,4) ,
                        new SqlParameter("@DeptID", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@PubOrgID", SqlDbType.Int,4) ,
                        new SqlParameter("@ReportObj", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@OrgNum", SqlDbType.Int,4) ,
                        new SqlParameter("@SalaryBein", SqlDbType.Int,4) ,
                        new SqlParameter("@SalaryEnd", SqlDbType.Int,4) ,
                        new SqlParameter("@PositionEdge", SqlDbType.NVarChar,500) ,
                        new SqlParameter("@PostionReason", SqlDbType.NVarChar,500) ,
                        new SqlParameter("@CommissionType", SqlDbType.Int,4) ,
                        new SqlParameter("@PriceCommission", SqlDbType.Int,4) ,
                        new SqlParameter("@PricePre", SqlDbType.Int,4) ,
                        new SqlParameter("@PriceInterview", SqlDbType.Int,4) ,
                        new SqlParameter("@PriceJoinWork", SqlDbType.Int,4) ,
                        new SqlParameter("@PriceGetWork", SqlDbType.Int,4) ,
                        new SqlParameter("@SafeDay", SqlDbType.Int,4) ,
                        new SqlParameter("@RequireContent", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@RequireEdu", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@RequireAbility", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@RequireExperience", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@RequireYear", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@RequireProject", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@AdditionInfo", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("@PositionInitFile", SqlDbType.Int,4) ,
                        new SqlParameter("@PositionPdfFile", SqlDbType.Int,4) ,
                        new SqlParameter("@PositionSourceUrl", SqlDbType.NVarChar,200) ,
                        new SqlParameter("@PositionSourceText", SqlDbType.NVarChar,50) ,
                        new SqlParameter("@PubDate", SqlDbType.NVarChar,50) ,
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

            parameters[0].Value = model.PositionName;
            parameters[1].Value = model.PositionDesc;
            parameters[2].Value = model.WordAddress;
            parameters[3].Value = model.NeedNum;
            parameters[4].Value = model.DeptID;
            parameters[5].Value = model.PubOrgID;
            parameters[6].Value = model.ReportObj;
            parameters[7].Value = model.OrgNum;
            parameters[8].Value = model.SalaryBein;
            parameters[9].Value = model.SalaryEnd;
            parameters[10].Value = model.PositionEdge;
            parameters[11].Value = model.PostionReason;
            parameters[12].Value = model.CommissionType;
            parameters[13].Value = model.PriceCommission;
            parameters[14].Value = model.PricePre;
            parameters[15].Value = model.PriceInterview;
            parameters[16].Value = model.PriceJoinWork;
            parameters[17].Value = model.PriceGetWork;
            parameters[18].Value = model.SafeDay;
            parameters[19].Value = model.RequireContent;
            parameters[20].Value = model.RequireEdu;
            parameters[21].Value = model.RequireAbility;
            parameters[22].Value = model.RequireExperience;
            parameters[23].Value = model.RequireYear;
            parameters[24].Value = model.RequireProject;
            parameters[25].Value = model.AdditionInfo;
            parameters[26].Value = model.PositionInitFile;
            parameters[27].Value = model.PositionPdfFile;
            parameters[28].Value = model.PositionSourceUrl;
            parameters[29].Value = model.PositionSourceText;
            parameters[30].Value = model.PubDate;
            parameters[31].Value = model.id;
            parameters[32].Value = model.AppID;
            parameters[33].Value = model.Version;
            parameters[34].Value = model.RandomNo;
            parameters[35].Value = model.ParentID;
            parameters[36].Value = model.Remark;
            parameters[37].Value = model.LableText;
            parameters[38].Value = model.ExJson;
            parameters[39].Value = model.Status;
            parameters[40].Value = model.OrderNo;
            parameters[41].Value = model.CreateDate;
            parameters[42].Value = model.ModifyDate;
            parameters[43].Value = model.CreateUser;
            parameters[44].Value = model.ModifyUser;
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
            strSql.Append("delete from tabPosition ");
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
            strSql.Append("delete from tabPosition ");
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
        public Maticsoft.Model.tabPosition GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PositionName, PositionDesc, WordAddress, NeedNum, DeptID, PubOrgID, ReportObj, OrgNum, SalaryBein, SalaryEnd, PositionEdge, PostionReason, CommissionType, PriceCommission, PricePre, PriceInterview, PriceJoinWork, PriceGetWork, SafeDay, RequireContent, RequireEdu, RequireAbility, RequireExperience, RequireYear, RequireProject, AdditionInfo, PositionInitFile, PositionPdfFile, PositionSourceUrl, PositionSourceText, PubDate, id, AppID, Version, RandomNo, ParentID, Remark, LableText, ExJson, Status, OrderNo, CreateDate, ModifyDate, CreateUser, ModifyUser  ");
            strSql.Append("  from tabPosition ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;


            Maticsoft.Model.tabPosition model = new Maticsoft.Model.tabPosition();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                model.PositionName = ds.Tables[0].Rows[0]["PositionName"].ToString();
                model.PositionDesc = ds.Tables[0].Rows[0]["PositionDesc"].ToString();
                model.WordAddress = ds.Tables[0].Rows[0]["WordAddress"].ToString();
                if (ds.Tables[0].Rows[0]["NeedNum"].ToString() != "")
                {
                    model.NeedNum = int.Parse(ds.Tables[0].Rows[0]["NeedNum"].ToString());
                }
                model.DeptID = ds.Tables[0].Rows[0]["DeptID"].ToString();
                if (ds.Tables[0].Rows[0]["PubOrgID"].ToString() != "")
                {
                    model.PubOrgID = int.Parse(ds.Tables[0].Rows[0]["PubOrgID"].ToString());
                }
                model.ReportObj = ds.Tables[0].Rows[0]["ReportObj"].ToString();
                if (ds.Tables[0].Rows[0]["OrgNum"].ToString() != "")
                {
                    model.OrgNum = int.Parse(ds.Tables[0].Rows[0]["OrgNum"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SalaryBein"].ToString() != "")
                {
                    model.SalaryBein = int.Parse(ds.Tables[0].Rows[0]["SalaryBein"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SalaryEnd"].ToString() != "")
                {
                    model.SalaryEnd = int.Parse(ds.Tables[0].Rows[0]["SalaryEnd"].ToString());
                }
                model.PositionEdge = ds.Tables[0].Rows[0]["PositionEdge"].ToString();
                model.PostionReason = ds.Tables[0].Rows[0]["PostionReason"].ToString();
                if (ds.Tables[0].Rows[0]["CommissionType"].ToString() != "")
                {
                    model.CommissionType = int.Parse(ds.Tables[0].Rows[0]["CommissionType"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PriceCommission"].ToString() != "")
                {
                    model.PriceCommission = int.Parse(ds.Tables[0].Rows[0]["PriceCommission"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PricePre"].ToString() != "")
                {
                    model.PricePre = int.Parse(ds.Tables[0].Rows[0]["PricePre"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PriceInterview"].ToString() != "")
                {
                    model.PriceInterview = int.Parse(ds.Tables[0].Rows[0]["PriceInterview"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PriceJoinWork"].ToString() != "")
                {
                    model.PriceJoinWork = int.Parse(ds.Tables[0].Rows[0]["PriceJoinWork"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PriceGetWork"].ToString() != "")
                {
                    model.PriceGetWork = int.Parse(ds.Tables[0].Rows[0]["PriceGetWork"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SafeDay"].ToString() != "")
                {
                    model.SafeDay = int.Parse(ds.Tables[0].Rows[0]["SafeDay"].ToString());
                }
                model.RequireContent = ds.Tables[0].Rows[0]["RequireContent"].ToString();
                model.RequireEdu = ds.Tables[0].Rows[0]["RequireEdu"].ToString();
                model.RequireAbility = ds.Tables[0].Rows[0]["RequireAbility"].ToString();
                model.RequireExperience = ds.Tables[0].Rows[0]["RequireExperience"].ToString();
                model.RequireYear = ds.Tables[0].Rows[0]["RequireYear"].ToString();
                model.RequireProject = ds.Tables[0].Rows[0]["RequireProject"].ToString();
                model.AdditionInfo = ds.Tables[0].Rows[0]["AdditionInfo"].ToString();
                if (ds.Tables[0].Rows[0]["PositionInitFile"].ToString() != "")
                {
                    model.PositionInitFile = int.Parse(ds.Tables[0].Rows[0]["PositionInitFile"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PositionPdfFile"].ToString() != "")
                {
                    model.PositionPdfFile = int.Parse(ds.Tables[0].Rows[0]["PositionPdfFile"].ToString());
                }
                model.PositionSourceUrl = ds.Tables[0].Rows[0]["PositionSourceUrl"].ToString();
                model.PositionSourceText = ds.Tables[0].Rows[0]["PositionSourceText"].ToString();
                model.PubDate = ds.Tables[0].Rows[0]["PubDate"].ToString();
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
            strSql.Append(" FROM tabPosition ");
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
            strSql.Append(" FROM tabPosition ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

