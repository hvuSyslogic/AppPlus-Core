using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ElPatFormTestDTO : DtoBase<int>
    {
        public ElPatFormTestDTO()
        {
        }

        [DataMember]
        public int PatFormId { get; set; }

        [DataMember]
        public int TestId { get; set; }

        [DataMember]
        public string Result { get; set; }

        [DataMember]
        public string Unit { get; set; }

        [DataMember]
        public short LsRefFlag { get; set; }

        [DataMember]
        public decimal LowValue { get; set; }

        [DataMember]
        public decimal HighValue { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string TextRange { get; set; }

        [DataMember]
        public int? LabId { get; set; }

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
