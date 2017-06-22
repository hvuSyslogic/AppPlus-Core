using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblReportGroupDTO : DtoBase<int>
    {
        public GblReportGroupDTO()
        {
        }

        public int ReportId { get; set; }
        public string Name { get; set; }
        public int OrderBy { get; set; }
    }
}
