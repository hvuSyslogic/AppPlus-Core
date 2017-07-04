using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuRecipeChinMap : EntityTypeConfiguration<OuRecipeChin>
    {
        public OuRecipeChinMap()
            : this("dbo")
        {
        }

        public OuRecipeChinMap(string schema)
        {
            ToTable("OuRecipeChin", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RecipeId).HasColumnName(@"RecipeId").IsRequired().HasColumnType("int");
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.DecoctNum).HasColumnName(@"DecoctNum").IsRequired().HasColumnType("smallint");
            Property(x => x.LsCookSelf).HasColumnName(@"LsCookSelf").IsRequired().HasColumnType("smallint");
            Property(x => x.CookMinute).HasColumnName(@"CookMinute").IsOptional().HasColumnType("smallint");
            Property(x => x.LsFire).HasColumnName(@"LsFire").IsOptional().HasColumnType("smallint");
        }
    }
}
