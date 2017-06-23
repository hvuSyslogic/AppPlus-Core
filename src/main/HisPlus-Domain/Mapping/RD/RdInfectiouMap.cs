using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RdInfectiouMap : EntityTypeConfiguration<RdInfectiou>
    {
        public RdInfectiouMap()
            : this("dbo")
        {
        }

        public RdInfectiouMap(string schema)
        {
            ToTable("RdInfectious", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.Code).HasColumnName(@"Code").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LsCardType).HasColumnName(@"LsCardType").IsOptional().HasColumnType("smallint");
            Property(x => x.LsCensus).HasColumnName(@"LsCensus").IsOptional().HasColumnType("smallint");
            Property(x => x.LsZone).HasColumnName(@"LsZone").IsOptional().HasColumnType("smallint");
            Property(x => x.Midwife).HasColumnName(@"Midwife").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.LsCancelType).HasColumnName(@"LsCancelType").IsOptional().HasColumnType("smallint");
            Property(x => x.IllDate).HasColumnName(@"IllDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.InTime).HasColumnName(@"InTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.DeadDate).HasColumnName(@"DeadDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.DiagDate).HasColumnName(@"DiagDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LsPreventive).HasColumnName(@"LsPreventive").IsOptional().HasColumnType("smallint");
            Property(x => x.IllIdCor).HasColumnName(@"IllIdCor").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.CancelMemo).HasColumnName(@"CancelMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.ReportUnit).HasColumnName(@"ReportUnit").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.LocId).HasColumnName(@"LocId").IsOptional().HasColumnType("int");
            Property(x => x.Phone).HasColumnName(@"Phone").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ReportDate).HasColumnName(@"ReportDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.JIllId).HasColumnName(@"JIllId").IsOptional().HasColumnType("int");
            Property(x => x.YIllId).HasColumnName(@"YIllId").IsOptional().HasColumnType("int");
            Property(x => x.BIllId).HasColumnName(@"BIllId").IsOptional().HasColumnType("int");
            Property(x => x.QIllId).HasColumnName(@"QIllId").IsOptional().HasColumnType("int");
            Property(x => x.JName).HasColumnName(@"JName").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.ReciOperId).HasColumnName(@"ReciOperId").IsOptional().HasColumnType("int");
            Property(x => x.IsWrite).HasColumnName(@"IsWrite").IsOptional().HasColumnType("int");
            Property(x => x.Canceloperid).HasColumnName(@"Canceloperid").IsOptional().HasColumnType("int");
            Property(x => x.Chkoperid).HasColumnName(@"Chkoperid").IsOptional().HasColumnType("int");
            Property(x => x.Printstart).HasColumnName(@"Printstart").IsOptional().HasColumnType("bit");
            Property(x => x.ChkOperTime).HasColumnName(@"ChkOperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.CancelOperTime).HasColumnName(@"CancelOperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.Lscanceltype2).HasColumnName(@"lscanceltype2").IsOptional().HasColumnType("smallint");
            Property(x => x.Hospid).HasColumnName(@"Hospid").IsOptional().HasColumnType("int");
            Property(x => x.WorkType).HasColumnName(@"WorkType").IsOptional().HasColumnType("int");
            Property(x => x.QilLness).HasColumnName(@"QilLness").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AfpId).HasColumnName(@"AfpID").IsOptional().HasColumnType("int");
        }
    }
}
