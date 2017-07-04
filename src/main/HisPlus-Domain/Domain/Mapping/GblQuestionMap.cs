using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblQuestionMap : EntityTypeConfiguration<GblQuestion>
    {
        public GblQuestionMap()
            : this("dbo")
        {
        }

        public GblQuestionMap(string schema)
        {
            ToTable("GblQuestion", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Question).HasColumnName(@"Question").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Answer).HasColumnName(@"Answer").IsOptional().HasColumnType("nvarchar").HasMaxLength(2500);
            Property(x => x.SystemId).HasColumnName(@"SystemId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
        }
    }
}
