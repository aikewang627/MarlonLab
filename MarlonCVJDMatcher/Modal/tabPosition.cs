using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Maticsoft.Model{
	 	//tabPosition
		public class tabPosition
	{
   		     
      	/// <summary>
		/// 职位名称
        /// </summary>		
		private string _positionname;
        public string PositionName
        {
            get{ return _positionname; }
            set{ _positionname = value; }
        }        
		/// <summary>
		/// 职位描述
        /// </summary>		
		private string _positiondesc;
        public string PositionDesc
        {
            get{ return _positiondesc; }
            set{ _positiondesc = value; }
        }        
		/// <summary>
		/// 工作地点
        /// </summary>		
		private string _wordaddress;
        public string WordAddress
        {
            get{ return _wordaddress; }
            set{ _wordaddress = value; }
        }        
		/// <summary>
		/// 招聘人数
        /// </summary>		
		private int _neednum;
        public int NeedNum
        {
            get{ return _neednum; }
            set{ _neednum = value; }
        }        
		/// <summary>
		/// 职位所属部门编号，可通过逆向查询公司名称
        /// </summary>		
		private string _deptid;
        public string DeptID
        {
            get{ return _deptid; }
            set{ _deptid = value; }
        }        
		/// <summary>
		/// 操作职位发布的公司ID，企业自己或猎头公司
        /// </summary>		
		private int _puborgid;
        public int PubOrgID
        {
            get{ return _puborgid; }
            set{ _puborgid = value; }
        }        
		/// <summary>
		/// 汇报对象
        /// </summary>		
		private string _reportobj;
        public string ReportObj
        {
            get{ return _reportobj; }
            set{ _reportobj = value; }
        }        
		/// <summary>
		/// 下属人数
        /// </summary>		
		private int _orgnum;
        public int OrgNum
        {
            get{ return _orgnum; }
            set{ _orgnum = value; }
        }        
		/// <summary>
		/// 年薪下限，单位：分
        /// </summary>		
		private int _salarybein;
        public int SalaryBein
        {
            get{ return _salarybein; }
            set{ _salarybein = value; }
        }        
		/// <summary>
		/// 年薪上限，单位：分
        /// </summary>		
		private int _salaryend;
        public int SalaryEnd
        {
            get{ return _salaryend; }
            set{ _salaryend = value; }
        }        
		/// <summary>
		/// 职位亮点
        /// </summary>		
		private string _positionedge;
        public string PositionEdge
        {
            get{ return _positionedge; }
            set{ _positionedge = value; }
        }        
		/// <summary>
		/// 职位开放原因
        /// </summary>		
		private string _postionreason;
        public string PostionReason
        {
            get{ return _postionreason; }
            set{ _postionreason = value; }
        }        
		/// <summary>
		/// 佣金政策类型：0：0元招聘；1：行规价；2：自定义价
        /// </summary>		
		private int _commissiontype;
        public int CommissionType
        {
            get{ return _commissiontype; }
            set{ _commissiontype = value; }
        }        
		/// <summary>
		/// 佣金总额，单位：分
        /// </summary>		
		private int _pricecommission;
        public int PriceCommission
        {
            get{ return _pricecommission; }
            set{ _pricecommission = value; }
        }        
		/// <summary>
		/// 佣金预付款，单位：分
        /// </summary>		
		private int _pricepre;
        public int PricePre
        {
            get{ return _pricepre; }
            set{ _pricepre = value; }
        }        
		/// <summary>
		/// 面试后款，单位：分
        /// </summary>		
		private int _priceinterview;
        public int PriceInterview
        {
            get{ return _priceinterview; }
            set{ _priceinterview = value; }
        }        
		/// <summary>
		/// 入职后款，单位：分
        /// </summary>		
		private int _pricejoinwork;
        public int PriceJoinWork
        {
            get{ return _pricejoinwork; }
            set{ _pricejoinwork = value; }
        }        
		/// <summary>
		/// 转正后款，单位：分
        /// </summary>		
		private int _pricegetwork;
        public int PriceGetWork
        {
            get{ return _pricegetwork; }
            set{ _pricegetwork = value; }
        }        
		/// <summary>
		/// 安全天数
        /// </summary>		
		private int _safeday;
        public int SafeDay
        {
            get{ return _safeday; }
            set{ _safeday = value; }
        }        
		/// <summary>
		/// 岗位要求
        /// </summary>		
		private string _requirecontent;
        public string RequireContent
        {
            get{ return _requirecontent; }
            set{ _requirecontent = value; }
        }        
		/// <summary>
		/// 学历要求
        /// </summary>		
		private string _requireedu;
        public string RequireEdu
        {
            get{ return _requireedu; }
            set{ _requireedu = value; }
        }        
		/// <summary>
		/// 资质证书要求
        /// </summary>		
		private string _requireability;
        public string RequireAbility
        {
            get{ return _requireability; }
            set{ _requireability = value; }
        }        
		/// <summary>
		/// 特殊工作经历要求
        /// </summary>		
		private string _requireexperience;
        public string RequireExperience
        {
            get{ return _requireexperience; }
            set{ _requireexperience = value; }
        }        
		/// <summary>
		/// 工作年限；下拉框：应届生；0-1年；1-3年；3-5年；5-10年；10年以上
        /// </summary>		
		private string _requireyear;
        public string RequireYear
        {
            get{ return _requireyear; }
            set{ _requireyear = value; }
        }        
		/// <summary>
		/// 项目要求
        /// </summary>		
		private string _requireproject;
        public string RequireProject
        {
            get{ return _requireproject; }
            set{ _requireproject = value; }
        }        
		/// <summary>
		/// 补充信息，使用json格式对其进行区分
        /// </summary>		
		private string _additioninfo;
        public string AdditionInfo
        {
            get{ return _additioninfo; }
            set{ _additioninfo = value; }
        }        
		/// <summary>
		/// 原始文件id（tabAsset.ID，没有原始文件则默认为0
        /// </summary>		
		private int _positioninitfile;
        public int PositionInitFile
        {
            get{ return _positioninitfile; }
            set{ _positioninitfile = value; }
        }        
		/// <summary>
		/// PDF版本文件编号(tabAssets.id)
        /// </summary>		
		private int _positionpdffile;
        public int PositionPdfFile
        {
            get{ return _positionpdffile; }
            set{ _positionpdffile = value; }
        }        
		/// <summary>
		/// 职位来源URL，如国际机器人大会URL
        /// </summary>		
		private string _positionsourceurl;
        public string PositionSourceUrl
        {
            get{ return _positionsourceurl; }
            set{ _positionsourceurl = value; }
        }        
		/// <summary>
		/// 职位来源文本，如国际机器人大会
        /// </summary>		
		private string _positionsourcetext;
        public string PositionSourceText
        {
            get{ return _positionsourcetext; }
            set{ _positionsourcetext = value; }
        }        
		/// <summary>
		/// 发布/暂停/停止时间，状态根据Status来判定
        /// </summary>		
		private string _pubdate;
        public string PubDate
        {
            get{ return _pubdate; }
            set{ _pubdate = value; }
        }        
		/// <summary>
		/// 编号
        /// </summary>		
		private int _id;
        public int id
        {
            get{ return _id; }
            set{ _id = value; }
        }        
		/// <summary>
		/// AppID
        /// </summary>		
		private string _appid;
        public string AppID
        {
            get{ return _appid; }
            set{ _appid = value; }
        }        
		/// <summary>
		/// Version
        /// </summary>		
		private string _version;
        public string Version
        {
            get{ return _version; }
            set{ _version = value; }
        }        
		/// <summary>
		/// 随机码
        /// </summary>		
		private string _randomno;
        public string RandomNo
        {
            get{ return _randomno; }
            set{ _randomno = value; }
        }        
		/// <summary>
		/// 职位所属公司
        /// </summary>		
		private int _parentid;
        public int ParentID
        {
            get{ return _parentid; }
            set{ _parentid = value; }
        }        
		/// <summary>
		/// 备注 ，当Status为1时，可为审核中，审核成功后为空字符
        /// </summary>		
		private string _remark;
        public string Remark
        {
            get{ return _remark; }
            set{ _remark = value; }
        }        
		/// <summary>
		/// 标签
        /// </summary>		
		private string _labletext;
        public string LableText
        {
            get{ return _labletext; }
            set{ _labletext = value; }
        }        
		/// <summary>
		/// 扩展Json
        /// </summary>		
		private string _exjson;
        public string ExJson
        {
            get{ return _exjson; }
            set{ _exjson = value; }
        }        
		/// <summary>
		/// 状态：-1：草拟；0:关闭职位；1：开放职位；2：暂停职位
        /// </summary>		
		private string _status;
        public string Status
        {
            get{ return _status; }
            set{ _status = value; }
        }        
		/// <summary>
		/// 排序
        /// </summary>		
		private int _orderno;
        public int OrderNo
        {
            get{ return _orderno; }
            set{ _orderno = value; }
        }        
		/// <summary>
		/// 创建时间
        /// </summary>		
		private string _createdate;
        public string CreateDate
        {
            get{ return _createdate; }
            set{ _createdate = value; }
        }        
		/// <summary>
		/// 修改时间
        /// </summary>		
		private string _modifydate;
        public string ModifyDate
        {
            get{ return _modifydate; }
            set{ _modifydate = value; }
        }        
		/// <summary>
		/// 创建用户
        /// </summary>		
		private int _createuser;
        public int CreateUser
        {
            get{ return _createuser; }
            set{ _createuser = value; }
        }        
		/// <summary>
		/// 修改用户
        /// </summary>		
		private int _modifyuser;
        public int ModifyUser
        {
            get{ return _modifyuser; }
            set{ _modifyuser = value; }
        }        
		   
	}
}

