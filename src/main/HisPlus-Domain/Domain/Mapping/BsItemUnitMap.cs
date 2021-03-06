using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemUnitMap : EntityTypeConfiguration<BsItemUnit>
    {
        public BsItemUnitMap()
            : this("dbo")
        {
        }

        public BsItemUnitMap(string schema)
        {
            ToTable("BsItemUnit", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.IsForYk).HasColumnName(@"IsForYk").IsRequired().HasColumnType("bit");
            Property(x => x.IsForYf).HasColumnName(@"IsForYf").IsRequired().HasColumnType("bit");
            Property(x => x.IsForRecipe).HasColumnName(@"IsForRecipe").IsRequired().HasColumnType("bit");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
