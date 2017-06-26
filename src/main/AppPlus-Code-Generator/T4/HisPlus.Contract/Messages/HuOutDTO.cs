using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class HuOutDTO : DtoBase<int>
    {
        public HuOutDTO()
        {
        }

        [DataMember]
        public string BillNo { get; set; }

        [DataMember]
        public int HouseId { get; set; }

        [DataMember]
        public int RoomId { get; set; }

        [DataMember]
        public int? ApplyId { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public string OutMemo { get; set; }

        [DataMember]
        public bool YfSign { get; set; }

        [DataMember]
        public int? YfOperId { get; set; }

        [DataMember]
        public System.DateTime? YfOperTime { get; set; }

        [DataMember]
        public bool IsSign { get; set; }

        [DataMember]
        public System.DateTime? SignTime { get; set; }

        [DataMember]
        public int? SignOperId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? ApperId { get; set; }

        [DataMember]
        public int? OutWayId { get; set; }
    }
}
