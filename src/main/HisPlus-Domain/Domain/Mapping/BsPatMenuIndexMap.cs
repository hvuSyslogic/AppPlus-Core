using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsPatMenuIndexMap : EntityTypeConfiguration<BsPatMenuIndex>
    {
        public BsPatMenuIndexMap()
            : this("dbo")
        {
        }

        public BsPatMenuIndexMap(string schema)
        {
            ToTable("BsPatMenuIndex", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.PatMenuId).HasColumnName(@"PatMenuId").IsRequired().HasColumnType("int");
            Property(x => x.ParentId).HasColumnName(@"ParentID").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RecordId).HasColumnName(@"RecordId").IsRequired().HasColumnType("int");
            Property(x => x.Tips).HasColumnName(@"Tips").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
