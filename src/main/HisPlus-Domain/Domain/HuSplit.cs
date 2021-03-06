using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class HuSplit : EntityBase<int>
    {
        public HuSplit()
        {    
        }

        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
    }
}
