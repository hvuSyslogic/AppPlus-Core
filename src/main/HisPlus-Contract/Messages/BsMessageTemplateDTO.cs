using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsMessageTemplateDTO : DtoBase<int>
    {
        public BsMessageTemplateDTO()
        {
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Contents { get; set; }

        [DataMember]
        public int? ParentId { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public bool? IsDefault { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }
    }
}
