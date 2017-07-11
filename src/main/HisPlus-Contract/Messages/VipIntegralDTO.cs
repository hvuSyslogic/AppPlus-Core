using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class VipIntegralDTO : DtoBase<int>
    {
        public VipIntegralDTO()
        {
        }

        [DataMember]
        public int? PatId { get; set; }

        [DataMember]
        public int? VipcardId { get; set; }

        [DataMember]
        public decimal? Integral { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public bool? OperStatus { get; set; }

        [DataMember]
        public string Comments { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }
    }
}
