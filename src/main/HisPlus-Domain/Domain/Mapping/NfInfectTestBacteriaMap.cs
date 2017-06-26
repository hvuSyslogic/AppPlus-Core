using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class NfInfectTestBacteriaMap : EntityTypeConfiguration<NfInfectTestBacteria>
    {
        public NfInfectTestBacteriaMap()
            : this("dbo")
        {
        }

        public NfInfectTestBacteriaMap(string schema)
        {
            ToTable("NfInfectTestBacteria", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TestId).HasColumnName(@"TestId").IsRequired().HasColumnType("int");
            Property(x => x.BacteriaId).HasColumnName(@"BacteriaId").IsRequired().HasColumnType("int");
            Property(x => x.BaseDrugId).HasColumnName(@"BaseDrugId").IsOptional().HasColumnType("int");
            Property(x => x.LsResult).HasColumnName(@"LsResult").IsOptional().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
