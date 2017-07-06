using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuDayReportMap : EntityTypeConfiguration<OuDayReport>
    {
        public OuDayReportMap()
            : this("dbo")
        {
        }

        public OuDayReportMap(string schema)
        {
            ToTable("OuDayReport", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RtpNo).HasColumnName(@"RtpNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.Remark).HasColumnName(@"Remark").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Beprice).HasColumnName(@"Beprice").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.FactGet).HasColumnName(@"FactGet").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.InArrear).HasColumnName(@"InArrear").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
        }
    }
}
