using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuInvoiceFeetySumMap : EntityTypeConfiguration<OuInvoiceFeetySum>
    {
        public OuInvoiceFeetySumMap()
            : this("dbo")
        {
        }

        public OuInvoiceFeetySumMap(string schema)
        {
            ToTable("OuInvoiceFeetySum", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InvoId).HasColumnName(@"InvoId").IsRequired().HasColumnType("int");
            Property(x => x.FeeId).HasColumnName(@"FeeId").IsRequired().HasColumnType("int");
            Property(x => x.Amount).HasColumnName(@"Amount").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountFact).HasColumnName(@"AmountFact").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountSelf).HasColumnName(@"AmountSelf").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountTally).HasColumnName(@"AmountTally").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountPay).HasColumnName(@"AmountPay").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
        }
    }
}
