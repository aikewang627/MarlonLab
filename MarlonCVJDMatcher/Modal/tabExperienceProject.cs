using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace Maticsoft.Model{
	 	//项目经验表
		public class tabExperienceProject
	{
   		     
      	/// <summary>
		/// 单位编号
        /// </summary>		
		private int _orgid;
        public int OrgID
        {
            get{ return _orgid; }
            set{ _orgid = value; }
        }        
		/// <summary>
		/// 项目名
        /// </summary>		
		private string _projectname;
        public string ProjectName
        {
            get{ return _projectname; }
            set{ _projectname = value; }
        }        
		/// <summary>
		/// 开始时间
        /// </summary>		
		private string _projectbegindate;
        public string ProjectBeginDate
        {
            get{ return _projectbegindate; }
            set{ _projectbegindate = value; }
        }        
		/// <summary>
		/// 结束时间
        /// </summary>		
		private string _projectenddate;
        public string ProjectEndDate
        {
            get{ return _projectenddate; }
            set{ _projectenddate = value; }
        }        
		/// <summary>
		/// 项目说明
        /// </summary>		
		private string _projectdesc;
        public string ProjectDesc
        {
            get{ return _projectdesc; }
            set{ _projectdesc = value; }
        }        
		/// <summary>
		/// 担任职位
        /// </summary>		
		private string _projectposition;
        public string ProjectPosition
        {
            get{ return _projectposition; }
            set{ _projectposition = value; }
        }        
		/// <summary>
		/// 工作业绩
        /// </summary>		
		private string _projectperformance;
        public string ProjectPerformance
        {
            get{ return _projectperformance; }
            set{ _projectperformance = value; }
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

