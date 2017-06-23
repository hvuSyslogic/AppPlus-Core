using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InYbBalanceMap : EntityTypeConfiguration<InYbBalance>
    {
        public InYbBalanceMap()
            : this("dbo")
        {
        }

        public InYbBalanceMap(string schema)
        {
            ToTable("InYBBalance", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Invono).HasColumnName(@"INVONO").IsRequired().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Lspaytype).HasColumnName(@"LSPAYTYPE").IsRequired().HasColumnType("int");
            Property(x => x.Hospid).HasColumnName(@"HOSPID").IsRequired().HasColumnType("int");
            Property(x => x.Pattypeid).HasColumnName(@"PATTYPEID").IsRequired().HasColumnType("int");
            Property(x => x.Fromdate).HasColumnName(@"FROMDATE").IsRequired().HasColumnType("date");
            Property(x => x.Todate).HasColumnName(@"TODATE").IsRequired().HasColumnType("date");
            Property(x => x.Chargedays).HasColumnName(@"CHARGEDAYS").IsRequired().HasColumnType("int");
            Property(x => x.Beprice).HasColumnName(@"BEPRICE").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Tallyno).HasColumnName(@"TALLYNO").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Factget).HasColumnName(@"FACTGET").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Insurance).HasColumnName(@"INSURANCE").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Payself).HasColumnName(@"PAYSELF").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Amountpay).HasColumnName(@"AMOUNTPAY").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Deposit).HasColumnName(@"DEPOSIT").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Complement).HasColumnName(@"COMPLEMENT").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Arrearage).HasColumnName(@"ARREARAGE").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Addfee).HasColumnName(@"ADDFEE").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Remark).HasColumnName(@"REMARK").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.Opertime).HasColumnName(@"OPERTIME").IsRequired().HasColumnType("date");
            Property(x => x.Operid).HasColumnName(@"OPERID").IsRequired().HasColumnType("int");
            Property(x => x.Iscancel).HasColumnName(@"ISCANCEL").IsRequired().HasColumnType("bit");
            Property(x => x.Cancelopertime).HasColumnName(@"CANCELOPERTIME").IsOptional().HasColumnType("date");
            Property(x => x.Canceloperid).HasColumnName(@"CANCELOPERID").IsOptional().HasColumnType("int");
            Property(x => x.Cancelmemo).HasColumnName(@"CANCELMEMO").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Involastid).HasColumnName(@"INVOLASTID").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.Hospitalid).HasColumnName(@"HOSPITALID").IsOptional().HasColumnType("int");
            Property(x => x.Name).HasColumnName(@"NAME").IsRequired().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.Inpatno).HasColumnName(@"INPATNO").IsRequired().HasColumnType("nvarchar").HasMaxLength(26);
            Property(x => x.Sumfee).HasColumnName(@"SUMFEE").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Amountinsurance).HasColumnName(@"AMOUNTINSURANCE").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Amountfact).HasColumnName(@"AMOUNTFACT").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Intime).HasColumnName(@"INTIME").IsRequired().HasColumnType("date");
            Property(x => x.Outtime).HasColumnName(@"OUTTIME").IsRequired().HasColumnType("date");
            Property(x => x.Reportcontent).HasColumnName(@"REPORTCONTENT").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
        }
    }
}
