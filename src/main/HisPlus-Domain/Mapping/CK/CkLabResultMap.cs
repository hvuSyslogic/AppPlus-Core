using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkLabResultMap : EntityTypeConfiguration<CkLabResult>
    {
        public CkLabResultMap()
            : this("dbo")
        {
        }

        public CkLabResultMap(string schema)
        {
            ToTable("CkLabResult", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LabId).HasColumnName(@"LabId").IsRequired().HasColumnType("int");
            Property(x => x.TestId).HasColumnName(@"TestId").IsRequired().HasColumnType("int");
            Property(x => x.LastResult).HasColumnName(@"LastResult").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Result).HasColumnName(@"Result").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Unit).HasColumnName(@"Unit").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.LsRefFlag).HasColumnName(@"LsRefFlag").IsRequired().HasColumnType("smallint");
            Property(x => x.IsPanic).HasColumnName(@"IsPanic").IsRequired().HasColumnType("bit");
            Property(x => x.IsDalta).HasColumnName(@"IsDalta").IsRequired().HasColumnType("bit");
            Property(x => x.DalAbsolute).HasColumnName(@"DalAbsolute").IsRequired().HasColumnType("decimal");
            Property(x => x.DalPercent).HasColumnName(@"DalPercent").IsRequired().HasColumnType("decimal");
            Property(x => x.LowValue).HasColumnName(@"LowValue").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.HighValue).HasColumnName(@"HighValue").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.PanicLow).HasColumnName(@"PanicLow").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.PanicHigh).HasColumnName(@"PanicHigh").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.IsPass).HasColumnName(@"IsPass").IsRequired().HasColumnType("bit");
            Property(x => x.IsReport).HasColumnName(@"IsReport").IsRequired().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IsPrint).HasColumnName(@"IsPrint").IsRequired().HasColumnType("bit");
            Property(x => x.PrintTime).HasColumnName(@"PrintTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.PrintOperId).HasColumnName(@"PrintOperId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.TextRange).HasColumnName(@"TextRange").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
        }
    }
}
