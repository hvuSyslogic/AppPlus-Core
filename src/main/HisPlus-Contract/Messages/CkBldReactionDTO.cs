using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkBldReactionDTO : DtoBase<int>
    {
        public CkBldReactionDTO()
        {
        }

        [DataMember]
        public string RecNo { get; set; }

        [DataMember]
        public int LabId { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public int BloodId { get; set; }

        [DataMember]
        public System.DateTime? TransTime { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public string TransType { get; set; }

        [DataMember]
        public decimal? TotalVollume { get; set; }

        [DataMember]
        public System.DateTime? ReactTime { get; set; }

        [DataMember]
        public short? LsTransType { get; set; }

        [DataMember]
        public string ClincHandle { get; set; }

        [DataMember]
        public string TransHandle { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }
    }
}
