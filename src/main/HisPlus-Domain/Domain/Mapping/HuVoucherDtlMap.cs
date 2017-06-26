using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class HuVoucherDtlMap : EntityTypeConfiguration<HuVoucherDtl>
    {
        public HuVoucherDtlMap()
            : this("dbo")
        {
        }

        public HuVoucherDtlMap(string schema)
        {
            ToTable("HuVoucherDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.VoucherId).HasColumnName(@"VoucherId").IsOptional().HasColumnType("int");
            Property(x => x.BillId).HasColumnName(@"BillId").IsRequired().HasColumnType("int");
            Property(x => x.Amount).HasColumnName(@"Amount").IsOptional().HasColumnType("decimal").HasPrecision(12,2);
            Property(x => x.HasPay).HasColumnName(@"HasPay").IsOptional().HasColumnType("decimal").HasPrecision(12,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
