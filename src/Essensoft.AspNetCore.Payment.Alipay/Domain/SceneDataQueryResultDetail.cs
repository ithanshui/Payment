using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneDataQueryResultDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SceneDataQueryResultDetail : AlipayObject
    {
        /// <summary>
        /// 网商银行申请单号
        /// </summary>
        [JsonProperty("app_seqno")]
        [XmlElement("app_seqno")]
        public string AppSeqno { get; set; }

        /// <summary>
        /// 机构需要查询的订单数据，
        /// </summary>
        [JsonProperty("result")]
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
