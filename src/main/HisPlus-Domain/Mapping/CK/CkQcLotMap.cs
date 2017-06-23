using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkQcLotMap : EntityTypeConfiguration<CkQcLot>
    {
        public CkQcLotMap()
            : this("dbo")
        {
        }

        public CkQcLotMap(string schema)
        {
            ToTable("CkQcLot", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.SampleNum).HasColumnName(@"SampleNum").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.MachineId).HasColumnName(@"MachineId").IsRequired().HasColumnType("int");
            Property(x => x.ExpiryDate).HasColumnName(@"ExpiryDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.CtrlId).HasColumnName(@"CtrlId").IsRequired().HasColumnType("int");
        }
    }
}
