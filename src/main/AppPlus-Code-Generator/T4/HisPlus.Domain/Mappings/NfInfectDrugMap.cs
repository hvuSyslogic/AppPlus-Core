using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class NfInfectDrugMap : EntityTypeConfiguration<NfInfectDrug>
    {
        public NfInfectDrugMap()
            : this("dbo")
        {
        }

        public NfInfectDrugMap(string schema)
        {
            ToTable("NfInfectDrug", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InfectId).HasColumnName(@"InfectId").IsRequired().HasColumnType("int");
            Property(x => x.BaseDrugId).HasColumnName(@"BaseDrugId").IsRequired().HasColumnType("int");
            Property(x => x.Dosage).HasColumnName(@"Dosage").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitTakeId).HasColumnName(@"UnitTakeId").IsOptional().HasColumnType("int");
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.Days).HasColumnName(@"Days").IsOptional().HasColumnType("smallint");
        }
    }
}
