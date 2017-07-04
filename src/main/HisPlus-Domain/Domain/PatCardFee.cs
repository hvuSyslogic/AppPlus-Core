using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class PatCardFee : EntityBase<int>
    {
        public PatCardFee()
        {    
        }

        public int PatId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public int? PaywayId { get; set; }
        public decimal? Amount { get; set; }
        public string Memo { get; set; }
        public short? CallOrder { get; set; }
    }
}
