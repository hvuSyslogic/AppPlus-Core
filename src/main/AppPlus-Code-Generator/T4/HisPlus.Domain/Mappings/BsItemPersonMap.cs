using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemPersonMap : EntityTypeConfiguration<BsItemPerson>
    {
        public BsItemPersonMap()
            : this("dbo")
        {
        }

        public BsItemPersonMap(string schema)
        {
            ToTable("BsItemPerson", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.UserId).HasColumnName(@"UserId").IsRequired().HasColumnType("int");
            Property(x => x.PatId).HasColumnName(@"PatId").IsOptional().HasColumnType("int");
            Property(x => x.FromTime).HasColumnName(@"FromTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ToTime).HasColumnName(@"ToTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IsExcept).HasColumnName(@"IsExcept").IsOptional().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
