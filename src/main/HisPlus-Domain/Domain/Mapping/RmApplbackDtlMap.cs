using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RmApplbackDtlMap : EntityTypeConfiguration<RmApplbackDtl>
    {
        public RmApplbackDtlMap()
            : this("dbo")
        {
        }

        public RmApplbackDtlMap(string schema)
        {
            ToTable("RmApplbackDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillId).HasColumnName(@"BillId").IsRequired().HasColumnType("int");
            Property(x => x.InBatchId).HasColumnName(@"InBatchId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.DrugNum).HasColumnName(@"DrugNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.StockPrice).HasColumnName(@"StockPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.RetailPrice).HasColumnName(@"RetailPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.BeforeStockNum).HasColumnName(@"BeforeStockNum").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.AfterStockNum).HasColumnName(@"AfterStockNum").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.CkDtlId).HasColumnName(@"CkDtlID").IsOptional().HasColumnType("int");
        }
    }
}
