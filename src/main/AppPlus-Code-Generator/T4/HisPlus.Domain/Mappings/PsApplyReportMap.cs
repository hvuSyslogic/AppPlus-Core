using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class PsApplyReportMap : EntityTypeConfiguration<PsApplyReport>
    {
        public PsApplyReportMap()
            : this("dbo")
        {
        }

        public PsApplyReportMap(string schema)
        {
            ToTable("PsApplyReport", schema);
            HasKey(x => x.Id);

            Property(x => x.ApplyNo).HasColumnName(@"ApplyNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.IsCancel).HasColumnName(@"IsCancel").IsRequired().HasColumnType("bit");
            Property(x => x.CancelTime).HasColumnName(@"CancelTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CancelOperId).HasColumnName(@"CancelOperId").IsOptional().HasColumnType("int");
            Property(x => x.XType).HasColumnName(@"XType").IsRequired().HasColumnType("smallint");
            Property(x => x.IsPre).HasColumnName(@"IsPre").IsRequired().HasColumnType("bit");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.IsCharged).HasColumnName(@"IsCharged").IsRequired().HasColumnType("bit");
            Property(x => x.IsConfirm).HasColumnName(@"IsConfirm").IsRequired().HasColumnType("bit");
            Property(x => x.ConfirmTime).HasColumnName(@"ConfirmTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Equipment).HasColumnName(@"Equipment").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ApplyMemo).HasColumnName(@"ApplyMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.ExecLocId).HasColumnName(@"ExecLocId").IsOptional().HasColumnType("int");
            Property(x => x.CheckTime).HasColumnName(@"CheckTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CheckOperId).HasColumnName(@"CheckOperId").IsOptional().HasColumnType("int");
            Property(x => x.ReportTime).HasColumnName(@"ReportTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ReportOperId).HasColumnName(@"ReportOperId").IsOptional().HasColumnType("int");
            Property(x => x.AuthOperId).HasColumnName(@"AuthOperId").IsOptional().HasColumnType("int");
            Property(x => x.CheckBody).HasColumnName(@"CheckBody").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.CheckParm).HasColumnName(@"CheckParm").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.CheckDesc).HasColumnName(@"CheckDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.CheckResult).HasColumnName(@"CheckResult").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.CheckAdvice).HasColumnName(@"CheckAdvice").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.IsAbNormal).HasColumnName(@"IsAbNormal").IsRequired().HasColumnType("bit");
            Property(x => x.Summary).HasColumnName(@"Summary").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Diagnose).HasColumnName(@"Diagnose").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.CheckId).HasColumnName(@"CheckId").IsOptional().HasColumnType("int");
            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ExecuteId).HasColumnName(@"ExecuteId").IsOptional().HasColumnType("int");
            Property(x => x.CallGroup).HasColumnName(@"CallGroup").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsStatus).HasColumnName(@"lsStatus").IsOptional().HasColumnType("smallint");
        }
    }
}
