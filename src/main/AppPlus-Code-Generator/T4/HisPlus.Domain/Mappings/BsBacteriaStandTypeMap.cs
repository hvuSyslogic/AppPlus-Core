using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsBacteriaStandTypeMap : EntityTypeConfiguration<BsBacteriaStandType>
    {
        public BsBacteriaStandTypeMap()
            : this("dbo")
        {
        }

        public BsBacteriaStandTypeMap(string schema)
        {
            ToTable("BsBacteriaStandType", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(2);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
