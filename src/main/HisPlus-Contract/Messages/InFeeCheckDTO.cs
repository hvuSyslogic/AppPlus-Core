using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InFeeCheckDTO : DtoBase<int>
    {
        public InFeeCheckDTO()
        {
        }

        [DataMember]
        public int? DetailId { get; set; }

        [DataMember]
        public int? AdviceId { get; set; }

        [DataMember]
        public short? LsMarkType { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool? IsSign { get; set; }
    }
}
