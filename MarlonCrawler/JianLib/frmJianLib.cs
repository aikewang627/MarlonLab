using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//
using System.Threading;//
using System.Net;//
using System.Net.Http;//
using MarlonLab.CommonLib;//
using Newtonsoft.Json;//序列化
using Newtonsoft.Json.Linq;
using System.IO.Compression;//压缩
using System.Web;//


namespace MarlonCrawler.JianLib
{
    public partial class frmJianLib : Form
    {
        //变量声明
        string strSiteBaseUrl = @"http://jianlib.com";
        string strSiteLoginUrl = @"http://jianlib.com/signin";
        string strSiteSearchUrl = @"http://jianlib.com/resume/search";
        string strSiteDetailUrl = @"http://jianlib.com/resume/detail";
        string strSiteGetUrl = @"http://jianlib.com/resume/get";
        string strUserName = "aikewang627@163.com";
        string strPassword = "aike27";
        string strKeyword = "";
        string strStorePath = "c:\\JianLib\\";
        string strCookie = "";//
        int iSearchItemsCount = 0;//检索到总条目
        int iSearchPageSize = 20;//每页的条目数
        int iSearchPageCount = 0;//检索的页数
        int iSearchPageNo = 0;//当前的页号
        int iSearchItemNo = 0;//当前的条目号
        List<JianLib.ResumeChiefModel> lsResumeChief = new List<JianLib.ResumeChiefModel>();//待下载的简历列队

