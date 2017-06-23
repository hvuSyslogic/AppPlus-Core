using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    // The table 'BsReportNurseItem' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class BsReportNurseItem
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
