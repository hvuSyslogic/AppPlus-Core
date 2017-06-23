using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InGfReport : EntityBase<int>
    {
        public InGfReport()
        {    
        }

        public int TallyGroupId { get; set; }
        public short LsReportFee { get; set; }
        public short ReportJz { get; set; }
        public short ReportBx { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
