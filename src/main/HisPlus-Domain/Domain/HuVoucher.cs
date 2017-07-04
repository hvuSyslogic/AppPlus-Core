using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class HuVoucher : EntityBase<int>
    {
        public HuVoucher()
        {    
        }

        public string VoucherNo { get; set; }
        public int? HouseId { get; set; }
        public int? CompId { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public string Memo { get; set; }
    }
}
