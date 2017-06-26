using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CsLogisticServeDetailDTO : DtoBase<int>
    {
        public CsLogisticServeDetailDTO()
        {
        }

        [DataMember]
        public System.DateTime ServeDate { get; set; }

        [DataMember]
        public string Abstract { get; set; }

        [DataMember]
        public int LogisticServeId { get; set; }

        [DataMember]
        public int BenefitLocId { get; set; }

        [DataMember]
        public int ServeLocId { get; set; }

        [DataMember]
        public decimal? Totality { get; set; }

        [DataMember]
        public decimal? Equivalent { get; set; }

        [DataMember]
        public string ServeNo { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public bool? IsAcctMark { get; set; }

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
