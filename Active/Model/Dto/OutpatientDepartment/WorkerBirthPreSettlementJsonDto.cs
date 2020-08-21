﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace BenDingActive.Model.Dto.OutpatientDepartment
{
    /// <summary>
    /// 职工生育住院预结算
    /// </summary>
    
    public class WorkerBirthPreSettlementJsonDto
    {
        /// <summary>
        /// 发生费用金额
        /// </summary>
      
        [JsonProperty(PropertyName = "PO_FYZE")]
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// 生育补助
        /// </summary>
        
        [JsonProperty(PropertyName = "PO_SYBZ")]
        public decimal BirthAallowance { get; set; }
        /// <summary>
        /// 基本统筹支付
        /// </summary>
     
        [JsonProperty(PropertyName = "PO_TCZF")]
        public decimal BasicOverallPay { get; set; }
        /// <summary>
        /// 补充医疗保险支付金额
        /// </summary>
       
        [JsonProperty(PropertyName = "PO_BCZF")]
        public decimal SupplementPayAmount { get; set; }
        /// <summary>
        /// 公务员补贴
        /// </summary>
        [JsonProperty(PropertyName = "PO_GWYBT")]
        public decimal CivilServantsSubsidies { get; set; }
        /// <summary>
        /// 公务员补助
        /// </summary>
        [JsonProperty(PropertyName = "PO_GWYBZ")]
        public decimal CivilServantsSubsidy { get; set; }
        /// <summary>
        ///  其它支付金额
        /// </summary>
      
        [JsonProperty(PropertyName = "PO_QTZF")]
        public decimal OtherPaymentAmount { get; set; }
        /// <summary>
        /// 账户支付
        /// </summary>
        [JsonProperty(PropertyName = "PO_ZHZF")]
        public decimal AccountPayment { get; set; }
       
        /// <summary>
        /// 现金支付
        /// </summary>
     
        [JsonProperty(PropertyName = "PO_XJZF")]
        public decimal CashPayment { get; set; }
        /// <summary>
        /// 起付金额
        /// </summary>
       
        [JsonProperty(PropertyName = "PO_QFJE")]
        public decimal PaidAmount { get; set; }
        /// <summary>
        /// 单据号
        /// </summary>
     
        [JsonProperty(PropertyName = "PO_DJH")]
        public string DocumentNo { get; set; }
        /// <summary>
        ///  备注
        /// </summary>
        
        [JsonProperty(PropertyName = "PO_BZ")]
        public string Remark { get; set; }
        /// <summary>
        /// 过程返回值(为1时正常，否则不正常)
        /// </summary>
        [JsonProperty(PropertyName = "PO_FHZ")]
        

        public string ResultState { get; set; }
        /// <summary>
        /// 系统错误信息
        /// </summary>
        [JsonProperty(PropertyName = "PO_MSG")]
       
        public string Msg { get; set; }
    }
}
