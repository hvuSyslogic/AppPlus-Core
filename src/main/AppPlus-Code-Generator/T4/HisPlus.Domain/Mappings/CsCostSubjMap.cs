using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CsCostSubjMap : EntityTypeConfiguration<CsCostSubj>
    {
        public CsCostSubjMap()
            : this("dbo")
        {
        }

        public CsCostSubjMap(string schema)
        {
            ToTable("CsCostSubj", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SuppItemCode).HasColumnName(@"SuppItemCode").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.LsTreatMed).HasColumnName(@"LsTreatMed").IsOptional().HasColumnType("smallint");
            Property(x => x.IsLastLevel).HasColumnName(@"IsLastLevel").IsOptional().HasColumnType("bit");
            Property(x => x.CostSubjGrade).HasColumnName(@"CostSubjGrade").IsOptional().HasColumnType("int");
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsFix).HasColumnName(@"IsFix").IsOptional().HasColumnType("bit");
            Property(x => x.LsType).HasColumnName(@"LsType").IsOptional().HasColumnType("smallint");
            Property(x => x.ClassId).HasColumnName(@"ClassId").IsOptional().HasColumnType("int");
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("smallint");
            Property(x => x.IsDerect).HasColumnName(@"IsDerect").IsOptional().HasColumnType("bit");
            Property(x => x.LsAppPara).HasColumnName(@"LsAppPara").IsOptional().HasColumnType("smallint");
            Property(x => x.ToLocIds).HasColumnName(@"ToLocIds").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
