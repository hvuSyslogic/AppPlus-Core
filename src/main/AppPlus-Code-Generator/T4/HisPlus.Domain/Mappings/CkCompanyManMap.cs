using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkCompanyManMap : EntityTypeConfiguration<CkCompanyMan>
    {
        public CkCompanyManMap()
            : this("dbo")
        {
        }

        public CkCompanyManMap(string schema)
        {
            ToTable("CkCompanyMan", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyGroupId).HasColumnName(@"CompanyGroupId").IsRequired().HasColumnType("int");
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
        }
    }
}
