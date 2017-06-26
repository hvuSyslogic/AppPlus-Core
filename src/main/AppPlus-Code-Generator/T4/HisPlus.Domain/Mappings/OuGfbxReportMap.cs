using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuGfbxReportMap : EntityTypeConfiguration<OuGfbxReport>
    {
        public OuGfbxReportMap()
            : this("dbo")
        {
        }

        public OuGfbxReportMap(string schema)
        {
            ToTable("OuGfbxReport", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.BeginTime).HasColumnName(@"BeginTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.EndTime).HasColumnName(@"EndTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.PatType).HasColumnName(@"PatType").IsRequired().HasColumnType("int");
            Property(x => x.TypeId).HasColumnName(@"TypeId").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
