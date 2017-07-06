using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class VipCardDiscountMap : EntityTypeConfiguration<VipCardDiscount>
    {
        public VipCardDiscountMap()
            : this("dbo")
        {
        }

        public VipCardDiscountMap(string schema)
        {
            ToTable("VipCardDiscount", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.VipCardId).HasColumnName(@"VipCardID").IsOptional().HasColumnType("int");
            Property(x => x.FeeId).HasColumnName(@"FeeID").IsOptional().HasColumnType("int");
            Property(x => x.Discount).HasColumnName(@"Discount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
        }
    }
}
