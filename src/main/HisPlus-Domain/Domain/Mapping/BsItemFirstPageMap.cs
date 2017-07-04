using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemFirstPageMap : EntityTypeConfiguration<BsItemFirstPage>
    {
        public BsItemFirstPageMap()
            : this("dbo")
        {
        }

        public BsItemFirstPageMap(string schema)
        {
            ToTable("BsItemFirstPage", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.PsFeeId).HasColumnName(@"PsFeeId").IsOptional().HasColumnType("int");
        }
    }
}
