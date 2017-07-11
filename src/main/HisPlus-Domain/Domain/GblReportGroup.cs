using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblReportGroup : EntityBase<int>
    {
        public GblReportGroup()
        {    
        }

        public int ReportId { get; set; }
        public string Name { get; set; }
        public int OrderBy { get; set; }
    }
}
