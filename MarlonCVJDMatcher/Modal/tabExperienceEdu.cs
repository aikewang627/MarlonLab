using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Maticsoft.Model{
	 	//教育经历表
		public class tabExperienceEdu
	{
   		     
      	/// <summary>
		/// 学校名称
        /// </summary>		
		private string _schoolname;
        public string SchoolName
        {
            get{ return _schoolname; }
            set{ _schoolname = value; }
        }        
		/// <summary>
		/// 专业名称
        /// </summary>		
		private string _professionalname;
        public string ProfessionalName
        {
            get{ return _professionalname; }
            set{ _professionalname = value; }
        }        
		/// <summary>
		/// EduBeginDate
        /// </summary>		
		private string _edubegindate;
        public string EduBeginDate
        {
            get{ return _edubegindate; }
            set{ _edubegindate = value; }
        }        
		/// <summary>
		/// EduEndDate
        /// </summary>		
		private string _eduenddate;
        public string EduEndDate
        {
            get{ return _eduenddate; }
            set{ _eduenddate = value; }
        }        
		/// <summary>
		/// 学历
        /// </summary>		
		private int _getedu;
        public int GetEdu
        {
            get{ return _getedu; }
            set{ _getedu = value; }
        }        
		/// <summary>
		/// 是否统招
        /// </summary>		
		private bool _istz;
        public bool IsTZ
        {
            get{ return _istz; }
            set{ _istz = value; }
        }        
		/// <summary>
		/// Is211
        /// </summary>		
		private bool _is211;
        public bool Is211
        {
            get{ return _is211; }
            set{ _is211 = value; }
        }        
		/// <summary>
		/// 是否第三方认证
        /// </summary>		
		private bool _isval;
        public bool IsVal
        {
            get{ return _isval; }
            set{ _isval = value; }
        }        
		/// <summary>
		/// 更多信息
        /// </summary>		
		private string _addoninfo;
        public string AddonInfo
        {
            get{ return _addoninfo; }
            set{ _addoninfo = value; }
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
		/// 简历编号
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

