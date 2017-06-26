using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InEmrXmlMap : EntityTypeConfiguration<InEmrXml>
    {
        public InEmrXmlMap()
            : this("dbo")
        {
        }

        public InEmrXmlMap(string schema)
        {
            ToTable("InEmrXml", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CatalogId).HasColumnName(@"CatalogId").IsRequired().HasColumnType("int");
            Property(x => x.XmlField).HasColumnName(@"XmlField").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.XmlValue).HasColumnName(@"XmlValue").IsOptional().HasColumnType("nvarchar").HasMaxLength(4000);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InEmrId).HasColumnName(@"InEmrId").IsOptional().HasColumnType("int");
        }
    }
}
