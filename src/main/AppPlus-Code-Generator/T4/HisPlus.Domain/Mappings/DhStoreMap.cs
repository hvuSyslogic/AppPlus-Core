using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class DhStoreMap : EntityTypeConfiguration<DhStore>
    {
        public DhStoreMap()
            : this("dbo")
        {
        }

        public DhStoreMap(string schema)
        {
            ToTable("DhStores", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsOptional().HasColumnType("int");
            Property(x => x.InBatchNo).HasColumnName(@"InBatchNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(14);
            Property(x => x.ItemCode).HasColumnName(@"ItemCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ItemName).HasColumnName(@"ItemName").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.UnitKcId).HasColumnName(@"UnitKcId").IsRequired().HasColumnType("int");
            Property(x => x.CompId).HasColumnName(@"CompId").IsOptional().HasColumnType("int");
            Property(x => x.ManuId).HasColumnName(@"ManuId").IsOptional().HasColumnType("int");
            Property(x => x.FormId).HasColumnName(@"FormId").IsRequired().HasColumnType("int");
            Property(x => x.IsRecipe).HasColumnName(@"IsRecipe").IsRequired().HasColumnType("bit");
            Property(x => x.IsPoison).HasColumnName(@"IsPoison").IsRequired().HasColumnType("bit");
            Property(x => x.IsMental).HasColumnName(@"IsMental").IsRequired().HasColumnType("bit");
            Property(x => x.IsExpen).HasColumnName(@"IsExpen").IsRequired().HasColumnType("bit");
            Property(x => x.IsSelf).HasColumnName(@"IsSelf").IsRequired().HasColumnType("bit");
            Property(x => x.LsImport).HasColumnName(@"LsImport").IsRequired().HasColumnType("smallint");
            Property(x => x.IsCountry).HasColumnName(@"IsCountry").IsRequired().HasColumnType("bit");
            Property(x => x.IsProvince).HasColumnName(@"IsProvince").IsRequired().HasColumnType("bit");
            Property(x => x.IsBid).HasColumnName(@"IsBid").IsRequired().HasColumnType("bit");
            Property(x => x.PassNo).HasColumnName(@"PassNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.StockNum).HasColumnName(@"StockNum").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.StockPrice).HasColumnName(@"StockPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.RetailPrice).HasColumnName(@"RetailPrice").IsRequired().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.StoreDate).HasColumnName(@"StoreDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.ProduceDate).HasColumnName(@"ProduceDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LimitDate).HasColumnName(@"LimitDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
