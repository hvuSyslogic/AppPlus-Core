using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsPriceAddMap : EntityTypeConfiguration<BsPriceAdd>
    {
        public BsPriceAddMap()
            : this("dbo")
        {
        }

        public BsPriceAddMap(string schema)
        {
            ToTable("BsPriceAdd", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PriceLow).HasColumnName(@"PriceLow").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.PriceHigh).HasColumnName(@"PriceHigh").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.AddPercent).HasColumnName(@"AddPercent").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.AddPrice).HasColumnName(@"AddPrice").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.FeeIds).HasColumnName(@"FeeIds").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
