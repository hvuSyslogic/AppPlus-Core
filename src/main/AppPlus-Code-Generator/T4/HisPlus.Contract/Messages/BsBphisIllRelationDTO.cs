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
    }
}
