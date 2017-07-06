using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class VisitRecordUserMap : EntityTypeConfiguration<VisitRecordUser>
    {
        public VisitRecordUserMap()
            : this("dbo")
        {
        }

        public VisitRecordUserMap(string schema)
        {
            ToTable("VisitRecordUser", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName(@"UserId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.LsUserRole).HasColumnName(@"LsUserRole").IsOptional().HasColumnType("int");
        }
    }
}
