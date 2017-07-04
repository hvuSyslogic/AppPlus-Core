using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class YbPatSeqDTO : DtoBase<int>
    {
        public YbPatSeqDTO()
        {
        }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public string YbSeq { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }
    }
}
