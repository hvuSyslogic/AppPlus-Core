using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblFunTraceDTO : DtoBase<int>
    {
        public GblFunTraceDTO()
        {
        }

        public byte? DebugMode { get; set; }
        public int? FuntionId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? UserId { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
