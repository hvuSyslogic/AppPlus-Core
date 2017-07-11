using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class HuVoucherDtl : EntityBase<int>
    {
        public HuVoucherDtl()
        {    
        }

        public int? VoucherId { get; set; }
        public int BillId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? HasPay { get; set; }
    }
}
