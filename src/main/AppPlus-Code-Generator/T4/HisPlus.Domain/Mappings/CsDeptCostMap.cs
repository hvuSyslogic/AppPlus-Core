using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CsDeptCostMap : EntityTypeConfiguration<CsDeptCost>
    {
        public CsDeptCostMap()
            : this("dbo")
        {
        }

        public CsDeptCostMap(string schema)
        {
            ToTable("CsDeptCost", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.YearMonth).HasColumnName(@"YearMonth").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(6);
            Property(x => x.LocId).HasColumnName(@"LocId").IsRequired().HasColumnType("int");
            Property(x => x.CostSubjId).HasColumnName(@"CostSubjId").IsOptional().HasColumnType("int");
            Property(x => x.TotAmount).HasColumnName(@"TotAmount").IsOptional().HasColumnType("decimal").HasPrecision(16,2);
            Property(x => x.PlanAmount).HasColumnName(@"PlanAmount").IsOptional().HasColumnType("decimal").HasPrecision(16,2);
            Property(x => x.PrimeCost).HasColumnName(@"PrimeCost").IsOptional().HasColumnType("decimal").HasPrecision(16,2);
            Property(x => x.ApportCost1).HasColumnName(@"ApportCost1").IsOptional().HasColumnType("decimal").HasPrecision(16,2);
            Property(x => x.ApportCost2).HasColumnName(@"ApportCost2").IsOptional().HasColumnType("decimal").HasPrecision(16,2);
            Property(x => x.ApportCost3).HasColumnName(@"ApportCost3").IsOptional().HasColumnType("decimal").HasPrecision(16,2);
            Property(x => x.ApportCost4).HasColumnName(@"ApportCost4").IsOptional().HasColumnType("decimal").HasPrecision(16,2);
            Property(x => x.ApportCostSend).HasColumnName(@"ApportCostSend").IsOptional().HasColumnType("decimal").HasPrecision(16,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
