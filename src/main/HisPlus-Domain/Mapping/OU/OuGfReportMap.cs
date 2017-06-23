using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuGfReportMap : EntityTypeConfiguration<OuGfReport>
    {
        public OuGfReportMap()
            : this("dbo")
        {
        }

        public OuGfReportMap(string schema)
        {
            ToTable("OuGFReport", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TallyGroupId).HasColumnName(@"TallyGroupId").IsRequired().HasColumnType("int");
            Property(x => x.LsreportFee).HasColumnName(@"LsreportFee").IsRequired().HasColumnType("smallint");
            Property(x => x.ReportJz).HasColumnName(@"ReportJz").IsRequired().HasColumnType("smallint");
            Property(x => x.ReportBx).HasColumnName(@"ReportBx").IsRequired().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
