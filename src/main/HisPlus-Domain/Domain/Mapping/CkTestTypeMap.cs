using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkTestTypeMap : EntityTypeConfiguration<CkTestType>
    {
        public CkTestTypeMap()
            : this("dbo")
        {
        }

        public CkTestTypeMap(string schema)
        {
            ToTable("CkTestType", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(6);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.TestGroupId).HasColumnName(@"TestGroupId").IsRequired().HasColumnType("int");
            Property(x => x.IsLab).HasColumnName(@"is_Lab").IsRequired().HasColumnType("bit");
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.GroupMain).HasColumnName(@"GroupMain").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.GroupSub).HasColumnName(@"GroupSub").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
