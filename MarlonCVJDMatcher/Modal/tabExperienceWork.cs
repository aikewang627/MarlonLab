using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Maticsoft.Model{
	 	//工作经历表
		public class tabExperienceWork
	{
   		     
      	/// <summary>
		/// 企业名称编号
        /// </summary>		
		private int _orgid;
        public int OrgID
        {
            get{ return _orgid; }
            set{ _orgid = value; }
        }        
		/// <summary>
		/// 入职时间
        /// </summary>		
		private string _orgbegindate;
        public string OrgBeginDate
        {
            get{ return _orgbegindate; }
            set{ _orgbegindate = value; }
        }        
		/// <summary>
		/// 离职时间
        /// </summary>		
		private string _orgenddate;
        public string OrgEndDate
        {
            get{ return _orgenddate; }
            set{ _orgenddate = value; }
        }        
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
		/// 工作地点
        /// </summary>		
		private string _positionaddress;
        public string PositionAddress
        {
            get{ return _positionaddress; }
            set{ _positionaddress = value; }
        }        
		/// <summary>
		/// 上任时间
        /// </summary>		
		private string _positionbegindate;
        public string PositionBeginDate
        {
            get{ return _positionbegindate; }
            set{ _positionbegindate = value; }
        }        
		/// <summary>
		/// 调任时间
        /// </summary>		
		private string _positionenddate;
        public string PositionEndDate
        {
            get{ return _positionenddate; }
            set{ _positionenddate = value; }
        }        
		/// <summary>
		/// 部门人数
        /// </summary>		
		private int _deptnum;
        public int DeptNum
        {
            get{ return _deptnum; }
            set{ _deptnum = value; }
        }        
		/// <summary>
		/// 工作职责
        /// </summary>		
		private string _positionduties;
        public string PositionDuties
        {
            get{ return _positionduties; }
            set{ _positionduties = value; }
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
		/// 所在部门
        /// </summary>		
		private string _deptname;
        public string DeptName
        {
            get{ return _deptname; }
            set{ _deptname = value; }
        }        
		/// <summary>
		/// 工作业绩
        /// </summary>		
		private string _workperformance;
        public string WorkPerformance
        {
            get{ return _workperformance; }
            set{ _workperformance = value; }
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

