using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InPay : EntityBase<int>
    {
        public InPay()
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
        public int? CancelPaywayId { get; set; }
    }
}
