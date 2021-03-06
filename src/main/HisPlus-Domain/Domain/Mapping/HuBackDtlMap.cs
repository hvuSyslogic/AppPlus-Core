using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class HuBackDtlMap : EntityTypeConfiguration<HuBackDtl>
    {
        public HuBackDtlMap()
            : this("dbo")
        {
        }

        public HuBackDtlMap(string schema)
        {
            ToTable("HuBackDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillId).HasColumnName(@"BillId").IsRequired().HasColumnType("int");
            Property(x => x.InBatchId).HasColumnName(@"InBatchId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.DrugNum).HasColumnName(@"DrugNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.RetailPrice).HasColumnName(@"RetailPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.StockPrice).HasColumnName(@"StockPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.VoucherNo).HasColumnName(@"VoucherNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsMargin).HasColumnName(@"IsMargin").IsRequired().HasColumnType("bit");
        }
    }
}
