using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmUnderLineDTO : DtoBase<int>
    {
        public RmUnderLineDTO()
        {
        }

        [DataMember]
        public int RoomId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public decimal UnderLine { get; set; }

        [DataMember]
        public decimal UperLine { get; set; }

        [DataMember]
        public decimal Normal { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public short? OrderBy { get; set; }

        [DataMember]
        public bool? IsStop { get; set; }
    }
}
