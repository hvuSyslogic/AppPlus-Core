using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmCheckDTO : DtoBase<int>
    {
        public RmCheckDTO()
        {
        }

        [DataMember]
        public string BillNo { get; set; }

        [DataMember]
        public int RoomId { get; set; }

        [DataMember]
        public System.DateTime? CheckTime { get; set; }

        [DataMember]
        public decimal CheckAmount { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

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
