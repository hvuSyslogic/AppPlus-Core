using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RmLose : EntityBase<int>
    {
        public RmLose()
        {    
        }

        public string BillNo { get; set; }
        public int RoomId { get; set; }
        public int? LocationId { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int Operid { get; set; }
        public bool IsSign { get; set; }
        public System.DateTime? SignDate { get; set; }
        public int? SignOperId { get; set; }
    }
}
