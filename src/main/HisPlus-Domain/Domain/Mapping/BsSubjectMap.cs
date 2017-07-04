using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsSubjectMap : EntityTypeConfiguration<BsSubject>
    {
        public BsSubjectMap()
            : this("dbo")
        {
        }

        public BsSubjectMap(string schema)
        {
            ToTable("BsSubject", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
        }
    }
}
