using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class NrPregnancy : EntityBase<int>
    {
        public NrPregnancy()
        {    
        }

        public int? HospId { get; set; }
        public int? LocationId { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public System.DateTime ExpectDate { get; set; }
        public short PregnantWeek { get; set; }
        public short? PregnancyTime { get; set; }
        public short? DeliveryTimes { get; set; }
        public System.DateTime? UterusShrink { get; set; }
        public System.DateTime? UterusOpen { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
