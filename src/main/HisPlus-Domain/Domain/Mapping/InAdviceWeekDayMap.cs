using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InAdviceWeekDayMap : EntityTypeConfiguration<InAdviceWeekDay>
    {
        public InAdviceWeekDayMap()
            : this("dbo")
        {
        }

        public InAdviceWeekDayMap(string schema)
        {
            ToTable("InAdviceWeekDay", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.AdviceId).HasColumnName(@"AdviceId").IsRequired().HasColumnType("int");
            Property(x => x.WeekDay).HasColumnName(@"WeekDay").IsRequired().HasColumnType("smallint");
        }
    }
}
