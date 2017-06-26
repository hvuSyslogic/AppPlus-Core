using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class NrPregnancyMap : EntityTypeConfiguration<NrPregnancy>
    {
        public NrPregnancyMap()
            : this("dbo")
        {
        }

        public NrPregnancyMap(string schema)
        {
            ToTable("NrPregnancy", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ExpectDate).HasColumnName(@"ExpectDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.PregnantWeek).HasColumnName(@"PregnantWeek").IsRequired().HasColumnType("smallint");
            Property(x => x.PregnancyTime).HasColumnName(@"PregnancyTime").IsOptional().HasColumnType("smallint");
            Property(x => x.DeliveryTimes).HasColumnName(@"DeliveryTimes").IsOptional().HasColumnType("smallint");
            Property(x => x.UterusShrink).HasColumnName(@"UterusShrink").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.UterusOpen).HasColumnName(@"UterusOpen").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
