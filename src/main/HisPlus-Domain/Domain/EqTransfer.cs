using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class EqTransfer : EntityBase<int>
    {
        public EqTransfer()
        {    
        }

        public int EquipmentId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Code { get; set; }
        public System.DateTime? ChangeTime { get; set; }
        public string Reason { get; set; }
        public int? FromLocId { get; set; }
        public int? ToLocId { get; set; }
        public string ToPlace { get; set; }
        public string RecieveMan { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
