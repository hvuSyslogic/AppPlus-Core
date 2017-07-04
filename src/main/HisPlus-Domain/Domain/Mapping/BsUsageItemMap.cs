using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsUsageItemMap : EntityTypeConfiguration<BsUsageItem>
    {
        public BsUsageItemMap()
            : this("dbo")
        {
        }

        public BsUsageItemMap(string schema)
        {
            ToTable("BsUsageItem", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.Totality).HasColumnName(@"Totality").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.LsUseArea).HasColumnName(@"LsUseArea").IsRequired().HasColumnType("smallint");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.IsBaby).HasColumnName(@"IsBaby").IsOptional().HasColumnType("bit");
            Property(x => x.IsWomen).HasColumnName(@"IsWomen").IsOptional().HasColumnType("bit");
            Property(x => x.IsMen).HasColumnName(@"IsMen").IsOptional().HasColumnType("bit");
            Property(x => x.IsOlder).HasColumnName(@"IsOlder").IsOptional().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsDrugTwoDay).HasColumnName(@"IsDrugTwoDay").IsOptional().HasColumnType("bit");
        }
    }
}
