using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class HuStockDtlMap : EntityTypeConfiguration<HuStockDtl>
    {
        public HuStockDtlMap()
            : this("dbo")
        {
        }

        public HuStockDtlMap(string schema)
        {
            ToTable("HuStockDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillId).HasColumnName(@"BillId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.InBatchNo).HasColumnName(@"InBatchNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(14);
            Property(x => x.PNo).HasColumnName(@"PNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.DrugNum).HasColumnName(@"DrugNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.StockPrice).HasColumnName(@"StockPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.RetailPrice).HasColumnName(@"RetailPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.ProduceDate).HasColumnName(@"ProduceDate").IsOptional().HasColumnType("datetime");
            Property(x => x.LimitDate).HasColumnName(@"LimitDate").IsOptional().HasColumnType("datetime");
            Property(x => x.IsBid).HasColumnName(@"IsBid").IsRequired().HasColumnType("bit");
            Property(x => x.VoucherNo).HasColumnName(@"VoucherNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ProAreaId).HasColumnName(@"ProAreaId").IsOptional().HasColumnType("int");
            Property(x => x.ManuId).HasColumnName(@"ManuId").IsOptional().HasColumnType("int");
            Property(x => x.PassNo).HasColumnName(@"PassNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PriceHighLine).HasColumnName(@"PriceHighLine").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
        }
    }
}
