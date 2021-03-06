using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblRoleModuleMap : EntityTypeConfiguration<GblRoleModule>
    {
        public GblRoleModuleMap()
            : this("dbo")
        {
        }

        public GblRoleModuleMap(string schema)
        {
            ToTable("GblRoleModule", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RoleId).HasColumnName(@"RoleId").IsRequired().HasColumnType("int");
            Property(x => x.ModuleId).HasColumnName(@"ModuleId").IsRequired().HasColumnType("int");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
