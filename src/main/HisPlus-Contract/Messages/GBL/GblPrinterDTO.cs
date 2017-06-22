using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblPrinterDTO : DtoBase<int>
    {
        public GblPrinterDTO()
        {
        }

        public string Hostname { get; set; }
        public string ReportName { get; set; }
        public string PrinterName { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
