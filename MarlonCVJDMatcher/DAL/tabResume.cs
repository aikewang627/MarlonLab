using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Maticsoft.DBUtility;
namespace Maticsoft.DAL
{
    //简历表
    public partial class tabResume
    {

        public bool Exists(string ResumeNo, string ResumeName, bool IsMe, string CurPosition, string CurStatus, string HopeAddress, string HopePosition, string HopeIndustry, int id, int ParentID, string CreateDate, string ModifyDate, int CreateUser)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tabResume");
            strSql.Append(" where ");
            strSql.Append(" ResumeNo = SQL2012ResumeNo and  ");
            strSql.Append(" ResumeName = SQL2012ResumeName and  ");
            strSql.Append(" IsMe = SQL2012IsMe and  ");
            strSql.Append(" CurPosition = SQL2012CurPosition and  ");
            strSql.Append(" CurStatus = SQL2012CurStatus and  ");
            strSql.Append(" HopeAddress = SQL2012HopeAddress and  ");
            strSql.Append(" HopePosition = SQL2012HopePosition and  ");
            strSql.Append(" HopeIndustry = SQL2012HopeIndustry and  ");
            strSql.Append(" id = SQL2012id and  ");
            strSql.Append(" ParentID = SQL2012ParentID and  ");
            strSql.Append(" CreateDate = SQL2012CreateDate and  ");
            strSql.Append(" ModifyDate = SQL2012ModifyDate and  ");
            strSql.Append(" CreateUser = SQL2012CreateUser  ");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012ResumeNo", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012ResumeName", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012IsMe", SqlDbType.Bit,1),
                    new SqlParameter("SQL2012CurPosition", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012CurStatus", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012HopeAddress", SqlDbType.NVarChar,100),
                    new SqlParameter("SQL2012HopePosition", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012HopeIndustry", SqlDbType.NVarChar,50),
                    new SqlParameter("SQL2012id", SqlDbType.Int,4),
                    new SqlParameter("SQL2012ParentID", SqlDbType.Int,4),
                    new SqlParameter("SQL2012CreateDate", SqlDbType.NVarChar,200),
                    new SqlParameter("SQL2012ModifyDate", SqlDbType.NVarChar,200),
                    new SqlParameter("SQL2012CreateUser", SqlDbType.Int,4)          };
            parameters[0].Value = ResumeNo;
            parameters[1].Value = ResumeName;
            parameters[2].Value = IsMe;
            parameters[3].Value = CurPosition;
            parameters[4].Value = CurStatus;
            parameters[5].Value = HopeAddress;
            parameters[6].Value = HopePosition;
            parameters[7].Value = HopeIndustry;
            parameters[8].Value = id;
            parameters[9].Value = ParentID;
            parameters[10].Value = CreateDate;
            parameters[11].Value = ModifyDate;
            parameters[12].Value = CreateUser;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.tabResume model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tabResume(");
            strSql.Append("ResumeNo,ResumeName,UserID,IsMe,IsDisplayRealName,CurPosition,CurSalary,CurComapny,CurIndustry,CurStatus,CurAddress,HopeAddress,HopePosition,HopeIndustry,HopeSalary,HunterComment,ResumeInitFile,ResumePDFFile,Other,Price,SourceUrl,SourceText,Tags,Lang,AppID,Version,RandomNo,ParentID,Remark,LableText,ExJson,Status,OrderNo,CreateDate,ModifyDate,CreateUser,ModifyUser");
            strSql.Append(") values (");
            strSql.Append("SQL2012ResumeNo,SQL2012ResumeName,SQL2012UserID,SQL2012IsMe,SQL2012IsDisplayRealName,SQL2012CurPosition,SQL2012CurSalary,SQL2012CurComapny,SQL2012CurIndustry,SQL2012CurStatus,SQL2012CurAddress,SQL2012HopeAddress,SQL2012HopePosition,SQL2012HopeIndustry,SQL2012HopeSalary,SQL2012HunterComment,SQL2012ResumeInitFile,SQL2012ResumePDFFile,SQL2012Other,SQL2012Price,SQL2012SourceUrl,SQL2012SourceText,SQL2012Tags,SQL2012Lang,SQL2012AppID,SQL2012Version,SQL2012RandomNo,SQL2012ParentID,SQL2012Remark,SQL2012LableText,SQL2012ExJson,SQL2012Status,SQL2012OrderNo,SQL2012CreateDate,SQL2012ModifyDate,SQL2012CreateUser,SQL2012ModifyUser");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                        new SqlParameter("SQL2012ResumeNo", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012ResumeName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012UserID", SqlDbType.Int,4) ,
                        new SqlParameter("SQL2012IsMe", SqlDbType.Bit,1) ,
                        new SqlParameter("SQL2012IsDisplayRealName", SqlDbType.Bit,1) ,
                        new SqlParameter("SQL2012CurPosition", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012CurSalary", SqlDbType.Decimal,9) ,
                        new SqlParameter("SQL2012CurComapny", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012CurIndustry", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012CurStatus", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012CurAddress", SqlDbType.NVarChar,100) ,
                        new SqlParameter("SQL2012HopeAddress", SqlDbType.NVarChar,100) ,
                        new SqlParameter("SQL2012HopePosition", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012HopeIndustry", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012HopeSalary", SqlDbType.Decimal,9) ,
                        new SqlParameter("SQL2012HunterComment", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("SQL2012ResumeInitFile", SqlDbType.Int,4) ,
                        new SqlParameter("SQL2012ResumePDFFile", SqlDbType.Int,4) ,
                        new SqlParameter("SQL2012Other", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("SQL2012Price", SqlDbType.Int,4) ,
                        new SqlParameter("SQL2012SourceUrl", SqlDbType.NVarChar,200) ,
                        new SqlParameter("SQL2012SourceText", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012Tags", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012Lang", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012AppID", SqlDbType.NVarChar,100) ,
                        new SqlParameter("SQL2012Version", SqlDbType.NVarChar,100) ,
                        new SqlParameter("SQL2012RandomNo", SqlDbType.NVarChar,200) ,
                        new SqlParameter("SQL2012ParentID", SqlDbType.Int,4) ,
                        new SqlParameter("SQL2012Remark", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("SQL2012LableText", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("SQL2012ExJson", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("SQL2012Status", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("SQL2012OrderNo", SqlDbType.Int,4) ,
                        new SqlParameter("SQL2012CreateDate", SqlDbType.NVarChar,200) ,
                        new SqlParameter("SQL2012ModifyDate", SqlDbType.NVarChar,200) ,
                        new SqlParameter("SQL2012CreateUser", SqlDbType.Int,4) ,
                        new SqlParameter("SQL2012ModifyUser", SqlDbType.Int,4)

            };

            parameters[0].Value = model.ResumeNo;
            parameters[1].Value = model.ResumeName;
            parameters[2].Value = model.UserID;
            parameters[3].Value = model.IsMe;
            parameters[4].Value = model.IsDisplayRealName;
            parameters[5].Value = model.CurPosition;
            parameters[6].Value = model.CurSalary;
            parameters[7].Value = model.CurComapny;
            parameters[8].Value = model.CurIndustry;
            parameters[9].Value = model.CurStatus;
            parameters[10].Value = model.CurAddress;
            parameters[11].Value = model.HopeAddress;
            parameters[12].Value = model.HopePosition;
            parameters[13].Value = model.HopeIndustry;
            parameters[14].Value = model.HopeSalary;
            parameters[15].Value = model.HunterComment;
            parameters[16].Value = model.ResumeInitFile;
            parameters[17].Value = model.ResumePDFFile;
            parameters[18].Value = model.Other;
            parameters[19].Value = model.Price;
            parameters[20].Value = model.SourceUrl;
            parameters[21].Value = model.SourceText;
            parameters[22].Value = model.Tags;
            parameters[23].Value = model.Lang;
            parameters[24].Value = model.AppID;
            parameters[25].Value = model.Version;
            parameters[26].Value = model.RandomNo;
            parameters[27].Value = model.ParentID;
            parameters[28].Value = model.Remark;
            parameters[29].Value = model.LableText;
            parameters[30].Value = model.ExJson;
            parameters[31].Value = model.Status;
            parameters[32].Value = model.OrderNo;
            parameters[33].Value = model.CreateDate;
            parameters[34].Value = model.ModifyDate;
            parameters[35].Value = model.CreateUser;
            parameters[36].Value = model.ModifyUser;

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
        public bool Update(Maticsoft.Model.tabResume model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tabResume set ");

            strSql.Append(" ResumeNo = SQL2012ResumeNo , ");
            strSql.Append(" ResumeName = SQL2012ResumeName , ");
            strSql.Append(" UserID = SQL2012UserID , ");
            strSql.Append(" IsMe = SQL2012IsMe , ");
            strSql.Append(" IsDisplayRealName = SQL2012IsDisplayRealName , ");
            strSql.Append(" CurPosition = SQL2012CurPosition , ");
            strSql.Append(" CurSalary = SQL2012CurSalary , ");
            strSql.Append(" CurComapny = SQL2012CurComapny , ");
            strSql.Append(" CurIndustry = SQL2012CurIndustry , ");
            strSql.Append(" CurStatus = SQL2012CurStatus , ");
            strSql.Append(" CurAddress = SQL2012CurAddress , ");
            strSql.Append(" HopeAddress = SQL2012HopeAddress , ");
            strSql.Append(" HopePosition = SQL2012HopePosition , ");
            strSql.Append(" HopeIndustry = SQL2012HopeIndustry , ");
            strSql.Append(" HopeSalary = SQL2012HopeSalary , ");
            strSql.Append(" HunterComment = SQL2012HunterComment , ");
            strSql.Append(" ResumeInitFile = SQL2012ResumeInitFile , ");
            strSql.Append(" ResumePDFFile = SQL2012ResumePDFFile , ");
            strSql.Append(" Other = SQL2012Other , ");
            strSql.Append(" Price = SQL2012Price , ");
            strSql.Append(" SourceUrl = SQL2012SourceUrl , ");
            strSql.Append(" SourceText = SQL2012SourceText , ");
            strSql.Append(" Tags = SQL2012Tags , ");
            strSql.Append(" Lang = SQL2012Lang , ");
            strSql.Append(" AppID = SQL2012AppID , ");
            strSql.Append(" Version = SQL2012Version , ");
            strSql.Append(" RandomNo = SQL2012RandomNo , ");
            strSql.Append(" ParentID = SQL2012ParentID , ");
            strSql.Append(" Remark = SQL2012Remark , ");
            strSql.Append(" LableText = SQL2012LableText , ");
            strSql.Append(" ExJson = SQL2012ExJson , ");
            strSql.Append(" Status = SQL2012Status , ");
            strSql.Append(" OrderNo = SQL2012OrderNo , ");
            strSql.Append(" CreateDate = SQL2012CreateDate , ");
            strSql.Append(" ModifyDate = SQL2012ModifyDate , ");
            strSql.Append(" CreateUser = SQL2012CreateUser , ");
            strSql.Append(" ModifyUser = SQL2012ModifyUser  ");
            strSql.Append(" where id=SQL2012id ");

            SqlParameter[] parameters = {
                        new SqlParameter("SQL2012ResumeNo", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012ResumeName", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012UserID", SqlDbType.Int,4) ,
                        new SqlParameter("SQL2012IsMe", SqlDbType.Bit,1) ,
                        new SqlParameter("SQL2012IsDisplayRealName", SqlDbType.Bit,1) ,
                        new SqlParameter("SQL2012CurPosition", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012CurSalary", SqlDbType.Decimal,9) ,
                        new SqlParameter("SQL2012CurComapny", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012CurIndustry", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012CurStatus", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012CurAddress", SqlDbType.NVarChar,100) ,
                        new SqlParameter("SQL2012HopeAddress", SqlDbType.NVarChar,100) ,
                        new SqlParameter("SQL2012HopePosition", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012HopeIndustry", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012HopeSalary", SqlDbType.Decimal,9) ,
                        new SqlParameter("SQL2012HunterComment", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("SQL2012ResumeInitFile", SqlDbType.Int,4) ,
                        new SqlParameter("SQL2012ResumePDFFile", SqlDbType.Int,4) ,
                        new SqlParameter("SQL2012Other", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("SQL2012Price", SqlDbType.Int,4) ,
                        new SqlParameter("SQL2012SourceUrl", SqlDbType.NVarChar,200) ,
                        new SqlParameter("SQL2012SourceText", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012Tags", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012Lang", SqlDbType.NVarChar,50) ,
                        new SqlParameter("SQL2012id", SqlDbType.Int,4) ,
                        new SqlParameter("SQL2012AppID", SqlDbType.NVarChar,100) ,
                        new SqlParameter("SQL2012Version", SqlDbType.NVarChar,100) ,
                        new SqlParameter("SQL2012RandomNo", SqlDbType.NVarChar,200) ,
                        new SqlParameter("SQL2012ParentID", SqlDbType.Int,4) ,
                        new SqlParameter("SQL2012Remark", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("SQL2012LableText", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("SQL2012ExJson", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("SQL2012Status", SqlDbType.NVarChar,-1) ,
                        new SqlParameter("SQL2012OrderNo", SqlDbType.Int,4) ,
                        new SqlParameter("SQL2012CreateDate", SqlDbType.NVarChar,200) ,
                        new SqlParameter("SQL2012ModifyDate", SqlDbType.NVarChar,200) ,
                        new SqlParameter("SQL2012CreateUser", SqlDbType.Int,4) ,
                        new SqlParameter("SQL2012ModifyUser", SqlDbType.Int,4)

            };

            parameters[0].Value = model.ResumeNo;
            parameters[1].Value = model.ResumeName;
            parameters[2].Value = model.UserID;
            parameters[3].Value = model.IsMe;
            parameters[4].Value = model.IsDisplayRealName;
            parameters[5].Value = model.CurPosition;
            parameters[6].Value = model.CurSalary;
            parameters[7].Value = model.CurComapny;
            parameters[8].Value = model.CurIndustry;
            parameters[9].Value = model.CurStatus;
            parameters[10].Value = model.CurAddress;
            parameters[11].Value = model.HopeAddress;
            parameters[12].Value = model.HopePosition;
            parameters[13].Value = model.HopeIndustry;
            parameters[14].Value = model.HopeSalary;
            parameters[15].Value = model.HunterComment;
            parameters[16].Value = model.ResumeInitFile;
            parameters[17].Value = model.ResumePDFFile;
            parameters[18].Value = model.Other;
            parameters[19].Value = model.Price;
            parameters[20].Value = model.SourceUrl;
            parameters[21].Value = model.SourceText;
            parameters[22].Value = model.Tags;
            parameters[23].Value = model.Lang;
            parameters[24].Value = model.id;
            parameters[25].Value = model.AppID;
            parameters[26].Value = model.Version;
            parameters[27].Value = model.RandomNo;
            parameters[28].Value = model.ParentID;
            parameters[29].Value = model.Remark;
            parameters[30].Value = model.LableText;
            parameters[31].Value = model.ExJson;
            parameters[32].Value = model.Status;
            parameters[33].Value = model.OrderNo;
            parameters[34].Value = model.CreateDate;
            parameters[35].Value = model.ModifyDate;
            parameters[36].Value = model.CreateUser;
            parameters[37].Value = model.ModifyUser;
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
            strSql.Append("delete from tabResume ");
            strSql.Append(" where id=SQL2012id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012id", SqlDbType.Int,4)
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
            strSql.Append("delete from tabResume ");
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
        public Maticsoft.Model.tabResume GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ResumeNo, ResumeName, UserID, IsMe, IsDisplayRealName, CurPosition, CurSalary, CurComapny, CurIndustry, CurStatus, CurAddress, HopeAddress, HopePosition, HopeIndustry, HopeSalary, HunterComment, ResumeInitFile, ResumePDFFile, Other, Price, SourceUrl, SourceText, Tags, Lang, id, AppID, Version, RandomNo, ParentID, Remark, LableText, ExJson, Status, OrderNo, CreateDate, ModifyDate, CreateUser, ModifyUser  ");
            strSql.Append("  from tabResume ");
            strSql.Append(" where id=SQL2012id");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;


            Maticsoft.Model.tabResume model = new Maticsoft.Model.tabResume();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                model.ResumeNo = ds.Tables[0].Rows[0]["ResumeNo"].ToString();
                model.ResumeName = ds.Tables[0].Rows[0]["ResumeName"].ToString();
                if (ds.Tables[0].Rows[0]["UserID"].ToString() != "")
                {
                    model.UserID = int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsMe"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsMe"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsMe"].ToString().ToLower() == "true"))
                    {
                        model.IsMe = true;
                    }
                    else
                    {
                        model.IsMe = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsDisplayRealName"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsDisplayRealName"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsDisplayRealName"].ToString().ToLower() == "true"))
                    {
                        model.IsDisplayRealName = true;
                    }
                    else
                    {
                        model.IsDisplayRealName = false;
                    }
                }
                model.CurPosition = ds.Tables[0].Rows[0]["CurPosition"].ToString();
                if (ds.Tables[0].Rows[0]["CurSalary"].ToString() != "")
                {
                    model.CurSalary = decimal.Parse(ds.Tables[0].Rows[0]["CurSalary"].ToString());
                }
                model.CurComapny = ds.Tables[0].Rows[0]["CurComapny"].ToString();
                model.CurIndustry = ds.Tables[0].Rows[0]["CurIndustry"].ToString();
                model.CurStatus = ds.Tables[0].Rows[0]["CurStatus"].ToString();
                model.CurAddress = ds.Tables[0].Rows[0]["CurAddress"].ToString();
                model.HopeAddress = ds.Tables[0].Rows[0]["HopeAddress"].ToString();
                model.HopePosition = ds.Tables[0].Rows[0]["HopePosition"].ToString();
                model.HopeIndustry = ds.Tables[0].Rows[0]["HopeIndustry"].ToString();
                if (ds.Tables[0].Rows[0]["HopeSalary"].ToString() != "")
                {
                    model.HopeSalary = decimal.Parse(ds.Tables[0].Rows[0]["HopeSalary"].ToString());
                }
                model.HunterComment = ds.Tables[0].Rows[0]["HunterComment"].ToString();
                if (ds.Tables[0].Rows[0]["ResumeInitFile"].ToString() != "")
                {
                    model.ResumeInitFile = int.Parse(ds.Tables[0].Rows[0]["ResumeInitFile"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ResumePDFFile"].ToString() != "")
                {
                    model.ResumePDFFile = int.Parse(ds.Tables[0].Rows[0]["ResumePDFFile"].ToString());
                }
                model.Other = ds.Tables[0].Rows[0]["Other"].ToString();
                if (ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    model.Price = int.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                model.SourceUrl = ds.Tables[0].Rows[0]["SourceUrl"].ToString();
                model.SourceText = ds.Tables[0].Rows[0]["SourceText"].ToString();
                model.Tags = ds.Tables[0].Rows[0]["Tags"].ToString();
                model.Lang = ds.Tables[0].Rows[0]["Lang"].ToString();
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
            strSql.Append(" FROM tabResume ");
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
            strSql.Append(" FROM tabResume ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

