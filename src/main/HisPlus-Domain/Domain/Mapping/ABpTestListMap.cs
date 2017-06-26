using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ABpTestListMap : EntityTypeConfiguration<ABpTestList>
    {
        public ABpTestListMap()
            : this("dbo")
        {
        }

        public ABpTestListMap(string schema)
        {
            ToTable("A_BPTestList", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemName).HasColumnName(@"ItemName").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Py).HasColumnName(@"PY").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Wb).HasColumnName(@"WB").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
        }
    }
}
