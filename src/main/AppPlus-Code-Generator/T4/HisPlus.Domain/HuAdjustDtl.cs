using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class HuAdjustDtl : EntityBase<int>
    {
        public HuAdjustDtl()
        {    
        }

        public int InBatchId { get; set; }
        public int BillId { get; set; }
        public int ItemId { get; set; }
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
        public decimal ProfLoss { get; set; }
        public decimal DrugNum { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
