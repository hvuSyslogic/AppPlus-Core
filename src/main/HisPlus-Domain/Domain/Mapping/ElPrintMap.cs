using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ElPrintMap : EntityTypeConfiguration<ElPrint>
    {
        public ElPrintMap()
            : this("dbo")
        {
        }

        public ElPrintMap(string schema)
        {
            ToTable("ElPrint", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatMenuId).HasColumnName(@"PatMenuId").IsRequired().HasColumnType("int");
            Property(x => x.Title).HasColumnName(@"Title").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PrnConfig).HasColumnName(@"PrnConfig").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
