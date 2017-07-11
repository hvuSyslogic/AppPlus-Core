using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class EqRepair : EntityBase<int>
    {
        public EqRepair()
        {    
        }

        public int EquipmentId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Code { get; set; }
        public System.DateTime? RepairTime { get; set; }
        public string Reason { get; set; }
        public string RepairWay { get; set; }
        public string RepairUnit { get; set; }
        public string RepairMan { get; set; }
        public decimal? RepairFee { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
