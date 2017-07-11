using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
