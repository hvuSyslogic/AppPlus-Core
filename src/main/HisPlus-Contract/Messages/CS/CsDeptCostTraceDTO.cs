using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CsDeptCostTraceDTO : DtoBase<int>
    {
        public CsDeptCostTraceDTO()
        {
        }

        public string YearMonth { get; set; }
        public int LocId { get; set; }
        public int? CostSubjId { get; set; }
        public int? FromLocId { get; set; }
        public decimal Amount { get; set; }
        public short Step { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
