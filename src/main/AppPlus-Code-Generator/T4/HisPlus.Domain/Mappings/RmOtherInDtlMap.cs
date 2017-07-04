using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RmOtherInDtlMap : EntityTypeConfiguration<RmOtherInDtl>
    {
        public RmOtherInDtlMap()
            : this("dbo")
        {
        }

        public RmOtherInDtlMap(string schema)
        {
            ToTable("RmOtherInDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillId).HasColumnName(@"BillId").IsRequired().HasColumnType("int");
            Property(x => x.InBatchNo).HasColumnName(@"InBatchNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(14);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.PNo).HasColumnName(@"PNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.DrugNum).HasColumnName(@"DrugNum").IsRequired().HasColumnType("numeric").HasPrecision(10,2);
            Property(x => x.StockPrice).HasColumnName(@"StockPrice").IsRequired().HasColumnType("numeric").HasPrecision(12,4);
            Property(x => x.RetailPrice).HasColumnName(@"RetailPrice").IsRequired().HasColumnType("numeric").HasPrecision(12,4);
            Property(x => x.StoreDate).HasColumnName(@"StoreDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.ProduceDate).HasColumnName(@"ProduceDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LimitDate).HasColumnName(@"LimitDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CompId).HasColumnName(@"CompId").IsOptional().HasColumnType("int");
        }
    }
}
