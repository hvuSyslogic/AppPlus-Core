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
