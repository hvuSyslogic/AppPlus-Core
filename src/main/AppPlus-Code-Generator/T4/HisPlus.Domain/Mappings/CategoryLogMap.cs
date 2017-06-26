using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CategoryLogMap : EntityTypeConfiguration<CategoryLog>
    {
        public CategoryLogMap()
            : this("dbo")
        {
        }

        public CategoryLogMap(string schema)
        {
            ToTable("CategoryLog", schema);
            HasKey(x => x.CategoryLogId);

            Property(x => x.CategoryLogId).HasColumnName(@"CategoryLogID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CategoryId).HasColumnName(@"CategoryID").IsRequired().HasColumnType("int");
            Property(x => x.LogId).HasColumnName(@"LogID").IsRequired().HasColumnType("int");
        }
    }
}
