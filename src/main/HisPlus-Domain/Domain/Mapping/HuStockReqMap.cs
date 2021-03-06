using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class HuStockReqMap : EntityTypeConfiguration<HuStockReq>
    {
        public HuStockReqMap()
            : this("dbo")
        {
        }

        public HuStockReqMap(string schema)
        {
            ToTable("HuStockReq", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillNo).HasColumnName(@"BillNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(14);
            Property(x => x.HouseId).HasColumnName(@"HouseId").IsRequired().HasColumnType("int");
            Property(x => x.ApplyTime).HasColumnName(@"ApplyTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.ValideTime).HasColumnName(@"ValideTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ApplyIdea).HasColumnName(@"ApplyIdea").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ApplyHander).HasColumnName(@"ApplyHander").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.CompId).HasColumnName(@"CompId").IsOptional().HasColumnType("int");
        }
    }
}
