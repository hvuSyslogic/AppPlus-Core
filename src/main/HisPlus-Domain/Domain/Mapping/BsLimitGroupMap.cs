using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsLimitGroupMap : EntityTypeConfiguration<BsLimitGroup>
    {
        public BsLimitGroupMap()
            : this("dbo")
        {
        }

        public BsLimitGroupMap(string schema)
        {
            ToTable("BsLimitGroup", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(6);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsOptional().HasColumnType("int");
            Property(x => x.TypeGfxeId).HasColumnName(@"TypeGFXEId").IsOptional().HasColumnType("int");
            Property(x => x.LimitFeeMz).HasColumnName(@"LimitFeeMz").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LimitFeeZy).HasColumnName(@"LimitFeeZy").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LsLimitType).HasColumnName(@"LsLimitType").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.DocLevelId).HasColumnName(@"DocLevelId").IsOptional().HasColumnType("int");
        }
    }
}
