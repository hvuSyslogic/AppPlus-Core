using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblPrinterMap : EntityTypeConfiguration<GblPrinter>
    {
        public GblPrinterMap()
            : this("dbo")
        {
        }

        public GblPrinterMap(string schema)
        {
            ToTable("GblPrinter", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Hostname).HasColumnName(@"Hostname").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ReportName).HasColumnName(@"ReportName").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PrinterName).HasColumnName(@"PrinterName").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
