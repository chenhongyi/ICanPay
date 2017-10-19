﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ICanPay.Alipay
{
    public class ExtendParam
    {
        /// <summary>
        /// 系统商编号，该参数作为系统商返佣数据提取的依据，请填写系统商签约协议的PID
        /// </summary>
        [JsonProperty(PropertyName = Constant.SYS_SERVICE_PROVIDER_ID)]
        [StringLength(64, ErrorMessage = "系统商编号最大长度为64位")]
        public string SysServiceProviderId { get; set; }

        /// <summary>
        /// 花呗分期数（目前仅支持3、6、12
		/// 注：使用该参数需要仔细阅读“花呗分期接入文档” https://docs.open.alipay.com/277/106748
        /// </summary>
        [JsonProperty(PropertyName = Constant.HB_FQ_NUM)]
        [StringLength(5, ErrorMessage = "花呗分期数最大长度为5位")]
        public string HbFqNum { get; set; }

        /// <summary>
        /// 卖家承担收费比例，商家承担手续费传入100，用户承担手续费传入0，仅支持传入100、0两种，其他比例暂不支持
		/// 注：使用该参数需要仔细阅读“花呗分期接入文档” https://docs.open.alipay.com/277/106748
        /// </summary>
        [JsonProperty(PropertyName = Constant.HB_FQ_SELLER_PERCENT)]
        [StringLength(3, ErrorMessage = "卖家承担收费比例最大长度为3位")]
        public string HbFqSellerPercent { get; set; }

        /// <summary>
        /// 是否发起实名校验 T：发起 F：不发起
        /// </summary>
        [JsonProperty(PropertyName = Constant.NEEDBUYERREALNAMED)]
        [StringLength(1, ErrorMessage = "是否发起实名校验最大长度为1位")]
        public string NeedBuyerRealnamed { get; set; }

        /// <summary>
        /// 账务备注 注：该字段显示在离线账单的账务备注中
        /// </summary>
        [JsonProperty(PropertyName = Constant.TRANS_MEMO)]
        [StringLength(128, ErrorMessage = "账务备注最大长度为128位")]
        public string TransMemo { get; set; }
    }
}