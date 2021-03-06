using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsQuestionMap : EntityTypeConfiguration<BsQuestion>
    {
        public BsQuestionMap()
            : this("dbo")
        {
        }

        public BsQuestionMap(string schema)
        {
            ToTable("BsQuestion", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Question).HasColumnName(@"Question").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(200);
            Property(x => x.Answer).HasColumnName(@"Answer").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.OptionA).HasColumnName(@"OptionA").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.OptionB).HasColumnName(@"OptionB").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.OptionC).HasColumnName(@"OptionC").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.OptionD).HasColumnName(@"OptionD").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.SubjectId).HasColumnName(@"SubjectId").IsRequired().HasColumnType("int");
        }
    }
}
