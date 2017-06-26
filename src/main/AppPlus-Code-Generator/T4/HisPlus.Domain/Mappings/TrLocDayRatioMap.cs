using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class TrLocDayRatioMap : EntityTypeConfiguration<TrLocDayRatio>
    {
        public TrLocDayRatioMap()
            : this("dbo")
        {
        }

        public TrLocDayRatioMap(string schema)
        {
            ToTable("TrLocDayRatio", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.RegDate).HasColumnName(@"RegDate").IsRequired().HasColumnType("datetime");
            Property(x => x.MedicineRatio).HasColumnName(@"MedicineRatio").IsRequired().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.AntiBiRatio).HasColumnName(@"AntiBiRatio").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.Ratio1).HasColumnName(@"Ratio1").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.Ratio2).HasColumnName(@"Ratio2").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.Ratio3).HasColumnName(@"Ratio3").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.Ratio4).HasColumnName(@"Ratio4").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.Ratio5).HasColumnName(@"Ratio5").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.Ratio6).HasColumnName(@"Ratio6").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.Ratio7).HasColumnName(@"Ratio7").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
