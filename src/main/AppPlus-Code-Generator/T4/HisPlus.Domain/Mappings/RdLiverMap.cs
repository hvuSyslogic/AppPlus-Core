using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RdLiverMap : EntityTypeConfiguration<RdLiver>
    {
        public RdLiverMap()
            : this("dbo")
        {
        }

        public RdLiverMap(string schema)
        {
            ToTable("RdLiver", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.Code).HasColumnName(@"Code").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LsCardType).HasColumnName(@"LsCardType").IsOptional().HasColumnType("smallint");
            Property(x => x.LsCensus).HasColumnName(@"LsCensus").IsOptional().HasColumnType("smallint");
            Property(x => x.JName).HasColumnName(@"JName").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.LsZone).HasColumnName(@"LsZone").IsOptional().HasColumnType("smallint");
            Property(x => x.LsCancelType).HasColumnName(@"LsCancelType").IsOptional().HasColumnType("smallint");
            Property(x => x.IllDate).HasColumnName(@"IllDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.InTime).HasColumnName(@"InTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.DeadDate).HasColumnName(@"DeadDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.DiagDate).HasColumnName(@"DiagDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LsDiagType).HasColumnName(@"LsDiagType").IsOptional().HasColumnType("smallint");
            Property(x => x.LsPreventive).HasColumnName(@"LsPreventive").IsOptional().HasColumnType("smallint");
            Property(x => x.LsClinicType).HasColumnName(@"LsClinicType").IsOptional().HasColumnType("smallint");
            Property(x => x.LsIllSource).HasColumnName(@"LsIllSource").IsOptional().HasColumnType("smallint");
            Property(x => x.Alt).HasColumnName(@"ALT").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Tbil).HasColumnName(@"Tbil").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.LsKHavIgM).HasColumnName(@"LsK_HAVIgM").IsOptional().HasColumnType("smallint");
            Property(x => x.HavRna).HasColumnName(@"HAV_RNA").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.LsHbsAg).HasColumnName(@"LsHbs_Ag").IsOptional().HasColumnType("smallint");
            Property(x => x.LsKHBs).HasColumnName(@"LsK_HBs").IsOptional().HasColumnType("smallint");
            Property(x => x.LsHBeAg).HasColumnName(@"LsHBeAg").IsOptional().HasColumnType("smallint");
            Property(x => x.LsKHBe).HasColumnName(@"LsK_HBe").IsOptional().HasColumnType("smallint");
            Property(x => x.LsKHBc).HasColumnName(@"LsK_HBc").IsOptional().HasColumnType("smallint");
            Property(x => x.LsKHBcIgM).HasColumnName(@"LsK_HBcIgM").IsOptional().HasColumnType("smallint");
            Property(x => x.HbvDna).HasColumnName(@"HBV_DNA").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.LsKHcv).HasColumnName(@"LsK_HCV").IsOptional().HasColumnType("smallint");
            Property(x => x.HcvRna).HasColumnName(@"HCV_RNA").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.LsKHdvIgM).HasColumnName(@"LsK_HDVIgM").IsOptional().HasColumnType("smallint");
            Property(x => x.KHdv).HasColumnName(@"K_HDV").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.HdvRna).HasColumnName(@"HDV_RNA").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.LsKHevIgM).HasColumnName(@"LsK_HEVIgM").IsOptional().HasColumnType("smallint");
            Property(x => x.LsKHev).HasColumnName(@"LsK_HEV").IsOptional().HasColumnType("smallint");
            Property(x => x.HevRna).HasColumnName(@"HEV_RNA").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.IllIdCor).HasColumnName(@"IllIdCor").IsOptional().HasColumnType("int");
            Property(x => x.CancelMemo).HasColumnName(@"CancelMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ReportUnit).HasColumnName(@"ReportUnit").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.LocId).HasColumnName(@"LocId").IsOptional().HasColumnType("int");
            Property(x => x.Phone).HasColumnName(@"Phone").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ReportDate).HasColumnName(@"ReportDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ReportPerson).HasColumnName(@"ReportPerson").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.JReportDate).HasColumnName(@"JReportDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.JReportPerson).HasColumnName(@"JReportPerson").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.ReciOperId).HasColumnName(@"ReciOperId").IsOptional().HasColumnType("int");
        }
    }
}
