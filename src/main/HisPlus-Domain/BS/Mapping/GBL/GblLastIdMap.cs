using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblLastIdMap : EntityTypeConfiguration<GblLastId>
    {
        public GblLastIdMap()
            : this("dbo")
        {
        }

        public GblLastIdMap(string schema)
        {
            ToTable("GblLastId", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TableName).HasColumnName(@"TableName").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.LastId).HasColumnName(@"LastId").IsOptional().HasColumnType("int");
            Property(x => x.LastTime).HasColumnName(@"LastTime").IsOptional().HasColumnType("datetime");
        }
    }
}
