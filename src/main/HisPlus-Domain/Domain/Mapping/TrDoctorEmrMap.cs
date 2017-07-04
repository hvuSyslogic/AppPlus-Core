using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class TrDoctorEmrMap : EntityTypeConfiguration<TrDoctorEmr>
    {
        public TrDoctorEmrMap()
            : this("dbo")
        {
        }

        public TrDoctorEmrMap(string schema)
        {
            ToTable("TrDoctorEmr", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.PatId).HasColumnName(@"PatID").IsRequired().HasColumnType("int");
        }
    }
}
