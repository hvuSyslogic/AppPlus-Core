using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblReportDTO : DtoBase<int>
    {
        public GblReportDTO()
        {
        }

        public string Name { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short LsOutOrIn { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
