using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkCompanyGroupMap : EntityTypeConfiguration<CkCompanyGroup>
    {
        public CkCompanyGroupMap()
            : this("dbo")
        {
        }

        public CkCompanyGroupMap(string schema)
        {
            ToTable("CkCompanyGroup", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyId).HasColumnName(@"CompanyId").IsRequired().HasColumnType("int");
            Property(x => x.GroupId).HasColumnName(@"GroupId").IsRequired().HasColumnType("int");
        }
    }
}
