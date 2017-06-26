using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkMachineNoPassageMap : EntityTypeConfiguration<CkMachineNoPassage>
    {
        public CkMachineNoPassageMap()
            : this("dbo")
        {
        }

        public CkMachineNoPassageMap(string schema)
        {
            ToTable("CKMachineNoPassage", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MachineId).HasColumnName(@"MachineID").IsRequired().HasColumnType("int");
            Property(x => x.PassAgeNum).HasColumnName(@"PassAgeNum").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.TestResuslt).HasColumnName(@"TestResuslt").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ResultDate).HasColumnName(@"ResultDate").IsOptional().HasColumnType("datetime");
        }
    }
}
