using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemNameMultiMap : EntityTypeConfiguration<BsItemNameMulti>
    {
        public BsItemNameMultiMap()
            : this("dbo")
        {
        }

        public BsItemNameMultiMap(string schema)
        {
            ToTable("BsItemNameMulti", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.NameMulti).HasColumnName(@"NameMulti").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.WbMulti).HasColumnName(@"WbMulti").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.PyMulti).HasColumnName(@"PyMulti").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
