using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OuInvoiceFeetySumDTO : DtoBase<int>
    {
        public OuInvoiceFeetySumDTO()
        {
        }

        public int InvoId { get; set; }
        public int FeeId { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountFact { get; set; }
        public decimal AmountSelf { get; set; }
        public decimal AmountTally { get; set; }
        public decimal AmountPay { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
