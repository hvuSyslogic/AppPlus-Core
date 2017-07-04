using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InDrugReqDTO : DtoBase<int>
    {
        public InDrugReqDTO()
        {
        }

        [DataMember]
        public string RequestNo { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int RoomId { get; set; }

        [DataMember]
        public short LsSendStatus { get; set; }

        [DataMember]
        public bool IsPrint { get; set; }

        [DataMember]
        public int? ConfirmOperId { get; set; }

        [DataMember]
        public System.DateTime? ConfirmDate { get; set; }
    }
}
