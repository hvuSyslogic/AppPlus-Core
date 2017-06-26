using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
