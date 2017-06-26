using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class HuStockReq : EntityBase<int>
    {
        public HuStockReq()
        {    
        }

        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public System.DateTime ApplyTime { get; set; }
        public System.DateTime? ValideTime { get; set; }
        public string ApplyIdea { get; set; }
        public string ApplyHander { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? CompId { get; set; }
    }
}
