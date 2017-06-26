using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblEmrFileMap : EntityTypeConfiguration<GblEmrFile>
    {
        public GblEmrFileMap()
            : this("dbo")
        {
        }

        public GblEmrFileMap(string schema)
        {
            ToTable("GblEMRFile", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.CatalogId).HasColumnName(@"CatalogId").IsRequired().HasColumnType("int");
            Property(x => x.XsdFile).HasColumnName(@"XSDFile").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
