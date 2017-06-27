using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class NrPlanMap : EntityTypeConfiguration<NrPlan>
    {
        public NrPlanMap()
            : this("dbo")
        {
        }

        public NrPlanMap(string schema)
        {
            ToTable("NrPlan", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IcdId).HasColumnName(@"IcdId").IsOptional().HasColumnType("int");
            Property(x => x.IllDesc).HasColumnName(@"IllDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Target).HasColumnName(@"Target").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Measure).HasColumnName(@"Measure").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.BasisOf).HasColumnName(@"BasisOf").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Evaluate).HasColumnName(@"Evaluate").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.EvalOperId).HasColumnName(@"EvalOperId").IsOptional().HasColumnType("int");
            Property(x => x.EvalTime).HasColumnName(@"EvalTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}