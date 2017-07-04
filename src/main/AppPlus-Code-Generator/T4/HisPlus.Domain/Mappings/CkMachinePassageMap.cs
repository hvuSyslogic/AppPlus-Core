using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkMachinePassageMap : EntityTypeConfiguration<CkMachinePassage>
    {
        public CkMachinePassageMap()
            : this("dbo")
        {
        }

        public CkMachinePassageMap(string schema)
        {
            ToTable("CKMachinePassage", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MachineId).HasColumnName(@"MachineID").IsRequired().HasColumnType("int");
            Property(x => x.TestId).HasColumnName(@"TestID").IsRequired().HasColumnType("int");
            Property(x => x.PassAgeNum).HasColumnName(@"PassAgeNum").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Modulus).HasColumnName(@"Modulus").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.IsQc).HasColumnName(@"IsQc").IsRequired().HasColumnType("bit");
        }
    }
}
