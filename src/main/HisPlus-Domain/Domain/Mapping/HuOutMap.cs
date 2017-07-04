using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class HuOutMap : EntityTypeConfiguration<HuOut>
    {
        public HuOutMap()
            : this("dbo")
        {
        }

        public HuOutMap(string schema)
        {
            ToTable("HuOut", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillNo).HasColumnName(@"BillNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.HouseId).HasColumnName(@"HouseId").IsRequired().HasColumnType("int");
            Property(x => x.RoomId).HasColumnName(@"RoomId").IsRequired().HasColumnType("int");
            Property(x => x.ApplyId).HasColumnName(@"ApplyId").IsOptional().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OutMemo).HasColumnName(@"OutMemo").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.YfSign).HasColumnName(@"YFSign").IsRequired().HasColumnType("bit");
            Property(x => x.YfOperId).HasColumnName(@"YFOperId").IsOptional().HasColumnType("int");
            Property(x => x.YfOperTime).HasColumnName(@"YFOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IsSign).HasColumnName(@"IsSign").IsRequired().HasColumnType("bit");
            Property(x => x.SignTime).HasColumnName(@"SignTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.SignOperId).HasColumnName(@"SignOperId").IsOptional().HasColumnType("int");
            Property(x => x.ApperId).HasColumnName(@"ApperId").IsOptional().HasColumnType("int");
            Property(x => x.OutWayId).HasColumnName(@"OutWayId").IsOptional().HasColumnType("int");
        }
    }
}
