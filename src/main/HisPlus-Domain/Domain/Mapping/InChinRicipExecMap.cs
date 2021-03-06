using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InChinRicipExecMap : EntityTypeConfiguration<InChinRicipExec>
    {
        public InChinRicipExecMap()
            : this("dbo")
        {
        }

        public InChinRicipExecMap(string schema)
        {
            ToTable("InChinRicipExec", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RecipeId).HasColumnName(@"RecipeId").IsRequired().HasColumnType("int");
            Property(x => x.ExecTime).HasColumnName(@"ExecTime").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
