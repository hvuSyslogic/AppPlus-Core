using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class DhInvoiceDtlTempMap : EntityTypeConfiguration<DhInvoiceDtlTemp>
    {
        public DhInvoiceDtlTempMap()
            : this("dbo")
        {
        }

        public DhInvoiceDtlTempMap(string schema)
        {
            ToTable("DhInvoiceDtlTemp", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsOptional().HasColumnType("int");
            Property(x => x.InvoNo).HasColumnName(@"InvoNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.LsInOut).HasColumnName(@"LsInOut").IsRequired().HasColumnType("smallint");
            Property(x => x.ItemCode).HasColumnName(@"ItemCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ItemName).HasColumnName(@"ItemName").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Spec).HasColumnName(@"Spec").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Price).HasColumnName(@"Price").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.LimitName).HasColumnName(@"LimitName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FeeId).HasColumnName(@"FeeId").IsOptional().HasColumnType("int");
            Property(x => x.FeetyName).HasColumnName(@"FeetyName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InvFeetyName).HasColumnName(@"InvFeetyName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AccountName).HasColumnName(@"AccountName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UnitName).HasColumnName(@"UnitName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Totality).HasColumnName(@"Totality").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.AmountPay).HasColumnName(@"AmountPay").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Amount).HasColumnName(@"Amount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Location1).HasColumnName(@"Location1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Location2).HasColumnName(@"Location2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Location3).HasColumnName(@"Location3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DoctorName).HasColumnName(@"DoctorName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DocLevel).HasColumnName(@"DocLevel").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RegOperTime).HasColumnName(@"RegOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
