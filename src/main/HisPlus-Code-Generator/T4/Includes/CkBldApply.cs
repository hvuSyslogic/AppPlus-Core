using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkBldApply : EntityBase<int>
    {
        public CkBldApply()
        {    
        }

        public string RecNo { get; set; }
        public int? HospId { get; set; }
        public string PatBloodGroup { get; set; }
        public string PatRhd { get; set; }
        public string Illness { get; set; }
        public string Purpose { get; set; }
        public string HstyBlood { get; set; }
        public string HstyReact { get; set; }
        public string HstyTest { get; set; }
        public string HstyPregnancy { get; set; }
        public string HstyBirth { get; set; }
        public string TestResult { get; set; }
        public int? BloodTypeId { get; set; }
        public decimal? Vollume { get; set; }
        public string Unit { get; set; }
        public decimal? PreOps { get; set; }
        public string SpecHandle { get; set; }
        public string BloodGroup { get; set; }
        public string Replace { get; set; }
        public string LabNum { get; set; }
        public bool? IsAgree { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
