using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OaDocFileMap : EntityTypeConfiguration<OaDocFile>
    {
        public OaDocFileMap()
            : this("dbo")
        {
        }

        public OaDocFileMap(string schema)
        {
            ToTable("OaDocFile", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DocId).HasColumnName(@"DocId").IsOptional().HasColumnType("int");
            Property(x => x.LsDocType).HasColumnName(@"LsDocType").IsOptional().HasColumnType("smallint");
            Property(x => x.DocFile).HasColumnName(@"DocFile").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
        }
    }
}
