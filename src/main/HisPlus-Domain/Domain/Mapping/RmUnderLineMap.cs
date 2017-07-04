using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RmUnderLineMap : EntityTypeConfiguration<RmUnderLine>
    {
        public RmUnderLineMap()
            : this("dbo")
        {
        }

        public RmUnderLineMap(string schema)
        {
            ToTable("RmUnderLine", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RoomId).HasColumnName(@"RoomId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.UnderLine).HasColumnName(@"UnderLine").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UperLine).HasColumnName(@"UperLine").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.Normal).HasColumnName(@"Normal").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("smallint");
            Property(x => x.IsStop).HasColumnName(@"IsStop").IsOptional().HasColumnType("bit");
        }
    }
}
