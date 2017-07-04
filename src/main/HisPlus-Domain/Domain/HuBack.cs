using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class HuBack : EntityBase<int>
    {
        public HuBack()
        {    
        }

        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public int CompId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsSign { get; set; }
        public System.DateTime? SignTime { get; set; }
        public int? SignOperId { get; set; }
        public string RkBillNo { get; set; }
    }
}
