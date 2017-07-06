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
            Property(x => x.CancelPaywayId).HasColumnName(@"cancelPaywayId").IsOptional().HasColumnType("int");
            Property(x => x.BankId).HasColumnName(@"BankId").IsOptional().HasColumnType("int");
        }
    }
}
