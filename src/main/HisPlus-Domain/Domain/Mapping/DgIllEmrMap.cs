using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class DgIllEmrMap : EntityTypeConfiguration<DgIllEmr>
    {
        public DgIllEmrMap()
            : this("dbo")
        {
        }

        public DgIllEmrMap(string schema)
        {
            ToTable("DgIllEmr", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IcdId).HasColumnName(@"IcdId").IsOptional().HasColumnType("int");
            Property(x => x.XsdFile).HasColumnName(@"XSDFile").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsBaby).HasColumnName(@"IsBaby").IsOptional().HasColumnType("bit");
            Property(x => x.IsWomen).HasColumnName(@"IsWomen").IsOptional().HasColumnType("bit");
            Property(x => x.IsMen).HasColumnName(@"IsMen").IsOptional().HasColumnType("bit");
            Property(x => x.IsOlder).HasColumnName(@"IsOlder").IsOptional().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
