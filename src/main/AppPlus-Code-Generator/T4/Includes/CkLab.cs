using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkLab : EntityBase<int>
    {
        public CkLab()
        {    
        }

        public string LabNum { get; set; }
        public int PatId { get; set; }
        public int? MzRegId { get; set; }
        public int? HospId { get; set; }
        public short LsSource { get; set; }
        public int? LocationId { get; set; }
        public int? DoctorId { get; set; }
        public string RefLocation { get; set; }
        public string IllHistory { get; set; }
        public string Diagnose { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsPriority { get; set; }
        public System.DateTime? CollectTime { get; set; }
        public int? CollectOperId { get; set; }
        public string Memo { get; set; }
        public bool IsCancel { get; set; }
        public System.DateTime? CancelTime { get; set; }
        public int? CancelOperId { get; set; }
        public bool? IsPass { get; set; }
        public string ReportMemo { get; set; }
        public string TechMemo { get; set; }
        public string OtherMemo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public System.DateTime? RecieveTime { get; set; }
        public int? RecieveOperId { get; set; }
        public System.DateTime? ResultTime { get; set; }
        public int? ResultOperId { get; set; }
        public System.DateTime? AuthTime { get; set; }
        public int? AuthOperId { get; set; }
        public System.DateTime? ReportTime { get; set; }
        public int? ReportOperId { get; set; }
        public short LsStatus { get; set; }
        public int? TestTypeId { get; set; }
        public int? CollectLocId { get; set; }
        public int? TogetherNum { get; set; }
        public int? SjOperId { get; set; }
        public System.DateTime? SjOperTime { get; set; }
    }
}
