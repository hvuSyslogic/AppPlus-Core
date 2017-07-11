using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RmOtherIn : EntityBase<int>
    {
        public RmOtherIn()
        {    
        }

        public string BillNo { get; set; }
        public int RoomId { get; set; }
        public string Reason { get; set; }
        public System.DateTime OperTime { get; set; }
        public int Operid { get; set; }
        public bool IsSign { get; set; }
        public System.DateTime? SignTime { get; set; }
        public int? SignOperId { get; set; }
    }
}
