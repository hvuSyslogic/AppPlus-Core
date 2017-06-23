using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkReportDefineDTO : DtoBase<int>
    {
        public CkReportDefineDTO()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int? TestTypeId { get; set; }
        public byte[] ReportContent { get; set; }
    }
}
