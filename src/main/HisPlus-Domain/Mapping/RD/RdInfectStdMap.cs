using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RdInfectStdMap : EntityTypeConfiguration<RdInfectStd>
    {
        public RdInfectStdMap()
            : this("dbo")
        {
        }

        public RdInfectStdMap(string schema)
        {
            ToTable("RdInfectStd", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.Code).HasColumnName(@"Code").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LsCardType).HasColumnName(@"LsCardType").IsOptional().HasColumnType("smallint");
            Property(x => x.Gestation).HasColumnName(@"Gestation").IsOptional().HasColumnType("int");
            Property(x => x.LsZone).HasColumnName(@"LsZone").IsOptional().HasColumnType("smallint");
            Property(x => x.LsCancelType).HasColumnName(@"LsCancelType").IsOptional().HasColumnType("smallint");
            Property(x => x.IllDate).HasColumnName(@"IllDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.DiagDate).HasColumnName(@"DiagDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.DeadDate).HasColumnName(@"DeadDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IllId).HasColumnName(@"IllId").IsOptional().HasColumnType("int");
            Property(x => x.LsClincSymptom).HasColumnName(@"LsClincSymptom").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ReportUnit).HasColumnName(@"ReportUnit").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.IllIdCor).HasColumnName(@"IllIdCor").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsCTrust).HasColumnName(@"LsCTrust").IsOptional().HasColumnType("smallint");
            Property(x => x.LsCTiter).HasColumnName(@"LsCTiter").IsOptional().HasColumnType("smallint");
            Property(x => x.LsCtppa).HasColumnName(@"LsCTPPA").IsOptional().HasColumnType("smallint");
            Property(x => x.LsCOther).HasColumnName(@"LsCOther").IsOptional().HasColumnType("smallint");
            Property(x => x.LsETrust).HasColumnName(@"LsETrust").IsOptional().HasColumnType("smallint");
            Property(x => x.LsETiter).HasColumnName(@"LsETiter").IsOptional().HasColumnType("smallint");
            Property(x => x.LsEtppa).HasColumnName(@"LsETPPA").IsOptional().HasColumnType("smallint");
            Property(x => x.LsEIgM).HasColumnName(@"LsEIgM").IsOptional().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.JName).HasColumnName(@"JName").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.LocId).HasColumnName(@"LocId").IsOptional().HasColumnType("int");
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.ReciOperId).HasColumnName(@"ReciOperId").IsOptional().HasColumnType("int");
            Property(x => x.ReportDate).HasColumnName(@"ReportDate").IsOptional().HasColumnType("smalldatetime");
        }
    }
}
