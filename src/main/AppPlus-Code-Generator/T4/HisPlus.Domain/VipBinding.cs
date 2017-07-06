using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class VipBinding : EntityBase<int>
    {
        public VipBinding()
        {    
        }

        public int? PatId { get; set; }
        public int? VipCardId { get; set; }
        public bool? IsCardHolder { get; set; }
        public bool? IsActive { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? ModifiedOperId { get; set; }
        public System.DateTime? ModifiedOperTime { get; set; }
    }
}
