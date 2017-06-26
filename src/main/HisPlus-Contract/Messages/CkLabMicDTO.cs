using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkLabMicDTO : DtoBase<int>
    {
        public CkLabMicDTO()
        {
        }

        [DataMember]
        public int LabId { get; set; }

        [DataMember]
        public int BacteriaId { get; set; }

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
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
