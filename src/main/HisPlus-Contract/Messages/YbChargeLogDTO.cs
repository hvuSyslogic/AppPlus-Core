using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class YbChargeLogDTO : DtoBase<int>
    {
        public YbChargeLogDTO()
        {
        }

        [DataMember]
        public string YbReqNo { get; set; }

        [DataMember]
        public string InvoNo { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public bool? IsCancel { get; set; }

        [DataMember]
        public int? CancelOperId { get; set; }

        [DataMember]
        public System.DateTime? CancelOperTime { get; set; }
    }
}
