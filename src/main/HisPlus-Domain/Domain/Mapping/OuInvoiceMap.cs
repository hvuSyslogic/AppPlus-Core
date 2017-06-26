using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuInvoiceMap : EntityTypeConfiguration<OuInvoice>
    {
        public OuInvoiceMap()
            : this("dbo")
        {
        }

        public OuInvoiceMap(string schema)
        {
            ToTable("OuInvoice", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InvoNo).HasColumnName(@"InvoNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsRequired().HasColumnType("int");
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.InvoTime).HasColumnName(@"InvoTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.Beprice).HasColumnName(@"Beprice").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.FactGet).HasColumnName(@"FactGet").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Insurance).HasColumnName(@"Insurance").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PaySelf).HasColumnName(@"PaySelf").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountPay).HasColumnName(@"AmountPay").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AddFee).HasColumnName(@"AddFee").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.TallyNo).HasColumnName(@"TallyNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Remark).HasColumnName(@"Remark").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IsCancel).HasColumnName(@"IsCancel").IsRequired().HasColumnType("bit");
            Property(x => x.CancelOperTime).HasColumnName(@"CancelOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CancelOperId).HasColumnName(@"CancelOperId").IsOptional().HasColumnType("int");
            Property(x => x.CancelMemo).HasColumnName(@"CancelMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.InvoLastId).HasColumnName(@"InvoLastId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.FeeMainId).HasColumnName(@"FeeMainId").IsOptional().HasColumnType("int");
            Property(x => x.FeeSubId).HasColumnName(@"FeeSubId").IsOptional().HasColumnType("int");
            Property(x => x.TallyTime).HasColumnName(@"TallyTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CancelTallyTime).HasColumnName(@"CancelTallyTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ReAmount).HasColumnName(@"ReAmount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ReAmountDate).HasColumnName(@"ReAmountDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ReAmountMemo).HasColumnName(@"ReAmountMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsOptional().HasColumnType("int");
            Property(x => x.F5).HasColumnName(@"F5").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F6).HasColumnName(@"F6").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F7).HasColumnName(@"F7").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F8).HasColumnName(@"F8").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsOptional().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.YbIllId).HasColumnName(@"YbIllId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.CheckTime).HasColumnName(@"CheckTime").IsOptional().HasColumnType("datetime");
            Property(x => x.CancelCheckTime).HasColumnName(@"CancelCheckTime").IsOptional().HasColumnType("datetime");
            Property(x => x.DocLocId).HasColumnName(@"DocLocId").IsOptional().HasColumnType("int");
        }
    }
}
