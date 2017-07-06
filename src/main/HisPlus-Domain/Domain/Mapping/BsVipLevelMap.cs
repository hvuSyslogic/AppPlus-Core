using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsVipLevelMap : EntityTypeConfiguration<BsVipLevel>
    {
        public BsVipLevelMap()
            : this("dbo")
        {
        }

        public BsVipLevelMap(string schema)
        {
            ToTable("BsVipLevel", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.VipTypeId).HasColumnName(@"VipTypeId").IsOptional().HasColumnType("int");
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Discount).HasColumnName(@"Discount").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.DefaultBalance).HasColumnName(@"DefaultBalance").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("int");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.InValidDays).HasColumnName(@"InValidDays").IsOptional().HasColumnType("int");
            Property(x => x.IsVipPrice).HasColumnName(@"IsVipPrice").IsOptional().HasColumnType("bit");
            Property(x => x.IsStoredCard).HasColumnName(@"IsStoredCard").IsOptional().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
        }
    }
}
