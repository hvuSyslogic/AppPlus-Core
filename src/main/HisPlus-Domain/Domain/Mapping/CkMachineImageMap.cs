using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkMachineImageMap : EntityTypeConfiguration<CkMachineImage>
    {
        public CkMachineImageMap()
            : this("dbo")
        {
        }

        public CkMachineImageMap(string schema)
        {
            ToTable("CKMachineImage", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LabId).HasColumnName(@"LabID").IsRequired().HasColumnType("int");
            Property(x => x.SampleNum).HasColumnName(@"SampleNum").IsRequired().HasColumnType("nvarchar").HasMaxLength(14);
            Property(x => x.MachineId).HasColumnName(@"MachineID").IsRequired().HasColumnType("int");
            Property(x => x.LabImage).HasColumnName(@"LabImage").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
            Property(x => x.ImageType).HasColumnName(@"ImageType").IsRequired().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.IsDisplay).HasColumnName(@"IsDisplay").IsRequired().HasColumnType("bit");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
        }
    }
}
