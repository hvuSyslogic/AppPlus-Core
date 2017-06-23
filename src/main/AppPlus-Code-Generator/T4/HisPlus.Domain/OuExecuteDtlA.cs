using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class OuExecuteDtlA : EntityBase<System.DateTime>
    {
        public OuExecuteDtlA()
        {    
        }

        public int? RecipeDtlId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public decimal? Totality { get; set; }
        public int? UnitDiagId { get; set; }
        public System.DateTime? IssueTime { get; set; }
        public System.DateTime? BackTime { get; set; }
    }
}
