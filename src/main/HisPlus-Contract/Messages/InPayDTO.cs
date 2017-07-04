using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InPayDTO : DtoBase<int>
    {
        public InPayDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public int? InvoId { get; set; }

        [DataMember]
        public int? DepositId { get; set; }

        [DataMember]
        public short LsChargeType { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public int PayWayId { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public decimal Remain { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int? CancelPaywayId { get; set; }
    }
}
