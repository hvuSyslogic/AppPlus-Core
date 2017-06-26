using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ElFormMap : EntityTypeConfiguration<ElForm>
    {
        public ElFormMap()
            : this("dbo")
        {
        }

        public ElFormMap(string schema)
        {
            ToTable("ElForm", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatMenuId).HasColumnName(@"PatMenuId").IsRequired().HasColumnType("int");
            Property(x => x.ElId).HasColumnName(@"ElId").IsOptional().HasColumnType("int");
            Property(x => x.X).HasColumnName(@"X").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
            Property(x => x.Y).HasColumnName(@"Y").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
            Property(x => x.Title).HasColumnName(@"Title").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
            Property(x => x.ReadOnly).HasColumnName(@"ReadOnly").IsOptional().HasColumnType("bit");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
