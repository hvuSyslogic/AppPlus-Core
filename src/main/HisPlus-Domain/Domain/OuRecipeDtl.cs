using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuRecipeDtl : EntityBase<int>
    {
        public OuRecipeDtl()
        {    
        }

        public int RecipeId { get; set; }
        public int ListNum { get; set; }
        public int ItemId { get; set; }
        public short GroupNum { get; set; }
        public decimal Dosage { get; set; }
        public int? UnitTakeId { get; set; }
        public int? FrequencyId { get; set; }
        public int? UsageId { get; set; }
        public short? Days { get; set; }
        public decimal Totality { get; set; }
        public int UnitDiagId { get; set; }
        public bool IsAttach { get; set; }
        public bool IsOtherFee { get; set; }
        public int? XdRpId { get; set; }
        public string Memo { get; set; }
        public bool IsCharged { get; set; }
        public bool IsCancel { get; set; }
        public System.DateTime? CancelTime { get; set; }
        public int? CancelOperId { get; set; }
        public bool IsPrint { get; set; }
        public System.DateTime? PrintTime { get; set; }
        public int? PrintOperId { get; set; }
        public bool IsPrepared { get; set; }
        public string PrepareTime { get; set; }
        public int? PrepareOperId { get; set; }
        public bool IsIssue { get; set; }
        public System.DateTime? IssueTime { get; set; }
        public int? IssueOperId { get; set; }
        public bool IsToBack { get; set; }
        public bool IsBack { get; set; }
        public bool? IsDoctorInput { get; set; }
        public int? RecNum { get; set; }
        public System.DateTime? RecipeTime { get; set; }
        public int? LocationId { get; set; }
        public int? DoctorId { get; set; }
        public int? AllPageNo { get; set; }
        public int? PageNo { get; set; }
        public int? CureDtlId { get; set; }
        public bool? IsBp { get; set; }
        public string BpReason { get; set; }
        public string YbType { get; set; }
        public string InvoNo { get; set; }
        public bool? IsAutoCharged { get; set; }
    }
}
