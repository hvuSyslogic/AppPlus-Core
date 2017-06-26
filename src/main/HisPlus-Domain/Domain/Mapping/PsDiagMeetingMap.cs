using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class PsDiagMeetingMap : EntityTypeConfiguration<PsDiagMeeting>
    {
        public PsDiagMeetingMap()
            : this("dbo")
        {
        }

        public PsDiagMeetingMap(string schema)
        {
            ToTable("PsDiagMeeting", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplyNo).HasColumnName(@"ApplyNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ApplyTime).HasColumnName(@"ApplyTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.Diagnose).HasColumnName(@"Diagnose").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.Clinic).HasColumnName(@"Clinic").IsOptional().HasColumnType("nvarchar").HasMaxLength(2000);
            Property(x => x.IsUrgent).HasColumnName(@"IsUrgent").IsRequired().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(2000);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
