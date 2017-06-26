using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuInvoicePayMap : EntityTypeConfiguration<OuInvoicePay>
    {
        public OuInvoicePayMap()
            : this("dbo")
        {
        }

        public OuInvoicePayMap(string schema)
        {
            ToTable("OuInvoicePay", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InvoId).HasColumnName(@"InvoId").IsRequired().HasColumnType("int");
            Property(x => x.PaywayId).HasColumnName(@"PaywayId").IsRequired().HasColumnType("int");
            Property(x => x.Amount).HasColumnName(@"Amount").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.CancelPaywayId).HasColumnName(@"cancelPaywayId").IsOptional().HasColumnType("int");
        }
    }
}
