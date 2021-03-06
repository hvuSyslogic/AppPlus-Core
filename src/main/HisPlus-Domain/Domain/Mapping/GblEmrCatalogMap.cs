using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblEmrCatalogMap : EntityTypeConfiguration<GblEmrCatalog>
    {
        public GblEmrCatalogMap()
            : this("dbo")
        {
        }

        public GblEmrCatalogMap(string schema)
        {
            ToTable("GblEMRCatalog", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(6);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ParentId).HasColumnName(@"ParentID").IsOptional().HasColumnType("int");
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.InfoPathFile).HasColumnName(@"InfoPathFile").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsCompareType).HasColumnName(@"LsCompareType").IsOptional().HasColumnType("smallint");
            Property(x => x.AheadHours).HasColumnName(@"AheadHours").IsOptional().HasColumnType("smallint");
        }
    }
}
