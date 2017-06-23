using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OaScheduleMap : EntityTypeConfiguration<OaSchedule>
    {
        public OaScheduleMap()
            : this("dbo")
        {
        }

        public OaScheduleMap(string schema)
        {
            ToTable("OaSchedule", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.Subject).HasColumnName(@"Subject").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Location).HasColumnName(@"Location").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.StartTime).HasColumnName(@"StartTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.EndTime).HasColumnName(@"EndTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Description).HasColumnName(@"Description").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.LabelId).HasColumnName(@"LabelId").IsOptional().HasColumnType("int");
            Property(x => x.Reminder).HasColumnName(@"Reminder").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
