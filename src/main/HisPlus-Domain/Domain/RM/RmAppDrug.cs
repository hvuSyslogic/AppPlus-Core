using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
