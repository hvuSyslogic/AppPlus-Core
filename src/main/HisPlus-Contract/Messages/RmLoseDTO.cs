using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmLoseDTO : DtoBase<int>
    {
        public RmLoseDTO()
        {
        }

        [DataMember]
        public string BillNo { get; set; }

        [DataMember]
        public int RoomId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int Operid { get; set; }

        [DataMember]
        public bool IsSign { get; set; }

        [DataMember]
        public System.DateTime? SignDate { get; set; }

        [DataMember]
        public int? SignOperId { get; set; }
    }
}
