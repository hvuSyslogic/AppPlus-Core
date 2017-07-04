using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class HuStoreMap : EntityTypeConfiguration<HuStore>
    {
        public HuStoreMap()
            : this("dbo")
        {
        }

        public HuStoreMap(string schema)
        {
            ToTable("HuStores", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InBatchNo).HasColumnName(@"InBatchNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(14);
            Property(x => x.HouseId).HasColumnName(@"HouseId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.PNo).HasColumnName(@"PNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.CompId).HasColumnName(@"CompId").IsOptional().HasColumnType("int");
            Property(x => x.StockNum).HasColumnName(@"StockNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.InstoreNum).HasColumnName(@"InstoreNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.StockPrice).HasColumnName(@"StockPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.RetailPrice).HasColumnName(@"RetailPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.StoreDate).HasColumnName(@"StoreDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.ProduceDate).HasColumnName(@"ProduceDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LimitDate).HasColumnName(@"LimitDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IsBalance).HasColumnName(@"IsBalance").IsRequired().HasColumnType("bit");
            Property(x => x.IsNewin).HasColumnName(@"IsNewin").IsRequired().HasColumnType("bit");
            Property(x => x.IsBid).HasColumnName(@"IsBid").IsRequired().HasColumnType("bit");
        }
    }
}
