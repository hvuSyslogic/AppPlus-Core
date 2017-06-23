using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class TraceDTO : DtoBase<int>
    {
        public TraceDTO()
        {
        }

        public System.DateTime CreateDate { get; set; }
        public int UserId { get; set; }
        public string Ip { get; set; }
        public string Messages { get; set; }
        public string Type { get; set; }
        public string OperateType { get; set; }
        public int? RecordId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
