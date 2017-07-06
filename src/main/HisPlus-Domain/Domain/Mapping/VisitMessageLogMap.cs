using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class VisitMessageLogMap : EntityTypeConfiguration<VisitMessageLog>
    {
        public VisitMessageLogMap()
            : this("dbo")
        {
        }

        public VisitMessageLogMap(string schema)
        {
            ToTable("VisitMessageLog", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.PatientName).HasColumnName(@"PatientName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Mobile).HasColumnName(@"Mobile").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Comments).HasColumnName(@"Comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("datetime");
        }
    }
}
