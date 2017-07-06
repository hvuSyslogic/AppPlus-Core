using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkLabMap : EntityTypeConfiguration<CkLab>
    {
        public CkLabMap()
            : this("dbo")
        {
        }

        public CkLabMap(string schema)
        {
            ToTable("CkLab", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LabNum).HasColumnName(@"LabNum").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.LsSource).HasColumnName(@"LsSource").IsRequired().HasColumnType("smallint");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.RefLocation).HasColumnName(@"RefLocation").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IllHistory).HasColumnName(@"IllHistory").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Diagnose).HasColumnName(@"Diagnose").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IsPriority).HasColumnName(@"IsPriority").IsRequired().HasColumnType("bit");
            Property(x => x.CollectTime).HasColumnName(@"CollectTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CollectOperId).HasColumnName(@"CollectOperId").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.IsCancel).HasColumnName(@"IsCancel").IsRequired().HasColumnType("bit");
            Property(x => x.CancelTime).HasColumnName(@"CancelTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CancelOperId).HasColumnName(@"CancelOperId").IsOptional().HasColumnType("int");
            Property(x => x.IsPass).HasColumnName(@"IsPass").IsOptional().HasColumnType("bit");
            Property(x => x.ReportMemo).HasColumnName(@"ReportMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.TechMemo).HasColumnName(@"TechMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.OtherMemo).HasColumnName(@"OtherMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.RecieveTime).HasColumnName(@"RecieveTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.RecieveOperId).HasColumnName(@"RecieveOperId").IsOptional().HasColumnType("int");
            Property(x => x.ResultTime).HasColumnName(@"ResultTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ResultOperId).HasColumnName(@"ResultOperId").IsOptional().HasColumnType("int");
            Property(x => x.AuthTime).HasColumnName(@"AuthTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.AuthOperId).HasColumnName(@"AuthOperId").IsOptional().HasColumnType("int");
            Property(x => x.ReportTime).HasColumnName(@"ReportTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ReportOperId).HasColumnName(@"ReportOperId").IsOptional().HasColumnType("int");
            Property(x => x.LsStatus).HasColumnName(@"LsStatus").IsRequired().HasColumnType("smallint");
            Property(x => x.TestTypeId).HasColumnName(@"TestTypeId").IsOptional().HasColumnType("int");
            Property(x => x.CollectLocId).HasColumnName(@"CollectLocId").IsOptional().HasColumnType("int");
            Property(x => x.TogetherNum).HasColumnName(@"TogetherNum").IsOptional().HasColumnType("int");
            Property(x => x.SjOperId).HasColumnName(@"SJOperId").IsOptional().HasColumnType("int");
            Property(x => x.SjOperTime).HasColumnName(@"SJOperTime").IsOptional().HasColumnType("datetime");
        }
    }
}
