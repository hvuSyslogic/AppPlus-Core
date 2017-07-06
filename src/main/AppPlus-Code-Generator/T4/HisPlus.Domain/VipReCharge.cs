using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class VipReCharge : EntityBase<int>
    {
        public VipReCharge()
        {    
        }

        public int? VipCardId { get; set; }
        public int? PatId { get; set; }
        public string CardNo { get; set; }
        public decimal? InCome { get; set; }
        public decimal? PayOut { get; set; }
        public decimal? Balance { get; set; }
        public int? PayWay { get; set; }
        public short? OperType { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public string Comments { get; set; }
        public int? VipTypeId { get; set; }
        public int? LsVipChaFromType { get; set; }
        public int? InvoId { get; set; }
    }
}
