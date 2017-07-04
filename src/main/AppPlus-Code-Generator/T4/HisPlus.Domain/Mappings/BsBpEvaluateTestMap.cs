using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsBpEvaluateTestMap : EntityTypeConfiguration<BsBpEvaluateTest>
    {
        public BsBpEvaluateTestMap()
            : this("dbo")
        {
        }

        public BsBpEvaluateTestMap(string schema)
        {
            ToTable("BsBPEvaluateTest", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BpItemId).HasColumnName(@"BPItemId").IsOptional().HasColumnType("int");
            Property(x => x.EvaluateId).HasColumnName(@"EvaluateId").IsOptional().HasColumnType("int");
            Property(x => x.IsCommon).HasColumnName(@"IsCommon").IsOptional().HasColumnType("bit");
            Property(x => x.BpIllId).HasColumnName(@"BPIllId").IsOptional().HasColumnType("int");
            Property(x => x.TestType).HasColumnName(@"TestType").IsOptional().HasColumnType("int");
        }
    }
}
