using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkLabDtlMap : EntityTypeConfiguration<CkLabDtl>
    {
        public CkLabDtlMap()
            : this("dbo")
        {
        }

        public CkLabDtlMap(string schema)
        {
            ToTable("CkLabDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LabId).HasColumnName(@"LabId").IsRequired().HasColumnType("int");
            Property(x => x.TestId).HasColumnName(@"TestId").IsRequired().HasColumnType("int");
            Property(x => x.SourceId).HasColumnName(@"SourceId").IsOptional().HasColumnType("int");
            Property(x => x.TubeTypeId).HasColumnName(@"TubeTypeId").IsOptional().HasColumnType("int");
            Property(x => x.IsDownLoad).HasColumnName(@"IsDownLoad").IsRequired().HasColumnType("bit");
            Property(x => x.IsPrint).HasColumnName(@"IsPrint").IsRequired().HasColumnType("bit");
            Property(x => x.PrintTime).HasColumnName(@"PrintTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.PrintOperId).HasColumnName(@"PrintOperId").IsOptional().HasColumnType("int");
            Property(x => x.IsBilled).HasColumnName(@"IsBilled").IsRequired().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ParentId).HasColumnName(@"ParentID").IsOptional().HasColumnType("int");
            Property(x => x.RecipeDtlId).HasColumnName(@"RecipeDtlId").IsOptional().HasColumnType("int");
            Property(x => x.DetailId).HasColumnName(@"DetailId").IsOptional().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
