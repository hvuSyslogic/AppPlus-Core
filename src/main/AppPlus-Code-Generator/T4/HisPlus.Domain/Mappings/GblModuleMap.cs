using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblModuleMap : EntityTypeConfiguration<GblModule>
    {
        public GblModuleMap()
            : this("dbo")
        {
        }

        public GblModuleMap(string schema)
        {
            ToTable("GblModule", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FunctionId).HasColumnName(@"FunctionID").IsOptional().HasColumnType("int");
            Property(x => x.MenuId).HasColumnName(@"MenuId").IsOptional().HasColumnType("int");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
