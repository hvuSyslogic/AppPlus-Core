using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblInvRegDTO : DtoBase<int>
    {
        public GblInvRegDTO()
        {
        }

        public string InvType { get; set; }
        public string Name { get; set; }
        public string StartInvoNo { get; set; }
        public string EndInvoNo { get; set; }
        public bool IsEnd { get; set; }
        public System.DateTime? EndTime { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
