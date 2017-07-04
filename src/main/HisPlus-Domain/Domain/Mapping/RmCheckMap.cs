using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RmCheckMap : EntityTypeConfiguration<RmCheck>
    {
        public RmCheckMap()
            : this("dbo")
        {
        }

        public RmCheckMap(string schema)
        {
            ToTable("RmCheck", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillNo).HasColumnName(@"BillNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.RoomId).HasColumnName(@"RoomId").IsRequired().HasColumnType("int");
            Property(x => x.CheckTime).HasColumnName(@"CheckTime").IsOptional().HasColumnType("datetime");
            Property(x => x.CheckAmount).HasColumnName(@"CheckAmount").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
        }
    }
}
