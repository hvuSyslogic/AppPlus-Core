using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class NfInfectTestMap : EntityTypeConfiguration<NfInfectTest>
    {
        public NfInfectTestMap()
            : this("dbo")
        {
        }

        public NfInfectTestMap(string schema)
        {
            ToTable("NfInfectTest", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.InfectId).HasColumnName(@"InfectId").IsRequired().HasColumnType("int");
            Property(x => x.LabNo).HasColumnName(@"LabNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SourceId).HasColumnName(@"SourceId").IsRequired().HasColumnType("int");
            Property(x => x.LabTime).HasColumnName(@"LabTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
