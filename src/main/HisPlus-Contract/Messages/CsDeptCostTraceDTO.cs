using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CsDeptCostTraceDTO : DtoBase<int>
    {
        public CsDeptCostTraceDTO()
        {
        }

        [DataMember]
        public string YearMonth { get; set; }

        [DataMember]
        public int LocId { get; set; }

        [DataMember]
        public int? CostSubjId { get; set; }

        [DataMember]
        public int? FromLocId { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public short Step { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
