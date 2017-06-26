using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class HuCheckDtlMap : EntityTypeConfiguration<HuCheckDtl>
    {
        public HuCheckDtlMap()
            : this("dbo")
        {
        }

        public HuCheckDtlMap(string schema)
        {
            ToTable("HuCheckDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillId).HasColumnName(@"BillId").IsRequired().HasColumnType("int");
            Property(x => x.InBatchId).HasColumnName(@"InBatchId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.CompId).HasColumnName(@"CompId").IsOptional().HasColumnType("int");
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.BalanceNum).HasColumnName(@"BalanceNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.StcokNum).HasColumnName(@"StcokNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.InstoreNum).HasColumnName(@"InstoreNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.CheckNum).HasColumnName(@"CheckNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.StockPrice).HasColumnName(@"StockPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.RetailPrice).HasColumnName(@"RetailPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.Compare).HasColumnName(@"compare").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.IsBalance).HasColumnName(@"IsBalance").IsRequired().HasColumnType("bit");
            Property(x => x.IsAdjust).HasColumnName(@"IsAdjust").IsRequired().HasColumnType("bit");
            Property(x => x.BuyIn).HasColumnName(@"BuyIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.BackIn).HasColumnName(@"BackIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OtherIn).HasColumnName(@"OtherIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DeptOut).HasColumnName(@"DeptOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SaleOut).HasColumnName(@"SaleOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.BackOut).HasColumnName(@"BackOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LoseOut).HasColumnName(@"LoseOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AdjustAmouUp).HasColumnName(@"AdjustAmouUp").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AdjustAmouDn).HasColumnName(@"AdjustAmouDn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
