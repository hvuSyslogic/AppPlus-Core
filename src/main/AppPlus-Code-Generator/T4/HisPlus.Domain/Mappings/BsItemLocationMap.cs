using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemLocationMap : EntityTypeConfiguration<BsItemLocation>
    {
        public BsItemLocationMap()
            : this("dbo")
        {
        }

        public BsItemLocationMap(string schema)
        {
            ToTable("BsItemLocation", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.FeeHsMzId).HasColumnName(@"FeeHsMzId").IsOptional().HasColumnType("int");
            Property(x => x.FeeHsZyId).HasColumnName(@"FeeHsZyId").IsOptional().HasColumnType("int");
            Property(x => x.Dosage).HasColumnName(@"Dosage").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitTake).HasColumnName(@"UnitTake").IsOptional().HasColumnType("int");
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.IsLocDrug).HasColumnName(@"IsLocDrug").IsRequired().HasColumnType("bit");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.ExecLocId).HasColumnName(@"ExecLocId").IsOptional().HasColumnType("int");
            Property(x => x.IsLocUse).HasColumnName(@"IsLocUse").IsOptional().HasColumnType("bit");
        }
    }
}
