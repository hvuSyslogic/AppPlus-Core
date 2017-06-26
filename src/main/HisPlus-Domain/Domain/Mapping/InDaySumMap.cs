using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InDaySumMap : EntityTypeConfiguration<InDaySum>
    {
        public InDaySumMap()
            : this("dbo")
        {
        }

        public InDaySumMap(string schema)
        {
            ToTable("InDaySum", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.RegDate).HasColumnName(@"RegDate").IsRequired().HasColumnType("datetime");
            Property(x => x.NotPay).HasColumnName(@"NotPay").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.HasPay).HasColumnName(@"HasPay").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DaySum).HasColumnName(@"DaySum").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Remain).HasColumnName(@"Remain").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
        }
    }
}
