using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RmstoreMap : EntityTypeConfiguration<Rmstore>
    {
        public RmstoreMap()
            : this("dbo")
        {
        }

        public RmstoreMap(string schema)
        {
            ToTable("Rmstores", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InBatchNo).HasColumnName(@"InBatchNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(14);
            Property(x => x.RoomId).HasColumnName(@"RoomId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.PNo).HasColumnName(@"PNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.CompId).HasColumnName(@"CompId").IsOptional().HasColumnType("int");
            Property(x => x.StockPrice).HasColumnName(@"StockPrice").IsOptional().HasColumnType("decimal").HasPrecision(12,5);
            Property(x => x.RetailPrice).HasColumnName(@"RetailPrice").IsOptional().HasColumnType("decimal").HasPrecision(12,5);
            Property(x => x.StockNum).HasColumnName(@"StockNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.InstoreNum).HasColumnName(@"InstoreNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.StoreDate).HasColumnName(@"StoreDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ProduceDate).HasColumnName(@"ProduceDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LimitDate).HasColumnName(@"LimitDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IsBalance).HasColumnName(@"IsBalance").IsRequired().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
