using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CsAppDeptTypeMap : EntityTypeConfiguration<CsAppDeptType>
    {
        public CsAppDeptTypeMap()
            : this("dbo")
        {
        }

        public CsAppDeptTypeMap(string schema)
        {
            ToTable("CsAppDeptType", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(5);
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
        }
    }
}
