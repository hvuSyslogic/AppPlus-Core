using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkBldToStationDTO : DtoBase<int>
    {
        public CkBldToStationDTO()
        {
        }

        [DataMember]
        public string RecNo { get; set; }

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
