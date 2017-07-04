using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class HuAdjustPlanDtlMap : EntityTypeConfiguration<HuAdjustPlanDtl>
    {
        public HuAdjustPlanDtlMap()
            : this("dbo")
        {
        }

        public HuAdjustPlanDtlMap(string schema)
        {
            ToTable("HuAdjustPlanDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillId).HasColumnName(@"BillId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.NewPrice).HasColumnName(@"NewPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.OldPrice).HasColumnName(@"OldPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
        }
    }
}
