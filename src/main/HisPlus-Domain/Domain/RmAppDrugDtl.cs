using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RmAppDrugDtl : EntityBase<int>
    {
        public RmAppDrugDtl()
        {    
        }

        public int BillId { get; set; }
        public int ItemId { get; set; }
        public decimal DrugNum { get; set; }
        public int UnitId { get; set; }
        public decimal? HuStockNum { get; set; }
        public int? UnitKc { get; set; }
        public string Pno { get; set; }
        public System.DateTime? LimitDate { get; set; }
    }
}
