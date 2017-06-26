using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
            : this("dbo")
        {
        }

        public CategoryMap(string schema)
        {
            ToTable("Category", schema);
            HasKey(x => x.CategoryId);

            Property(x => x.CategoryId).HasColumnName(@"CategoryID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CategoryName).HasColumnName(@"CategoryName").IsRequired().HasColumnType("nvarchar").HasMaxLength(64);
        }
    }
}
