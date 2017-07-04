using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemFrequencyMap : EntityTypeConfiguration<BsItemFrequency>
    {
        public BsItemFrequencyMap()
            : this("dbo")
        {
        }

        public BsItemFrequencyMap(string schema)
        {
            ToTable("BsItemFrequency", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsRequired().HasColumnType("int");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
