using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkGroupDTO : DtoBase<int>
    {
        public CkGroupDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
