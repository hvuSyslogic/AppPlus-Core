using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsTallyGroupMap : EntityTypeConfiguration<BsTallyGroup>
    {
        public BsTallyGroupMap()
            : this("dbo")
        {
        }

        public BsTallyGroupMap(string schema)
        {
            ToTable("BsTallyGroup", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(6);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsGf).HasColumnName(@"IsGf").IsRequired().HasColumnType("bit");
            Property(x => x.IsYb).HasColumnName(@"IsYb").IsRequired().HasColumnType("bit");
            Property(x => x.YbHospNo).HasColumnName(@"YbHospNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.ZyClassName).HasColumnName(@"ZyClassName").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.MzClassName).HasColumnName(@"MzClassName").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Lsinout).HasColumnName(@"Lsinout").IsOptional().HasColumnType("smallint");
        }
    }
}
