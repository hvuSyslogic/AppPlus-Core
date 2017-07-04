using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkItemRangeMap : EntityTypeConfiguration<CkItemRange>
    {
        public CkItemRangeMap()
            : this("dbo")
        {
        }

        public CkItemRangeMap(string schema)
        {
            ToTable("CkItemRange", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TestId).HasColumnName(@"TestId").IsRequired().HasColumnType("int");
            Property(x => x.Sex).HasColumnName(@"Sex").IsRequired().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.AgeFrom).HasColumnName(@"AgeFrom").IsRequired().HasColumnType("int");
            Property(x => x.AgeTo).HasColumnName(@"AgeTo").IsRequired().HasColumnType("int");
            Property(x => x.LowValue).HasColumnName(@"LowValue").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.HighValue).HasColumnName(@"HighValue").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.PanicLow).HasColumnName(@"PanicLow").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.PanicHigh).HasColumnName(@"PanicHigh").IsRequired().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.PrintResult).HasColumnName(@"PrintResult").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TextRange).HasColumnName(@"TextRange").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.LsAgeUnit).HasColumnName(@"LsAgeUnit").IsOptional().HasColumnType("smallint");
            Property(x => x.MachineId).HasColumnName(@"MachineId").IsOptional().HasColumnType("int");
        }
    }
}
