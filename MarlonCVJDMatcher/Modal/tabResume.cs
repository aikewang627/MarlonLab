using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Maticsoft.Model{
	 	//简历表
		public class tabResume
	{
   		     
      	/// <summary>
		/// ResumeNo
        /// </summary>		
		private string _resumeno;
        public string ResumeNo
        {
            get{ return _resumeno; }
            set{ _resumeno = value; }
        }        
		/// <summary>
		/// 特殊标识（简历名称）
        /// </summary>		
		private string _resumename;
        public string ResumeName
        {
            get{ return _resumename; }
            set{ _resumename = value; }
        }        
		/// <summary>
		/// 用户编号
        /// </summary>		
		private int _userid;
        public int UserID
        {
            get{ return _userid; }
            set{ _userid = value; }
        }        
		/// <summary>
		/// 是否自己的简历，在创建简历的时候自动作出判断
        /// </summary>		
		private bool _isme;
        public bool IsMe
        {
            get{ return _isme; }
            set{ _isme = value; }
        }        
		/// <summary>
		/// 是否公开联系方式
        /// </summary>		
		private bool _isdisplayrealname;
        public bool IsDisplayRealName
        {
            get{ return _isdisplayrealname; }
            set{ _isdisplayrealname = value; }
        }        
		/// <summary>
		/// 最近职位
        /// </summary>		
		private string _curposition;
        public string CurPosition
        {
            get{ return _curposition; }
            set{ _curposition = value; }
        }        
		/// <summary>
		/// 目前年薪
        /// </summary>		
		private decimal _cursalary;
        public decimal CurSalary
        {
            get{ return _cursalary; }
            set{ _cursalary = value; }
        }        
		/// <summary>
		/// 当前公司名称
        /// </summary>		
		private string _curcomapny;
        public string CurComapny
        {
            get{ return _curcomapny; }
            set{ _curcomapny = value; }
        }        
		/// <summary>
		/// 当前行业职能
        /// </summary>		
		private string _curindustry;
        public string CurIndustry
        {
            get{ return _curindustry; }
            set{ _curindustry = value; }
        }        
		/// <summary>
		/// 求职状态
        /// </summary>		
		private string _curstatus;
        public string CurStatus
        {
            get{ return _curstatus; }
            set{ _curstatus = value; }
        }        
		/// <summary>
		/// 目前居住地
        /// </summary>		
		private string _curaddress;
        public string CurAddress
        {
            get{ return _curaddress; }
            set{ _curaddress = value; }
        }        
		/// <summary>
		/// 期望工作地址
        /// </summary>		
		private string _hopeaddress;
        public string HopeAddress
        {
            get{ return _hopeaddress; }
            set{ _hopeaddress = value; }
        }        
		/// <summary>
		/// 期望职位
        /// </summary>		
		private string _hopeposition;
        public string HopePosition
        {
            get{ return _hopeposition; }
            set{ _hopeposition = value; }
        }        
		/// <summary>
		/// 期望行业
        /// </summary>		
		private string _hopeindustry;
        public string HopeIndustry
        {
            get{ return _hopeindustry; }
            set{ _hopeindustry = value; }
        }        
		/// <summary>
		/// HopeSalary
        /// </summary>		
		private decimal _hopesalary;
        public decimal HopeSalary
        {
            get{ return _hopesalary; }
            set{ _hopesalary = value; }
        }        
		/// <summary>
		/// 猎手评价
        /// </summary>		
		private string _huntercomment;
        public string HunterComment
        {
            get{ return _huntercomment; }
            set{ _huntercomment = value; }
        }        
		/// <summary>
		/// 简历原始文档
        /// </summary>		
		private int _resumeinitfile;
        public int ResumeInitFile
        {
            get{ return _resumeinitfile; }
            set{ _resumeinitfile = value; }
        }        
		/// <summary>
		/// ResumePDFFile
        /// </summary>		
		private int _resumepdffile;
        public int ResumePDFFile
        {
            get{ return _resumepdffile; }
            set{ _resumepdffile = value; }
        }        
		/// <summary>
		/// 其他信息
        /// </summary>		
		private string _other;
        public string Other
        {
            get{ return _other; }
            set{ _other = value; }
        }        
		/// <summary>
		/// 建立购买单价，单位：分
        /// </summary>		
		private int _price;
        public int Price
        {
            get{ return _price; }
            set{ _price = value; }
        }        
		/// <summary>
		/// 职位来源URL，如国际机器人大会URL
        /// </summary>		
		private string _sourceurl;
        public string SourceUrl
        {
            get{ return _sourceurl; }
            set{ _sourceurl = value; }
        }        
		/// <summary>
		/// 职位来源文本，如国际机器人大会
        /// </summary>		
		private string _sourcetext;
        public string SourceText
        {
            get{ return _sourcetext; }
            set{ _sourcetext = value; }
        }        
		/// <summary>
		/// 简历标签
        /// </summary>		
		private string _tags;
        public string Tags
        {
            get{ return _tags; }
            set{ _tags = value; }
        }        
		/// <summary>
		/// 语言能力
        /// </summary>		
		private string _lang;
        public string Lang
        {
            get{ return _lang; }
            set{ _lang = value; }
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
		/// 上级编号
        /// </summary>		
		private int _parentid;
        public int ParentID
        {
            get{ return _parentid; }
            set{ _parentid = value; }
        }        
		/// <summary>
		/// 备注
        /// </summary>		
		private string _remark;
        public string Remark
        {
            get{ return _remark; }
            set{ _remark = value; }
        }        
		/// <summary>
		/// 简历标签
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
		/// 状态
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

