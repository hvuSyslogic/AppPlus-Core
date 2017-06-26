using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ElPatFormTestMap : EntityTypeConfiguration<ElPatFormTest>
    {
        public ElPatFormTestMap()
            : this("dbo")
        {
        }

        public ElPatFormTestMap(string schema)
        {
            ToTable("ElPatFormTest", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatFormId).HasColumnName(@"PatFormId").IsRequired().HasColumnType("int");
            Property(x => x.TestId).HasColumnName(@"TestId").IsRequired().HasColumnType("int");
            Property(x => x.Result).HasColumnName(@"Result").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Unit).HasColumnName(@"Unit").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.LsRefFlag).HasColumnName(@"LsRefFlag").IsRequired().HasColumnType("smallint");
            Property(x => x.LowValue).HasColumnName(@"LowValue").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.HighValue).HasColumnName(@"HighValue").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.TextRange).HasColumnName(@"TextRange").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.LabId).HasColumnName(@"LabId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
