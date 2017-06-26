using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsBphisIllRelationDTO : DtoBase<int>
    {
        public BsBphisIllRelationDTO()
        {
        }

        [DataMember]
        public int? BpIllId { get; set; }

        [DataMember]
        public int? HisIllId { get; set; }

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
