using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkBldDonateDTO : DtoBase<int>
    {
        public CkBldDonateDTO()
        {
        }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public string BloodGroup { get; set; }

        [DataMember]
        public string Rhd { get; set; }

        [DataMember]
        public int? BloodTypeId { get; set; }

        [DataMember]
        public decimal? Vollume { get; set; }

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
