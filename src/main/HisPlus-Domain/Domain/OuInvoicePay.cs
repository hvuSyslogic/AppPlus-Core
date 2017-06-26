using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuInvoicePay : EntityBase<int>
    {
        public OuInvoicePay()
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
