using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
