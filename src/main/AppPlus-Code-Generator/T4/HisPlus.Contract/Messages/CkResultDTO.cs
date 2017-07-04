using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkResultDTO : DtoBase<int>
    {
        public CkResultDTO()
        {
        }

        [DataMember]
        public int CheckId { get; set; }

        [DataMember]
        public int TestId { get; set; }

        [DataMember]
        public string LastResult { get; set; }

        [DataMember]
        public string Result { get; set; }

        [DataMember]
        public short? LsRefFlag { get; set; }

        [DataMember]
        public bool? IsPanic { get; set; }

        [DataMember]
        public bool? IsDalta { get; set; }

        [DataMember]
        public double? DalAbsolute { get; set; }

        [DataMember]
        public double? DalPercent { get; set; }

        [DataMember]
        public decimal? LowValue { get; set; }

        [DataMember]
        public decimal? HighValue { get; set; }

        [DataMember]
        public decimal? PanicLow { get; set; }

        [DataMember]
        public decimal? PanicHigh { get; set; }

        [DataMember]
        public bool? IsPass { get; set; }

        [DataMember]
        public System.DateTime? ReportDate { get; set; }

        [DataMember]
        public string ReportBy { get; set; }

        [DataMember]
        public bool? IsPrint { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public int? ParentId { get; set; }

        [DataMember]
        public string TextRange { get; set; }

        [DataMember]
        public decimal? Price { get; set; }

        [DataMember]
        public decimal? Discount { get; set; }

        [DataMember]
        public int? TestGroupId { get; set; }

        [DataMember]
        public string F5 { get; set; }

        [DataMember]
        public string F6 { get; set; }

        [DataMember]
        public string F7 { get; set; }

        [DataMember]
        public string F8 { get; set; }
    }
}
