using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Maticsoft.Model{
	 	//来往单位表（通表）
		public class tabOrg
	{
   		     
      	/// <summary>
		/// 结构名称
        /// </summary>		
		private string _orgname;
        public string OrgName
        {
            get{ return _orgname; }
            set{ _orgname = value; }
        }        
		/// <summary>
		/// 描述
        /// </summary>		
		private string _orgdesc;
        public string OrgDesc
        {
            get{ return _orgdesc; }
            set{ _orgdesc = value; }
        }        
		/// <summary>
		/// 简称
        /// </summary>		
		private string _orgnickname;
        public string OrgNickName
        {
            get{ return _orgnickname; }
            set{ _orgnickname = value; }
        }        
		/// <summary>
		/// 职责
        /// </summary>		
		private string _orgzz;
        public string OrgZZ
        {
            get{ return _orgzz; }
            set{ _orgzz = value; }
        }        
		/// <summary>
		/// 组织代码
        /// </summary>		
		private string _orgcode;
        public string OrgCode
        {
            get{ return _orgcode; }
            set{ _orgcode = value; }
        }        
		/// <summary>
		/// 机构类型，公司：Company；工会组织：Union；工会：部门：Dept
        /// </summary>		
		private string _orgtype;
        public string OrgType
        {
            get{ return _orgtype; }
            set{ _orgtype = value; }
        }        
		/// <summary>
		/// 自定义分类，客户类型：合作客户，潜在客户，意向客户，优质合作客户，集体所有，国有，外资，民营
        /// </summary>		
		private int _orgclass;
        public int OrgClass
        {
            get{ return _orgclass; }
            set{ _orgclass = value; }
        }        
		/// <summary>
		/// 发展阶段
        /// </summary>		
		private string _orglevel;
        public string OrgLevel
        {
            get{ return _orglevel; }
            set{ _orglevel = value; }
        }        
		/// <summary>
		/// 单位亮点
        /// </summary>		
		private string _orgedge;
        public string OrgEdge
        {
            get{ return _orgedge; }
            set{ _orgedge = value; }
        }        
		/// <summary>
		/// 专业领域
        /// </summary>		
		private string _orgpro;
        public string OrgPro
        {
            get{ return _orgpro; }
            set{ _orgpro = value; }
        }        
		/// <summary>
		/// 公司名片
        /// </summary>		
		private int _orgcard;
        public int OrgCard
        {
            get{ return _orgcard; }
            set{ _orgcard = value; }
        }        
		/// <summary>
		/// 编制
        /// </summary>		
		private int _plannum;
        public int PlanNum
        {
            get{ return _plannum; }
            set{ _plannum = value; }
        }        
		/// <summary>
		/// 联系人
        /// </summary>		
		private string _leader;
        public string Leader
        {
            get{ return _leader; }
            set{ _leader = value; }
        }        
		/// <summary>
		/// 领导手机
        /// </summary>		
		private string _leadermobile;
        public string LeaderMobile
        {
            get{ return _leadermobile; }
            set{ _leadermobile = value; }
        }        
		/// <summary>
		/// Logo
        /// </summary>		
		private int _logo;
        public int Logo
        {
            get{ return _logo; }
            set{ _logo = value; }
        }        
		/// <summary>
		/// 网站
        /// </summary>		
		private string _website;
        public string WebSite
        {
            get{ return _website; }
            set{ _website = value; }
        }        
		/// <summary>
		/// 座机
        /// </summary>		
		private string _phone;
        public string Phone
        {
            get{ return _phone; }
            set{ _phone = value; }
        }        
		/// <summary>
		/// 执照编号
        /// </summary>		
		private string _zzno;
        public string ZZNo
        {
            get{ return _zzno; }
            set{ _zzno = value; }
        }        
		/// <summary>
		/// ZZImg
        /// </summary>		
		private int _zzimg;
        public int ZZImg
        {
            get{ return _zzimg; }
            set{ _zzimg = value; }
        }        
		/// <summary>
		/// 性质
        /// </summary>		
		private int _natrue;
        public int Natrue
        {
            get{ return _natrue; }
            set{ _natrue = value; }
        }        
		/// <summary>
		/// 拼音
        /// </summary>		
		private string _py;
        public string PY
        {
            get{ return _py; }
            set{ _py = value; }
        }        
		/// <summary>
		/// 国家
        /// </summary>		
		private string _country;
        public string Country
        {
            get{ return _country; }
            set{ _country = value; }
        }        
		/// <summary>
		/// 省
        /// </summary>		
		private string _state;
        public string State
        {
            get{ return _state; }
            set{ _state = value; }
        }        
		/// <summary>
		/// 市
        /// </summary>		
		private string _city;
        public string City
        {
            get{ return _city; }
            set{ _city = value; }
        }        
		/// <summary>
		/// 县/区
        /// </summary>		
		private string _district;
        public string District
        {
            get{ return _district; }
            set{ _district = value; }
        }        
		/// <summary>
		/// 社区
        /// </summary>		
		private string _community;
        public string Community
        {
            get{ return _community; }
            set{ _community = value; }
        }        
		/// <summary>
		/// 详细地址
        /// </summary>		
		private string _address;
        public string Address
        {
            get{ return _address; }
            set{ _address = value; }
        }        
		/// <summary>
		/// AreaFull
        /// </summary>		
		private string _areafull;
        public string AreaFull
        {
            get{ return _areafull; }
            set{ _areafull = value; }
        }        
		/// <summary>
		/// 邮编
        /// </summary>		
		private string _zipcode;
        public string ZipCode
        {
            get{ return _zipcode; }
            set{ _zipcode = value; }
        }        
		/// <summary>
		/// QQ号
        /// </summary>		
		private string _qqopenid;
        public string QQOpenID
        {
            get{ return _qqopenid; }
            set{ _qqopenid = value; }
        }        
		/// <summary>
		/// 微信号
        /// </summary>		
		private string _weixinopenid;
        public string WeiXinOpenID
        {
            get{ return _weixinopenid; }
            set{ _weixinopenid = value; }
        }        
		/// <summary>
		/// 传真
        /// </summary>		
		private string _fax;
        public string Fax
        {
            get{ return _fax; }
            set{ _fax = value; }
        }        
		/// <summary>
		/// 邮箱
        /// </summary>		
		private string _email;
        public string Email
        {
            get{ return _email; }
            set{ _email = value; }
        }        
		/// <summary>
		/// 销售类型
        /// </summary>		
		private string _saletype;
        public string SaleType
        {
            get{ return _saletype; }
            set{ _saletype = value; }
        }        
		/// <summary>
		/// 规模
        /// </summary>		
		private string _scale;
        public string Scale
        {
            get{ return _scale; }
            set{ _scale = value; }
        }        
		/// <summary>
		/// 客户来源
        /// </summary>		
		private string _source;
        public string Source
        {
            get{ return _source; }
            set{ _source = value; }
        }        
		/// <summary>
		/// 销售状态
        /// </summary>		
		private string _salestatus;
        public string SaleStatus
        {
            get{ return _salestatus; }
            set{ _salestatus = value; }
        }        
		/// <summary>
		/// 开户行
        /// </summary>		
		private string _bankname;
        public string BankName
        {
            get{ return _bankname; }
            set{ _bankname = value; }
        }        
		/// <summary>
		/// 银行账号
        /// </summary>		
		private string _bankaccount;
        public string BankAccount
        {
            get{ return _bankaccount; }
            set{ _bankaccount = value; }
        }        
		/// <summary>
		/// 最早创建时间
        /// </summary>		
		private string _createunitdate;
        public string CreateUnitDate
        {
            get{ return _createunitdate; }
            set{ _createunitdate = value; }
        }        
		/// <summary>
		/// 成立时间
        /// </summary>		
		private string _begindate;
        public string BeginDate
        {
            get{ return _begindate; }
            set{ _begindate = value; }
        }        
		/// <summary>
		/// EndDate
        /// </summary>		
		private string _enddate;
        public string EndDate
        {
            get{ return _enddate; }
            set{ _enddate = value; }
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

