using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkMachineResultAMap : EntityTypeConfiguration<CkMachineResultA>
    {
        public CkMachineResultAMap()
            : this("dbo")
        {
        }

        public CkMachineResultAMap(string schema)
        {
            ToTable("CKMachineResult_A", schema);
            HasKey(x => new { x.OperDate, x.Id, x.LabId, x.SampleNum, x.TestDate, x.MachineId, x.TestTypeId });

            Property(x => x.OperDate).HasColumnName(@"OperDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int");
            Property(x => x.LabId).HasColumnName(@"LabID").IsRequired().HasColumnType("int");
            Property(x => x.SampleNum).HasColumnName(@"SampleNum").IsRequired().HasColumnType("nvarchar").HasMaxLength(14);
            Property(x => x.TestDate).HasColumnName(@"TestDate").IsRequired().HasColumnType("datetime");
            Property(x => x.MachineId).HasColumnName(@"MachineID").IsRequired().HasColumnType("int");
            Property(x => x.TestTypeId).HasColumnName(@"TestTypeID").IsRequired().HasColumnType("int");
        }
    }
}
