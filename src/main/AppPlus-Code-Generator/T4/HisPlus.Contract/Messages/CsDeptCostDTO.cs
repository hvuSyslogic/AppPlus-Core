using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CsDeptCostDTO : DtoBase<int>
    {
        public CsDeptCostDTO()
        {
        }

        [DataMember]
        public string YearMonth { get; set; }

        [DataMember]
        public int LocId { get; set; }

        [DataMember]
        public int? CostSubjId { get; set; }

        [DataMember]
        public decimal? TotAmount { get; set; }

        [DataMember]
        public decimal? PlanAmount { get; set; }

        [DataMember]
        public decimal? PrimeCost { get; set; }

        [DataMember]
        public decimal? ApportCost1 { get; set; }

        [DataMember]
        public decimal? ApportCost2 { get; set; }

        [DataMember]
        public decimal? ApportCost3 { get; set; }

        [DataMember]
        public decimal? ApportCost4 { get; set; }

        [DataMember]
        public decimal? ApportCostSend { get; set; }

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
