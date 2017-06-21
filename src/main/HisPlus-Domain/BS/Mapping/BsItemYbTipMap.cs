using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemYbTipMap : EntityTypeConfiguration<BsItemYbTip>
    {
        public BsItemYbTipMap()
            : this("dbo")
        {
        }

        public BsItemYbTipMap(string schema)
        {
            ToTable("BsItemYbTips", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsOptional().HasColumnType("int");
            Property(x => x.TallyGroupId).HasColumnName(@"TallyGroupId").IsOptional().HasColumnType("int");
            Property(x => x.IcdId).HasColumnName(@"IcdId").IsOptional().HasColumnType("int");
            Property(x => x.IllDesc).HasColumnName(@"IllDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Tips).HasColumnName(@"Tips").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
