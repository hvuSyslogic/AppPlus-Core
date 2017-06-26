using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BaseTableRoleMap : EntityTypeConfiguration<BaseTableRole>
    {
        public BaseTableRoleMap()
            : this("dbo")
        {
        }

        public BaseTableRoleMap(string schema)
        {
            ToTable("BaseTableRole", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BaseTableId).HasColumnName(@"BaseTableId").IsOptional().HasColumnType("int");
            Property(x => x.RoleId).HasColumnName(@"RoleId").IsOptional().HasColumnType("int");
        }
    }
}
