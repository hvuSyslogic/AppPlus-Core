using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmAppDrugDTO : DtoBase<int>
    {
        public RmAppDrugDTO()
        {
        }

        [DataMember]
        public string BillNo { get; set; }

        [DataMember]
        public int HouseId { get; set; }

        [DataMember]
        public int RoomId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool IsAffirm { get; set; }

        [DataMember]
        public System.DateTime? AffirmTime { get; set; }

        [DataMember]
        public int? AffirmOperid { get; set; }

        [DataMember]
        public bool? IsAuth { get; set; }

        [DataMember]
        public int? AuthOperId { get; set; }

        [DataMember]
        public System.DateTime? AuthOperTime { get; set; }

        [DataMember]
        public string Memo { get; set; }
    }
}
