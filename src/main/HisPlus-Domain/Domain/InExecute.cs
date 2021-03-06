using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InExecute : EntityBase<int>
    {
        public InExecute()
        {    
        }

        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public int LocationId { get; set; }
        public int AdviceId { get; set; }
        public short LsMarkType { get; set; }
        public string Memo { get; set; }
        public bool IsPrint { get; set; }
        public System.DateTime? PrintOperTime { get; set; }
        public int? PrintOperId { get; set; }
        public System.DateTime? AdviceTime { get; set; }
        public int? DoctorId { get; set; }
        public int? HospId { get; set; }
        public short? GroupNum { get; set; }
        public int? ItemId { get; set; }
        public decimal? Dosage { get; set; }
        public int? UnitTakeId { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public decimal? PriceIn { get; set; }
        public decimal? Totality { get; set; }
        public int? UnitInId { get; set; }
        public bool? IsUrgent { get; set; }
        public bool? IsAttach { get; set; }
        public bool? IsSelf { get; set; }
        public short? LsSpecialUsage { get; set; }
        public short? LsExecLoc { get; set; }
        public bool? IsSkin { get; set; }
        public System.DateTime? SkinTime { get; set; }
        public string SkinTest { get; set; }
        public int? DetailId { get; set; }
        public int? ExecLocId { get; set; }
        public bool? IsExecuted { get; set; }
        public System.DateTime? ExecutedTime { get; set; }
        public int? ExecutedOperId { get; set; }
        public bool? IsMinus { get; set; }
        public string NurseMemo { get; set; }
        public System.DateTime? MemoTime { get; set; }
        public int? MemoOperId { get; set; }
        public short? FirstDay { get; set; }
        public short? LastDay { get; set; }
        public bool? IsLastLong { get; set; }
        public bool? IsArrearage { get; set; }
        public string YbType { get; set; }
    }
}
