using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblBaseTableItemMap : EntityTypeConfiguration<GblBaseTableItem>
    {
        public GblBaseTableItemMap()
            : this("dbo")
        {
        }

        public GblBaseTableItemMap(string schema)
        {
            ToTable("GblBaseTableItem", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ParentId).HasColumnName(@"ParentID").IsRequired().HasColumnType("int");
            Property(x => x.BaseTable).HasColumnName(@"BaseTable").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.BllClassName).HasColumnName(@"BLLClassName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ModelClassName).HasColumnName(@"ModelClassName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ConfigType).HasColumnName(@"ConfigType").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsTable).HasColumnName(@"IsTable").IsRequired().HasColumnType("bit");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.RoleId).HasColumnName(@"RoleId").IsOptional().HasColumnType("int");
            Property(x => x.OrderField).HasColumnName(@"OrderField").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsToWmr).HasColumnName(@"IsToWmr").IsOptional().HasColumnType("bit");
        }
    }
}