        //初始化
        public frmJianLib()
        {
            InitializeComponent();
            InitializeComponent2();
        }
        private void InitializeComponent2()
        {
            tbUserName.Text = strUserName;
            tbPassword.Text = strPassword;
            tbKeyword.Text = strKeyword;
            tbStorePath.Text = strStorePath;
        }
        //选择文件的存放路径
        private void btnSelectStorePath_Click(object sender, EventArgs e)
        {
            dlgStorePath.SelectedPath = tbStorePath.Text;
            dlgStorePath.ShowDialog();
            tbStorePath.Text = dlgStorePath.SelectedPath;
        }
        //开始爬虫
        private void btStart_Click(object sender, EventArgs e)
        {
            AddLog("开始检查参数……");
            strUserName = tbUserName.Text;
            strPassword = tbPassword.Text;
            strKeyword = tbKeyword.Text;
            strStorePath = tbStorePath.Text;
            if (strUserName == "" || strPassword == "" || strStorePath == "")
            {
                AddLog("参数不完整，请检查！！！");
                return;
            }
            if (!Directory.Exists(strStorePath))
            {
                Directory.CreateDirectory(strStorePath);
                AddLog("成功创建 存放文件夹： " + strStorePath + " 。");
            }
            AddLog("参数检查通过，打开网站……");
            wbMain.Navigate(strSiteLoginUrl);

        }
        // 浏览器加载文档结束（控制中心）
        private void wbMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //避免webbroswer.DocumentCompleted被多次引发
            if ((e.Url != wbMain.Url) || (wbMain.ReadyState != WebBrowserReadyState.Complete))
            { return; }
            AddLog("网站： " + wbMain.Url.ToString() + " 加载完成。");
            //如果是登录页面
            HtmlDocument htmlDoc = wbMain.Document;
            if (e.Url.ToString().Contains(strSiteLoginUrl))
            {
                AddLog("进入登录页面。");
                htmlDoc.GetElementById("login-username").SetAttribute("value", strUserName);
                htmlDoc.GetElementById("login-password").SetAttribute("value", strPassword);
                tmLogin.Enabled = true;//开始计时                
                AddLog("输入用户名、口令，启动登录计时器。");

            }
            //如果是搜索页面
            if (e.Url.ToString().Contains(strSiteSearchUrl))
            {
                AddLog("进入简历搜索页面。");
                strCookie = wbMain.Document.Cookie;//获得Cookie
                AddLog("Cookie为: " + strCookie);
               // SetSearchCondition(strKeyword);//设置 检索条件
                tmAjaxRequest .Enabled = true;//开始计时
                AddLog("开启 异步请求 计时器");

            }

        }
        //设置检索条件
        void SetSearchCondition(string strSearchKey)
        {
            HtmlDocument htmlDoc = wbMain.Document;
            HtmlElement htmlEleKeyword = htmlDoc.GetElementById("keyword");
            htmlEleKeyword.SetAttribute("value", strSearchKey);
            //HtmlElementCollection htmlEleList = htmlDoc.GetElementsByTagName("input");
            //foreach (HtmlElement ele in htmlEleList)
            //{
            //    if (ele.GetAttribute("placeholder").Contains("输入关键字"))
            //    { }
            //}
        }
        // 登录计时器到时
        private void tmLogin_Tick(object sender, EventArgs e)
        {
            AddLog("登录计时器响，开始登录。");

            tmLogin.Enabled = false;

            HtmlDocument htmlDoc = wbMain.Document;
            HtmlElement htmlEleBtnLogin = htmlDoc.GetElementById("btn-login");
            htmlEleBtnLogin.InvokeMember("click");
            //htmlEleBtnLogin.RaiseEvent("onclick");
        }
        //异步请求计时器
        private void tmAjaxRequest_Tick(object sender, EventArgs e)
        {
            AddLog("异步请求计时器响。");
            tmAjaxRequest.Enabled = false;
            if (lsResumeChief.Count == 0)
            {
                if (iSearchItemsCount == 0 && iSearchPageNo == 0)//第一次搜索
                {
                    
                    SetSearchCondition(strKeyword);//设置 检索条件
                    iSearchPageNo++;//页号加一
                    AddLog("开始第一次搜索，并试图获取第1页列表。");
                    RequestResumeListByHttpWebRequest(strKeyword,iSearchPageNo);//获得列表                    
                }
                else if (iSearchItemsCount == 00 && iSearchPageNo == 1)//第一次搜索，无结果
                {
                    AddLog("第一次搜索，无结果。");
                    return;
                }
                else if (iSearchItemsCount>0&& iSearchPageSize*iSearchPageNo<=iSearchItemsCount)
                {
                    
                    iSearchPageNo++;//页号加一
                    AddLog("开始试图获取第"+iSearchPageNo+"页列表。");
                    RequestResumeListByHttpWebRequest(strKeyword, iSearchPageNo);//获得列表
                }
                else
                {
                    AddLog("全部下载结束。");
                    return;
                }
            }
            else
            {
                RequestResumeGetByHttpWebRequest(lsResumeChief[0]);//获取联系方式
                RequestResumeDetailByHttpWebRequest(lsResumeChief[0]);//下载简历
                lsResumeChief.RemoveAt(0);//下载后，移除Url
            }
            tmAjaxRequest.Enabled = true;
        }
        //获得简历列表
        void RequestResumeListByHttpWebRequest(string keyword,int pageNo)
        {
            AddLog(string.Format("开始获取简历列表：关键字{0}，第{1}页",keyword,pageNo));

            System.Net.HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(strSiteSearchUrl);
            request.Method = "POST";
            //添加Header
            request.Headers.Clear();
            request.Accept = "*/*";
            request.Connection = "false";
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            request.Headers.Add("Accept-Encoding", "gzip, deflate");
            request.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            request.Headers.Add("Cookie", strCookie);
            request.Host = "jianlib.com";
            request.Referer = "http://jianlib.com/resume/search";
            request.Headers.Add("Origin", "http://jianlib.com");
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
            request.Headers.Add("X-Request-With", "XMLHttpRequest");
            //组合Body
            List<KeyValuePair<string, string>> content = new List<KeyValuePair<string, string>>();
            content.Add(new KeyValuePair<string, string>("id", "-1"));
            content.Add(new KeyValuePair<string, string>("ageLower", ""));
            content.Add(new KeyValuePair<string, string>("ageUpper", ""));
            content.Add(new KeyValuePair<string, string>("experienceLower", ""));
            content.Add(new KeyValuePair<string, string>("experienceUpper", ""));
            content.Add(new KeyValuePair<string, string>("educationLower", ""));
            content.Add(new KeyValuePair<string, string>("educationUpper", ""));
            content.Add(new KeyValuePair<string, string>("gender", "0"));
            content.Add(new KeyValuePair<string, string>("keyword",HttpUtility.HtmlEncode(keyword)));
            content.Add(new KeyValuePair<string, string>("company", ""));
            content.Add(new KeyValuePair<string, string>("state", ""));
            content.Add(new KeyValuePair<string, string>("page", pageNo.ToString()));

            string strPostdata = "";
            foreach (KeyValuePair<string,string> pair in content)
            {
                strPostdata += "&" + pair.Key + "=" + pair.Value;
            }
            if (strPostdata.Length > 1) { strPostdata = strPostdata.TrimStart('&'); }
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(strPostdata);
            using (Stream reqStream = request.GetRequestStream())
            {
                reqStream.Write(buffer, 0, buffer.Length);
            }

            System.Net.HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.GetEncoding("utf-8")))
            {
                AddLog("获取列表结束" );
                string strResponse = reader.ReadToEnd().FromUnicodeString();
                HandResponseOfResumeList(strResponse);
                SaveResumeList(keyword,pageNo.ToString(), strResponse);
            }

        }
        //反序列化
        void HandResponseOfResumeList(string response)
        {
            ResumeListResult result = new ResumeListResult();
            try
            {
                result = JsonConvert.DeserializeObject<JianLib.ResumeListResult>(response);
                if (result != null)
                {
                    iSearchItemsCount = result.total;
                    lsResumeChief = result.resumes;
                    AddLog(string.Format("获得列表信息成功：总{0}条，当前第{1}页", result.total, result.current_page));

                }
            }
            catch (Exception ex)
            {
                lsResumeChief = new List<ResumeChiefModel>();
                AddLog(string.Format("获得列表信息错误：{0}", ex.Message));
            }

        }
        void SaveResumeList(string keyword,string pageNo, string response)
        {
            string fileFullName = string.Format(strStorePath + "\\{0}-{1}-{2}.txt",DateTime.Now.ToString("yyyyMMdd") , keyword,pageNo);
            FileStream fs = new FileStream(fileFullName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(response);
            sw.Flush();
            sw.Close();
            fs.Close();
            AddLog("保存结束：" + fileFullName);
        }
        //获得简历详情
        void RequestResumeGetByHttpWebRequest(JianLib.ResumeChiefModel rcm)
        {
            AddLog("开始获取简历联系方式，编号：" + rcm.id);
            System.Net.HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(strSiteGetUrl + @"/" + rcm.id);
            request.Method = "POST";
            //添加Header
            request.Headers.Clear();
            request.Accept = "*/*";
            request.Connection = "false";
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            request.Headers.Add("Accept-Encoding", "gzip, deflate");
            request.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            request.Headers.Add("Cookie", strCookie);
            request.Host = "jianlib.com";
            request.Referer = "http://jianlib.com/resume/detail" + @"/" + rcm.id;
            request.Headers.Add("Origin", "http://jianlib.com");
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
            request.Headers.Add("X-Request-With", "XMLHttpRequest");
            //组合Body

            System.Net.HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.GetEncoding("utf-8")))
            {

                string strResponse = reader.ReadToEnd().FromUnicodeString();
                if (strResponse.Contains("ok"))
                { AddLog("获取联系方式成功"); }
                else
                { AddLog("获取联系方式失败"); }
            }
            AddLog("获取简历联系方式结束");

        }
        void RequestResumeDetailByHttpWebRequest(JianLib.ResumeChiefModel rcm)
        {
            AddLog("开始下载简历，编号："+rcm.id);

            string getUrl = strSiteDetailUrl + @"/" + rcm.id;
            System.Net.HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(getUrl);
            request.Method = "GET";
            //添加Header
            request.Headers.Clear();
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            request.Connection = "false";
            request.Headers.Add("Accept-Encoding", "gzip, deflate, sdch");
            request.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
            request.Headers.Add("Cookie", strCookie);
            request.Headers.Add("Upgrade-Insecure-Requests", "1");
            request.Host = "jianlib.com";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
            //组合QueryString
            System.Net.HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            BinaryReader br = new BinaryReader(response.GetResponseStream());
            byte[] buffer = br.ReadBytes((int)response.ContentLength);

            string strResponse = (string)(System.Text.Encoding.UTF8.GetString(Decompress(buffer)));//gzip解压
            AddLog("下载结束");

            SaveResume(rcm, strResponse);
          
     
        }
        //解码gzip
        public static byte[] Decompress(byte[] zippedData)
        {
            MemoryStream ms = new MemoryStream(zippedData);
            GZipStream compressedzipStream = new GZipStream(ms, CompressionMode.Decompress);
            MemoryStream outBuffer = new MemoryStream();
            byte[] block = new byte[1024];
            while (true)
            {
                int bytesRead = compressedzipStream.Read(block, 0, block.Length);
                if (bytesRead <= 0)
                    break;
                else
                    outBuffer.Write(block, 0, bytesRead);
            }
            compressedzipStream.Close();
            return outBuffer.ToArray();
        }
        void SaveResume(JianLib.ResumeChiefModel rcm,string response)
        {
            string fileFullName = string.Format(strStorePath + "\\{0}-{1}-{2}.html", rcm.id, rcm.name, rcm.sex);
            FileStream fs = new FileStream(fileFullName,FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(response);
            sw.Flush();
            sw.Close();
            fs.Close();
            AddLog("保存结束：" +fileFullName);
        }
        //添加日志
        void AddLog(string msg)
        {
            if (rtbLog.Text.Length > 100000)
            {
                string fileFullName = string.Format(strStorePath + "\\{0}-{1}.html", "Log", DateTime.Now.ToString("yyyyMMddHHmmSS"));
                FileStream fs = new FileStream(fileFullName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(rtbLog.Text);
                sw.Flush();
                sw.Close();
                fs.Close();

                rtbLog.Text = "";
            }

            rtbLog.Text += DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss fff") + "  " + msg + "\r\n ";
            rtbLog.SelectionStart = rtbLog.Text.Length ;
            rtbLog.ScrollToCaret();
        }

    }



}
