using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsReportNurseItem : EntityBase<int>
    {
        public BsReportNurseItem()
        {    
        }

        public string FeeName { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Spec { get; set; }
        public double? Price { get; set; }
        public string Unit { get; set; }
        public int? ItemId { get; set; }
        public int? IsOuInAll { get; set; }
        public string Type { get; set; }
    }
}
