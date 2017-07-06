using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkTogetherMap : EntityTypeConfiguration<CkTogether>
    {
        public CkTogetherMap()
            : this("dbo")
        {
        }

        public CkTogetherMap(string schema)
        {
            ToTable("CkTogether", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TestId1).HasColumnName(@"TestId1").IsRequired().HasColumnType("int");
            Property(x => x.TestId2).HasColumnName(@"TestId2").IsOptional().HasColumnType("int");
        }
    }
}
