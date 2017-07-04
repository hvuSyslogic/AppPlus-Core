using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class PsDiagDoctorMap : EntityTypeConfiguration<PsDiagDoctor>
    {
        public PsDiagDoctorMap()
            : this("dbo")
        {
        }

        public PsDiagDoctorMap(string schema)
        {
            ToTable("PsDiagDoctors", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplyId).HasColumnName(@"ApplyId").IsOptional().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.IsConfirm).HasColumnName(@"IsConfirm").IsOptional().HasColumnType("bit");
            Property(x => x.ConfirmTime).HasColumnName(@"ConfirmTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Answer).HasColumnName(@"Answer").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
