using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblSystemMenuMap : EntityTypeConfiguration<GblSystemMenu>
    {
        public GblSystemMenuMap()
            : this("dbo")
        {
        }

        public GblSystemMenuMap(string schema)
        {
            ToTable("GblSystemMenu", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SystemId).HasColumnName(@"SystemId").IsRequired().HasColumnType("int");
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsOptional().HasColumnType("smallint");
            Property(x => x.Hint).HasColumnName(@"Hint").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Shortcut).HasColumnName(@"Shortcut").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.ParentId).HasColumnName(@"ParentID").IsOptional().HasColumnType("int");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("smallint");
            Property(x => x.IsMostUsed).HasColumnName(@"IsMostUsed").IsOptional().HasColumnType("bit");
            Property(x => x.IsBeginGroup).HasColumnName(@"IsBeginGroup").IsOptional().HasColumnType("bit");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
