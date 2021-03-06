using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class OpsEvent : EntityBase<int>
    {
        public OpsEvent()
        {    
        }

        public int? ItemId { get; set; }
        public int? UnitTakeId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? UsageId { get; set; }
    }
}
