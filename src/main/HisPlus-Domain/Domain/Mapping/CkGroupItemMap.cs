using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkGroupItemMap : EntityTypeConfiguration<CkGroupItem>
    {
        public CkGroupItemMap()
            : this("dbo")
        {
        }

        public CkGroupItemMap(string schema)
        {
            ToTable("CkGroupItem", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyGroupId).HasColumnName(@"CompanyGroupId").IsRequired().HasColumnType("int");
            Property(x => x.TestId).HasColumnName(@"TestId").IsRequired().HasColumnType("int");
            Property(x => x.ParentId).HasColumnName(@"ParentID").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AppId).HasColumnName(@"AppId").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
