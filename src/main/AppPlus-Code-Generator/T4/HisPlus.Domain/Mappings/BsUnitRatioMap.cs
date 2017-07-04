using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsUnitRatioMap : EntityTypeConfiguration<BsUnitRatio>
    {
        public BsUnitRatioMap()
            : this("dbo")
        {
        }

        public BsUnitRatioMap(string schema)
        {
            ToTable("BsUnitRatio", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.UnitId1).HasColumnName(@"UnitId1").IsRequired().HasColumnType("int");
            Property(x => x.UnitId2).HasColumnName(@"UnitId2").IsRequired().HasColumnType("int");
            Property(x => x.DrugRatio).HasColumnName(@"DrugRatio").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
