using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsBpEvaluateMap : EntityTypeConfiguration<BsBpEvaluate>
    {
        public BsBpEvaluateMap()
            : this("dbo")
        {
        }

        public BsBpEvaluateMap(string schema)
        {
            ToTable("BsBPEvaluate", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.EvaluateId).HasColumnName(@"EvaluateId").IsOptional().HasColumnType("int");
            Property(x => x.EvaluateName).HasColumnName(@"EvaluateName").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ShortName).HasColumnName(@"ShortName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
