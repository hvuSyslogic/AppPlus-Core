using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class HuPy : EntityBase<int>
    {
        public HuPy()
        {    
        }

        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsSign { get; set; }
        public System.DateTime? SignTime { get; set; }
        public int? SignOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
