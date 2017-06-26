using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ReportTableMap : EntityTypeConfiguration<ReportTable>
    {
        public ReportTableMap()
            : this("dbo")
        {
        }

        public ReportTableMap(string schema)
        {
            ToTable("Report_Table", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").IsRequired().HasColumnType("numeric");
            Property(x => x.TabelName).HasColumnName(@"Tabel_Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.FiledName).HasColumnName(@"Filed_Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.FiledZw).HasColumnName(@"Filed_ZW").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.FiledType).HasColumnName(@"Filed_Type").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
        }
    }
}
