using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OaDocReaderMap : EntityTypeConfiguration<OaDocReader>
    {
        public OaDocReaderMap()
            : this("dbo")
        {
        }

        public OaDocReaderMap(string schema)
        {
            ToTable("OaDocReader", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DocId).HasColumnName(@"DocId").IsOptional().HasColumnType("int");
            Property(x => x.AllowOperId).HasColumnName(@"AllowOperId").IsOptional().HasColumnType("int");
            Property(x => x.ExpireTime).HasColumnName(@"ExpireTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
