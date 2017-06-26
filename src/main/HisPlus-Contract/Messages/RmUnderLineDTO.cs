using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

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
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public short? OrderBy { get; set; }
    }
}
