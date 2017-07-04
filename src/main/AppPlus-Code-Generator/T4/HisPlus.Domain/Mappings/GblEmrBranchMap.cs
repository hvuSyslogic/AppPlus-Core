using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblEmrBranchMap : EntityTypeConfiguration<GblEmrBranch>
    {
        public GblEmrBranchMap()
            : this("dbo")
        {
        }

        public GblEmrBranchMap(string schema)
        {
            ToTable("GblEMRBranch", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BranchId).HasColumnName(@"BranchId").IsOptional().HasColumnType("int");
            Property(x => x.CatalogId).HasColumnName(@"CatalogId").IsRequired().HasColumnType("int");
            Property(x => x.XsdFile).HasColumnName(@"XSDFile").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
