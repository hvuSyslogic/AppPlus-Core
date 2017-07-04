using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class TrAdviceDTO : DtoBase<int>
    {
        public TrAdviceDTO()
        {
        }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int AdviceId { get; set; }

        [DataMember]
        public short LsMarkType { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Before { get; set; }

        [DataMember]
        public string After { get; set; }

        [DataMember]
        public int? HospId { get; set; }
    }
}
