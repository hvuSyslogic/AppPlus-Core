using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OuExecuteDtlDTO : DtoBase<int>
    {
        public OuExecuteDtlDTO()
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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
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
