using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsLocationRoomWindowMap : EntityTypeConfiguration<BsLocationRoomWindow>
    {
        public BsLocationRoomWindowMap()
            : this("dbo")
        {
        }

        public BsLocationRoomWindowMap(string schema)
        {
            ToTable("BsLocationRoomWindow", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.RoomWindowName).HasColumnName(@"RoomWindowName").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PrinterName).HasColumnName(@"PrinterName").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
