using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuInvoiceDtlMap : EntityTypeConfiguration<OuInvoiceDtl>
    {
        public OuInvoiceDtlMap()
            : this("dbo")
        {
        }

        public OuInvoiceDtlMap(string schema)
        {
            ToTable("OuInvoiceDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InvoId).HasColumnName(@"InvoId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.Totality).HasColumnName(@"Totality").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.Price).HasColumnName(@"Price").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.DiscDiag).HasColumnName(@"DiscDiag").IsRequired().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.IsModiDisc).HasColumnName(@"IsModiDisc").IsRequired().HasColumnType("bit");
            Property(x => x.DiscSelf).HasColumnName(@"DiscSelf").IsRequired().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.Amount).HasColumnName(@"Amount").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountFact).HasColumnName(@"AmountFact").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountSelf).HasColumnName(@"AmountSelf").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountTally).HasColumnName(@"AmountTally").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountPay).HasColumnName(@"AmountPay").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LsPerform).HasColumnName(@"LsPerform").IsRequired().HasColumnType("smallint");
            Property(x => x.LimitGroupId).HasColumnName(@"LimitGroupId").IsOptional().HasColumnType("int");
            Property(x => x.LimitFee).HasColumnName(@"LimitFee").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ExecLocId).HasColumnName(@"ExecLocId").IsRequired().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsRequired().HasColumnType("int");
            Property(x => x.InvItemId).HasColumnName(@"InvItemId").IsRequired().HasColumnType("int");
            Property(x => x.FeeId).HasColumnName(@"FeeId").IsRequired().HasColumnType("int");
            Property(x => x.FeeHsId).HasColumnName(@"FeeHsId").IsOptional().HasColumnType("int");
            Property(x => x.XdRpId).HasColumnName(@"XDRpId").IsOptional().HasColumnType("int");
            Property(x => x.LsReportType).HasColumnName(@"LsReportType").IsOptional().HasColumnType("smallint");
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RecipeItemId).HasColumnName(@"RecipeItemId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.RecipeGroupId).HasColumnName(@"RecipeGroupId").IsOptional().HasColumnType("int");
            Property(x => x.DocLocId).HasColumnName(@"DocLocID").IsOptional().HasColumnType("int");
        }
    }
}
