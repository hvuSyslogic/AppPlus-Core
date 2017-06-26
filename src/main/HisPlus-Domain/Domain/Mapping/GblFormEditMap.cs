using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblFormEditMap : EntityTypeConfiguration<GblFormEdit>
    {
        public GblFormEditMap()
            : this("dbo")
        {
        }

        public GblFormEditMap(string schema)
        {
            ToTable("GblFormEdit", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FormName).HasColumnName(@"FormName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FiledName).HasColumnName(@"FiledName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsAdd).HasColumnName(@"IsAdd").IsOptional().HasColumnType("bit");
            Property(x => x.ToolTip).HasColumnName(@"ToolTip").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsExcept).HasColumnName(@"IsExcept").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
