using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemPeopleMap : EntityTypeConfiguration<BsItemPeople>
    {
        public BsItemPeopleMap()
            : this("dbo")
        {
        }

        public BsItemPeopleMap(string schema)
        {
            ToTable("BsItemPeople", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.Sex).HasColumnName(@"Sex").IsRequired().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.AgeFrom).HasColumnName(@"AgeFrom").IsRequired().HasColumnType("int");
            Property(x => x.AgeTo).HasColumnName(@"AgeTo").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
