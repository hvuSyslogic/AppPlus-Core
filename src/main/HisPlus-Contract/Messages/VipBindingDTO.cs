using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class VipBindingDTO : DtoBase<int>
    {
        public VipBindingDTO()
        {
        }

        [DataMember]
        public int? PatId { get; set; }

        [DataMember]
        public int? VipCardId { get; set; }

        [DataMember]
        public bool? IsCardHolder { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? ModifiedOperId { get; set; }

        [DataMember]
        public System.DateTime? ModifiedOperTime { get; set; }
    }
}
