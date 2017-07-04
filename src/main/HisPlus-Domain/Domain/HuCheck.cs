using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class HuCheck : EntityBase<int>
    {
        public HuCheck()
        {    
        }

        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public System.DateTime? CheckTime { get; set; }
        public decimal CheckAmount { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
    }
}
