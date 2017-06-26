using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ElTipMap : EntityTypeConfiguration<ElTip>
    {
        public ElTipMap()
            : this("dbo")
        {
        }

        public ElTipMap(string schema)
        {
            ToTable("ElTips", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatMenuId).HasColumnName(@"PatMenuId").IsOptional().HasColumnType("int");
            Property(x => x.WhereFormat).HasColumnName(@"WhereFormat").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Arg1).HasColumnName(@"Arg1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Arg2).HasColumnName(@"Arg2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Arg3).HasColumnName(@"Arg3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Arg4).HasColumnName(@"Arg4").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Arg5).HasColumnName(@"Arg5").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Tips).HasColumnName(@"Tips").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.IsFollow).HasColumnName(@"IsFollow").IsOptional().HasColumnType("bit");
            Property(x => x.ActiveDays).HasColumnName(@"ActiveDays").IsOptional().HasColumnType("smallint");
            Property(x => x.RoleIds).HasColumnName(@"RoleIds").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
