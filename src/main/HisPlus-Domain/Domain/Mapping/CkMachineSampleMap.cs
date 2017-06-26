using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkMachineSampleMap : EntityTypeConfiguration<CkMachineSample>
    {
        public CkMachineSampleMap()
            : this("dbo")
        {
        }

        public CkMachineSampleMap(string schema)
        {
            ToTable("CKMachineSample", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LabId).HasColumnName(@"LabID").IsRequired().HasColumnType("int");
            Property(x => x.SampleNum).HasColumnName(@"SampleNum").IsRequired().HasColumnType("nvarchar").HasMaxLength(14);
            Property(x => x.MatchDate).HasColumnName(@"MatchDate").IsRequired().HasColumnType("datetime");
            Property(x => x.SendStatus).HasColumnName(@"SendStatus").IsRequired().HasColumnType("bit");
            Property(x => x.MachineId).HasColumnName(@"MachineID").IsOptional().HasColumnType("int");
            Property(x => x.UserId).HasColumnName(@"UserID").IsRequired().HasColumnType("int");
        }
    }
}
