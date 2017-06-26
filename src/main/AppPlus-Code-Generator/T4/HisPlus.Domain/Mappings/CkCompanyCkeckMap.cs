using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkCompanyCkeckMap : EntityTypeConfiguration<CkCompanyCkeck>
    {
        public CkCompanyCkeckMap()
            : this("dbo")
        {
        }

        public CkCompanyCkeckMap(string schema)
        {
            ToTable("CkCompanyCkeck", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyId).HasColumnName(@"CompanyId").IsRequired().HasColumnType("int");
            Property(x => x.CkeckDate).HasColumnName(@"CkeckDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.CkeckNo).HasColumnName(@"CkeckNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
