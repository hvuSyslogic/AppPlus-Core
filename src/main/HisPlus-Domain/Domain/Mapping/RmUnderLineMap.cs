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
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("smallint");
        }
    }
}
