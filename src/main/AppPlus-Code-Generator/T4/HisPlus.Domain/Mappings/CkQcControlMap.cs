using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkQcControlMap : EntityTypeConfiguration<CkQcControl>
    {
        public CkQcControlMap()
            : this("dbo")
        {
        }

        public CkQcControlMap(string schema)
        {
            ToTable("CkQcControl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.MachineId).HasColumnName(@"MachineID").IsRequired().HasColumnType("int");
        }
    }
}
