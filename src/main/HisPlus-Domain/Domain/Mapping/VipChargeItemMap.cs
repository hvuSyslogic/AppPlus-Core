using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class VipChargeItemMap : EntityTypeConfiguration<VipChargeItem>
    {
        public VipChargeItemMap()
            : this("dbo")
        {
        }

        public VipChargeItemMap(string schema)
        {
            ToTable("VipChargeItem", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.VccId).HasColumnName(@"VccId").IsOptional().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.TotalCount).HasColumnName(@"TotalCount").IsOptional().HasColumnType("int");
            Property(x => x.DiscountPrice).HasColumnName(@"DiscountPrice").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.IsDisCount).HasColumnName(@"IsDisCount").IsOptional().HasColumnType("bit");
        }
    }
}
