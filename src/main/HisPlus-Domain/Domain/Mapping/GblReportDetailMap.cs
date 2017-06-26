using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblReportDetailMap : EntityTypeConfiguration<GblReportDetail>
    {
        public GblReportDetailMap()
            : this("dbo")
        {
        }

        public GblReportDetailMap(string schema)
        {
            ToTable("GblReportDetail", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.GroupId).HasColumnName(@"GroupId").IsRequired().HasColumnType("int");
            Property(x => x.FeeId).HasColumnName(@"FeeId").IsRequired().HasColumnType("int");
        }
    }
}
