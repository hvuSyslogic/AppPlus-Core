using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkMachineFluidMap : EntityTypeConfiguration<CkMachineFluid>
    {
        public CkMachineFluidMap()
            : this("dbo")
        {
        }

        public CkMachineFluidMap(string schema)
        {
            ToTable("CKMachineFluid", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MachineId).HasColumnName(@"MachineID").IsRequired().HasColumnType("int");
            Property(x => x.BodyFluidId).HasColumnName(@"BodyFluidId").IsRequired().HasColumnType("int");
            Property(x => x.MachineFluidCode).HasColumnName(@"MachineFluidCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
        }
    }
}
