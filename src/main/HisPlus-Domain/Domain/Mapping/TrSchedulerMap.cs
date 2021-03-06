using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class TrSchedulerMap : EntityTypeConfiguration<TrScheduler>
    {
        public TrSchedulerMap()
            : this("dbo")
        {
        }

        public TrSchedulerMap(string schema)
        {
            ToTable("TrScheduler", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName(@"UserId").IsRequired().HasColumnType("int");
            Property(x => x.LineId).HasColumnName(@"LineId").IsRequired().HasColumnType("int");
            Property(x => x.ScheTime).HasColumnName(@"ScheTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsOptional().HasColumnType("smallint");
        }
    }
}
