using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RmAdjustDtl : EntityBase<int>
    {
        public RmAdjustDtl()
        {    
        }

        public int BillId { get; set; }
        public int RoomId { get; set; }
        public int InBatchId { get; set; }
        public int ItemId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
        public decimal ProfLoss { get; set; }
    }
}
