using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkMachineResultMap : EntityTypeConfiguration<CkMachineResult>
    {
        public CkMachineResultMap()
            : this("dbo")
        {
        }

        public CkMachineResultMap(string schema)
        {
            ToTable("CKMachineResult", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LabId).HasColumnName(@"LabID").IsRequired().HasColumnType("int");
            Property(x => x.SampleNum).HasColumnName(@"SampleNum").IsRequired().HasColumnType("nvarchar").HasMaxLength(14);
            Property(x => x.TestDate).HasColumnName(@"TestDate").IsRequired().HasColumnType("datetime");
            Property(x => x.MachineId).HasColumnName(@"MachineID").IsRequired().HasColumnType("int");
            Property(x => x.TestTypeId).HasColumnName(@"TestTypeID").IsRequired().HasColumnType("int");
        }
    }
}
