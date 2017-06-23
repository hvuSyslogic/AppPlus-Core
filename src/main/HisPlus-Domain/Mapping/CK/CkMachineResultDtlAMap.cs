using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkMachineResultDtlAMap : EntityTypeConfiguration<CkMachineResultDtlA>
    {
        public CkMachineResultDtlAMap()
            : this("dbo")
        {
        }

        public CkMachineResultDtlAMap(string schema)
        {
            ToTable("CKMachineResultDtl_A", schema);
            HasKey(x => new { x.OperDate, x.Id, x.ResultId, x.TestId });

            Property(x => x.OperDate).HasColumnName(@"OperDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int");
            Property(x => x.ResultId).HasColumnName(@"ResultID").IsRequired().HasColumnType("int");
            Property(x => x.TestId).HasColumnName(@"TestID").IsRequired().HasColumnType("int");
            Property(x => x.Result).HasColumnName(@"Result").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Bench).HasColumnName(@"bench").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
        }
    }
}
