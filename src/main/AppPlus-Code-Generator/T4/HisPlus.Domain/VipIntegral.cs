using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class VipIntegral : EntityBase<int>
    {
        public VipIntegral()
        {    
        }

        public int? PatId { get; set; }
        public int? VipcardId { get; set; }
        public decimal? Integral { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public bool? OperStatus { get; set; }
        public string Comments { get; set; }
        public bool? IsActive { get; set; }
    }
}
