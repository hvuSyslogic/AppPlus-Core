using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RmstoreStockNum2Map : EntityTypeConfiguration<RmstoreStockNum2>
    {
        public RmstoreStockNum2Map()
            : this("dbo")
        {
        }

        public RmstoreStockNum2Map(string schema)
        {
            ToTable("RmstoreStockNum2", schema);
            HasKey(x => new { x.Opertime, x.HospitalId, x.LsRoomType, x.LsInOut, x.ItemId });

            Property(x => x.Opertime).HasColumnName(@"opertime").IsRequired().HasColumnType("datetime");
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsRequired().HasColumnType("int");
            Property(x => x.LsRoomType).HasColumnName(@"LsRoomType").IsRequired().HasColumnType("int");
            Property(x => x.LsInOut).HasColumnName(@"LsInOut").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.StockNum).HasColumnName(@"StockNum").IsOptional().HasColumnType("numeric").HasPrecision(38,6);
        }
    }
}
