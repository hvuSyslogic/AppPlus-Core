using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuInvoiceInvItemSum : EntityBase<int>
    {
        public OuInvoiceInvItemSum()
        {    
        }

        public int InvoId { get; set; }
        public int InvItemId { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountFact { get; set; }
        public decimal AmountSelf { get; set; }
        public decimal AmountTally { get; set; }
        public decimal AmountPay { get; set; }
    }
}
