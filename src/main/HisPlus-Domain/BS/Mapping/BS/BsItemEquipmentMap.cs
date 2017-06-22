using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemEquipmentMap : EntityTypeConfiguration<BsItemEquipment>
    {
        public BsItemEquipmentMap()
            : this("dbo")
        {
        }

        public BsItemEquipmentMap(string schema)
        {
            ToTable("BsItemEquipment", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.LsEqType).HasColumnName(@"LsEqType").IsOptional().HasColumnType("smallint");
            Property(x => x.EqTypeId).HasColumnName(@"EqTypeId").IsOptional().HasColumnType("int");
            Property(x => x.EqType).HasColumnName(@"EqType").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SeriesNo).HasColumnName(@"SeriesNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Brand).HasColumnName(@"Brand").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CountryId).HasColumnName(@"CountryId").IsOptional().HasColumnType("int");
            Property(x => x.RepairBy).HasColumnName(@"RepairBy").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LimitYears).HasColumnName(@"LimitYears").IsOptional().HasColumnType("int");
            Property(x => x.LsQuaClass).HasColumnName(@"LsQuaClass").IsOptional().HasColumnType("smallint");
            Property(x => x.LsEqClass).HasColumnName(@"LsEqClass").IsOptional().HasColumnType("smallint");
            Property(x => x.MonthDisc).HasColumnName(@"MonthDisc").IsOptional().HasColumnType("decimal").HasPrecision(12,2);
            Property(x => x.LsMoneyFrom).HasColumnName(@"LsMoneyFrom").IsOptional().HasColumnType("smallint");
            Property(x => x.MoneyGiven).HasColumnName(@"MoneyGiven").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MoneySelf).HasColumnName(@"MoneySelf").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.UnderLine).HasColumnName(@"UnderLine").IsOptional().HasColumnType("decimal");
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsOptional().HasColumnType("int");
            Property(x => x.CostPercent).HasColumnName(@"CostPercent").IsOptional().HasColumnType("int");
            Property(x => x.AlarmLine).HasColumnName(@"AlarmLine").IsOptional().HasColumnType("decimal");
            Property(x => x.IsCalProfit).HasColumnName(@"IsCalProfit").IsOptional().HasColumnType("bit");
            Property(x => x.UseArea).HasColumnName(@"UseArea").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UseMemo).HasColumnName(@"UseMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsOptional().HasColumnType("smallint");
        }
    }
}
