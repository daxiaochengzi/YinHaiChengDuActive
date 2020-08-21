using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenDingActive.Help
{
   public class LogWriteDataParam
    {/// <summary>
    /// 入参
    /// </summary>
        public string JoinJson { get; set; }
        /// <summary>
        /// 回参
        /// </summary>
        public string ReturnJson { get; set; }
        /// <summary>
        /// 操作人员
        /// </summary>
        public string OperatorId { get; set; }
        /// <summary>
        /// 交易编码
        /// </summary>

        public  string TransactionCode { get; set; }
    }
}
