using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class DhInvoiceTempMap : EntityTypeConfiguration<DhInvoiceTemp>
    {
        public DhInvoiceTempMap()
            : this("dbo")
        {
        }

        public DhInvoiceTempMap(string schema)
        {
            ToTable("DhInvoiceTemp", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsOptional().HasColumnType("int");
            Property(x => x.LsInOut).HasColumnName(@"LsInOut").IsRequired().HasColumnType("smallint");
            Property(x => x.InvoNo).HasColumnName(@"InvoNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.InvoTime).HasColumnName(@"InvoTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperName).HasColumnName(@"OperName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InPatNo).HasColumnName(@"InPatNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.CardNo).HasColumnName(@"CardNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.PatientName).HasColumnName(@"PatientName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RegTypeName).HasColumnName(@"RegTypeName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InDays).HasColumnName(@"InDays").IsOptional().HasColumnType("smallint");
            Property(x => x.PatTypeCode).HasColumnName(@"PatTypeCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PatType1).HasColumnName(@"PatType1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PatType2).HasColumnName(@"PatType2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PatType3).HasColumnName(@"PatType3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IcdCode).HasColumnName(@"ICDCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Illness).HasColumnName(@"Illness").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.AmountPay).HasColumnName(@"AmountPay").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Amount).HasColumnName(@"Amount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
