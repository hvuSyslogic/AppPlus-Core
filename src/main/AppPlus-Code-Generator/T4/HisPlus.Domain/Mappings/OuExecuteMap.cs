using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuExecuteMap : EntityTypeConfiguration<OuExecute>
    {
        public OuExecuteMap()
            : this("dbo")
        {
        }

        public OuExecuteMap(string schema)
        {
            ToTable("OuExecute", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsRequired().HasColumnType("int");
            Property(x => x.LsRepType).HasColumnName(@"LsRepType").IsRequired().HasColumnType("smallint");
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.RecipeId).HasColumnName(@"RecipeId").IsRequired().HasColumnType("int");
            Property(x => x.GroupNum).HasColumnName(@"GroupNum").IsRequired().HasColumnType("smallint");
            Property(x => x.NDay).HasColumnName(@"NDay").IsRequired().HasColumnType("smallint");
            Property(x => x.NTime).HasColumnName(@"NTime").IsRequired().HasColumnType("smallint");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsExecuted).HasColumnName(@"IsExecuted").IsOptional().HasColumnType("bit");
        }
    }
}
