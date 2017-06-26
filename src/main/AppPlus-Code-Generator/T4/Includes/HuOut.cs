using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class HuOut : EntityBase<int>
    {
        public HuOut()
        {    
        }

        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public int RoomId { get; set; }
        public int? ApplyId { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public string OutMemo { get; set; }
        public bool YfSign { get; set; }
        public int? YfOperId { get; set; }
        public System.DateTime? YfOperTime { get; set; }
        public bool IsSign { get; set; }
        public System.DateTime? SignTime { get; set; }
        public int? SignOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? ApperId { get; set; }
        public int? OutWayId { get; set; }
    }
}
