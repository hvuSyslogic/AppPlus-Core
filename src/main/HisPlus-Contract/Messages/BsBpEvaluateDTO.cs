using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsBpEvaluateDTO : DtoBase<int>
    {
        public BsBpEvaluateDTO()
        {
        }

        [DataMember]
        public int? EvaluateId { get; set; }

        [DataMember]
        public string EvaluateName { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string ShortName { get; set; }
    }
}
