using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsItemEquipment : EntityBase<int>
    {
        public BsItemEquipment()
        {    
        }

        public int ItemId { get; set; }
        public short? LsEqType { get; set; }
        public int? EqTypeId { get; set; }
        public string EqType { get; set; }
        public string SeriesNo { get; set; }
        public string Brand { get; set; }
        public int? CountryId { get; set; }
        public string RepairBy { get; set; }
        public int? LimitYears { get; set; }
        public short? LsQuaClass { get; set; }
        public short? LsEqClass { get; set; }
        public decimal? MonthDisc { get; set; }
        public short? LsMoneyFrom { get; set; }
        public decimal? MoneyGiven { get; set; }
        public decimal? MoneySelf { get; set; }
        public decimal? UnderLine { get; set; }
        public int? UnitId { get; set; }
        public int? CostPercent { get; set; }
        public decimal? AlarmLine { get; set; }
        public bool? IsCalProfit { get; set; }
        public string UseArea { get; set; }
        public string UseMemo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short? IconIndex { get; set; }
    }
}
