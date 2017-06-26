using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InAdviceGroup : EntityBase<int>
    {
        public InAdviceGroup()
        {    
        }

        public int HospId { get; set; }
        public int UsageId { get; set; }
        public short? GroupNum { get; set; }
        public short? LsMarkType { get; set; }
        public int? MaxFrequency { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? LocationId { get; set; }
    }
}
