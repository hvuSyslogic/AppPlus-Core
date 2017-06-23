using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OuIllReportDTO : DtoBase<int>
    {
        public OuIllReportDTO()
        {
        }

        public int MzRegId { get; set; }
        public string Xml { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
