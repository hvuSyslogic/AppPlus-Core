using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsOuMergeFeeMap : EntityTypeConfiguration<BsOuMergeFee>
    {
        public BsOuMergeFeeMap()
            : this("dbo")
        {
        }

        public BsOuMergeFeeMap(string schema)
        {
            ToTable("BsOuMergeFee", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId1).HasColumnName(@"ItemId1").IsRequired().HasColumnType("int");
            Property(x => x.ItemId2).HasColumnName(@"ItemId2").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
