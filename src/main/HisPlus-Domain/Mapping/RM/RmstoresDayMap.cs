using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RmstoresDayMap : EntityTypeConfiguration<RmstoresDay>
    {
        public RmstoresDayMap()
            : this("dbo")
        {
        }

        public RmstoresDayMap(string schema)
        {
            ToTable("RmstoresDays", schema);
            HasKey(x => new { x.Id, x.StockTime, x.StockId, x.RoomId, x.ItemId, x.Unitid, x.StockPrice, x.RetailPrice, x.StockNum, x.IsBid, x.IsInject, x.OptionPrice, x.IsSpecSum, x.IsAntiBacterial });

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.StockTime).HasColumnName(@"StockTime").IsRequired().HasColumnType("datetime");
            Property(x => x.StockId).HasColumnName(@"StockID").IsRequired().HasColumnType("int");
            Property(x => x.RoomId).HasColumnName(@"RoomId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.Unitid).HasColumnName(@"unitid").IsRequired().HasColumnType("int");
            Property(x => x.CompId).HasColumnName(@"CompId").IsOptional().HasColumnType("int");
            Property(x => x.StockPrice).HasColumnName(@"StockPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.RetailPrice).HasColumnName(@"RetailPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.StockNum).HasColumnName(@"StockNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.IsBid).HasColumnName(@"IsBid").IsRequired().HasColumnType("bit");
            Property(x => x.IsInject).HasColumnName(@"IsInject").IsRequired().HasColumnType("bit");
            Property(x => x.OptionPrice).HasColumnName(@"OptionPrice").IsRequired().HasColumnType("bit");
            Property(x => x.IsSpecSum).HasColumnName(@"IsSpecSum").IsRequired().HasColumnType("bit");
            Property(x => x.IsAntiBacterial).HasColumnName(@"IsAntiBacterial").IsRequired().HasColumnType("bit");
        }
    }
}
