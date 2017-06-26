using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemDrugMap : EntityTypeConfiguration<BsItemDrug>
    {
        public BsItemDrugMap()
            : this("dbo")
        {
        }

        public BsItemDrugMap(string schema)
        {
            ToTable("BsItemDrug", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.ChemName).HasColumnName(@"ChemName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsRecipe).HasColumnName(@"IsRecipe").IsOptional().HasColumnType("bit");
            Property(x => x.IsPoison).HasColumnName(@"IsPoison").IsOptional().HasColumnType("bit");
            Property(x => x.IsMental).HasColumnName(@"IsMental").IsOptional().HasColumnType("bit");
            Property(x => x.IsExpen).HasColumnName(@"IsExpen").IsOptional().HasColumnType("bit");
            Property(x => x.IsSelf).HasColumnName(@"IsSelf").IsOptional().HasColumnType("bit");
            Property(x => x.ProAreaId).HasColumnName(@"ProAreaId").IsOptional().HasColumnType("int");
            Property(x => x.AheadAlert).HasColumnName(@"AheadAlert").IsOptional().HasColumnType("int");
            Property(x => x.UnderLineKc).HasColumnName(@"UnderLineKc").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UperLineKc).HasColumnName(@"UperLineKc").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.NormalLineKc).HasColumnName(@"NormalLineKc").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.FormId).HasColumnName(@"FormId").IsOptional().HasColumnType("int");
            Property(x => x.ManuId).HasColumnName(@"ManuId").IsOptional().HasColumnType("int");
            Property(x => x.PassNo).HasColumnName(@"PassNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AreaKc).HasColumnName(@"AreaKc").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsImport).HasColumnName(@"LsImport").IsOptional().HasColumnType("smallint");
            Property(x => x.IsInject).HasColumnName(@"IsInject").IsOptional().HasColumnType("bit");
            Property(x => x.IsSpecial).HasColumnName(@"IsSpecial").IsOptional().HasColumnType("bit");
            Property(x => x.HouseId).HasColumnName(@"HouseId").IsOptional().HasColumnType("int");
            Property(x => x.RoomIdOut).HasColumnName(@"RoomIdOut").IsOptional().HasColumnType("int");
            Property(x => x.RoomIdIn).HasColumnName(@"RoomIdIn").IsOptional().HasColumnType("int");
            Property(x => x.UnitKc).HasColumnName(@"UnitKc").IsOptional().HasColumnType("int");
            Property(x => x.RetailPriceKc).HasColumnName(@"RetailPriceKc").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.StockPriceKc).HasColumnName(@"StockPriceKc").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.IsBid).HasColumnName(@"IsBid").IsOptional().HasColumnType("bit");
            Property(x => x.IsLocDrug).HasColumnName(@"IsLocDrug").IsOptional().HasColumnType("bit");
            Property(x => x.CompId).HasColumnName(@"CompId").IsOptional().HasColumnType("int");
            Property(x => x.IsBatch).HasColumnName(@"IsBatch").IsOptional().HasColumnType("bit");
            Property(x => x.IsSave).HasColumnName(@"IsSave").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsOptional().HasColumnType("smallint");
            Property(x => x.DrugId).HasColumnName(@"DrugID").IsOptional().HasColumnType("int");
            Property(x => x.BuyInCode).HasColumnName(@"BuyInCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsSecMental).HasColumnName(@"IsSecMental").IsOptional().HasColumnType("bit");
            Property(x => x.IsSkin).HasColumnName(@"IsSkin").IsOptional().HasColumnType("bit");
            Property(x => x.IsAntiBacterial).HasColumnName(@"IsAntiBacterial").IsOptional().HasColumnType("bit");
            Property(x => x.IsHighDanger).HasColumnName(@"IsHighDanger").IsOptional().HasColumnType("bit");
            Property(x => x.IsDanger).HasColumnName(@"IsDanger").IsOptional().HasColumnType("bit");
            Property(x => x.IsVaccine).HasColumnName(@"IsVaccine").IsOptional().HasColumnType("bit");
            Property(x => x.IsTestReport).HasColumnName(@"IsTestReport").IsOptional().HasColumnType("bit");
            Property(x => x.IsAnaes).HasColumnName(@"IsAnaes").IsOptional().HasColumnType("bit");
            Property(x => x.IsMeetingUse).HasColumnName(@"IsMeetingUse").IsOptional().HasColumnType("bit");
            Property(x => x.RegNo).HasColumnName(@"RegNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ImpotTestBy).HasColumnName(@"ImpotTestBy").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TestReportNo).HasColumnName(@"TestReportNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsParity).HasColumnName(@"IsParity").IsOptional().HasColumnType("bit");
            Property(x => x.DddMinValue).HasColumnName(@"DDDMinValue").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DddValue).HasColumnName(@"DDDValue").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DrugsTypes).HasColumnName(@"DrugsTypes").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.NotXZjDrug).HasColumnName(@"NotXZjDrug").IsOptional().HasColumnType("bit");
            Property(x => x.XZjDrug).HasColumnName(@"XZjDrug").IsOptional().HasColumnType("bit");
            Property(x => x.TSjDrug).HasColumnName(@"TSjDrug").IsOptional().HasColumnType("bit");
            Property(x => x.IsAz).HasColumnName(@"IsAz").IsOptional().HasColumnType("bit");
            Property(x => x.IsJh).HasColumnName(@"IsJH").IsOptional().HasColumnType("bit");
        }
    }
}
