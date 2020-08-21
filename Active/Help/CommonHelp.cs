﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace BenDingActive.Help
{
   public static class CommonHelp
    {
        public static string StrToTransCoding(byte[] param)
        {
            string resultData = null;
            if (param.Length > 0)
            {
                resultData = Encoding.ASCII.GetString(param, 1, 1023).Replace("\0", "");
            }
            Regex reg = new Regex("^[-+]?(([0-9]+)([.]([0-9]+))?|([.]([0-9]+))?)$");
            if (resultData != null)
            {
                if (reg.IsMatch(resultData) == false)
                {
                    resultData = Encoding.GetEncoding("GBK").GetString(param, 1, 1023).Replace("\0", "");
                    //获取字符是否包含??
                    bool flag = resultData.Contains("??");
                    if (flag) resultData = Encoding.GetEncoding("GBK").GetString(param, 1, 1023).Replace("\0", "");

                }

            }


            return resultData;
        }
        public static string GuidToStr(string param)
        {
            return BitConverter.ToInt64(Guid.Parse(param).ToByteArray(), 0).ToString();
        }
        /// <summary>
        /// 获取银海xml头
        /// </summary>
        /// <returns></returns>
        public static string GetYinHaiXmlHead()
        {
            string resultData = "<?xml version=\"1.0\" encoding=\"GBK\" standalone=\"yes\" ?>";
            return resultData;
        }
        /// <summary>
        /// 获取数据库链接
        /// </summary>
        /// <returns></returns>
        public static string GetConnStr()
        {
            string connStr = null;
            var is64Bit = Environment.Is64BitOperatingSystem;
            if (is64Bit)
            {

                connStr = @"Data Source=C:\Program Files (x86)\Microsoft\本鼎医保插件\xmlData\logData.db; Initial Catalog=logData;Integrated Security=True;Max Pool Size=10";
            }
            else
            {

                connStr = @"Data Source=C:\Program Files\Microsoft\本鼎医保插件\xmlData\logData.db; Initial Catalog=logData;Integrated Security=True;Max Pool Size=10";
            }

            return connStr;
        }
    }
}
