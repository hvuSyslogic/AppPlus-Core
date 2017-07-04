using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InInvoiceInvItemSum : EntityBase<int>
    {
        public InInvoiceInvItemSum()
        {    
        }

        public int InvoId { get; set; }
        public int InvItemId { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountFact { get; set; }
        public decimal AmountSelf { get; set; }
        public decimal AmountTally { get; set; }
        public decimal AmountPay { get; set; }
        public decimal? MzAmount { get; set; }
        public decimal? Insurance { get; set; }
    }
}
