using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InInvoiceFeetySum : EntityBase<int>
    {
        public InInvoiceFeetySum()
        {    
        }

        public int InvoId { get; set; }
        public int FeeId { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountFact { get; set; }
        public decimal AmountSelf { get; set; }
        public decimal AmountTally { get; set; }
        public decimal AmountPay { get; set; }
        public decimal? MzAmount { get; set; }
        public decimal? Insurance { get; set; }
    }
}
