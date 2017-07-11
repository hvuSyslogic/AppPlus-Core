using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkBloodBackDTO : DtoBase<int>
    {
        public CkBloodBackDTO()
        {
        }

        [DataMember]
        public string RecNo { get; set; }

        [DataMember]
        public int LabId { get; set; }

        [DataMember]
        public int BloodId { get; set; }

        [DataMember]
        public System.DateTime? BackTime { get; set; }

        [DataMember]
        public int? BackOperId { get; set; }

        [DataMember]
        public string BackReason { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }
    }
}
