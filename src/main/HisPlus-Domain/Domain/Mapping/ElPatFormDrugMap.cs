using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ElPatFormDrugMap : EntityTypeConfiguration<ElPatFormDrug>
    {
        public ElPatFormDrugMap()
            : this("dbo")
        {
        }

        public ElPatFormDrugMap(string schema)
        {
            ToTable("ElPatFormDrug", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatFormId).HasColumnName(@"PatFormId").IsOptional().HasColumnType("int");
            Property(x => x.ListNum).HasColumnName(@"ListNum").IsOptional().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.GroupNum).HasColumnName(@"GroupNum").IsOptional().HasColumnType("smallint");
            Property(x => x.Dosage).HasColumnName(@"Dosage").IsOptional().HasColumnType("decimal").HasPrecision(10,4);
            Property(x => x.UnitTakeId).HasColumnName(@"UnitTakeId").IsOptional().HasColumnType("int");
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.Days).HasColumnName(@"Days").IsOptional().HasColumnType("smallint");
            Property(x => x.Totality).HasColumnName(@"Totality").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitDiagId).HasColumnName(@"UnitDiagId").IsOptional().HasColumnType("int");
            Property(x => x.IsAttach).HasColumnName(@"IsAttach").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
