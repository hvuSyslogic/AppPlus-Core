using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ElBaseDtlMap : EntityTypeConfiguration<ElBaseDtl>
    {
        public ElBaseDtlMap()
            : this("dbo")
        {
        }

        public ElBaseDtlMap(string schema)
        {
            ToTable("ElBaseDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ElId).HasColumnName(@"ElId").IsOptional().HasColumnType("int");
            Property(x => x.ElId1).HasColumnName(@"ElId1").IsOptional().HasColumnType("int");
            Property(x => x.IsReadOnly).HasColumnName(@"IsReadOnly").IsOptional().HasColumnType("bit");
            Property(x => x.IsAllowSort).HasColumnName(@"IsAllowSort").IsOptional().HasColumnType("bit");
            Property(x => x.Width).HasColumnName(@"Width").IsOptional().HasColumnType("smallint");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
