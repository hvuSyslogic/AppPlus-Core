using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsBpPatientGroupMap : EntityTypeConfiguration<BsBpPatientGroup>
    {
        public BsBpPatientGroupMap()
            : this("dbo")
        {
        }

        public BsBpPatientGroupMap(string schema)
        {
            ToTable("BsBPPatientGroup", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatientGroup).HasColumnName(@"PatientGroup").IsOptional().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.BpIllId).HasColumnName(@"BPIllId").IsOptional().HasColumnType("int");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("int");
        }
    }
}
