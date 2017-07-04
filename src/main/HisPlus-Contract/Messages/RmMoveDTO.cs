using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmMoveDTO : DtoBase<int>
    {
        public RmMoveDTO()
        {
        }

        [DataMember]
        public string BillNo { get; set; }

        [DataMember]
        public int RoomIdI { get; set; }

        [DataMember]
        public int RoomIdO { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int Operid { get; set; }

        [DataMember]
        public bool IsSign { get; set; }

        [DataMember]
        public System.DateTime? SignTime { get; set; }

        [DataMember]
        public int? SignOperId { get; set; }

        [DataMember]
        public bool? IsSignRev { get; set; }

        [DataMember]
        public System.DateTime? SignTimeRev { get; set; }

        [DataMember]
        public int? SignOperIdRev { get; set; }
    }
}
