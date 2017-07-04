using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuInvoiceDtlTempMap : EntityTypeConfiguration<OuInvoiceDtlTemp>
    {
        public OuInvoiceDtlTempMap()
            : this("dbo")
        {
        }

        public OuInvoiceDtlTempMap(string schema)
        {
            ToTable("OuInvoiceDtlTemp", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Amount).HasColumnName(@"Amount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountFact).HasColumnName(@"AmountFact").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountInsurance).HasColumnName(@"AmountInsurance").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountPay).HasColumnName(@"AmountPay").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountSelf).HasColumnName(@"AmountSelf").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AmountTally).HasColumnName(@"AmountTally").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Code).HasColumnName(@"Code").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DiscDiag).HasColumnName(@"DiscDiag").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DiscSelf).HasColumnName(@"DiscSelf").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DocLevId).HasColumnName(@"DocLevId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorName).HasColumnName(@"DoctorName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ExecLocId).HasColumnName(@"ExecLocId").IsOptional().HasColumnType("int");
            Property(x => x.F5).HasColumnName(@"F5").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FeeHsId).HasColumnName(@"FeeHsId").IsOptional().HasColumnType("int");
            Property(x => x.FeeHsMzName).HasColumnName(@"FeeHsMzName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FeeId).HasColumnName(@"FeeId").IsOptional().HasColumnType("int");
            Property(x => x.FeeName).HasColumnName(@"FeeName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InvItemId).HasColumnName(@"InvItemId").IsOptional().HasColumnType("int");
            Property(x => x.InvMzItemName).HasColumnName(@"InvMzItemName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InvoId).HasColumnName(@"InvoId").IsOptional().HasColumnType("int");
            Property(x => x.InvoTime).HasColumnName(@"InvoTime").IsOptional().HasColumnType("datetime");
            Property(x => x.IsBack).HasColumnName(@"IsBack").IsOptional().HasColumnType("bit");
            Property(x => x.IsDoctorInput).HasColumnName(@"IsDoctorInput").IsOptional().HasColumnType("bit");
            Property(x => x.IsIssue).HasColumnName(@"IsIssue").IsOptional().HasColumnType("bit");
            Property(x => x.IsModiDisc).HasColumnName(@"IsModiDisc").IsOptional().HasColumnType("bit");
            Property(x => x.IsOtherFee).HasColumnName(@"IsOtherFee").IsOptional().HasColumnType("bit");
            Property(x => x.IsPriority).HasColumnName(@"IsPriority").IsOptional().HasColumnType("bit");
            Property(x => x.IsToBack).HasColumnName(@"IsToBack").IsOptional().HasColumnType("bit");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.LimitFee).HasColumnName(@"LimitFee").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LimitGroupId).HasColumnName(@"LimitGroupId").IsOptional().HasColumnType("int");
            Property(x => x.LimitTotalMz).HasColumnName(@"LimitTotalMz").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ListNum).HasColumnName(@"ListNum").IsOptional().HasColumnType("int");
            Property(x => x.LocationName).HasColumnName(@"LocationName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsAdviceType).HasColumnName(@"LsAdviceType").IsOptional().HasColumnType("int");
            Property(x => x.LsGfType).HasColumnName(@"LsGfType").IsOptional().HasColumnType("int");
            Property(x => x.LsGroupType).HasColumnName(@"LsGroupType").IsOptional().HasColumnType("int");
            Property(x => x.LsPerform).HasColumnName(@"LsPerform").IsOptional().HasColumnType("int");
            Property(x => x.LsReportType).HasColumnName(@"LsReportType").IsOptional().HasColumnType("int");
            Property(x => x.LsRepType).HasColumnName(@"LsRepType").IsOptional().HasColumnType("int");
            Property(x => x.LsRpType).HasColumnName(@"LsRpType").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PrepareTime).HasColumnName(@"PrepareTime").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Price).HasColumnName(@"Price").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.RecipeGroupId).HasColumnName(@"RecipeGroupId").IsOptional().HasColumnType("int");
            Property(x => x.RecipeGroupIds).HasColumnName(@"RecipeGroupIds").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RecipeId).HasColumnName(@"RecipeId").IsOptional().HasColumnType("int");
            Property(x => x.RecipeItemId).HasColumnName(@"RecipeItemId").IsOptional().HasColumnType("int");
            Property(x => x.RoomId).HasColumnName(@"RoomId").IsOptional().HasColumnType("int");
            Property(x => x.Spec).HasColumnName(@"Spec").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Totality).HasColumnName(@"Totality").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.TypeGfxeId).HasColumnName(@"TypeGFXEId").IsOptional().HasColumnType("int");
            Property(x => x.UnitDiagName).HasColumnName(@"UnitDiagName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsOptional().HasColumnType("int");
            Property(x => x.XdRpId).HasColumnName(@"XDRpId").IsOptional().HasColumnType("int");
            Property(x => x.Mzregid).HasColumnName(@"Mzregid").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("datetime");
        }
    }
}
