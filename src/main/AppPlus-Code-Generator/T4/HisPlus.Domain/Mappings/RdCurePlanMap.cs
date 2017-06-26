using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RdCurePlanMap : EntityTypeConfiguration<RdCurePlan>
    {
        public RdCurePlanMap()
            : this("dbo")
        {
        }

        public RdCurePlanMap(string schema)
        {
            ToTable("RdCurePlan", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(12);
            Property(x => x.F1).HasColumnName(@"F1").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Illness).HasColumnName(@"Illness").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CureItem).HasColumnName(@"CureItem").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.CurePlan).HasColumnName(@"CurePlan").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.BeginTime).HasColumnName(@"BeginTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.EndTime).HasColumnName(@"EndTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
        }
    }
}
