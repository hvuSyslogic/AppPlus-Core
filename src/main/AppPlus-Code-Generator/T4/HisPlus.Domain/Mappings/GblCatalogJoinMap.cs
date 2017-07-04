using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblCatalogJoinMap : EntityTypeConfiguration<GblCatalogJoin>
    {
        public GblCatalogJoinMap()
            : this("dbo")
        {
        }

        public GblCatalogJoinMap(string schema)
        {
            ToTable("GblCatalogJoin", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CatalogId1).HasColumnName(@"CatalogId1").IsRequired().HasColumnType("int");
            Property(x => x.XmlField1).HasColumnName(@"XmlField1").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.CatalogId2).HasColumnName(@"CatalogId2").IsRequired().HasColumnType("int");
            Property(x => x.XmlField2).HasColumnName(@"XmlField2").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
        }
    }
}
