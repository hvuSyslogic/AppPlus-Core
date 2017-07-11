using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

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
        public string BloodDonor { get; set; }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public string Receptor { get; set; }
    }
}
