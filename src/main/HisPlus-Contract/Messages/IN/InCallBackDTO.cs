using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InCallBackDTO : DtoBase<int>
    {
        public InCallBackDTO()
        {
        }

        public int? LocationId { get; set; }
        public int HospId { get; set; }
        public System.DateTime BackTime { get; set; }
        public string Reason { get; set; }
        public System.DateTime OperTime { get; set; }
        public int? OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
