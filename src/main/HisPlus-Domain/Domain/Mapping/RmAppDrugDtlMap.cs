using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RmAppDrugDtlMap : EntityTypeConfiguration<RmAppDrugDtl>
    {
        public RmAppDrugDtlMap()
            : this("dbo")
        {
        }

        public RmAppDrugDtlMap(string schema)
        {
            ToTable("RmAppDrugDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillId).HasColumnName(@"BillId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.DrugNum).HasColumnName(@"DrugNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.HuStockNum).HasColumnName(@"HuStockNum").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitKc).HasColumnName(@"UnitKc").IsOptional().HasColumnType("int");
            Property(x => x.Pno).HasColumnName(@"Pno").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.LimitDate).HasColumnName(@"LimitDate").IsOptional().HasColumnType("smalldatetime");
        }
    }
}
