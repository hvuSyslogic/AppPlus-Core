using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class AdviceAuthDtl : EntityBase<int>
    {
        public AdviceAuthDtl()
        {    
        }

        public int? LsMarkType { get; set; }
        public System.DateTime? AdviceTime { get; set; }
        public int? AdviceId { get; set; }
        public int? DoctorId { get; set; }
        public int? LocationId { get; set; }
        public int? HospId { get; set; }
        public int? GroupNum { get; set; }
        public int? ItemId { get; set; }
        public int? FormId { get; set; }
        public decimal? PriceIn { get; set; }
        public int? UnitTakeId { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public decimal? Totality { get; set; }
        public decimal? ToTalityAll { get; set; }
        public decimal? Amount { get; set; }
        public int? UnitInId { get; set; }
        public bool? IsAttach { get; set; }
        public bool? IsSelf { get; set; }
        public int? LsSpecialUsage { get; set; }
        public int? LsExecLoc { get; set; }
        public System.DateTime? SkinTime { get; set; }
        public bool? IsSkin { get; set; }
        public string SkinTest { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public bool? IsPrinted { get; set; }
        public bool? IsChk { get; set; }
        public System.DateTime? ChkOperTime { get; set; }
        public int? ChkOperId { get; set; }
        public bool? IsEnd { get; set; }
        public System.DateTime? EndOperTime { get; set; }
        public int? EndOperId { get; set; }
        public int? EndDoctorId { get; set; }
        public bool? IsAuth { get; set; }
        public System.DateTime? AuthOperTime { get; set; }
        public int? AuthOperId { get; set; }
        public string Memo { get; set; }
        public bool? IsOtherFee { get; set; }
        public bool? IsBeforeops { get; set; }
        public int? LsRpType { get; set; }
        public bool? IsInject { get; set; }
        public string Sn { get; set; }
        public int? FirstDay { get; set; }
        public int? LastDay { get; set; }
        public int? ExecLocId { get; set; }
        public int? OriAdviceId { get; set; }
        public int? InfeeCheck { get; set; }
        public int? Adcolor { get; set; }
        public bool IsManual { get; set; }
        public bool? IsArrearage { get; set; }
        public bool? IsTodayIn { get; set; }
        public int? DrugReqId1 { get; set; }
        public int? DrugReqId2 { get; set; }
        public int? DetailId1 { get; set; }
        public int? DetailId2 { get; set; }
        public string AdviceName { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Spec { get; set; }
        public int? ExecuteId { get; set; }
        public int? ExecuteId2 { get; set; }
        public decimal? Dosage { get; set; }
        public int? ExecDoctorId { get; set; }
        public bool? IsYbxj { get; set; }
        public bool? IsAutoMatic { get; set; }
        public string YbType { get; set; }
        public bool? IsPriority { get; set; }
    }
}
