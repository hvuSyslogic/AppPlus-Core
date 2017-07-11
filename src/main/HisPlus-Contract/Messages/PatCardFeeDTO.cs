using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class PatCardFeeDTO : DtoBase<int>
    {
        public PatCardFeeDTO()
        {
        }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public int? PaywayId { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public short? CallOrder { get; set; }
    }
}
