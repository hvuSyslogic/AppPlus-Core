using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public decimal? MzAmount { get; set; }
    }
}
