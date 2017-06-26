using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RdFollowMap : EntityTypeConfiguration<RdFollow>
    {
        public RdFollowMap()
            : this("dbo")
        {
        }

        public RdFollowMap(string schema)
        {
            ToTable("RdFollow", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsRequired().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(12);
            Property(x => x.PlanTime).HasColumnName(@"PlanTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.VisitMan).HasColumnName(@"VisitMan").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Purpose).HasColumnName(@"Purpose").IsRequired().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.LsVisitType).HasColumnName(@"LsVisitType").IsRequired().HasColumnType("smallint");
            Property(x => x.IsVisited).HasColumnName(@"IsVisited").IsRequired().HasColumnType("bit");
            Property(x => x.Process).HasColumnName(@"Process").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Result).HasColumnName(@"Result").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Other).HasColumnName(@"Other").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.SumUp).HasColumnName(@"SumUp").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
