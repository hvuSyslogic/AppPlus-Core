using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkResultMap : EntityTypeConfiguration<CkResult>
    {
        public CkResultMap()
            : this("dbo")
        {
        }

        public CkResultMap(string schema)
        {
            ToTable("CkResult", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CheckId).HasColumnName(@"CheckId").IsRequired().HasColumnType("int");
            Property(x => x.TestId).HasColumnName(@"TestId").IsRequired().HasColumnType("int");
            Property(x => x.LastResult).HasColumnName(@"LastResult").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Result).HasColumnName(@"Result").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LsRefFlag).HasColumnName(@"LsRefFlag").IsOptional().HasColumnType("smallint");
            Property(x => x.IsPanic).HasColumnName(@"IsPanic").IsOptional().HasColumnType("bit");
            Property(x => x.IsDalta).HasColumnName(@"IsDalta").IsOptional().HasColumnType("bit");
            Property(x => x.DalAbsolute).HasColumnName(@"DalAbsolute").IsOptional().HasColumnType("float");
            Property(x => x.DalPercent).HasColumnName(@"DalPercent").IsOptional().HasColumnType("float");
            Property(x => x.LowValue).HasColumnName(@"LowValue").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.HighValue).HasColumnName(@"HighValue").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.PanicLow).HasColumnName(@"PanicLow").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.PanicHigh).HasColumnName(@"PanicHigh").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.IsPass).HasColumnName(@"IsPass").IsOptional().HasColumnType("bit");
            Property(x => x.ReportDate).HasColumnName(@"ReportDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ReportBy).HasColumnName(@"ReportBy").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.IsPrint).HasColumnName(@"IsPrint").IsOptional().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.ParentId).HasColumnName(@"ParentID").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.TextRange).HasColumnName(@"TextRange").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Price).HasColumnName(@"Price").IsOptional().HasColumnType("decimal").HasPrecision(12,2);
            Property(x => x.Discount).HasColumnName(@"Discount").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.TestGroupId).HasColumnName(@"TestGroupId").IsOptional().HasColumnType("int");
            Property(x => x.F5).HasColumnName(@"F5").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F6).HasColumnName(@"F6").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F7).HasColumnName(@"F7").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F8).HasColumnName(@"F8").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
