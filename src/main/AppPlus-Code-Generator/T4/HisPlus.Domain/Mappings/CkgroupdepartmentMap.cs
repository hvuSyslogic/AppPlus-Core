using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkgroupdepartmentMap : EntityTypeConfiguration<Ckgroupdepartment>
    {
        public CkgroupdepartmentMap()
            : this("dbo")
        {
        }

        public CkgroupdepartmentMap(string schema)
        {
            ToTable("CKGROUPDEPARTMENT", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"CODE").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(40);
            Property(x => x.Name).HasColumnName(@"NAME").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Isactive).HasColumnName(@"ISACTIVE").IsRequired().HasColumnType("bit");
            Property(x => x.Wbcode).HasColumnName(@"WBCODE").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Pycode).HasColumnName(@"PYCODE").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Operid).HasColumnName(@"OPERID").IsOptional().HasColumnType("int");
            Property(x => x.Opertime).HasColumnName(@"OPERTIME").IsOptional().HasColumnType("datetime");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.Iconindex).HasColumnName(@"ICONINDEX").IsRequired().HasColumnType("int");
        }
    }
}
