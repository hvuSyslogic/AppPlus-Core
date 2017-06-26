using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InWorkLogMap : EntityTypeConfiguration<InWorkLog>
    {
        public InWorkLogMap()
            : this("dbo")
        {
        }

        public InWorkLogMap(string schema)
        {
            ToTable("InWorkLog", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.BedSum).HasColumnName(@"BedSum").IsOptional().HasColumnType("numeric").HasPrecision(10,2);
            Property(x => x.OverBedSum).HasColumnName(@"OverBedSum").IsOptional().HasColumnType("numeric");
            Property(x => x.Standard).HasColumnName(@"Standard").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.LastNum).HasColumnName(@"LastNum").IsOptional().HasColumnType("smallint");
            Property(x => x.StartNum).HasColumnName(@"StartNum").IsOptional().HasColumnType("smallint");
            Property(x => x.InHospital).HasColumnName(@"InHospital").IsOptional().HasColumnType("smallint");
            Property(x => x.InLocation).HasColumnName(@"InLocation").IsOptional().HasColumnType("smallint");
            Property(x => x.OutLocation).HasColumnName(@"OutLocation").IsOptional().HasColumnType("smallint");
            Property(x => x.OutHospital).HasColumnName(@"OutHospital").IsOptional().HasColumnType("smallint");
            Property(x => x.Dead).HasColumnName(@"Dead").IsOptional().HasColumnType("smallint");
            Property(x => x.NowNum).HasColumnName(@"NowNum").IsOptional().HasColumnType("smallint");
            Property(x => x.OverNum).HasColumnName(@"OverNum").IsOptional().HasColumnType("smallint");
            Property(x => x.CompanyNum).HasColumnName(@"CompanyNum").IsOptional().HasColumnType("smallint");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Days).HasColumnName(@"Days").IsOptional().HasColumnType("int");
            Property(x => x.Danger).HasColumnName(@"Danger").IsOptional().HasColumnType("int");
            Property(x => x.Heavy).HasColumnName(@"Heavy").IsOptional().HasColumnType("int");
            Property(x => x.Acute).HasColumnName(@"Acute").IsOptional().HasColumnType("int");
        }
    }
}
