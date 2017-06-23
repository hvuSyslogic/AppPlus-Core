using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InInvoYbMap : EntityTypeConfiguration<InInvoYb>
    {
        public InInvoYbMap()
            : this("dbo")
        {
        }

        public InInvoYbMap(string schema)
        {
            ToTable("InInvoYB", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InvoId).HasColumnName(@"InvoId").IsOptional().HasColumnType("int");
            Property(x => x.FactYp).HasColumnName(@"FactYP").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.FactJz).HasColumnName(@"FactJZ").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AllFactYp).HasColumnName(@"AllFactYP").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AllFactJz).HasColumnName(@"AllFactJZ").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OtherFact).HasColumnName(@"OtherFact").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.YbDisc).HasColumnName(@"YBDisc").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Insurance).HasColumnName(@"Insurance").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.UnderLine).HasColumnName(@"UnderLine").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.InsuranceB1).HasColumnName(@"InsuranceB1").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.InsuranceB2).HasColumnName(@"InsuranceB2").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.InsuranceB3).HasColumnName(@"InsuranceB3").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PaySelf).HasColumnName(@"PaySelf").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SelfPayDisc).HasColumnName(@"SelfPayDisc").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SelfPayB1).HasColumnName(@"SelfPayB1").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SelfPayB2).HasColumnName(@"SelfPayB2").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SelfPayB3).HasColumnName(@"SelfPayB3").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OutTopSelfFee).HasColumnName(@"OutTopSelfFee").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SelfFee).HasColumnName(@"SelfFee").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.BchzylbxAmount).HasColumnName(@"BchzylbxAmount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AccountAttribute).HasColumnName(@"AccountAttribute").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.BcProportion).HasColumnName(@"BcProportion").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.FdAmount).HasColumnName(@"FdAmount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MedicalNo).HasColumnName(@"MedicalNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.NdybcAmount).HasColumnName(@"NdybcAmount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.TgProportion).HasColumnName(@"TgProportion").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.WbhProportion).HasColumnName(@"WbhProportion").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ZyyProportion).HasColumnName(@"ZyyProportion").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ZzProportion).HasColumnName(@"ZzProportion").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KbcAmount).HasColumnName(@"KbcAmount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KbcA1).HasColumnName(@"KbcA1").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KbcA2).HasColumnName(@"KbcA2").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KbcA3).HasColumnName(@"KbcA3").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KbcA4).HasColumnName(@"KbcA4").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KbcA5).HasColumnName(@"KbcA5").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KbcA6).HasColumnName(@"KbcA6").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KbcA12).HasColumnName(@"KbcA12").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KbcA13).HasColumnName(@"KbcA13").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KbcA16).HasColumnName(@"KbcA16").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KbcA17).HasColumnName(@"KbcA17").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KbcA18).HasColumnName(@"KbcA18").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KbcA19).HasColumnName(@"KbcA19").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KbcA20).HasColumnName(@"KbcA20").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SjbcA1).HasColumnName(@"SjbcA1").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SjbcA2).HasColumnName(@"SjbcA2").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SjbcA3).HasColumnName(@"SjbcA3").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SjbcA4).HasColumnName(@"SjbcA4").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SjbcA5).HasColumnName(@"SjbcA5").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SjbcA6).HasColumnName(@"SjbcA6").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SjbcA12).HasColumnName(@"SjbcA12").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SjbcA13).HasColumnName(@"SjbcA13").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SjbcA16).HasColumnName(@"SjbcA16").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SjbcA17).HasColumnName(@"SjbcA17").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SjbcA18).HasColumnName(@"SjbcA18").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SjbcA19).HasColumnName(@"SjbcA19").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SjbcA20).HasColumnName(@"SjbcA20").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OriginalAmount).HasColumnName(@"OriginalAmount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OriginalA1).HasColumnName(@"OriginalA1").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OriginalA2).HasColumnName(@"OriginalA2").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OriginalA3).HasColumnName(@"OriginalA3").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OriginalA4).HasColumnName(@"OriginalA4").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OriginalA5).HasColumnName(@"OriginalA5").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OriginalA6).HasColumnName(@"OriginalA6").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OriginalA12).HasColumnName(@"OriginalA12").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OriginalA13).HasColumnName(@"OriginalA13").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OriginalA16).HasColumnName(@"OriginalA16").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OriginalA17).HasColumnName(@"OriginalA17").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OriginalA18).HasColumnName(@"OriginalA18").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OriginalA19).HasColumnName(@"OriginalA19").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OriginalA20).HasColumnName(@"OriginalA20").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.F5).HasColumnName(@"F5").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F6).HasColumnName(@"F6").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.F7).HasColumnName(@"F7").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.F8).HasColumnName(@"F8").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.InvoYbTime).HasColumnName(@"InvoYBTime").IsOptional().HasColumnType("datetime");
        }
    }
}
