using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OuInvoicePayDTO : DtoBase<int>
    {
        public OuInvoicePayDTO()
        {
        }

        public int InvoId { get; set; }
        public int PaywayId { get; set; }
        public decimal Amount { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? CancelPaywayId { get; set; }
    }
}
