using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class HuCheckMap : EntityTypeConfiguration<HuCheck>
    {
        public HuCheckMap()
            : this("dbo")
        {
        }

        public HuCheckMap(string schema)
        {
            ToTable("HuCheck", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillNo).HasColumnName(@"BillNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.HouseId).HasColumnName(@"HouseId").IsRequired().HasColumnType("int");
            Property(x => x.CheckTime).HasColumnName(@"CheckTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CheckAmount).HasColumnName(@"CheckAmount").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
