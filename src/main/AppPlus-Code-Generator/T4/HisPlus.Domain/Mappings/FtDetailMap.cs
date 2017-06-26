using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class FtDetailMap : EntityTypeConfiguration<FtDetail>
    {
        public FtDetailMap()
            : this("dbo")
        {
        }

        public FtDetailMap(string schema)
        {
            ToTable("FtDetail", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillId).HasColumnName(@"BillId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.Price).HasColumnName(@"Price").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.OrderNum).HasColumnName(@"OrderNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
