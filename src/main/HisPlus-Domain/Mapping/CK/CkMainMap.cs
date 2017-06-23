using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkMainMap : EntityTypeConfiguration<CkMain>
    {
        public CkMainMap()
            : this("dbo")
        {
        }

        public CkMainMap(string schema)
        {
            ToTable("CkMain", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CheckNo).HasColumnName(@"CheckNo").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.CheckTime).HasColumnName(@"CheckTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.CompanyCkeckId).HasColumnName(@"CompanyCkeckId").IsOptional().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IsCancel).HasColumnName(@"IsCancel").IsRequired().HasColumnType("bit");
            Property(x => x.CancelOperTime).HasColumnName(@"CancelOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CancelOperId).HasColumnName(@"CancelOperId").IsOptional().HasColumnType("int");
            Property(x => x.CancelMemo).HasColumnName(@"CancelMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.RecieveTime).HasColumnName(@"RecieveTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.RecieveOperId).HasColumnName(@"RecieveOperId").IsOptional().HasColumnType("int");
            Property(x => x.ReportTime).HasColumnName(@"ReportTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ReportOperId).HasColumnName(@"ReportOperId").IsOptional().HasColumnType("int");
            Property(x => x.LsStatus).HasColumnName(@"LsStatus").IsOptional().HasColumnType("smallint");
            Property(x => x.ReportMemo).HasColumnName(@"ReportMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.TechMemo).HasColumnName(@"TechMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.OtherMemo).HasColumnName(@"OtherMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.CompanyId).HasColumnName(@"CompanyId").IsOptional().HasColumnType("int");
            Property(x => x.CompanyGroupId).HasColumnName(@"CompanyGroupId").IsOptional().HasColumnType("int");
            Property(x => x.RptFileName).HasColumnName(@"RptFileName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsPay).HasColumnName(@"IsPay").IsOptional().HasColumnType("bit");
        }
    }
}
