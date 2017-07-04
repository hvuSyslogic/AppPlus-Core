using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblCatalogKeyMap : EntityTypeConfiguration<GblCatalogKey>
    {
        public GblCatalogKeyMap()
            : this("dbo")
        {
        }

        public GblCatalogKeyMap(string schema)
        {
            ToTable("GblCatalogKey", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CatalogId).HasColumnName(@"CatalogId").IsRequired().HasColumnType("int");
            Property(x => x.XmlField).HasColumnName(@"XmlField").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.KeyFile).HasColumnName(@"KeyFile").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.TmpWord).HasColumnName(@"TmpWord").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
