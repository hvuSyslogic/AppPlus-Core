using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InDayChargeMap : EntityTypeConfiguration<InDayCharge>
    {
        public InDayChargeMap()
            : this("dbo")
        {
        }

        public InDayChargeMap(string schema)
        {
            ToTable("InDayCharge", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsOptional().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.BeginTime).HasColumnName(@"BeginTime").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Totality).HasColumnName(@"Totality").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitId).HasColumnName(@"UnitId").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
