using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class EqRepairDTO : DtoBase<int>
    {
        public EqRepairDTO()
        {
        }

        [DataMember]
        public int EquipmentId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public System.DateTime? RepairTime { get; set; }

        [DataMember]
        public string Reason { get; set; }

        [DataMember]
        public string RepairWay { get; set; }

        [DataMember]
        public string RepairUnit { get; set; }

        [DataMember]
        public string RepairMan { get; set; }

        [DataMember]
        public decimal? RepairFee { get; set; }

        [DataMember]
        public string Memo { get; set; }

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
