using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class TmpItemMap : EntityTypeConfiguration<TmpItem>
    {
        public TmpItemMap()
            : this("dbo")
        {
        }

        public TmpItemMap(string schema)
        {
            ToTable("TmpItem", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MenuId).HasColumnName(@"MenuId").IsOptional().HasColumnType("int");
            Property(x => x.CKey).HasColumnName(@"CKey").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CType).HasColumnName(@"CType").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Value).HasColumnName(@"Value").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.LsType).HasColumnName(@"LsType").IsOptional().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.TempName).HasColumnName(@"TempName").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
        }
    }
}
