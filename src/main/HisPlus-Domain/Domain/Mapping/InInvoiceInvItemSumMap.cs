using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InInvoiceInvItemSumMap : EntityTypeConfiguration<InInvoiceInvItemSum>
    {
        public InInvoiceInvItemSumMap()
            : this("dbo")
        {
        }

        public InInvoiceInvItemSumMap(string schema)
        {
            ToTable("InInvoiceInvItemSum", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InvoId).HasColumnName(@"InvoId").IsRequired().HasColumnType("int");
            Property(x => x.InvItemId).HasColumnName(@"InvItemId").IsRequired().HasColumnType("int");
            Property(x => x.Amount).HasColumnName(@"Amount").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountFact).HasColumnName(@"AmountFact").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountSelf).HasColumnName(@"AmountSelf").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountTally).HasColumnName(@"AmountTally").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountPay).HasColumnName(@"AmountPay").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MzAmount).HasColumnName(@"MzAmount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Insurance).HasColumnName(@"Insurance").IsOptional().HasColumnType("decimal").HasPrecision(15,2);
        }
    }
}
