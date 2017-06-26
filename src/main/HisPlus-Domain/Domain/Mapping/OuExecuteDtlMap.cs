using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuExecuteDtlMap : EntityTypeConfiguration<OuExecuteDtl>
    {
        public OuExecuteDtlMap()
            : this("dbo")
        {
        }

        public OuExecuteDtlMap(string schema)
        {
            ToTable("OuExecuteDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
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
            Property(x => x.IsExecuted).HasColumnName(@"IsExecuted").IsOptional().HasColumnType("bit");
            Property(x => x.ExecutedTime).HasColumnName(@"ExecutedTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
        }
    }
}
