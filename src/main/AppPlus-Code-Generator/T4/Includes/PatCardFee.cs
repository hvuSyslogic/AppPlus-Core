using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
