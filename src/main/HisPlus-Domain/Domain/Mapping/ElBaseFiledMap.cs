using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ElBaseFiledMap : EntityTypeConfiguration<ElBaseFiled>
    {
        public ElBaseFiledMap()
            : this("dbo")
        {
        }

        public ElBaseFiledMap(string schema)
        {
            ToTable("ElBaseFiled", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsDataType).HasColumnName(@"LsDataType").IsOptional().HasColumnType("smallint");
            Property(x => x.Lengh).HasColumnName(@"Lengh").IsOptional().HasColumnType("smallint");
            Property(x => x.EditMask).HasColumnName(@"EditMask").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ToolTips).HasColumnName(@"ToolTips").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ErrorTips).HasColumnName(@"ErrorTips").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsHasChild).HasColumnName(@"IsHasChild").IsOptional().HasColumnType("bit");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsEncrypt).HasColumnName(@"IsEncrypt").IsOptional().HasColumnType("bit");
            Property(x => x.IsLog).HasColumnName(@"IsLog").IsOptional().HasColumnType("bit");
        }
    }
}
