using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsBpEvaluateTestDTO : DtoBase<int>
    {
        public BsBpEvaluateTestDTO()
        {
        }

        [DataMember]
        public int? BpItemId { get; set; }

        [DataMember]
        public int? EvaluateId { get; set; }

        [DataMember]
        public bool? IsCommon { get; set; }

        [DataMember]
        public int? BpIllId { get; set; }

        [DataMember]
        public int? TestType { get; set; }
    }
}
