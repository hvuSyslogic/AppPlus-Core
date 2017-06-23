using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class RmAdjustDTO : DtoBase<int>
    {
        public RmAdjustDTO()
        {
        }

        public string BillNo { get; set; }
        public System.DateTime AdjustDate { get; set; }
        public string DispUnit { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
