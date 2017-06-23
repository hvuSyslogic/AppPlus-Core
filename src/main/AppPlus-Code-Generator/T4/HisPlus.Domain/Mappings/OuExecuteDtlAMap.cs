using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuExecuteDtlAMap : EntityTypeConfiguration<OuExecuteDtlA>
    {
        public OuExecuteDtlAMap()
            : this("dbo")
        {
        }

        public OuExecuteDtlAMap(string schema)
        {
            ToTable("OuExecuteDtl_A", schema);
            HasKey(x => new { x.OperDate, x.Id, x.ExecuteId, x.ListNum, x.ItemId, x.Dosage, x.UnitId, x.UsageId, x.FrequencyId, x.Days });

            Property(x => x.OperDate).HasColumnName(@"OperDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int");
            Property(x => x.ExecuteId).HasColumnName(@"ExecuteId").IsRequired().HasColumnType("int");
            Property(x => x.RecipeDtlId).HasColumnName(@"RecipeDtlId").IsOptional().HasColumnType("int");
            Property(x => x.ListNum).HasColumnName(@"listNum").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.Dosage).HasColumnName(@"Dosage").IsRequired().HasColumnType("decimal").HasPrecision(10,4);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsRequired().HasColumnType("int");
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsRequired().HasColumnType("int");
            Property(x => x.Days).HasColumnName(@"Days").IsRequired().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Totality).HasColumnName(@"Totality").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitDiagId).HasColumnName(@"UnitDiagId").IsOptional().HasColumnType("int");
            Property(x => x.IssueTime).HasColumnName(@"IssueTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.BackTime).HasColumnName(@"BackTime").IsOptional().HasColumnType("smalldatetime");
        }
    }
}
