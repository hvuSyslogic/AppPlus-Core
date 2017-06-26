using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class EquipmentMap : EntityTypeConfiguration<Equipment>
    {
        public EquipmentMap()
            : this("dbo")
        {
        }

        public EquipmentMap(string schema)
        {
            ToTable("Equipment", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"CODE").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(6);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.Spec).HasColumnName(@"Spec").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.EqType).HasColumnName(@"EqType").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SeriesNo).HasColumnName(@"SeriesNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Brand).HasColumnName(@"Brand").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CountryId).HasColumnName(@"CountryId").IsOptional().HasColumnType("int");
            Property(x => x.ManuId).HasColumnName(@"ManuId").IsOptional().HasColumnType("int");
            Property(x => x.CompId).HasColumnName(@"CompId").IsOptional().HasColumnType("int");
            Property(x => x.RepairBy).HasColumnName(@"RepairBy").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.BuyDate).HasColumnName(@"BuyDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.StartDate).HasColumnName(@"StartDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LimitYears).HasColumnName(@"LimitYears").IsOptional().HasColumnType("int");
            Property(x => x.MnrgLocId).HasColumnName(@"MnrgLocId").IsOptional().HasColumnType("int");
            Property(x => x.UseLocId).HasColumnName(@"UseLocId").IsOptional().HasColumnType("int");
            Property(x => x.LsQuaClass).HasColumnName(@"LsQuaClass").IsOptional().HasColumnType("smallint");
            Property(x => x.LsEqClass).HasColumnName(@"LsEqClass").IsOptional().HasColumnType("smallint");
            Property(x => x.InActiveReason).HasColumnName(@"InActiveReason").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InActiveTime).HasColumnName(@"InActiveTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.InActiveOperId).HasColumnName(@"InActiveOperID").IsOptional().HasColumnType("int");
            Property(x => x.LotNo).HasColumnName(@"LotNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.StoreIn).HasColumnName(@"StoreIn").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Manager).HasColumnName(@"Manager").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsEqStatus).HasColumnName(@"LsEqStatus").IsOptional().HasColumnType("smallint");
            Property(x => x.Price).HasColumnName(@"Price").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.HowMany).HasColumnName(@"HowMany").IsOptional().HasColumnType("int");
            Property(x => x.Amount).HasColumnName(@"Amount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MonthDisc).HasColumnName(@"MonthDisc").IsOptional().HasColumnType("decimal").HasPrecision(12,2);
            Property(x => x.LsMoneyFrom).HasColumnName(@"LsMoneyFrom").IsOptional().HasColumnType("smallint");
            Property(x => x.MoneyGiven).HasColumnName(@"MoneyGiven").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MoneySelf).HasColumnName(@"MoneySelf").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.UnderLine).HasColumnName(@"UnderLine").IsOptional().HasColumnType("decimal");
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsOptional().HasColumnType("int");
            Property(x => x.CostPercent).HasColumnName(@"CostPercent").IsOptional().HasColumnType("int");
            Property(x => x.AlarmLine).HasColumnName(@"AlarmLine").IsOptional().HasColumnType("decimal");
            Property(x => x.IsCalProfit).HasColumnName(@"IsCalProfit").IsOptional().HasColumnType("bit");
            Property(x => x.Attachment).HasColumnName(@"Attachment").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.UseArea).HasColumnName(@"UseArea").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UseMemo).HasColumnName(@"UseMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.LsEqType).HasColumnName(@"LsEqType").IsRequired().HasColumnType("smallint");
            Property(x => x.GroupSubId).HasColumnName(@"GroupSubId").IsOptional().HasColumnType("int");
            Property(x => x.CopyId).HasColumnName(@"CopyId").IsOptional().HasColumnType("int");
            Property(x => x.VoucherNo).HasColumnName(@"VoucherNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ProduceArea).HasColumnName(@"ProduceArea").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
