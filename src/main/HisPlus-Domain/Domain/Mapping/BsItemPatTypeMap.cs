using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemPatTypeMap : EntityTypeConfiguration<BsItemPatType>
    {
        public BsItemPatTypeMap()
            : this("dbo")
        {
        }

        public BsItemPatTypeMap(string schema)
        {
            ToTable("BsItemPatType", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.DiscDiag).HasColumnName(@"DiscDiag").IsRequired().HasColumnType("decimal").HasPrecision(8,4);
            Property(x => x.DiscIn).HasColumnName(@"DiscIn").IsRequired().HasColumnType("decimal").HasPrecision(8,4);
            Property(x => x.InvMzItemId).HasColumnName(@"InvMzItemId").IsRequired().HasColumnType("int");
            Property(x => x.InvInItemId).HasColumnName(@"InvInItemId").IsRequired().HasColumnType("int");
            Property(x => x.LimitGroupId).HasColumnName(@"LimitGroupId").IsOptional().HasColumnType("int");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
