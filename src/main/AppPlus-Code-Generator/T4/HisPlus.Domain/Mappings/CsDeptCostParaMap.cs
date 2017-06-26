using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CsDeptCostParaMap : EntityTypeConfiguration<CsDeptCostPara>
    {
        public CsDeptCostParaMap()
            : this("dbo")
        {
        }

        public CsDeptCostParaMap(string schema)
        {
            ToTable("CsDeptCostPara", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LocId).HasColumnName(@"LocId").IsRequired().HasColumnType("int");
            Property(x => x.CostSubjId).HasColumnName(@"CostSubjId").IsRequired().HasColumnType("int");
            Property(x => x.LsAppPara).HasColumnName(@"LsAppPara").IsOptional().HasColumnType("smallint");
            Property(x => x.ToLocIds).HasColumnName(@"ToLocIds").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
