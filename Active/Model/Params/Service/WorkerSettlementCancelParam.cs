﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenDingActive.Model.Params.Service
{
   public class WorkerSettlementCancelParam: WorkerBaseParam
    {
        /// <summary>
        /// 结算单据号
        /// </summary>

        public string SettlementNo { get; set; }
        /// <summary>
        /// 取消度取消程度(1取消结算2删除资料)病人办理出院后，若需要取消：应先调用接口取消结算，再调用接口删除资料
        /// </summary>

        public string CancelLimit { get; set; }
        /// <summary>
        /// 划卡流水号
        /// </summary>

        public string WorkersStrokeCardNo { get; set; }
        /// <summary>
        /// 取消结算备注
        /// </summary>
        public string CancelSettlementRemarks { get; set; }
     
    }
}
