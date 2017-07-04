using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OulInvoiceRegMap : EntityTypeConfiguration<OulInvoiceReg>
    {
        public OulInvoiceRegMap()
            : this("dbo")
        {
        }

        public OulInvoiceRegMap(string schema)
        {
            ToTable("OulInvoiceReg", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InvoNo).HasColumnName(@"InvoNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsRequired().HasColumnType("int");
            Property(x => x.InvoTime).HasColumnName(@"InvoTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.RegFee).HasColumnName(@"RegFee").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DiagnoFee).HasColumnName(@"DiagnoFee").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ZyFee).HasColumnName(@"ZyFee").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OtherFee1).HasColumnName(@"OtherFee1").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OtherFee2).HasColumnName(@"OtherFee2").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IsCancel).HasColumnName(@"IsCancel").IsRequired().HasColumnType("bit");
            Property(x => x.CancelTime).HasColumnName(@"CancelTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CancelOperId).HasColumnName(@"CancelOperId").IsOptional().HasColumnType("int");
            Property(x => x.InvoLastId).HasColumnName(@"InvoLastId").IsOptional().HasColumnType("int");
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsOptional().HasColumnType("int");
            Property(x => x.RegTypeId).HasColumnName(@"RegTypeId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsOptional().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.CheckTime).HasColumnName(@"CheckTime").IsOptional().HasColumnType("datetime");
            Property(x => x.CancelCheckTime).HasColumnName(@"CancelCheckTime").IsOptional().HasColumnType("datetime");
            Property(x => x.DocLocId).HasColumnName(@"DocLocId").IsOptional().HasColumnType("int");
            Property(x => x.OrderWxid).HasColumnName(@"OrderWXID").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsRegDoctorTemp).HasColumnName(@"IsRegDoctorTemp").IsOptional().HasColumnType("bit");
        }
    }
}
