using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class HuOtherIn : EntityBase<int>
    {
        public HuOtherIn()
        {    
        }

        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public string Reason { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsSign { get; set; }
        public System.DateTime? SignTime { get; set; }
        public int? SignOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? LocationId { get; set; }
    }
}
