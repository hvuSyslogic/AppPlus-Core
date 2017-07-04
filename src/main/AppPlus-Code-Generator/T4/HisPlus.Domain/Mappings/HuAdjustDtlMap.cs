using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class HuAdjustDtlMap : EntityTypeConfiguration<HuAdjustDtl>
    {
        public HuAdjustDtlMap()
            : this("dbo")
        {
        }

        public HuAdjustDtlMap(string schema)
        {
            ToTable("HuAdjustDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InBatchId).HasColumnName(@"InBatchId").IsRequired().HasColumnType("int");
            Property(x => x.BillId).HasColumnName(@"BillId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.NewPrice).HasColumnName(@"NewPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.OldPrice).HasColumnName(@"OldPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.ProfLoss).HasColumnName(@"ProfLoss").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DrugNum).HasColumnName(@"DrugNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
        }
    }
}
