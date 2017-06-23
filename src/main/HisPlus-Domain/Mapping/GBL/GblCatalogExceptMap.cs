using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblCatalogExceptMap : EntityTypeConfiguration<GblCatalogExcept>
    {
        public GblCatalogExceptMap()
            : this("dbo")
        {
        }

        public GblCatalogExceptMap(string schema)
        {
            ToTable("GblCatalogExcept", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CatalogId).HasColumnName(@"CatalogId").IsRequired().HasColumnType("int");
            Property(x => x.XmlField).HasColumnName(@"XmlField").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.IsHide).HasColumnName(@"IsHide").IsOptional().HasColumnType("bit");
            Property(x => x.DefaultValue).HasColumnName(@"DefaultValue").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.IsBaby).HasColumnName(@"IsBaby").IsOptional().HasColumnType("bit");
            Property(x => x.IsWomen).HasColumnName(@"IsWomen").IsOptional().HasColumnType("bit");
            Property(x => x.IsMen).HasColumnName(@"IsMen").IsOptional().HasColumnType("bit");
            Property(x => x.IsOlder).HasColumnName(@"IsOlder").IsOptional().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
