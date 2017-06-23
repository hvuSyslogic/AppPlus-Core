using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RmCheckDtlMap : EntityTypeConfiguration<RmCheckDtl>
    {
        public RmCheckDtlMap()
            : this("dbo")
        {
        }

        public RmCheckDtlMap(string schema)
        {
            ToTable("RmCheckDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CheckId).HasColumnName(@"CheckId").IsRequired().HasColumnType("int");
            Property(x => x.InBatchId).HasColumnName(@"InBatchId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.CompId).HasColumnName(@"CompId").IsOptional().HasColumnType("int");
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.BalanceNum).HasColumnName(@"BalanceNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.StockNum).HasColumnName(@"StockNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.InstoreNum).HasColumnName(@"InstoreNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.CheckNum).HasColumnName(@"CheckNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.StockPrice).HasColumnName(@"StockPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.RetailPrice).HasColumnName(@"RetailPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.Compare).HasColumnName(@"compare").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.Balance).HasColumnName(@"balance").IsRequired().HasColumnType("bit");
            Property(x => x.IsAdjust).HasColumnName(@"isAdjust").IsRequired().HasColumnType("bit");
            Property(x => x.ApplyIn).HasColumnName(@"ApplyIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MzBackIn).HasColumnName(@"MzBackIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ZyBackIn).HasColumnName(@"ZyBackIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MoveIn).HasColumnName(@"MoveIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OtherIn).HasColumnName(@"OtherIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MoveOut).HasColumnName(@"MoveOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MzOut).HasColumnName(@"MzOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ZyOut).HasColumnName(@"ZyOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LoseOut).HasColumnName(@"LoseOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.BackOut).HasColumnName(@"BackOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OtherOut).HasColumnName(@"OtherOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AdjustAmouUp).HasColumnName(@"AdjustAmouUp").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AdjustAmouDn).HasColumnName(@"AdjustAmouDn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.RecipeOut).HasColumnName(@"RecipeOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KsBackIn).HasColumnName(@"KsBackIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KsOut).HasColumnName(@"KsOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F5).HasColumnName(@"F5").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F6).HasColumnName(@"F6").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F7).HasColumnName(@"F7").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
