using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class VipReckoningChargeMap : EntityTypeConfiguration<VipReckoningCharge>
    {
        public VipReckoningChargeMap()
            : this("dbo")
        {
        }

        public VipReckoningChargeMap(string schema)
        {
            ToTable("VipReckoningCharge", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.VipCardId).HasColumnName(@"VipCardId").IsOptional().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.TotalCount).HasColumnName(@"TotalCount").IsOptional().HasColumnType("int");
            Property(x => x.ConsumeCount).HasColumnName(@"ConsumeCount").IsOptional().HasColumnType("int");
            Property(x => x.LastChargeTime).HasColumnName(@"LastChargeTime").IsOptional().HasColumnType("datetime");
            Property(x => x.DiscountPrice).HasColumnName(@"DiscountPrice").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.IsDiscount).HasColumnName(@"IsDiscount").IsOptional().HasColumnType("bit");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.Comments).HasColumnName(@"Comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
        }
    }
}
