using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class PsApplyReport : EntityBase<int>
    {
        public PsApplyReport()
        {    
        }

        public string ApplyNo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public int? LocationId { get; set; }
        public int? DoctorId { get; set; }
        public int PatId { get; set; }
        public int? MzRegId { get; set; }
        public int? HospId { get; set; }
        public bool IsCancel { get; set; }
        public System.DateTime? CancelTime { get; set; }
        public int? CancelOperId { get; set; }
        public short XType { get; set; }
        public bool IsPre { get; set; }
        public int? ItemId { get; set; }
        public bool IsCharged { get; set; }
        public bool IsConfirm { get; set; }
        public System.DateTime? ConfirmTime { get; set; }
        public string Equipment { get; set; }
        public string ApplyMemo { get; set; }
        public int? ExecLocId { get; set; }
        public System.DateTime? CheckTime { get; set; }
        public int? CheckOperId { get; set; }
        public System.DateTime? ReportTime { get; set; }
        public int? ReportOperId { get; set; }
        public int? AuthOperId { get; set; }
        public string CheckBody { get; set; }
        public string CheckParm { get; set; }
        public string CheckDesc { get; set; }
        public string CheckResult { get; set; }
        public string CheckAdvice { get; set; }
        public bool IsAbNormal { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Summary { get; set; }
        public string Diagnose { get; set; }
        public int? CheckId { get; set; }
        public int? ExecuteId { get; set; }
    }
}
