using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblReportGroupMap : EntityTypeConfiguration<GblReportGroup>
    {
        public GblReportGroupMap()
            : this("dbo")
        {
        }

        public GblReportGroupMap(string schema)
        {
            ToTable("GblReportGroup", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ReportId).HasColumnName(@"ReportId").IsRequired().HasColumnType("int");
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("int");
        }
    }
}
