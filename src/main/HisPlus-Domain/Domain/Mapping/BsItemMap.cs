using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemMap : EntityTypeConfiguration<BsItem>
    {
        public BsItemMap()
            : this("dbo")
        {
        }

        public BsItemMap(string schema)
        {
            ToTable("BsItem", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LsGroupType).HasColumnName(@"LsGroupType").IsRequired().HasColumnType("smallint");
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.StrokeCode).HasColumnName(@"StrokeCode").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.OtherCode).HasColumnName(@"OtherCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.GroupMainId).HasColumnName(@"GroupMainId").IsRequired().HasColumnType("int");
            Property(x => x.GroupSubId).HasColumnName(@"GroupSubId").IsOptional().HasColumnType("int");
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LongDesc).HasColumnName(@"LongDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.EngDesc).HasColumnName(@"EngDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Spec).HasColumnName(@"Spec").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UnitInId).HasColumnName(@"UnitInId").IsOptional().HasColumnType("int");
            Property(x => x.PriceIn).HasColumnName(@"PriceIn").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.UnitDiagId).HasColumnName(@"UnitDiagId").IsOptional().HasColumnType("int");
            Property(x => x.PriceDiag).HasColumnName(@"PriceDiag").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.AddPercent).HasColumnName(@"AddPercent").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.LsRpType).HasColumnName(@"LsRpType").IsOptional().HasColumnType("smallint");
            Property(x => x.Dosage).HasColumnName(@"Dosage").IsOptional().HasColumnType("decimal").HasPrecision(10,4);
            Property(x => x.UnitTakeId).HasColumnName(@"UnitTakeId").IsOptional().HasColumnType("int");
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.FeeMzId).HasColumnName(@"FeeMzId").IsOptional().HasColumnType("int");
            Property(x => x.FeeZyId).HasColumnName(@"FeeZyId").IsOptional().HasColumnType("int");
            Property(x => x.LsGfType).HasColumnName(@"LsGfType").IsOptional().HasColumnType("smallint");
            Property(x => x.GfFixDisc).HasColumnName(@"GfFixDisc").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.OptionPrice).HasColumnName(@"OptionPrice").IsOptional().HasColumnType("bit");
            Property(x => x.LimitTotalMz).HasColumnName(@"LimitTotalMz").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.LimitTotalZy).HasColumnName(@"LimitTotalZy").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.TypeGfxeId).HasColumnName(@"TypeGFXEId").IsOptional().HasColumnType("int");
            Property(x => x.IsSpecSum).HasColumnName(@"IsSpecSum").IsOptional().HasColumnType("bit");
            Property(x => x.IsNew).HasColumnName(@"IsNew").IsOptional().HasColumnType("bit");
            Property(x => x.IsOnlyForSys).HasColumnName(@"IsOnlyForSys").IsOptional().HasColumnType("bit");
            Property(x => x.IsRpForbid).HasColumnName(@"IsRpForbid").IsOptional().HasColumnType("bit");
            Property(x => x.IsChildAdd).HasColumnName(@"IsChildAdd").IsOptional().HasColumnType("bit");
            Property(x => x.IsBedFee).HasColumnName(@"IsBedFee").IsOptional().HasColumnType("bit");
            Property(x => x.IsOpsAdd).HasColumnName(@"IsOpsAdd").IsOptional().HasColumnType("bit");
            Property(x => x.LsfeeTurn).HasColumnName(@"LsfeeTurn").IsOptional().HasColumnType("smallint");
            Property(x => x.LsAdviceType).HasColumnName(@"LsAdviceType").IsOptional().HasColumnType("smallint");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.LisCode).HasColumnName(@"LISCode").IsOptional().HasColumnType("int");
            Property(x => x.CoverPicture).HasColumnName(@"CoverPicture").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(200);
            Property(x => x.MemoPicture).HasColumnName(@"MemoPicture").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(200);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(3000);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsOptional().HasColumnType("smallint");
            Property(x => x.IsInoculate).HasColumnName(@"IsInoculate").IsOptional().HasColumnType("bit");
            Property(x => x.PriceHighLine).HasColumnName(@"PriceHighLine").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("smallint");
            Property(x => x.GroupSubId2).HasColumnName(@"GroupSubId2").IsOptional().HasColumnType("int");
            Property(x => x.LastTime).HasColumnName(@"LastTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.PriceSub).HasColumnName(@"PriceSub").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.CheckId).HasColumnName(@"CheckId").IsOptional().HasColumnType("int");
            Property(x => x.NurseId).HasColumnName(@"NurseId").IsOptional().HasColumnType("int");
            Property(x => x.CureId).HasColumnName(@"CureId").IsOptional().HasColumnType("int");
            Property(x => x.DrugId).HasColumnName(@"DrugID").IsOptional().HasColumnType("int");
            Property(x => x.CopyId).HasColumnName(@"CopyId").IsOptional().HasColumnType("int");
            Property(x => x.MzUnitTotal).HasColumnName(@"MzUnitTotal").IsOptional().HasColumnType("int");
            Property(x => x.ZyUnitTotal).HasColumnName(@"ZyUnitTotal").IsOptional().HasColumnType("int");
            Property(x => x.IsMtDrug).HasColumnName(@"IsMtDrug").IsOptional().HasColumnType("bit");
            Property(x => x.PackageSpec).HasColumnName(@"PackageSpec").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsCitySum).HasColumnName(@"IsCitySum").IsOptional().HasColumnType("bit");
            Property(x => x.YbAvgPrice).HasColumnName(@"YBAvgPrice").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.TyxmCode).HasColumnName(@"TYXMCode").IsOptional().HasColumnType("int");
            Property(x => x.TyxmName).HasColumnName(@"TYXMName").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
        }
    }
}
