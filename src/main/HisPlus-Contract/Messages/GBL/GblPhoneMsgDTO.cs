using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblPhoneMsgDTO : DtoBase<int>
    {
        public GblPhoneMsgDTO()
        {
        }

        public string PhoneNum { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public System.DateTime? PlanTime { get; set; }
        public bool? IsSend { get; set; }
        public System.DateTime? SendTime { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
