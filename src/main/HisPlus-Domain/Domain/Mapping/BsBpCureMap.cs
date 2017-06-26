using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsBpCureMap : EntityTypeConfiguration<BsBpCure>
    {
        public BsBpCureMap()
            : this("dbo")
        {
        }

        public BsBpCureMap(string schema)
        {
            ToTable("BsBPCure", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CureRuleName).HasColumnName(@"CureRuleName").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.CureRuleDesc).HasColumnName(@"CureRuleDesc").IsOptional().HasColumnType("nvarchar(max)");
            Property(x => x.BpIllId).HasColumnName(@"BPIllId").IsOptional().HasColumnType("int");
            Property(x => x.BpGroupId).HasColumnName(@"BPGroupId").IsOptional().HasColumnType("int");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
