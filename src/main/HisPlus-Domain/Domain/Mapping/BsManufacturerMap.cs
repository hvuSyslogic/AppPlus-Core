using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsManufacturerMap : EntityTypeConfiguration<BsManufacturer>
    {
        public BsManufacturerMap()
            : this("dbo")
        {
        }

        public BsManufacturerMap(string schema)
        {
            ToTable("BsManufacturer", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"CODE").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(8);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsKind).HasColumnName(@"LsKind").IsOptional().HasColumnType("smallint");
            Property(x => x.AreaCode).HasColumnName(@"AreaCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Address).HasColumnName(@"Address").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.LsType).HasColumnName(@"LsType").IsOptional().HasColumnType("smallint");
        }
    }
}
