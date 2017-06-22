using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsdocregtypeTemp36Map : EntityTypeConfiguration<BsdocregtypeTemp36>
    {
        public BsdocregtypeTemp36Map()
            : this("dbo")
        {
        }

        public BsdocregtypeTemp36Map(string schema)
        {
            ToTable("BSDOCREGTYPE_TEMP$", schema);
            HasKey(x => new { x.Locationid, x.Regtypeid, x.Timespanid, x.Doctorid });

            Property(x => x.Locationid).HasColumnName(@"locationid").IsRequired().HasColumnType("int");
            Property(x => x.Regtypeid).HasColumnName(@"regtypeid").IsRequired().HasColumnType("int");
            Property(x => x.Timespanid).HasColumnName(@"timespanid").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Mdinfo).HasColumnName(@"mdinfo").IsOptional().HasColumnType("nvarchar").HasMaxLength(62);
            Property(x => x.Tdinfo).HasColumnName(@"tdinfo").IsOptional().HasColumnType("nvarchar").HasMaxLength(62);
            Property(x => x.Wdinfo).HasColumnName(@"wdinfo").IsOptional().HasColumnType("nvarchar").HasMaxLength(62);
            Property(x => x.Tudinfo).HasColumnName(@"tudinfo").IsOptional().HasColumnType("nvarchar").HasMaxLength(62);
            Property(x => x.Fdinfo).HasColumnName(@"fdinfo").IsOptional().HasColumnType("nvarchar").HasMaxLength(62);
            Property(x => x.Stdinfo).HasColumnName(@"stdinfo").IsOptional().HasColumnType("nvarchar").HasMaxLength(62);
            Property(x => x.Sudinfo).HasColumnName(@"sudinfo").IsOptional().HasColumnType("nvarchar").HasMaxLength(62);
            Property(x => x.Doctorid).HasColumnName(@"doctorid").IsRequired().HasColumnType("int");
        }
    }
}
