﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenDingActive.Help
{
   public class LogParam
    {/// <summary>
    /// 操作人员编号
    /// </summary>
        public  string OperatorCode { get; set; }
        /// <summary>
        /// 如参
        /// </summary>
        public  string Params { get; set; } 
        /// <summary>
        /// 返回值
        /// </summary>
        public string ResultData { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }
        public  string TransactionCode { get; set; }
     
    }
}
