using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InPayMap : EntityTypeConfiguration<InPay>
    {
        public InPayMap()
            : this("dbo")
        {
        }

        public InPayMap(string schema)
        {
            ToTable("InPay", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.InvoId).HasColumnName(@"InvoId").IsOptional().HasColumnType("int");
            Property(x => x.DepositId).HasColumnName(@"DepositId").IsOptional().HasColumnType("int");
            Property(x => x.LsChargeType).HasColumnName(@"LsChargeType").IsRequired().HasColumnType("smallint");
            Property(x => x.Amount).HasColumnName(@"Amount").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PayWayId).HasColumnName(@"PayWayId").IsRequired().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Remain).HasColumnName(@"Remain").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.CancelPaywayId).HasColumnName(@"CancelPaywayId").IsOptional().HasColumnType("int");
        }
    }
}
