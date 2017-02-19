using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;//正则表达式


namespace MarlonLab.CommonLib
{
    //正则表达可以实现匹配、替换、提取功能
    public static class RegularHelper
    {
        public static bool IsUrl(this string sourse, string pattern = "")
        {
            //  @"^http://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$"
            //  @"[a-zA-z]+://[^\s]*"
            pattern = (pattern == "") ? @"^(http|https|ftp)\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&$%\$#\=~])*$" : pattern;
            Regex reg =new Regex(pattern);
            return reg.IsMatch(sourse);
        }
        public static bool IsContainsUrl(this string sourse, string pattern = "")
        {
            pattern = (pattern == "") ? @"^(http|https|ftp)\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&$%\$#\=~])*$" : pattern;
            Regex reg = new Regex(pattern);
            Match mch = reg.Match(sourse);
            return mch.Success;
        }
        public static List<string> GetMachedUrl(this string sourse, string pattern = "")
        {
            List<string> lsResult = new List<string>();
            pattern = (pattern == "") ? @"^(http|https|ftp)\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&$%\$#\=~])*$" : pattern;
            Regex reg = new Regex(pattern);
            MatchCollection mchs = reg.Matches(sourse);
            foreach (Match mch in mchs)
            {
                lsResult.Add(mch.Value);
            }
            return lsResult;
        }
        public static string ReplaceUrlWith(this string sourse,string target, string pattern = "")
        {
            pattern = (pattern == "") ? @"^(http|https|ftp)\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&$%\$#\=~])*$" : pattern;
            Regex reg = new Regex(pattern);
            return reg.Replace(sourse, target);
        }







    }
}
