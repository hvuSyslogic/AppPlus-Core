using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CsIncomeDetailDTO : DtoBase<int>
    {
        public CsIncomeDetailDTO()
        {
        }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public System.DateTime PayDate { get; set; }

        [DataMember]
        public string Summary { get; set; }

        [DataMember]
        public int? LocId { get; set; }

        [DataMember]
        public int? ExcLocId { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public decimal? Totality { get; set; }

        [DataMember]
        public string Unit { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public int? FeeHsId { get; set; }

        [DataMember]
        public int? DetailId { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public bool? IsAcct { get; set; }

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
