using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkLabBoodMap : EntityTypeConfiguration<CkLabBood>
    {
        public CkLabBoodMap()
            : this("dbo")
        {
        }

        public CkLabBoodMap(string schema)
        {
            ToTable("CkLabBood", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LabId).HasColumnName(@"LabId").IsOptional().HasColumnType("int");
            Property(x => x.BdBankId).HasColumnName(@"BdBankId").IsOptional().HasColumnType("int");
        }
    }
}
