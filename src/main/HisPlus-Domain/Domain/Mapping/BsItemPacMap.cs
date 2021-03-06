using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemPacMap : EntityTypeConfiguration<BsItemPac>
    {
        public BsItemPacMap()
            : this("dbo")
        {
        }

        public BsItemPacMap(string schema)
        {
            ToTable("BsItemPacs", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.XType).HasColumnName(@"XType").IsOptional().HasColumnType("smallint");
            Property(x => x.Equipment).HasColumnName(@"Equipment").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CheckBody).HasColumnName(@"CheckBody").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
