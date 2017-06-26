using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class PsExecuteMap : EntityTypeConfiguration<PsExecute>
    {
        public PsExecuteMap()
            : this("dbo")
        {
        }

        public PsExecuteMap(string schema)
        {
            ToTable("PsExecute", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplyId).HasColumnName(@"ApplyId").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RecipeId).HasColumnName(@"RecipeId").IsOptional().HasColumnType("int");
            Property(x => x.IsExecuted).HasColumnName(@"IsExecuted").IsOptional().HasColumnType("bit");
            Property(x => x.ExecutedTime).HasColumnName(@"ExecutedTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ExecutedOperId).HasColumnName(@"ExecutedOperId").IsOptional().HasColumnType("int");
            Property(x => x.ExecLocId).HasColumnName(@"ExecLocId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
