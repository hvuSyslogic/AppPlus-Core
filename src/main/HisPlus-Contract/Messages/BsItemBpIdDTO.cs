using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemBpIdDTO : DtoBase<int>
    {
        public BsItemBpIdDTO()
        {
        }

        [DataMember]
        public int? BpItemId { get; set; }

        [DataMember]
        public int? HisItemId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? UserId { get; set; }
    }
}
