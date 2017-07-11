using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblPrinter : EntityBase<int>
    {
        public GblPrinter()
        {    
        }

        public string Hostname { get; set; }
        public string ReportName { get; set; }
        public string PrinterName { get; set; }
    }
}
