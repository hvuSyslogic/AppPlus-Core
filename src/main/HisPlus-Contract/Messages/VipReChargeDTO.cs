using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class VipReChargeDTO : DtoBase<int>
    {
        public VipReChargeDTO()
        {
        }

        [DataMember]
        public int? VipCardId { get; set; }

        [DataMember]
        public int? PatId { get; set; }

        [DataMember]
        public string CardNo { get; set; }

        [DataMember]
        public decimal? InCome { get; set; }

        [DataMember]
        public decimal? PayOut { get; set; }

        [DataMember]
        public decimal? Balance { get; set; }

        [DataMember]
        public int? PayWay { get; set; }

        [DataMember]
        public short? OperType { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public string Comments { get; set; }

        [DataMember]
        public int? VipTypeId { get; set; }

        [DataMember]
        public int? LsVipChaFromType { get; set; }

        [DataMember]
        public int? InvoId { get; set; }
    }
}
