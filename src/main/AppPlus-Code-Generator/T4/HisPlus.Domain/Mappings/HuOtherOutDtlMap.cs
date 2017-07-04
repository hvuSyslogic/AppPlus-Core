using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class HuOtherOutDtlMap : EntityTypeConfiguration<HuOtherOutDtl>
    {
        public HuOtherOutDtlMap()
            : this("dbo")
        {
        }

        public HuOtherOutDtlMap(string schema)
        {
            ToTable("HuOtherOutDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillId).HasColumnName(@"BillId").IsRequired().HasColumnType("int");
            Property(x => x.InBatchId).HasColumnName(@"InBatchId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.DrugNum).HasColumnName(@"DrugNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.StockPrice).HasColumnName(@"StockPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.RetailPrice).HasColumnName(@"RetailPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.Reason).HasColumnName(@"Reason").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
