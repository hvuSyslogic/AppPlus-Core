using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuInvoiceDtlTemp : EntityBase<int>
    {
        public OuInvoiceDtlTemp()
        {    
        }

        public decimal? Amount { get; set; }
        public decimal? AmountFact { get; set; }
        public decimal? AmountInsurance { get; set; }
        public decimal? AmountPay { get; set; }
        public decimal? AmountSelf { get; set; }
        public decimal? AmountTally { get; set; }
        public string Code { get; set; }
        public decimal? DiscDiag { get; set; }
        public decimal? DiscSelf { get; set; }
        public int? DocLevId { get; set; }
        public int? DoctorId { get; set; }
        public string DoctorName { get; set; }
        public int? ExecLocId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string F5 { get; set; }
        public int? FeeHsId { get; set; }
        public string FeeHsMzName { get; set; }
        public int? FeeId { get; set; }
        public string FeeName { get; set; }
        public int? InvItemId { get; set; }
        public string InvMzItemName { get; set; }
        public int? InvoId { get; set; }
        public System.DateTime? InvoTime { get; set; }
        public bool? IsBack { get; set; }
        public bool? IsDoctorInput { get; set; }
        public bool? IsIssue { get; set; }
        public bool? IsModiDisc { get; set; }
        public bool? IsOtherFee { get; set; }
        public bool? IsPriority { get; set; }
        public bool? IsToBack { get; set; }
        public int? ItemId { get; set; }
        public decimal? LimitFee { get; set; }
        public int? LimitGroupId { get; set; }
        public decimal? LimitTotalMz { get; set; }
        public int? ListNum { get; set; }
        public string LocationName { get; set; }
        public int? LsAdviceType { get; set; }
        public int? LsGfType { get; set; }
        public int? LsGroupType { get; set; }
        public int? LsPerform { get; set; }
        public int? LsReportType { get; set; }
        public int? LsRepType { get; set; }
        public int? LsRpType { get; set; }
        public string Memo { get; set; }
        public string Name { get; set; }
        public string PrepareTime { get; set; }
        public decimal? Price { get; set; }
        public int? RecipeGroupId { get; set; }
        public string RecipeGroupIds { get; set; }
        public int? RecipeId { get; set; }
        public int? RecipeItemId { get; set; }
        public int? RoomId { get; set; }
        public string Spec { get; set; }
        public decimal? Totality { get; set; }
        public int? TypeGfxeId { get; set; }
        public string UnitDiagName { get; set; }
        public int? UnitId { get; set; }
        public int? XdRpId { get; set; }
        public int Mzregid { get; set; }
        public System.DateTime OperTime { get; set; }
    }
}
