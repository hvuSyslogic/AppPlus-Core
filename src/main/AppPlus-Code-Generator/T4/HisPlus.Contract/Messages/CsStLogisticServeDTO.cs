using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CsStLogisticServeDTO : DtoBase<int>
    {
        public CsStLogisticServeDTO()
        {
        }

        [DataMember]
        public string YearMonth { get; set; }

        [DataMember]
        public int LogisticServeId { get; set; }

        [DataMember]
        public int BenefitLocId { get; set; }

        [DataMember]
        public int ServeLocId { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public decimal? Money { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? InputTime { get; set; }

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
