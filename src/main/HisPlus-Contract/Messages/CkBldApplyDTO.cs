using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkBldApplyDTO : DtoBase<int>
    {
        public CkBldApplyDTO()
        {
        }

        [DataMember]
        public string RecNo { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public string PatBloodGroup { get; set; }

        [DataMember]
        public string PatRhd { get; set; }

        [DataMember]
        public string Illness { get; set; }

        [DataMember]
        public string Purpose { get; set; }

        [DataMember]
        public string HstyBlood { get; set; }

        [DataMember]
        public string HstyReact { get; set; }

        [DataMember]
        public string HstyTest { get; set; }

        [DataMember]
        public string HstyPregnancy { get; set; }

        [DataMember]
        public string HstyBirth { get; set; }

        [DataMember]
        public string TestResult { get; set; }

        [DataMember]
        public int? BloodTypeId { get; set; }

        [DataMember]
        public decimal? Vollume { get; set; }

        [DataMember]
        public string Unit { get; set; }

        [DataMember]
        public decimal? PreOps { get; set; }

        [DataMember]
        public string SpecHandle { get; set; }

        [DataMember]
        public string BloodGroup { get; set; }

        [DataMember]
        public string Replace { get; set; }

        [DataMember]
        public string LabNum { get; set; }

        [DataMember]
        public bool? IsAgree { get; set; }
    }
}
