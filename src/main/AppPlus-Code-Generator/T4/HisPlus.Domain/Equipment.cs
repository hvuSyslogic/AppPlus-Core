using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class Equipment : EntityBase<int>
    {
        public Equipment()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public string Spec { get; set; }
        public string EqType { get; set; }
        public string SeriesNo { get; set; }
        public string Brand { get; set; }
        public int? CountryId { get; set; }
        public int? ManuId { get; set; }
        public int? CompId { get; set; }
        public string RepairBy { get; set; }
        public System.DateTime? BuyDate { get; set; }
        public System.DateTime? StartDate { get; set; }
        public int? LimitYears { get; set; }
        public int? MnrgLocId { get; set; }
        public int? UseLocId { get; set; }
        public short? LsQuaClass { get; set; }
        public short? LsEqClass { get; set; }
        public string InActiveReason { get; set; }
        public System.DateTime? InActiveTime { get; set; }
        public int? InActiveOperId { get; set; }
        public string LotNo { get; set; }
        public string StoreIn { get; set; }
        public string Manager { get; set; }
        public short? LsEqStatus { get; set; }
        public decimal? Price { get; set; }
        public int? HowMany { get; set; }
        public decimal? Amount { get; set; }
        public decimal? MonthDisc { get; set; }
        public short? LsMoneyFrom { get; set; }
        public decimal? MoneyGiven { get; set; }
        public decimal? MoneySelf { get; set; }
        public decimal? UnderLine { get; set; }
        public int? UnitId { get; set; }
        public int? CostPercent { get; set; }
        public decimal? AlarmLine { get; set; }
        public bool? IsCalProfit { get; set; }
        public string Attachment { get; set; }
        public string UseArea { get; set; }
        public string UseMemo { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public short LsEqType { get; set; }
        public int? GroupSubId { get; set; }
        public int? CopyId { get; set; }
        public string VoucherNo { get; set; }
        public string ProduceArea { get; set; }
    }
}
