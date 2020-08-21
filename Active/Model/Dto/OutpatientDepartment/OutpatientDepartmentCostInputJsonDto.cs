﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace BenDingActive.Model.Dto.OutpatientDepartment
{
   public class OutpatientDepartmentCostInputJsonDto:IniDto
    {/// <summary>
        /// 业务流水号
        /// </summary>

        [JsonProperty(PropertyName = "PO_BAE007")]
        public string DocumentNo { get; set; }
        /// <summary>
        /// 报销支付
        /// </summary>

        [JsonProperty(PropertyName = "PO_TCZF")]
        public decimal ReimbursementExpensesAmount { get; set; }

        /// <summary>
        /// 个人自付
        /// </summary>

        [JsonProperty(PropertyName = "PO_XJZF")]
        public decimal SelfPayFeeAmount { get; set; }

        /// <summary>
        /// 报销说明备注
        /// </summary>
        [JsonProperty(PropertyName = "PO_SMBZ")]

        public string Remark { get; set; }
    }
}
