using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuGfReport : EntityBase<int>
    {
        public OuGfReport()
        {    
        }

        public int TallyGroupId { get; set; }
        public short LsreportFee { get; set; }
        public short ReportJz { get; set; }
        public short ReportBx { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
