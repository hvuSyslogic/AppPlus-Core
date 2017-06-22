using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblReportDetailDTO : DtoBase<int>
    {
        public GblReportDetailDTO()
        {
        }

        public int GroupId { get; set; }
        public int FeeId { get; set; }
    }
}
