using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemAttachMap : EntityTypeConfiguration<BsItemAttach>
    {
        public BsItemAttachMap()
            : this("dbo")
        {
        }

        public BsItemAttachMap(string schema)
        {
            ToTable("BsItemAttach", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId1).HasColumnName(@"ItemId1").IsRequired().HasColumnType("int");
            Property(x => x.ItemId2).HasColumnName(@"ItemId2").IsRequired().HasColumnType("int");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.Totality).HasColumnName(@"Totality").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.LsUseArea).HasColumnName(@"LsUseArea").IsOptional().HasColumnType("smallint");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
        }
    }
}
