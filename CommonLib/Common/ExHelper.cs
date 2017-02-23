using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace MarlonLab.CommonLib.Common
{
    /// <summary>
    /// 类型扩展
    /// </summary>
    public static class ExHelper
    {
        #region 截取字符串
        /// <summary>
        /// 截取字符串
        /// </summary>
        /// <param name="StrSource"></param>
        /// <param name="BeginStr"></param>
        /// <param name="EndStr"></param>
        /// <returns></returns>
        public static string SubSplitStr(this string StrSource, string BeginStr, string EndStr)
        {
            string strRes = StrSource.Substring(StrSource.IndexOf(BeginStr) + BeginStr.Length, StrSource.Length - StrSource.IndexOf(BeginStr) - BeginStr.Length);
            strRes = strRes.Substring(0, strRes.IndexOf(EndStr));
            return strRes;
        }

        #endregion 替换字符
        #region 将字符串转换为Int
        /// <summary>
        /// 将字符串转换为Int
        /// </summary>
        /// <param name="t"></param>
        /// <returns>当转换失败时返回0</returns>
        public static int ToInt(this string t, int defaultVal)
        {
            int ntemp = defaultVal;
            if (t.IsNullOrEmpty()) return defaultVal;
            if (int.TryParse(t, out ntemp))
            {
                return ntemp;
            }
            else
            {
                return defaultVal;
            }
        }
        #endregion
        #region 将字符串转换为Float
        /// <summary>
        /// 将字符串转换为Float
        /// </summary>
        /// <param name="t"></param>
        /// <param name="defaultVal"></param>
        /// <returns></returns>
        public static float ToFloat(this string t, float defaultVal)
        {
            float ntemp = defaultVal;
            if (float.TryParse(t, out ntemp))
            {
                return ntemp;
            }
            else
            {
                return defaultVal;
            }
        }
        #endregion
        #region 将字符串转换为Datetime
        /// <summary>
        /// 将字符串转换为Datetime
        /// </summary>
        /// <param name="t"></param>
        /// <param name="defaultVal"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string t, DateTime defaultVal)
        {
            DateTime ntemp = defaultVal;
            if (DateTime.TryParse(t, out ntemp))
            {
                return ntemp;
            }
            else
            {
                return defaultVal;
            }
        }
        #endregion
        #region 将字符串转换为bool
        /// <summary>
        /// 将字符串转换为bool
        /// </summary>
        /// <param name="t"></param>
        /// <returns>当转换失败时返回false</returns>
        public static bool ToBool(this string t, bool defaultVal)
        {
            bool ntemp = defaultVal;
            if (bool.TryParse(t, out ntemp))
            {
                return ntemp;
            }
            else
            {
                return defaultVal;
            }
        }
        #endregion
        #region 将字符串转换为bool
        /// <summary>
        /// 将字符串转换为bool
        /// </summary>
        /// <param name="t"></param>
        /// <returns>当转换失败时返回false</returns>
        public static bool ToObjectBool(this object t, bool defaultVal)
        {
            bool ntemp = defaultVal;
            if (t.ToString() == "1") return true;
            if (t.ToString() == "0") return false;
            if (bool.TryParse(t.ToString(), out ntemp))
            {
                return ntemp;
            }
            else
            {
                return defaultVal;
            }
        }
        #endregion
        public static bool IsNotNullOrEmpty(this string t)
        {
            if (string.IsNullOrEmpty(t)) return false;
            else return true;
        }
        public static bool IsNotNull(this object t)
        {
            if (t == null) return false;
            else return true;
        }
        public static bool IsNull(this object t)
        {
            if (t == null) return true;
            else return false;
        }
        public static bool IsNullOrEmpty(this string t)
        {
            if (string.IsNullOrEmpty(t)) return true;
            else return false;
        }
        public static string GetPostDataValue(this string PostData, string PostDataName)
        {
            string[] str = PostData.Split('&');
            foreach (string item in str)
            {
                string[] strItem = item.Split('=');
                if (strItem[0] == PostDataName)
                {
                    return strItem[1];
                }
            }
            return string.Empty;
        }
        public static string GetFormValue(this HttpRequestBase form, string FormName)
        {
            if (form.Form[FormName].IsNotNullOrEmpty())
            {
                return form.Form[FormName];
            }
            else
                return string.Empty;
        }
        public static bool IsMobile(this string t)
        {
            //电信手机号码正则
            string dianxin = @"^1[3578][01379]\d{8}$";
            Regex dReg = new Regex(dianxin);
            //联通手机号正则       
            string liantong = @"^1[34578][01256]\d{8}$";
            Regex tReg = new Regex(liantong);
            //移动手机号正则        
            string yidong = @"^(134[012345678]\d{7}|1[34578][012356789]\d{8})$";
            Regex yReg = new Regex(yidong);
            if (dReg.IsMatch(t) || tReg.IsMatch(t) || yReg.IsMatch(t)) return true;
            else return false;
        }
        /// <summary>
        /// 此时间是否在此范围内 -1:小于开始时间 0:在开始与结束时间范围内 1:已超出结束时间
        /// </summary>
        /// <param name="t"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public static int IsRange(this DateTime t, DateTime startTime, DateTime endTime)
        {
            if (((startTime - t).TotalSeconds > 0))
            {
                return -1;
            }

            if (((endTime - t).TotalSeconds < 0))
            {
                return 1;
            }

            return 0;
        }
        /// <summary>
        /// 本周周一
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetWeekBegin(this DateTime dt)
        {
            DateTime weekBegin = dt.AddDays(1 - Convert.ToInt32(dt.DayOfWeek.ToString("d")));
            return new DateTime(weekBegin.Year, weekBegin.Month, weekBegin.Day);
        }

        /// <summary>
        /// 本周周日
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetWeekEnd(this DateTime dt)
        {
            DateTime weekEnd = GetWeekBegin(dt).AddDays(6);
            return new DateTime(weekEnd.Year, weekEnd.Month, weekEnd.Day);
        }

        /// <summary>
        /// 本月月初 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetMonthBegin(this DateTime dt)
        {
            DateTime monthBegin = dt.AddDays(1 - dt.Day);
            return new DateTime(monthBegin.Year, monthBegin.Month, monthBegin.Day);
        }

        /// <summary>
        /// 本月月末
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime GetMonthEnd(this DateTime dt)
        {
            DateTime monthEnd = GetMonthBegin(dt).AddMonths(1).AddDays(-1);
            return new DateTime(monthEnd.Year, monthEnd.Month, monthEnd.Day);
        }

        public static DateTime AddWeeks(this DateTime dt, int count)
        {
            DateTime dateBegin = GetWeekEnd(dt);
            return dateBegin.AddDays(7 * count);
        }
    }
}
