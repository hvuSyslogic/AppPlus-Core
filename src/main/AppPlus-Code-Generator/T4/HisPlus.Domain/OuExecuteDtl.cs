using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuExecuteDtl : EntityBase<int>
    {
        public OuExecuteDtl()
        {    
        }

        public int ExecuteId { get; set; }
        public int? RecipeDtlId { get; set; }
        public int ListNum { get; set; }
        public int ItemId { get; set; }
        public decimal Dosage { get; set; }
        public int UnitId { get; set; }
        public int UsageId { get; set; }
        public int FrequencyId { get; set; }
        public short Days { get; set; }
        public decimal? Totality { get; set; }
        public int? UnitDiagId { get; set; }
        public System.DateTime? IssueTime { get; set; }
        public System.DateTime? BackTime { get; set; }
        public bool? IsExecuted { get; set; }
        public System.DateTime? ExecutedTime { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
    }
}
