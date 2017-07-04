using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuInvoiceDtl : EntityBase<int>
    {
        public OuInvoiceDtl()
        {    
        }

        public int InvoId { get; set; }
        public int ItemId { get; set; }
        public decimal Totality { get; set; }
        public int UnitId { get; set; }
        public decimal Price { get; set; }
        public decimal DiscDiag { get; set; }
        public bool IsModiDisc { get; set; }
        public decimal DiscSelf { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountFact { get; set; }
        public decimal AmountSelf { get; set; }
        public decimal AmountTally { get; set; }
        public decimal? AmountPay { get; set; }
        public short LsPerform { get; set; }
        public int? LimitGroupId { get; set; }
        public decimal LimitFee { get; set; }
        public int ExecLocId { get; set; }
        public int DoctorId { get; set; }
        public int InvItemId { get; set; }
        public int FeeId { get; set; }
        public int? FeeHsId { get; set; }
        public int? XdRpId { get; set; }
        public short? LsReportType { get; set; }
        public string Memo { get; set; }
        public int? RecipeItemId { get; set; }
        public int? RecipeGroupId { get; set; }
        public int? DocLocId { get; set; }
    }
}
