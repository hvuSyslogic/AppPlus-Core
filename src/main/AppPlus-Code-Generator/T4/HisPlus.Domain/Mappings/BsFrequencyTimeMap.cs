using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsFrequencyTimeMap : EntityTypeConfiguration<BsFrequencyTime>
    {
        public BsFrequencyTimeMap()
            : this("dbo")
        {
        }

        public BsFrequencyTimeMap(string schema)
        {
            ToTable("BsFrequencyTime", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsRequired().HasColumnType("int");
            Property(x => x.ExecTime).HasColumnName(@"ExecTime").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(5);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
