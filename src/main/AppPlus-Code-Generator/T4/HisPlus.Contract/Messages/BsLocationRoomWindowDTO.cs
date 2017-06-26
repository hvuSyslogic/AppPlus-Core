using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

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
