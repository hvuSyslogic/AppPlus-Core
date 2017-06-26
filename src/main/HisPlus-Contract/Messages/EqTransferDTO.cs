using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class EqTransferDTO : DtoBase<int>
    {
        public EqTransferDTO()
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
        public System.DateTime? ChangeTime { get; set; }

        [DataMember]
        public string Reason { get; set; }

        [DataMember]
        public int? FromLocId { get; set; }

        [DataMember]
        public int? ToLocId { get; set; }

        [DataMember]
        public string ToPlace { get; set; }

        [DataMember]
        public string RecieveMan { get; set; }

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
