using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkBldDonate : EntityBase<int>
    {
        public CkBldDonate()
        {    
        }

        public int? HospId { get; set; }
        public int? LocationId { get; set; }
        public string BloodGroup { get; set; }
        public string Rhd { get; set; }
        public int? BloodTypeId { get; set; }
        public decimal? Vollume { get; set; }
        public string Memo { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public string BloodDonor { get; set; }
        public int? MzRegId { get; set; }
        public string Receptor { get; set; }
    }
}
