using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HardWareInfoAcquire.Util
{
    /// <summary>
    /// 字符串工具类
    /// </summary>
    class StringUtil
    {
        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <param name="textStr">输入参数</param>
        /// <returns></returns>
        public static Boolean checkStringIsNotNull(string textStr)
        {
            Boolean boo = false;
            if (!string.IsNullOrEmpty(textStr))
            {
                boo = true;
            }
            return boo;

        }

        /// <summary>
        /// 获取UUID
        /// </summary>
        /// <returns></returns>
        public static string getUUid()
        {
            string id = System.Guid.NewGuid().ToString("N");
            return id;
        }

        /// <summary>
        /// 判断字符串是否为数字
        /// </summary>
        /// <param name="value">输入参数</param>
        /// <returns></returns>
        public static bool isNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
        }
    }
}
