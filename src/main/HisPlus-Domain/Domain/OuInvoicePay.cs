using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
        public int? CancelPaywayId { get; set; }
        public int? BankId { get; set; }
    }
}
