using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class HuStoreLogMap : EntityTypeConfiguration<HuStoreLog>
    {
        public HuStoreLogMap()
            : this("dbo")
        {
        }

        public HuStoreLogMap(string schema)
        {
            ToTable("HuStoreLog", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HappenTime).HasColumnName(@"HappenTime").IsRequired().HasColumnType("datetime");
            Property(x => x.HouseId).HasColumnName(@"HouseId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.InBatchId).HasColumnName(@"InBatchId").IsRequired().HasColumnType("int");
            Property(x => x.BeforeStockNum).HasColumnName(@"BeforeStockNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.HappenNum).HasColumnName(@"HappenNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.AfterStockNum).HasColumnName(@"AfterStockNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.RetailPrice).HasColumnName(@"RetailPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.StockPrice).HasColumnName(@"StockPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.BillNo).HasColumnName(@"BillNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsActType).HasColumnName(@"LsActType").IsRequired().HasColumnType("smallint");
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.BeforeStockNumSum).HasColumnName(@"BeforeStockNumSum").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.AfterStockNumSum).HasColumnName(@"AfterStockNumSum").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
        }
    }
}
