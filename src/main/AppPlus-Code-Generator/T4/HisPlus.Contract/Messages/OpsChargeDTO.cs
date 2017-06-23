using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OpsChargeDTO : DtoBase<int>
    {
        public OpsChargeDTO()
        {
        }

        public int ApplyId { get; set; }
        public int ListNum { get; set; }
        public int ItemId { get; set; }
        public string Remark { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsTally { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public decimal? Before { get; set; }
        public decimal? Progress { get; set; }
        public decimal? After { get; set; }
    }
}
