using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RmMove : EntityBase<int>
    {
        public RmMove()
        {    
        }

        public string BillNo { get; set; }
        public int RoomIdI { get; set; }
        public int RoomIdO { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int Operid { get; set; }
        public bool IsSign { get; set; }
        public System.DateTime? SignTime { get; set; }
        public int? SignOperId { get; set; }
        public bool? IsSignRev { get; set; }
        public System.DateTime? SignTimeRev { get; set; }
        public int? SignOperIdRev { get; set; }
    }
}
