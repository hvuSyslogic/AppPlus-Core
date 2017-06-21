using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsYbCodeSpecMap : EntityTypeConfiguration<BsYbCodeSpec>
    {
        public BsYbCodeSpecMap()
            : this("dbo")
        {
        }

        public BsYbCodeSpecMap(string schema)
        {
            ToTable("BsYbCodeSpec", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.TallyGroupId).HasColumnName(@"TallyGroupId").IsRequired().HasColumnType("int");
            Property(x => x.IcdId).HasColumnName(@"IcdId").IsOptional().HasColumnType("int");
            Property(x => x.YbCode).HasColumnName(@"YbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
