using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsItemDrug : EntityBase<int>
    {
        public BsItemDrug()
        {    
        }

        public int ItemId { get; set; }
        public string ChemName { get; set; }
        public bool? IsRecipe { get; set; }
        public bool? IsPoison { get; set; }
        public bool? IsMental { get; set; }
        public bool? IsExpen { get; set; }
        public bool? IsSelf { get; set; }
        public int? ProAreaId { get; set; }
        public int? AheadAlert { get; set; }
        public decimal? UnderLineKc { get; set; }
        public decimal? UperLineKc { get; set; }
        public decimal? NormalLineKc { get; set; }
        public int? FormId { get; set; }
        public int? ManuId { get; set; }
        public string PassNo { get; set; }
        public string AreaKc { get; set; }
        public short? LsImport { get; set; }
        public bool? IsInject { get; set; }
        public bool? IsSpecial { get; set; }
        public int? HouseId { get; set; }
        public int? RoomIdOut { get; set; }
        public int? RoomIdIn { get; set; }
        public int? UnitKc { get; set; }
        public decimal? RetailPriceKc { get; set; }
        public decimal? StockPriceKc { get; set; }
        public bool? IsBid { get; set; }
        public bool? IsLocDrug { get; set; }
        public int? CompId { get; set; }
        public bool? IsBatch { get; set; }
        public bool? IsSave { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short? IconIndex { get; set; }
        public int? DrugId { get; set; }
        public string BuyInCode { get; set; }
        public bool? IsSecMental { get; set; }
        public bool? IsSkin { get; set; }
        public bool? IsAntiBacterial { get; set; }
        public bool? IsHighDanger { get; set; }
        public bool? IsDanger { get; set; }
        public bool? IsVaccine { get; set; }
        public bool? IsTestReport { get; set; }
        public bool? IsAnaes { get; set; }
        public bool? IsMeetingUse { get; set; }
        public string RegNo { get; set; }
        public string ImpotTestBy { get; set; }
        public string TestReportNo { get; set; }
        public bool? IsParity { get; set; }
        public string DddMinValue { get; set; }
        public string DddValue { get; set; }
        public string DrugsTypes { get; set; }
        public bool? NotXZjDrug { get; set; }
        public bool? XZjDrug { get; set; }
        public bool? TSjDrug { get; set; }
        public bool? IsAz { get; set; }
        public bool? IsJh { get; set; }
    }
}
