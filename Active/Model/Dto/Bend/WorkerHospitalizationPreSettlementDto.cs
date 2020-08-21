﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BenDingActive.Model.Dto.Bend
{
    /// <summary>
    /// 
    /// </summary>
    public class WorkerHospitalizationPreSettlementDto
    {/// <summary>
     /// 发生费用金额
     /// </summary>
        [JsonProperty(PropertyName = "发生费用金额")]
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// 基本统筹支付
        /// </summary>
        [JsonProperty(PropertyName = "基本统筹支付")]
        public decimal BasicOverallPay { get; set; }
        /// <summary>
        /// 补充医疗保险支付金额
        /// </summary>
        [JsonProperty(PropertyName = "补充医疗保险支付金额")]
        public decimal SupplementPayAmount { get; set; }
        /// <summary>
        /// 专项基金支付金额
        /// </summary>
        [JsonProperty(PropertyName = "专项基金支付金额")]
        public decimal SpecialFundPayAmount { get; set; }
        /// <summary>
        /// 公务员补贴
        /// </summary>
        [JsonProperty(PropertyName = "公务员补贴")]
        public decimal CivilServantsSubsidies { get; set; }
        /// <summary>
        /// 公务员补助
        /// </summary>
        [JsonProperty(PropertyName = "公务员补助")]
        public decimal CivilServantsSubsidy { get; set; }
        /// <summary>
        ///  其它支付金额
        /// </summary>
        [JsonProperty(PropertyName = "其它支付金额")]
        public decimal OtherPaymentAmount { get; set; }
        /// <summary>
        /// 账户支付
        /// </summary>
        [JsonProperty(PropertyName = "账户支付")]
        public decimal AccountPayment { get; set; }
        /// <summary>
        /// 现金支付
        /// </summary>
        [JsonProperty(PropertyName = "现金支付")]
        public decimal CashPayment { get; set; }
        /// <summary>
        /// 起付金额
        /// </summary>
        [JsonProperty(PropertyName = "起付金额")]
        public decimal PaidAmount { get; set; }
        /// <summary>
        /// 报销金额
        /// </summary>
        [JsonIgnore]
        public decimal ReimbursementExpenses { get; set; }
        /// <summary>
        /// 单据号
        /// </summary>
       
        public string DocumentNo { get; set; }
      
        /// <summary>
        ///  备注
        /// </summary>
        [JsonIgnore]
        public string Remark { get; set; }
    }
}
