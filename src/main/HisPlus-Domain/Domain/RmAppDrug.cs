using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RmAppDrug : EntityBase<int>
    {
        public RmAppDrug()
        {    
        }

        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public int RoomId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsAffirm { get; set; }
        public System.DateTime? AffirmTime { get; set; }
        public int? AffirmOperid { get; set; }
        public bool? IsAuth { get; set; }
        public int? AuthOperId { get; set; }
        public System.DateTime? AuthOperTime { get; set; }
        public string Memo { get; set; }
    }
}
