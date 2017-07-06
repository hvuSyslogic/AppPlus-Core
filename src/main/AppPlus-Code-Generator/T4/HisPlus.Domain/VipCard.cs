using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class VipCard : EntityBase<int>
    {
        public VipCard()
        {    
        }

        public int? PatId { get; set; }
        public string CardNo { get; set; }
        public int? VipLevelId { get; set; }
        public decimal? Discount { get; set; }
        public string Password { get; set; }
        public System.DateTime? CreateTime { get; set; }
        public System.DateTime? InvalidDate { get; set; }
        public int? OperId { get; set; }
        public int? CardStatus { get; set; }
        public bool? IsActive { get; set; }
        public string IntroducerId { get; set; }
        public int? IntroducerOperId { get; set; }
        public System.DateTime? ModiTime { get; set; }
        public int? ModiOperId { get; set; }
        public System.DateTime? SalesDate { get; set; }
    }
}
