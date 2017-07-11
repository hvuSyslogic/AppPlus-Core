using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmZyOutDTO : DtoBase<int>
    {
        public RmZyOutDTO()
        {
        }

        [DataMember]
        public string BillNo { get; set; }

        [DataMember]
        public int RoomId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool IsSign { get; set; }

        [DataMember]
        public System.DateTime? SignTime { get; set; }

        [DataMember]
        public int? SignOperId { get; set; }
    }
}
