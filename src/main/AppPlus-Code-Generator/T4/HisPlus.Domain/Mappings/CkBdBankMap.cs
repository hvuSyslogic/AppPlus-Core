using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkBdBankMap : EntityTypeConfiguration<CkBdBank>
    {
        public CkBdBankMap()
            : this("dbo")
        {
        }

        public CkBdBankMap(string schema)
        {
            ToTable("CkBdBank", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SerialNo).HasColumnName(@"SerialNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.BloodTypeId).HasColumnName(@"BloodTypeId").IsRequired().HasColumnType("smallint");
            Property(x => x.BloodGroup).HasColumnName(@"BloodGroup").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.Rhd).HasColumnName(@"RHD").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RecieveDate).HasColumnName(@"RecieveDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.RecieveOperId).HasColumnName(@"RecieveOperId").IsRequired().HasColumnType("int");
            Property(x => x.LsSource).HasColumnName(@"LsSource").IsRequired().HasColumnType("smallint");
            Property(x => x.Account).HasColumnName(@"Account").IsOptional().HasColumnType("nvarchar").HasMaxLength(5);
            Property(x => x.ExpireDate).HasColumnName(@"ExpireDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OfferMan).HasColumnName(@"OfferMan").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CollectDate).HasColumnName(@"CollectDate").IsOptional().HasColumnType("datetime");
            Property(x => x.CollectMan).HasColumnName(@"CollectMan").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Vollume).HasColumnName(@"Vollume").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.Price).HasColumnName(@"Price").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.LsStatus).HasColumnName(@"LsStatus").IsRequired().HasColumnType("smallint");
            Property(x => x.BackDate).HasColumnName(@"BackDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.BackOperId).HasColumnName(@"BackOperId").IsOptional().HasColumnType("int");
            Property(x => x.BackMemo).HasColumnName(@"BackMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Unit).HasColumnName(@"Unit").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DiscardReason).HasColumnName(@"DiscardReason").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DiscardTime).HasColumnName(@"DiscardTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.DiscardOperId).HasColumnName(@"DiscardOperID").IsOptional().HasColumnType("int");
        }
    }
}
