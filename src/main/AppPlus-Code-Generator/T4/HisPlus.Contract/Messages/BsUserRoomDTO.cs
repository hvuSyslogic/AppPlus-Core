using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsUserRoomDTO : DtoBase<int>
    {
        public BsUserRoomDTO()
        {
        }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int RoomId { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
