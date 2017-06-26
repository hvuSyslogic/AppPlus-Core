using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class HuStock : EntityBase<int>
    {
        public HuStock()
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
        public bool IsBack { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Memo { get; set; }
        public int? BuyId { get; set; }
        public int? BuyWayId { get; set; }
        public int? Applicant { get; set; }
        public int? Application { get; set; }
    }
}
