using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InHosUsageItemMap : EntityTypeConfiguration<InHosUsageItem>
    {
        public InHosUsageItemMap()
            : this("dbo")
        {
        }

        public InHosUsageItemMap(string schema)
        {
            ToTable("InHosUsageItem", schema);
            HasKey(x => new { x.Id, x.ItemId, x.AdviceId, x.LsMarkType, x.Totality, x.HospId, x.UsageItemId, x.Times, x.AdviceTime });

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.AdviceId).HasColumnName(@"AdviceId").IsRequired().HasColumnType("int");
            Property(x => x.LsMarkType).HasColumnName(@"LsMarkType").IsRequired().HasColumnType("smallint");
            Property(x => x.Totality).HasColumnName(@"Totality").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.GroupNum).HasColumnName(@"GroupNum").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.UsageMemo).HasColumnName(@"UsageMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.AdviceMemo).HasColumnName(@"AdviceMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.UsageItemId).HasColumnName(@"UsageItemId").IsRequired().HasColumnType("int");
            Property(x => x.Times).HasColumnName(@"Times").IsRequired().HasColumnType("decimal").HasPrecision(5,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.AdviceTime).HasColumnName(@"AdviceTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
        }
    }
}
