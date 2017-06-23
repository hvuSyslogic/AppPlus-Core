using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkMachineResultDtlMap : EntityTypeConfiguration<CkMachineResultDtl>
    {
        public CkMachineResultDtlMap()
            : this("dbo")
        {
        }

        public CkMachineResultDtlMap(string schema)
        {
            ToTable("CKMachineResultDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ResultId).HasColumnName(@"ResultID").IsRequired().HasColumnType("int");
            Property(x => x.TestId).HasColumnName(@"TestID").IsRequired().HasColumnType("int");
            Property(x => x.Result).HasColumnName(@"Result").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Bench).HasColumnName(@"bench").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
        }
    }
}
