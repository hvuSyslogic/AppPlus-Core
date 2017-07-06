using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkLabResultDTO : DtoBase<int>
    {
        public CkLabResultDTO()
        {
        }

        [DataMember]
        public int LabId { get; set; }

        [DataMember]
        public int TestId { get; set; }

        [DataMember]
        public string LastResult { get; set; }

        [DataMember]
        public string Result { get; set; }

        [DataMember]
        public string Unit { get; set; }

        [DataMember]
        public short LsRefFlag { get; set; }

        [DataMember]
        public bool IsPanic { get; set; }

        [DataMember]
        public bool IsDalta { get; set; }

        [DataMember]
        public decimal DalAbsolute { get; set; }

        [DataMember]
        public decimal DalPercent { get; set; }

        [DataMember]
        public decimal LowValue { get; set; }

        [DataMember]
        public decimal HighValue { get; set; }

        [DataMember]
        public decimal PanicLow { get; set; }

        [DataMember]
        public decimal PanicHigh { get; set; }

        [DataMember]
        public bool IsPass { get; set; }

        [DataMember]
        public bool IsReport { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool IsPrint { get; set; }

        [DataMember]
        public System.DateTime? PrintTime { get; set; }

        [DataMember]
        public int? PrintOperId { get; set; }

        [DataMember]
        public string TextRange { get; set; }
    }
}
