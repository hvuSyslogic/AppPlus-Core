using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OaDocKeyMap : EntityTypeConfiguration<OaDocKey>
    {
        public OaDocKeyMap()
            : this("dbo")
        {
        }

        public OaDocKeyMap(string schema)
        {
            ToTable("OaDocKey", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DocId).HasColumnName(@"DocId").IsOptional().HasColumnType("int");
            Property(x => x.WordKey).HasColumnName(@"WordKey").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
