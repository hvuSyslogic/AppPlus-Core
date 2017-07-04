using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InInvoiceDtlTemp : EntityBase<int>
    {
        public InInvoiceDtlTemp()
        {    
        }

        public int HospId { get; set; }
        public int ItemId { get; set; }
        public System.DateTime RegOperTime { get; set; }
        public int RegOperId { get; set; }
        public int LocationId { get; set; }
        public int AdviceId { get; set; }
        public short LsMarkType { get; set; }
        public decimal Totality { get; set; }
        public decimal PriceIn { get; set; }
        public int UnitId { get; set; }
        public bool IsPay { get; set; }
        public decimal DiscIn { get; set; }
        public decimal DiscSelf { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountFact { get; set; }
        public decimal AmountSelf { get; set; }
        public decimal AmountTally { get; set; }
        public decimal AmountPay { get; set; }
        public int? InvoId { get; set; }
        public short LsPerform { get; set; }
        public bool IsModiDisc { get; set; }
        public int? LimitGroupId { get; set; }
        public decimal? LimitFee { get; set; }
        public int? DoctorId { get; set; }
        public int ExecOperId { get; set; }
        public int ExecLocId { get; set; }
        public int InvItemId { get; set; }
        public int FeeId { get; set; }
        public int? FeeHsId { get; set; }
        public int? LsReportType { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsCancel { get; set; }
        public int? CancelId { get; set; }
        public bool IsManual { get; set; }
    }
}
