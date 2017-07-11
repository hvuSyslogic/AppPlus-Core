using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class Rtrjkreport : EntityBase<int>
    {
        public Rtrjkreport()
        {    
        }

        public System.DateTime? Cancelopertime { get; set; }
        public int? Iscancel { get; set; }
        public System.DateTime? Begintime { get; set; }
        public System.DateTime? Endtime { get; set; }
        public int? Hospitalid { get; set; }
        public string LsOutIn { get; set; }
        public int? Bills { get; set; }
        public int? Billcancel { get; set; }
        public decimal? AmountSum { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountCancel { get; set; }
        public decimal? Insurance { get; set; }
        public decimal? AmountPay { get; set; }
        public decimal? AmountYf { get; set; }
        public System.DateTime? SignTime { get; set; }
        public int? SignOperId { get; set; }
        public string Memo { get; set; }
    }
}
