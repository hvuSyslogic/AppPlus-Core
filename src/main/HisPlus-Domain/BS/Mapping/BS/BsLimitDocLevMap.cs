using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsLimitDocLevMap : EntityTypeConfiguration<BsLimitDocLev>
    {
        public BsLimitDocLevMap()
            : this("dbo")
        {
        }

        public BsLimitDocLevMap(string schema)
        {
            ToTable("BsLimitDocLev", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LimitGroupId).HasColumnName(@"LimitGroupId").IsRequired().HasColumnType("int");
            Property(x => x.DocLevId).HasColumnName(@"DocLevId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("int");
            Property(x => x.TypeGfxeId).HasColumnName(@"TypeGFXEId").IsOptional().HasColumnType("int");
            Property(x => x.LimitFeeMz).HasColumnName(@"LimitFeeMz").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LimitFeeZy).HasColumnName(@"LimitFeeZy").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LsLimitType).HasColumnName(@"LsLimitType").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
        }
    }
}
