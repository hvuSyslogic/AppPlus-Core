using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsUserWordMap : EntityTypeConfiguration<BsUserWord>
    {
        public BsUserWordMap()
            : this("dbo")
        {
        }

        public BsUserWordMap(string schema)
        {
            ToTable("BsUserWord", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.KeyType).HasColumnName(@"KeyType").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Content).HasColumnName(@"Content").IsOptional().HasColumnType("ntext").IsMaxLength();
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsOptional().HasColumnType("smallint");
        }
    }
}
