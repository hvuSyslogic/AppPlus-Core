using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ElFormDtlMap : EntityTypeConfiguration<ElFormDtl>
    {
        public ElFormDtlMap()
            : this("dbo")
        {
        }

        public ElFormDtlMap(string schema)
        {
            ToTable("ElFormDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatMenuId).HasColumnName(@"PatMenuId").IsRequired().HasColumnType("int");
            Property(x => x.ElId).HasColumnName(@"ElId").IsOptional().HasColumnType("int");
            Property(x => x.NColumn).HasColumnName(@"NColumn").IsOptional().HasColumnType("smallint");
            Property(x => x.NRow).HasColumnName(@"NRow").IsOptional().HasColumnType("smallint");
            Property(x => x.ColumnSpan).HasColumnName(@"ColumnSpan").IsOptional().HasColumnType("smallint");
            Property(x => x.Title).HasColumnName(@"Title").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsReadOnly).HasColumnName(@"IsReadOnly").IsOptional().HasColumnType("bit");
            Property(x => x.IsRequire).HasColumnName(@"IsRequire").IsOptional().HasColumnType("bit");
            Property(x => x.DefultValue).HasColumnName(@"DefultValue").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsAlignment).HasColumnName(@"LsAlignment").IsOptional().HasColumnType("smallint");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsInherit).HasColumnName(@"IsInherit").IsOptional().HasColumnType("bit");
            Property(x => x.ColWidth).HasColumnName(@"ColWidth").IsOptional().HasColumnType("smallint");
            Property(x => x.FontSize).HasColumnName(@"FontSize").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.FontColor).HasColumnName(@"FontColor").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
