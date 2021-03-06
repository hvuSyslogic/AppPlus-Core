using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsBacteriaShuMap : EntityTypeConfiguration<BsBacteriaShu>
    {
        public BsBacteriaShuMap()
            : this("dbo")
        {
        }

        public BsBacteriaShuMap(string schema)
        {
            ToTable("BsBacteriaShu", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(6);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
            Property(x => x.TypeId).HasColumnName(@"TypeId").IsRequired().HasColumnType("int");
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.GramsId).HasColumnName(@"GramsId").IsOptional().HasColumnType("int");
        }
    }
}
