using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InPayDTO : DtoBase<int>
    {
        public InPayDTO()
        {
        }

        public int HospId { get; set; }
        public int? InvoId { get; set; }
        public int? DepositId { get; set; }
        public short LsChargeType { get; set; }
        public decimal Amount { get; set; }
        public int PayWayId { get; set; }
        public string Memo { get; set; }
        public decimal Remain { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? CancelPaywayId { get; set; }
    }
}
