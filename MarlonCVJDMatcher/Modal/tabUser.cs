using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Maticsoft.Model{
	 	//用户表
		public class tabUser
	{
   		     
      	/// <summary>
		/// 用户名
        /// </summary>		
		private string _username;
        public string UserName
        {
            get{ return _username; }
            set{ _username = value; }
        }        
		/// <summary>
		/// 昵称
        /// </summary>		
		private string _nickname;
        public string NickName
        {
            get{ return _nickname; }
            set{ _nickname = value; }
        }        
		/// <summary>
		/// 密码
        /// </summary>		
		private string _pwd;
        public string Pwd
        {
            get{ return _pwd; }
            set{ _pwd = value; }
        }        
		/// <summary>
		/// 性别
        /// </summary>		
		private string _sex;
        public string Sex
        {
            get{ return _sex; }
            set{ _sex = value; }
        }        
		/// <summary>
		/// 生日
        /// </summary>		
		private string _birthday;
        public string Birthday
        {
            get{ return _birthday; }
            set{ _birthday = value; }
        }        
		/// <summary>
		/// 头像
        /// </summary>		
		private int _headimgurlid;
        public int HeadImgURLID
        {
            get{ return _headimgurlid; }
            set{ _headimgurlid = value; }
        }        
		/// <summary>
		/// 真实姓名
        /// </summary>		
		private string _realname;
        public string RealName
        {
            get{ return _realname; }
            set{ _realname = value; }
        }        
		/// <summary>
		/// 身份证
        /// </summary>		
		private string _sfzno;
        public string SFZNo
        {
            get{ return _sfzno; }
            set{ _sfzno = value; }
        }        
		/// <summary>
		/// 手持身份证照片资源ID
        /// </summary>		
		private int _idcardperson;
        public int IDCardPerson
        {
            get{ return _idcardperson; }
            set{ _idcardperson = value; }
        }        
		/// <summary>
		/// 手机
        /// </summary>		
		private string _mobile;
        public string Mobile
        {
            get{ return _mobile; }
            set{ _mobile = value; }
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
		/// 婚否
        /// </summary>		
		private string _marriage;
        public string Marriage
        {
            get{ return _marriage; }
            set{ _marriage = value; }
        }        
		/// <summary>
		/// 开始工作年份，如2012
        /// </summary>		
		private string _beginjobyear;
        public string BeginJobYear
        {
            get{ return _beginjobyear; }
            set{ _beginjobyear = value; }
        }        
		/// <summary>
		/// 微信账号
        /// </summary>		
		private string _weixinopenid;
        public string WeiXinOpenID
        {
            get{ return _weixinopenid; }
            set{ _weixinopenid = value; }
        }        
		/// <summary>
		/// WXNickName
        /// </summary>		
		private string _wxnickname;
        public string WXNickName
        {
            get{ return _wxnickname; }
            set{ _wxnickname = value; }
        }        
		/// <summary>
		/// WxCode
        /// </summary>		
		private string _wxcode;
        public string WxCode
        {
            get{ return _wxcode; }
            set{ _wxcode = value; }
        }        
		/// <summary>
		/// QQ账号
        /// </summary>		
		private string _qqid;
        public string QQID
        {
            get{ return _qqid; }
            set{ _qqid = value; }
        }        
		/// <summary>
		/// QQNickName
        /// </summary>		
		private string _qqnickname;
        public string QQNickName
        {
            get{ return _qqnickname; }
            set{ _qqnickname = value; }
        }        
		/// <summary>
		/// QQNo
        /// </summary>		
		private string _qqno;
        public string QQNo
        {
            get{ return _qqno; }
            set{ _qqno = value; }
        }        
		/// <summary>
		/// 新浪微博账号
        /// </summary>		
		private string _sinaid;
        public string SinaID
        {
            get{ return _sinaid; }
            set{ _sinaid = value; }
        }        
		/// <summary>
		/// 淘宝账号
        /// </summary>		
		private string _ali;
        public string Ali
        {
            get{ return _ali; }
            set{ _ali = value; }
        }        
		/// <summary>
		/// 第三方账号
        /// </summary>		
		private string _otherid;
        public string OtherID
        {
            get{ return _otherid; }
            set{ _otherid = value; }
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
		/// 省份
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
		/// 完整地址
        /// </summary>		
		private string _addressfull;
        public string AddressFull
        {
            get{ return _addressfull; }
            set{ _addressfull = value; }
        }        
		/// <summary>
		/// 安全问题
        /// </summary>		
		private string _safequestion;
        public string SafeQuestion
        {
            get{ return _safequestion; }
            set{ _safequestion = value; }
        }        
		/// <summary>
		/// 安全问题答案
        /// </summary>		
		private string _safeanswer;
        public string SafeAnswer
        {
            get{ return _safeanswer; }
            set{ _safeanswer = value; }
        }        
		/// <summary>
		/// 用户类型，采用AppName.UserType标识，如DDZC.CompanyUser
        /// </summary>		
		private string _usertype;
        public string UserType
        {
            get{ return _usertype; }
            set{ _usertype = value; }
        }        
		/// <summary>
		/// 是否允许登录
        /// </summary>		
		private bool _islogin;
        public bool IsLogin
        {
            get{ return _islogin; }
            set{ _islogin = value; }
        }        
		/// <summary>
		/// 最后登录时间
        /// </summary>		
		private string _lastlogintime;
        public string LastLoginTime
        {
            get{ return _lastlogintime; }
            set{ _lastlogintime = value; }
        }        
		/// <summary>
		/// 角色
        /// </summary>		
		private int _roleid;
        public int RoleID
        {
            get{ return _roleid; }
            set{ _roleid = value; }
        }        
		/// <summary>
		/// 用户组
        /// </summary>		
		private int _groupid;
        public int GroupID
        {
            get{ return _groupid; }
            set{ _groupid = value; }
        }        
		/// <summary>
		/// 注册IP
        /// </summary>		
		private string _regip;
        public string RegIP
        {
            get{ return _regip; }
            set{ _regip = value; }
        }        
		/// <summary>
		/// 注册时间
        /// </summary>		
		private string _regdate;
        public string RegDate
        {
            get{ return _regdate; }
            set{ _regdate = value; }
        }        
		/// <summary>
		/// 行业
        /// </summary>		
		private string _industry;
        public string Industry
        {
            get{ return _industry; }
            set{ _industry = value; }
        }        
		/// <summary>
		/// 民族
        /// </summary>		
		private int _minzu;
        public int MinZu
        {
            get{ return _minzu; }
            set{ _minzu = value; }
        }        
		/// <summary>
		/// 面貌
        /// </summary>		
		private int _mianmao;
        public int MianMao
        {
            get{ return _mianmao; }
            set{ _mianmao = value; }
        }        
		/// <summary>
		/// 学历
        /// </summary>		
		private int _xueli;
        public int XueLi
        {
            get{ return _xueli; }
            set{ _xueli = value; }
        }        
		/// <summary>
		/// 职务
        /// </summary>		
		private int _zhiwu;
        public int ZhiWu
        {
            get{ return _zhiwu; }
            set{ _zhiwu = value; }
        }        
		/// <summary>
		/// 所属单位
        /// </summary>		
		private string _orgid;
        public string OrgID
        {
            get{ return _orgid; }
            set{ _orgid = value; }
        }        
		/// <summary>
		/// 银行卡号
        /// </summary>		
		private string _bankcardno;
        public string BankCardNo
        {
            get{ return _bankcardno; }
            set{ _bankcardno = value; }
        }        
		/// <summary>
		/// 高佣金订单的 做单资质
        /// </summary>		
		private bool _orderquality;
        public bool OrderQuality
        {
            get{ return _orderquality; }
            set{ _orderquality = value; }
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

