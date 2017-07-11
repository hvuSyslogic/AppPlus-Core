using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsLocationRoomWindowDTO : DtoBase<int>
    {
        public BsLocationRoomWindowDTO()
        {
        }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public string RoomWindowName { get; set; }

        [DataMember]
        public string PrinterName { get; set; }
    }
}
