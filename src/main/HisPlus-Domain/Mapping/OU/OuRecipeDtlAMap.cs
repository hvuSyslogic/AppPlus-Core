using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuRecipeDtlAMap : EntityTypeConfiguration<OuRecipeDtlA>
    {
        public OuRecipeDtlAMap()
            : this("dbo")
        {
        }

        public OuRecipeDtlAMap(string schema)
        {
            ToTable("OuRecipeDtl_A", schema);
            HasKey(x => new { x.OperDate, x.Id, x.RecipeId, x.ListNum, x.ItemId, x.GroupNum, x.Dosage, x.Totality, x.UnitDiagId, x.IsAttach, x.IsOtherFee, x.Memo, x.IsCharged, x.IsCancel, x.IsPrint, x.IsPrepared, x.IsIssue, x.IsToBack, x.IsBack });

            Property(x => x.OperDate).HasColumnName(@"OperDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int");
            Property(x => x.RecipeId).HasColumnName(@"RecipeId").IsRequired().HasColumnType("int");
            Property(x => x.ListNum).HasColumnName(@"ListNum").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.GroupNum).HasColumnName(@"GroupNum").IsRequired().HasColumnType("smallint");
            Property(x => x.Dosage).HasColumnName(@"Dosage").IsRequired().HasColumnType("decimal").HasPrecision(10,4);
            Property(x => x.UnitTakeId).HasColumnName(@"UnitTakeId").IsOptional().HasColumnType("int");
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.Days).HasColumnName(@"Days").IsOptional().HasColumnType("smallint");
            Property(x => x.Totality).HasColumnName(@"Totality").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitDiagId).HasColumnName(@"UnitDiagId").IsRequired().HasColumnType("int");
            Property(x => x.IsAttach).HasColumnName(@"IsAttach").IsRequired().HasColumnType("bit");
            Property(x => x.IsOtherFee).HasColumnName(@"IsOtherFee").IsRequired().HasColumnType("bit");
            Property(x => x.XdRpId).HasColumnName(@"XDRpId").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsCharged).HasColumnName(@"IsCharged").IsRequired().HasColumnType("bit");
            Property(x => x.IsCancel).HasColumnName(@"IsCancel").IsRequired().HasColumnType("bit");
            Property(x => x.CancelTime).HasColumnName(@"CancelTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CancelOperId).HasColumnName(@"CancelOperId").IsOptional().HasColumnType("int");
            Property(x => x.IsPrint).HasColumnName(@"IsPrint").IsRequired().HasColumnType("bit");
            Property(x => x.PrintTime).HasColumnName(@"PrintTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.PrintOperId).HasColumnName(@"PrintOperId").IsOptional().HasColumnType("int");
            Property(x => x.IsPrepared).HasColumnName(@"IsPrepared").IsRequired().HasColumnType("bit");
            Property(x => x.PrepareTime).HasColumnName(@"PrepareTime").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.PrepareOperId).HasColumnName(@"PrepareOperId").IsOptional().HasColumnType("int");
            Property(x => x.IsIssue).HasColumnName(@"IsIssue").IsRequired().HasColumnType("bit");
            Property(x => x.IssueTime).HasColumnName(@"IssueTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IssueOperId).HasColumnName(@"IssueOperId").IsOptional().HasColumnType("int");
            Property(x => x.IsToBack).HasColumnName(@"IsToBack").IsRequired().HasColumnType("bit");
            Property(x => x.IsBack).HasColumnName(@"IsBack").IsRequired().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsDoctorInput).HasColumnName(@"IsDoctorInput").IsOptional().HasColumnType("bit");
            Property(x => x.RecNum).HasColumnName(@"RecNum").IsOptional().HasColumnType("int");
            Property(x => x.RecipeTime).HasColumnName(@"RecipeTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.F5).HasColumnName(@"F5").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F6).HasColumnName(@"F6").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F7).HasColumnName(@"F7").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F8).HasColumnName(@"F8").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.AllPageNo).HasColumnName(@"AllPageNo").IsOptional().HasColumnType("int");
            Property(x => x.PageNo).HasColumnName(@"PageNo").IsOptional().HasColumnType("int");
            Property(x => x.IsBp).HasColumnName(@"IsBP").IsOptional().HasColumnType("bit");
            Property(x => x.BpReason).HasColumnName(@"BPReason").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
        }
    }
}
