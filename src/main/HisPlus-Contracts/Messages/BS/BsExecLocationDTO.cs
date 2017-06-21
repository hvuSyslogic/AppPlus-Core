using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsExecLocationDTO : DtoBase<int>
    {
        public BsExecLocationDTO()
        {
        }

        public int? LocationId { get; set; }
        public int ItemId { get; set; }
        public string TimeBegin { get; set; }
        public string TimeEnd { get; set; }
        public string ExecPoint { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
